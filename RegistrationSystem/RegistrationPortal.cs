using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;
using RegistrationSystem.Properties;
using RegistrationSystem.UserControls;
using static System.Linq.Enumerable;

namespace RegistrationSystem
{
    public partial class RegistrationPortalForm : Form
    {
        private readonly AspNetUser _user;
        private readonly StudentRepo _studentRepo = new StudentRepo();
        private readonly SubjectRepo _subjectRepo = new SubjectRepo();
        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();

        public RegistrationPortalForm(AspNetUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private DataAccess.Student _student;
        private DataAccess.Guardian _guardian;
        private DataAccess.PaymentPlan _selectedPaymentPlan;
        private DataAccess.Payment _payment = null;
        private List<DataAccess.Subject> _availableSubjects;

        private readonly List<DataAccess.RegisteredSubject>
            _selectedSubjects = new List<DataAccess.RegisteredSubject>();

        private readonly List<DataAccess.SupportingDocument> _supportDocs = new List<DataAccess.SupportingDocument>();

        // closing application when form closing event is fired
        private void SubjectRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
        }

        // generates a new array of strings, given start and size 

        private void SubjectRegistrationForm_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            // gender
            Gender_combobox.SelectedIndex = 0;

            // populate fields with account data
            FirstName_control.InputText = _user.FirstName;
            LastName_control.InputText = _user.LastName;
            EmailAddress_control.InputText = _user.Email;
            FirstName_control.Enabled = false;
            LastName_control.Enabled = false;
            EmailAddress_control.Enabled = false;
            LoadSubjects();
            LoadPaymentPlans();
        }

        private void LoadSubjects()
        {
            // loads subjects;
            var subjects = _subjectRepo.GetActiveSubjects().ToList();
            _availableSubjects = subjects;

            foreach (var subject in subjects)
            {
                var sub = new UcSubject
                {
                    Name = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                    SubjectCode = subject.SubjectCode,
                    SubjectDescription = subject.SubjectDescription,
                    SubjectPrice = subject.SubjectPrice
                };
                sub.SubjectSelectedChanged += Subject_SubjectSelectedChanged;
                sub.MatricMarkChanged += Subject_MatricMarkChanged;
                SubjectSelection_flowlayout.Controls.Add(sub);
            }
        }

        private void LoadPaymentPlans()
        {
            var paymentPlans = _extrasRepo.GetPaymentPlans().OrderBy(p => p.PaymentLength);

            foreach (var paymentPlan in paymentPlans)
            {
                var plan = new UcPaymentPlan
                {
                    Name = $"{paymentPlan.PaymentTitle}",
                    PaymentPlanId = paymentPlan.PaymentTitle,
                    PaymentPlanTitle = paymentPlan.PaymentTitle,
                    PaymentPlanDescription = paymentPlan.PaymentPlanDescription,
                    PaymentPlanLength = paymentPlan.PaymentLength.ToString()
                };
                plan.SelectedPaymentPlanChanged += PaymentPlan_PaymentPlanSelectedChanged;
                PaymentPlan_flowlayout.Controls.Add(plan);
            }
        }


        #region PERSONAL DETAILS TAB

