using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;
using RegistrationSystem.DataTransferObject;
using RegistrationSystem.DataTransferObjects;

namespace RegistrationSystem
{
    public partial class AdminPortal : Form
    {
        private readonly Helpers.Helpers _helpers = new Helpers.Helpers();
        private StudentRepo _studentRepo = new StudentRepo();
        private ExtrasRepo _extrasRepo = new ExtrasRepo();
        private readonly SubjectRepo _subjectRepo = new SubjectRepo();
        private readonly AdminDto _admin;

        public AdminPortal(AdminDto admin)
        {
            InitializeComponent();
            _admin = admin;
        }

        private int _studentId = 0;
        private AspNetUser _user;

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            if (_admin == null)
            {
                var login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }

            AdminDetails.Text = $@"{_admin?.FirstName} {_admin?.LastName}";

            LoadStudents();
            LoadSubjects();
            LoadTeachers();
        }

        private void LoadStudents()
        {
            StudentDataGrid.DataSource = _studentRepo.GetStudentsDetails().ToList();
            NoneStudentsGrid.DataSource =
                _extrasRepo.GetUsers()
                    .Where(u => u.AspNetRoles.Any(x => x.Name.ToLower() == "student") && !u.Students.Any()).Select(
                        netUser =>
                            new UserDto
                            {
                                UserId = netUser.Id,
                                FirstName = netUser.FirstName,
                                LastName = netUser.LastName,
                                Email = netUser.Email,
                            }).ToList();
        }

        private void LoadSubjects()
        {
            SubjectDataGrid.DataSource = _subjectRepo.GetSubjects().Select(subject => new SubjectDTO
            {
                SubjectCode = subject.SubjectCode,
                TeacherID = subject.TeacherID,
                SubjectName = subject.SubjectName.Trim(),
                SubjectDescription = subject.SubjectDescription,
                SubjectPrice = subject.SubjectPrice,
                IsActive = subject.IsActive
            }).ToList();
        }

        private void LoadTeachers()
        {
            Teacher_combobox.DataSource = _extrasRepo.GetUsers().Join(_extrasRepo.GetTeachers(),
                u => u.Id,
                t => t.UserID,
                (u, t) => new
                {
                    AspNetUser = u,
                    Teacher = t
                }).Select(x => new TeacherDTO
                {
                    TeacherID = x.Teacher.TeacherID,
                    UserId = x.Teacher.UserID,
                    FirstName = x.AspNetUser.FirstName,
                    LastName = x.AspNetUser.LastName,
                    Email = x.AspNetUser.Email,
                }).ToList();
            Teacher_combobox.DisplayMember = "FirstName";
            Teacher_combobox.ValueMember = "TeacherID";
        }

