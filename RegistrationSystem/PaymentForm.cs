using System;
using System.Data.Entity;
using System.Windows.Forms;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;

namespace RegistrationSystem
{
    public partial class PaymentForm : Form
    {
        private readonly StudentDetail _studentDetail;
        private readonly Registration _registration;
        private BankDetail _bank;

        public PaymentForm(int studentId)
        {
            InitializeComponent();
            _studentDetail = _studentRepo.GetStudentDetail(id: studentId);
            _registration = _studentRepo.GetRegistration(studentId: _studentDetail.StudentID);
            _bank = _extrasRepo.GetBankDetails(studentId: _studentDetail.StudentID);
        }

        private readonly Helpers.Helpers _helper = new Helpers.Helpers();
        private readonly StudentRepo _studentRepo = new StudentRepo();
        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();

        private static decimal GetFee(Registration registration)
        {
            if (registration.AmountDue - registration.AmountPayed < 1)
            {
                return registration.AmountDue - registration.AmountPayed;
            }

            return registration.AmountDue / registration.PaymentPlan.PaymentLength;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            if (_registration != null)
            {
                var bankingForm = new BankingForm(_studentDetail.StudentID);
                if (_bank == null)
                {
                    // show banking form to capture student's banking data
                    MessageBox.Show(@"Please Input student's banking details", @"Banking required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    bankingForm.ShowDialog();
                }

                // recheck if the student's banking data was captured in the bankingForm
                _bank = _extrasRepo.GetBankDetails(_studentDetail.StudentID);

                if (_bank == null)
                {
                    MessageBox.Show(@"No banking details found for student", @"Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }

                var fee = GetFee(_registration);
                const decimal regFee = 500;
                RegistrationFee.Visible = _registration.PaymentCycle <= 1;
                RegistrationFeeLabel.Visible = _registration.PaymentCycle <= 1;
                TuitionFee.Text = fee.ToString("C");
                RegistrationFee.Text = regFee.ToString("C");
                TotalDue.Text = _registration.PaymentCycle <= 1 ? (fee + regFee).ToString("C") : fee.ToString("C");

                NoteReg.Visible = _registration.PaymentCycle <= 1;
                TuitionFeeCalc.Text = $@"({_registration.AmountDue:C} / {_registration.PaymentPlan.PaymentLength})";
            }
            else
            {
                MessageBox.Show(@"Failed to load student registration data", @"Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void PayNowBtn_Click(object sender, EventArgs e)
        {
            using (var transaction = _studentRepo.DbTransaction())
            {
                try
                {
                    if (_registration.PaymentCycle <= 1)
                    {
                        var regPayment = new Payment
                        {
                            RegistrationID = _registration.RegistrationID,
                            Amount = 500,
                            PaymentDecription = "Initial Registration Fee",
                            PaymentDate = DateTime.Now,
                            Success = true,
                        };
                        _studentRepo.MakePayment(regPayment);
                        _studentRepo.SaveChanges();
                    }

                    var payment = new Payment
                    {
                        RegistrationID = _registration.RegistrationID,
                        Amount = GetFee(_registration),
                        PaymentDecription =
                            $"Tuition fee payment {_registration.PaymentCycle} of {_registration.PaymentPlan.PaymentLength}",
                        PaymentDate = DateTime.Now,
                        Success = true
                    };
                    var reg = _studentRepo.GetRegistration(studentId: _studentDetail.StudentID);
                    if (Utils.Validators.PaymentRequired(reg))
                    {
                        _studentRepo.MakePayment(payment);
                        reg.PaymentCycle += 1;
                        reg.NextPayment = DateTime.Now.AddMonths(1);
                        reg.AmountPayed += GetFee(reg);
                        _studentRepo.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show(@"Payment successfully captured!", @"Payment Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"No payment is required from student", @"Payment Status",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        Utils.Helpers.NotNull(ex.Message)
                            ? Utils.Helpers.GetErrorMessage(ex)
                            : "Payment process failed", @"Payment Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    transaction.Rollback();
                }
                finally
                {
                    Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}