        //personal details
        private void PDSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            var student = new DataAccess.Student();
            if (Helpers.Helpers.AllFieldsChecked(PersonalDetailsForm_groupbox))
            {
                var idValidation =
                    Utils.Validators.IsValidIdentityNumber(PersonalDetailsIDorPassportNumber_control.InputText);
                if (!idValidation.Item1)
                {
                    MessageBox.Show(idValidation.Item2, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                student.HomeAddress = //
                    $@"{Address_control.InputText} {Suburb_control.InputText}, {CityOrTown_control.InputText} {ZipOrPostalCode_control.InputText}";
                student.DateOfBirth =
                    DateTime.Parse(Utils.Helpers.GetDobFromId(PersonalDetailsIDorPassportNumber_control.InputText));
                student.Gender = Gender_combobox.Text.Substring(0, 1);
                student.IDNumber = PersonalDetailsIDorPassportNumber_control.InputText;
                student.Active = true;
                student.UserID = _user.Id;
                _student = student;
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show(@"Please fill all the input in the form");
            }
        }

        #endregion

        private void PersonalDetails_InputFieldError(object sender, InputFieldErrorEventArgs e)
        {
            InputErrorEvent(PDSaveAndContinue_button, e, RegError_errorprovider);
        }

        #region GARDIAN DETAILS TAB

        private void GDSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            var guardian = new DataAccess.Guardian();
            if (Helpers.Helpers.AllFieldsChecked(GuardianDetailsForm_groupbox))
            {
                var idValidation =
                    Utils.Validators.IsValidIdentityNumber(GuardianIDorPassportNumber_control.InputText);
                if (!idValidation.Item1)
                {
                    MessageBox.Show(idValidation.Item2, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                guardian.FirstName = GuardianFirstName_control.InputText;
                guardian.LastName = GuardianLastName_control.InputText;
                guardian.HomeAddress =
                    $@"{GuardianAddress_control.InputText} {GuardianSuburb_control.InputText}, {GuardianCityOrTown_control.InputText} {GuardianZipOrPostalCode_control.InputText}";
                guardian.PhoneNumber = GuardianPhoneNumber_control.InputText;
                guardian.IDNumber = GuardianIDorPassportNumber_control.InputText;
                _guardian = guardian;
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show(@"Please fill all the input in the form");
            }
        }

        private void Guardian_InputFieldError(object sender, InputFieldErrorEventArgs e)
        {
            InputErrorEvent(GDSaveAndContinue_button, e, RegError_errorprovider);
        }

        #endregion

        #region SUPPORTING DOCUMENTS TAB

        private static byte[] GetFileByte(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            var x = File.ReadAllBytes(path);
            return x;
        }

        // fileType/fileType can be (Student ID Copy, Guardian ID Copy or Matric Statement Copy)
        private FileInfo FileUpload(string fileType)
        {
            var uploader = new OpenFileDialog
            {
                Filter = @"allfiles(pdf) | *.pdf",
                CheckFileExists = true,
                CheckPathExists = true,
                Title = fileType
            };
            if (uploader.ShowDialog() != DialogResult.OK) return null;
            try
            {
                var fileInfo = new FileInfo(uploader.FileName);
                if (fileInfo.Extension.ToLower() != ".pdf") return null;
                if (fileInfo.Length > 4194304) // Max upload file size 4194304B(4MB)
                {
                    MessageBox.Show($@"File is too big ({fileInfo.Length / 1048576}MB). The Max size is 4MB");
                    return null;
                }

                var fileByte = GetFileByte(uploader.FileName);
                if (fileByte == null) return null;
                var file = new DataAccess.SupportingDocument
                {
                    File = fileByte,
                    IsVerified = false,
                    FileName = fileInfo.Name,
                    FileType = fileType,
                    ContentType = "application/pdf"
                };

                foreach (var doc in _supportDocs.Where(doc => doc.FileType == fileType))
                {
                    // first remove a doc with same name if all ready in the support docs
                    _supportDocs.Remove(doc);
                }

                _supportDocs.Add(file);
                return fileInfo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // uploading file from button click
        private void FileUpload_Click(object sender, EventArgs e)
        {
            var control = (Button) sender;
            var pControl = (TableLayoutPanel) control.Parent;
            var file = FileUpload(control.Tag.ToString());
            if (file == null) return;
            FileUploadPreview_adobe.src = file.FullName;

            control.Text = $@"Re{control.Text}";
            control.Image = Resources.checked_icon;

            PictureBox icon = null;
            try
            {
                icon = (PictureBox) pControl?.Controls[0];
            }
            catch (Exception)
            {
                icon = (PictureBox) pControl?.Controls[1];
            }

            if (icon != null) icon.Image = Resources.pdf_light_icon;
        }

        // save and continue button
        private void SDSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            if (_supportDocs.Count < 3)
            {
                MessageBox.Show(@"Upload all the required supporting documents!");
            }
            else
            {
                // next tab
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
        }

        #endregion

        #region SUBJECT SELECTION TAB

        // deals with selection of subjects
        private void Subject_SubjectSelectedChanged(object sender, EventArgs e)
        {
            var changedSubject = (UcSubject) sender;
            changedSubject.BackColor = changedSubject.SubjectSelected ? Color.DarkOrange : Color.Transparent;
            var subject = new DataAccess.RegisteredSubject
            {
                SubjectCode = changedSubject.SubjectCode,
                MatricMark = 0,
                UpgradeMark = 0,
            };

            if (changedSubject.SubjectSelected)
            {
                _selectedSubjects.Add(subject);
            }
            else
            {
                _selectedSubjects.RemoveAll(sub => sub.SubjectCode.Equals(subject.SubjectCode));
            }
        }

        private void Subject_MatricMarkChanged(object sender, EventArgs e)
        {
            var changedSubject = (UcSubject) sender;
            if (byte.TryParse(changedSubject.MatricMark, out var result))
            {
                foreach (var sub in _selectedSubjects.Where(sub => sub.SubjectCode == changedSubject.SubjectCode))
                {
                    sub.MatricMark = result;
                    break;
                }
            }
            else
            {
                changedSubject.MatricMark = string.Empty;
            }
        }

        private bool MarksValid() => _selectedSubjects.All(sub => sub.MatricMark <= 100);

        // subject selection save and continue button
        private void SSSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            // subject selection
            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"Choose at least one subject", @"Subject Required");
            }
            else
            {
                if (MarksValid())
                {
                    SubjectsRegistration_tabs.SelectedIndex += 1;
                }
                else
                {
                    MessageBox.Show(@"Make sure all selected subjects have valid matric marks", @"Invalid Marks");
                }
            }
        }

        // gets total of subjects selected
        private decimal GetTotal()
        {
            try
            {
                var total = _availableSubjects.Join(_selectedSubjects,
                        sub => sub.SubjectCode,
                        selected => selected.SubjectCode,
                        (sub, selected) => new {Subject = sub, RegisteredSubject = selected})
                    .Sum(sub => sub.Subject.SubjectPrice);
                var x = 0;
                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : @"Failed to register student",
                    @"Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }
        }

        #endregion

        #region PAYMENTPLAN TAB

        // deals with selection of payment plans
        private void PaymentPlan_PaymentPlanSelectedChanged(object sender, EventArgs e)
        {
            var plan = (UcPaymentPlan) sender;
            _selectedPaymentPlan = null;
            var paymentPlan = new DataAccess.PaymentPlan
            {
                PaymentTitle = plan.PaymentPlanTitle,
                PaymentLength = int.Parse(plan.PaymentPlanLength),
                PaymentPlanDescription = plan.PaymentPlanDescription,
            };
            _selectedPaymentPlan = paymentPlan;

            // updates the SelectIcon to indicated whether the payment is selected or not
            foreach (UcPaymentPlan payment in PaymentPlan_flowlayout.Controls)
            {
                payment.PaymentPlanSelected = payment.PaymentPlanTitle == _selectedPaymentPlan.PaymentTitle;
                payment.SelectIcon = payment.PaymentPlanSelected ? Resources.checked_icon : Resources.check_icon;
            }
        }

        private void PPSaveAndContinue_button_Click(object sender, EventArgs e)
        {
            //payment plan
            if (_selectedPaymentPlan == null)
            {
                MessageBox.Show(@"Choose one payment plan");
            }
            else
            {
                SubjectsRegistration_tabs.SelectedIndex += 1;
            }
        }

        private void PaymentPlan_tab_Enter(object sender, EventArgs e)
        {
            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"Please choose at least one subject");
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
            }
            else
            {
                foreach (UcPaymentPlan payment in PaymentPlan_flowlayout.Controls)
                {
                    if (int.Parse(payment.PaymentPlanLength) > 1)
                    {
                        payment.ExpectedPay = $"{(GetTotal() / decimal.Parse(payment.PaymentPlanLength)):C} p/m";
                    }
                    else
                    {
                        payment.ExpectedPay = $"{GetTotal():C} full";
                    }
                }
            }
        }

