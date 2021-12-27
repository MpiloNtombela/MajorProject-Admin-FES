using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using JetBrains.Annotations;
using RegistrationSystem.DataAccess.Repos;
using RegistrationSystem.DataTransferObject;
using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    public partial class StudentPortal : Form
    {
        private readonly int _studentId;
        private readonly AdminDto _admin;

        public StudentPortal(int studentId, [CanBeNull] AdminDto admin)
        {
            InitializeComponent();
            _studentId = studentId;
            _admin = admin;
            GetStudentDetails();
        }

        private StudentRepo _studentRepo = new StudentRepo();

        private void GetStudentDetails()
        {
            if (_studentId > 0)
            {
                try
                {
                    var student = _studentRepo.GetStudentDetail(id: _studentId);
                    if (student == null) return;
                    var reg = LoadRegStats(studentId: student.StudentID);
                    var profile = new UcStudent
                    {
                        StudentFullName = $@"{student.FirstName} {student.LastName}",
                        StudentEmail = student.Email,
                        RegistrationDate = reg.RegistrationDate.ToString(CultureInfo.InvariantCulture),
                        RegistrationStatus = reg.IsApproved ? "Approved" : "Not Approved",
                        PaymentPlan = reg.PaymentPlanID,
                        NumSubs = reg.Student.RegisteredSubjects.Count.ToString()
                    };

                    profile.Anchor = AnchorStyles.Top;
                    StudentProfileTableLayout.Controls.Add(profile, 0, 0);
                    LoadPayments(studentId: student.StudentID);
                    foreach (var rSub in reg.Student.RegisteredSubjects)
                    {
                        var subject = new UcSubject
                        {
                            SubjectName = rSub.Subject.SubjectName,
                            SubjectCode = rSub.SubjectCode,
                            SubjectDescription = rSub.Subject.SubjectDescription,
                            SubjectPrice = rSub.Subject.SubjectPrice,
                            SubjectSelectable = false
                        };

                        RegisteredSubjects_flowlayout.Controls.Add(subject);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        Utils.Helpers.NotNull(ex.Message)
                            ? Utils.Helpers.GetErrorMessage(ex)
                            : "Something went wrong loading student data", @"Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                var regForm = new RegistrationForm();
                regForm.ShowDialog();
            }
        }

        private void LoadPayments(int studentId)
        {
            payments_datagrid.DataSource = _studentRepo.GetPayments(studentId: studentId).Select(pay =>
                new PaymentDto
                {
                    PaymentId = pay.PaymentID,
                    Amount = pay.Amount,
                    PaymentDescription = pay.PaymentDecription,
                    PaymentDate = pay.PaymentDate,
                    Success = pay.Success
                }).ToList();
        }

        private DataAccess.Registration LoadRegStats(int studentId)
        {
            var reg = _studentRepo.GetRegistration(studentId: studentId);
            AmountDue.Text = reg.AmountDue.ToString("C");
            AmountPaid.Text = reg.AmountPayed.ToString("C");
            var owing = reg.AmountPayed - reg.AmountDue;
            AmountOwing.Text = owing.ToString("C");
            AmountOwing.ForeColor = owing < 0 ? Color.Red : Color.LimeGreen;
            PaymentStatsPanel.Visible = true;
            MakePaymentButton.Visible = Utils.Validators.PaymentRequired(reg);
            if (reg.IsApproved)
            {
                ApprovalDate.Text = reg.ApproveDate?.ToString("D");
                NextPaymentDate.Text = reg.NextPayment?.ToString("D");
            }
            else
            {
                ApprovalDate.Text = @"Not Approved";
                NextPaymentDate.Text = @"Awaiting Approval";
            }

            NextPaymentDataPanel.Visible = reg.AmountDue > reg.AmountPayed;
            ApproveRegBtn.Visible = !reg.IsApproved;
            return reg;
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            if (_admin != null)
            {
                AdminDetails.Text = $@"{_admin.FirstName} {_admin.LastName} (admin)";
            }
        }

        private void MakePaymentButton_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm(_studentId);
            var payed = payment.ShowDialog();
            if (payed == DialogResult.OK)
            {
                RefreshData();
            }
            else
            {
                MessageBox.Show(@"Transaction Cancelled", @"Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ApproveRegBtn_Click(object sender, EventArgs e)
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
                    reg.AdminID = _admin?.AdminId;
                    if (_studentRepo.SaveChanges())
                    {
                        MessageBox.Show($@"Successfully approved registration!",
                            @"Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadRegStats(studentId: reg.StudentID);
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

        private void RefreshData()
        {
            _studentRepo = new StudentRepo();
            LoadRegStats(studentId: _studentId);
            LoadPayments(studentId: _studentId);
        }

        private void ReloadData_Click(object sender, EventArgs e)
        {
            RefreshData();
            MessageBox.Show(@"Page refreshed successfully", @"Complete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}