        private void AddSubject_button_Click(object sender, EventArgs e)
        {
            if (Helpers.Helpers.AllFieldsChecked(NewSubject_groupbox))
            {
                DataAccess.Subject sub = new Subject
                {
                    SubjectCode = SubjectCode_control.InputText,
                    SubjectName = SubjectName_control.InputText,
                    SubjectDescription = SubjectDescription_control.InputText,
                    SubjectPrice = decimal.Parse(SubjectPrice_control.InputText),
                    IsActive = SubjectActive_checkbox.Checked,
                    TeacherID = (int) Teacher_combobox.SelectedValue,
                };
                _subjectRepo.CreateSubject(sub);
                if (_subjectRepo.SaveChanges())
                {
                    MessageBox.Show($@"New Subject '{sub.SubjectName}' was added successfully!",
                        @"Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjects();
                }
                else
                {
                    MessageBox.Show($@"Failed to add new subject: '{sub.SubjectName}'!",
                        @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // resets form
                SubjectName_control.InputText = "";
                SubjectCode_control.InputText = "";
                SubjectDescription_control.InputText = "";
                SubjectPrice_control.InputText = "";
                SubjectActive_checkbox.Checked = true;
            }
            else
            {
                MessageBox.Show($@"Please enter all subject details!",
                    @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ApproveReg_button_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = _studentRepo.GetRegistration(studentId: _studentId);
                if (reg == null)
                {
                    MessageBox.Show(@"Failed to find registration", @"Registration status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (reg.IsApproved)
                {
                    MessageBox.Show(@"Registration is already Approved", @"Registration status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reg.IsApproved = true;
                    reg.ApproveDate = DateTime.Now;
                    reg.AdminID = _admin.AdminId;
                    if (_studentRepo.SaveChanges())
                    {
                        MessageBox.Show($@"Successfully approved registration!",
                            @"Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadStudentProfile(studentId: reg.StudentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : "Something went wrong while approving registration", @"Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadStudentProfile(int studentId)
        {
            var student = _studentRepo.GetStudentDetail(id: studentId);
            var reg = _studentRepo.GetRegistration(studentId: student.StudentID);
            _studentId = student.StudentID;
            var profile = new UcStudent
            {
                StudentFullName = $@"{student.FirstName} {student.LastName}",
                StudentEmail = student.Email,
                RegistrationDate = reg.RegistrationDate.ToString(CultureInfo.InvariantCulture),
                RegistrationStatus = reg.IsApproved ? "Approved" : "Not Approved",
                PaymentPlan = reg.PaymentPlanID,
                NumSubs = reg.Student.RegisteredSubjects?.Count().ToString(),
            };
            StudentProfileContainer_panel.Controls.Clear();
            StudentProfileContainer_panel.Controls.Add(profile);
            ApproveReg_button.Visible = !reg.IsApproved;
        }

        private void StudentDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _studentId = 0;
            try
            {
                var studentId = (int) StudentDataGrid.Rows[e.RowIndex].Cells[0].Value;
                IEnumerable<RegisteredSubjectDto> registeredSubjects =
                    _studentRepo.GetRegisteredSubjects(studentId: studentId).Select(subject => new RegisteredSubjectDto
                    {
                        StudentId = subject.StudentID,
                        SubjectCode = subject.SubjectCode,
                        SubjectName = subject.Subject.SubjectName,
                        MatricMark = subject.MatricMark,
                        UpgradeMark = subject.UpgradeMark
                    }).ToList();

                PaymentDataGrid.DataSource = registeredSubjects;
                LoadStudentProfile(studentId: studentId);
                if (!registeredSubjects.Any())
                {
                    MessageBox.Show($@"This student is not registered for any subjects", @"Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _studentId = 0;
                MessageBox.Show(
                    Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : $@"Oops failed to load requested data!", @"Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OpenOnStudentPortalBtn.Visible = _studentId > 0;
            }
        }

        private void SubjectDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var subCode = (string) SubjectDataGrid.Rows[e.RowIndex].Cells[0].Value;
                if (Utils.Helpers.NotNull(subCode))
                {
                    IQueryable<RegisteredSubject> regSubs = _subjectRepo.GetRegisteredSubjectsByCode(subCode);
                    RegStatsPanel.Visible = true;
                    if (regSubs.Any())
                    {
                        RegStuNum.Text = regSubs.Count().ToString();
                        PassedStuNum.Text = regSubs.Count(rs => rs.MatricMark > 49).ToString();
                        FailedStuNum.Text = regSubs.Count(rs => rs.MatricMark < 50).ToString();
                        AvgMarkNum.Text = regSubs.Average(rs => rs.MatricMark).ToString("N2");
                    }
                    else
                    {
                        RegStuNum.Text = @"0";
                        PassedStuNum.Text = @"0";
                        FailedStuNum.Text = @"0";
                        AvgMarkNum.Text = @"0";
                        MessageBox.Show($@"No student(s) have registered for the subject", @"Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : $@"Oops failed to load requested data!", @"Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_textbox_TextChanged(object sender, EventArgs e)
        {
            var subs = _subjectRepo.GetSubjects();
            if (Search_textbox.Text.Trim().Any())
            {
                SubjectDataGrid.DataSource = subs.Where(sub =>
                        sub.SubjectName.Contains(Search_textbox.Text.Trim()) ||
                        sub.SubjectCode.Contains(Search_textbox.Text.Trim()))
                    .Select(subject => new SubjectDTO
                    {
                        SubjectCode = subject.SubjectCode,
                        TeacherID = subject.TeacherID,
                        SubjectName = subject.SubjectName.Trim(),
                        SubjectDescription = subject.SubjectDescription,
                        SubjectPrice = subject.SubjectPrice,
                        IsActive = subject.IsActive
                    }).ToList();
            }
            else
            {
                LoadSubjects();
            }
        }

        private void Subjects_tab_Click(object sender, EventArgs e)
        {
        }

        private void OpenOnStudentPortalBtn_Click(object sender, EventArgs e)
        {
            if (_studentId > 0)
            {
                StudentPortal portal = new StudentPortal(_studentId, admin: _admin);
                portal.ShowDialog();
            }
        }

        private void NoneStudentsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var userId = (string) NoneStudentsGrid.Rows[e.RowIndex].Cells[0].Value;
                _user = _extrasRepo.GetUsers().FirstOrDefault(u => u.Id == userId);
                CreateStuAccountBtn.Visible = _user != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : $@"Oops failed to load user data!", @"Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateStuAccountBtn_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                RegistrationPortalForm registrationPortal = new RegistrationPortalForm(_user);
                var reg = registrationPortal.ShowDialog();
                if (reg == DialogResult.OK)
                {
                    _studentRepo = new StudentRepo();
                    _extrasRepo = new ExtrasRepo();
                    LoadStudents();
                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent_textbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchStudent_textbox.Text.Trim().Any())
            {
                StudentDataGrid.DataSource = _studentRepo.GetStudentsDetails().Where(stu =>
                        stu.FirstName.Contains(SearchStudent_textbox.Text.Trim()) ||
                        stu.LastName.Contains(SearchStudent_textbox.Text.Trim())).ToList();
            }
            else
            {
                StudentDataGrid.DataSource = _studentRepo.GetStudentsDetails().ToList();
            }
        }

        private void AddTeacher_btn_Click(object sender, EventArgs e)
        {
            var teacherForm = new TeacherForm();
            var op = teacherForm.ShowDialog(); // returns dialogue result

            // returns ok if teacher added
            if(op != DialogResult.Abort)
            {
                MessageBox.Show(@"New teacher added successfully", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                LoadTeachers();
            }
            else{
                MessageBox.Show(@"No new teacher was added", @"Operation cancelled", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
    }
}