        #endregion

        #region PAYMENT TAB

        // when the pab opens
        private void Payment_tab_Enter(object sender, EventArgs e)
        {
            if (_student == null)
            {
                MessageBox.Show(@"Personal Information Missing");
                SubjectsRegistration_tabs.SelectedTab = PersonalDetails_tabs;
                return;
            }

            if (_guardian == null)
            {
                MessageBox.Show(@"Guardian Information Missing");
                SubjectsRegistration_tabs.SelectedTab = GuardianDetails_tab;
                return;
            }

            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"No Subjects were selected");
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
                return;
            }

            if (_selectedPaymentPlan != null)
            {
                return;
            }

            MessageBox.Show(@"No payment plan chosen", @"Payment Required");
            SubjectsRegistration_tabs.SelectedTab = PaymentPlan_tab;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            using (DbContextTransaction transaction = _studentRepo.DbTransaction())
            {
                try
                {
                    var student = _studentRepo.CreateStudent(student: _student);
                    _studentRepo.SaveChanges();
                    _guardian.StudentID = student.StudentID;
                    var guardian = _studentRepo.CreateGuardian(guardian: _guardian);
                    _studentRepo.SaveChanges();
                    foreach (var doc in _supportDocs)
                    {
                        doc.StudentID = student.StudentID;
                    }

                    _studentRepo.AddSupportingDocs(_supportDocs);

                    foreach (var sub in _selectedSubjects)
                    {
                        sub.StudentID = student.StudentID;
                    }

                    _studentRepo.RegisterSubjects(_selectedSubjects);

                    _studentRepo.SaveChanges();

                    var registration = new DataAccess.Registration
                    {
                        StudentID = student.StudentID,
                        AmountDue = GetTotal(),
                        AmountPayed = 0,
                        PaymentPlanID = _selectedPaymentPlan.PaymentTitle,
                        RegistrationDate = DateTime.Now,
                        ReasonNotApproved = "Awaiting Admin review and approval",
                        PaymentCycle = 1,
                        IsApproved = false,
                        NextPayment = DateTime.Now,
                    };
                    _studentRepo.CreateRegistration(registration);
                    _studentRepo.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show(@"Student registration complete", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Utils.Helpers.NotNull(ex.Message)
                            ? Utils.Helpers.GetErrorMessage(ex)
                            : @"Failed to register student"
                        , @"Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    transaction.Rollback();
                }
            }
        }

        #endregion

        #region CONFIRMATION TAB

        // when confirmation tab opens up
        private void Confirmation_tab_Enter(object sender, EventArgs e)
        {
            if (_selectedSubjects.Count < 1)
            {
                MessageBox.Show(@"Oops no subjects were chosen!", @"Subject(s) Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                SubjectsRegistration_tabs.SelectedTab = SubjectSelection_tab;
                return;
            }

            if (_supportDocs.Count < 3)
            {
                MessageBox.Show(@"Oops you missed supporting docs!", @"Docs Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                SubjectsRegistration_tabs.SelectedTab = SupportingDocuments_tab;
                return;
            }

            if (_selectedPaymentPlan == null)
            {
                MessageBox.Show(@"Oops you forgot about payment plan!", @"Plan Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                SubjectsRegistration_tabs.SelectedTab = PaymentPlan_tab;
                return;
            }

            // loops all the registered subjects from List<Subject>
            var subs = _availableSubjects.Join(_selectedSubjects,
                    sub => sub.SubjectCode,
                    selected => selected.SubjectCode,
                    (sub, selected) => new {Subject = sub, RegisteredSubject = selected})
                .Select(sub => new UcSubject
                {
                    SubjectName = sub.Subject.SubjectName,
                    SubjectCode = sub.Subject.SubjectCode,
                    SubjectDescription = sub.Subject.SubjectDescription,
                    SubjectPrice = sub.Subject.SubjectPrice,
                    // hides selection box(check icon) of subject
                    SubjectSelectable = false,
                });
            ConRegSubjectsLayout.Controls.Clear();
            foreach (var sub in subs)
            {
                ConRegSubjectsLayout.Controls.Add(sub);
            }
            ConTuitionFee.Text = GetTotal().ToString("C");
        }

        #endregion

        #region Generic Events

        private void Tab_Enter(object sender, EventArgs e)
        {
            CausesValidation = true;
        }

        private void Tab_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var control = (TabPage) sender;
                if (control?.Tag == null || string.IsNullOrWhiteSpace(control.Tag.ToString())) return;
                var first = control.Controls.Find(control.Tag.ToString(), true).First();
                if (Helpers.Helpers.AllFieldsChecked(first)) return;
                e.Cancel = true;
                MessageBox.Show($@"All Fields are required at {control.Text} tab");
                SubjectsRegistration_tabs.SelectedTab = control;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private static void InputErrorEvent(Control button, InputFieldErrorEventArgs e, ErrorProvider err)
        {
            if (e.IsResolved)
            {
                button.BackColor = Color.DarkOrange;
                button.Enabled = true;
                err.Clear();
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.DarkGray;
                err.SetError(button, "Please fix input errors");
            }
        }

        //close form
        private void FormClose_button_Click(object sender, EventArgs e)
        {
            var confirmClose = MessageBox.Show(@"Are you sure you want cancel registration!",
                @"Cancel registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmClose == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FormClose_button_MouseEnter(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
        }

        private void FormClose_button_MouseLeave(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Inherit;
        }

        #endregion
    }
}