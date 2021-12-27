using System;
using System.Windows.Forms;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;
using RegistrationSystem.Utils;

namespace RegistrationSystem
{
    public partial class BankingForm : Form
    {
        private readonly BankDetail _bank;
        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();
        private readonly int _studentId;

        public BankingForm(int studentId)
        {
            _studentId = studentId;
            _bank = _extrasRepo.GetBankDetails(studentId: studentId);
            InitializeComponent();
        }

        private void AddBank_btn_Click(object sender, EventArgs e)
        {
            if (!Helpers.Helpers.AllFieldsChecked(BankingDetails_groupbox))
            {
                MessageBox.Show(@"Please fill all required fields", @"Input Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!Validators.IsValidDigits(CardNumber_control.InputText))
                {
                    MessageBox.Show(@"Please enter a valid card Number", @"Invalid Card");
                    return;
                }

                if (_bank != null)
                {
                    var bank = _extrasRepo.GetBankDetails(studentId: _studentId);
                    bank.BankName = BankName_control.InputText;
                    bank.CardHolder = CardholderName_control.InputText;
                    bank.CardNumber = CardNumber_control.InputText;
                    bank.Cvc = CVVorCVC_control.InputText;
                    bank.ExpiryDate = new DateTime(
                        int.Parse(ExpYear_combobox.Text),
                        int.Parse(ExpMonth_combobox.Text),
                        01);
                    // check if card doesn't expire in the next 6 months
                    if (bank.ExpiryDate > DateTime.Now.AddMonths(6))
                    {
                        if (_extrasRepo.SaveChanges())
                        {
                            MessageBox.Show(@"Bank Details updated successfully", @"Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(@"Oops update failed, something went wrong", @"Error Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Please use a card that doesn't expire in the next 6 months",
                            @"Card not allowed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    var bank = new BankDetail
                    {
                        StudentID = _studentId,
                        BankName = BankName_control.InputText,
                        CardHolder = CardholderName_control.InputText,
                        CardNumber = CardNumber_control.InputText,
                        Cvc = CVVorCVC_control.InputText,
                        ExpiryDate = new DateTime(
                            int.Parse(ExpYear_combobox.Text),
                            int.Parse(ExpMonth_combobox.Text),
                            01)
                    };
                    // check if card doesn't expire in the next 6 months
                    if (bank.ExpiryDate > DateTime.Now.AddMonths(6))
                    {
                        _extrasRepo.AddBankingDetails(bank);
                        if (_extrasRepo.SaveChanges())
                        {
                            MessageBox.Show(@"Bank Details captured successfully", @"Success Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(@"Oops failed to capture details", @"Error Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Please use a card that doesn't expire in the next 6 months",
                            @"Card not allowed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    Utils.Helpers.NotNull(ex.Message)
                        ? Utils.Helpers.GetErrorMessage(ex)
                        : "Banking details operation failed", @"Banking Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BankingForm_Load(object sender, EventArgs e)
        {
            if (_studentId < 1)
            {
                MessageBox.Show(@"Failed to load student data", @"Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
            else
            {
                ExpYear_combobox.Items.AddRange(Utils.Helpers.GetArray(DateTime.Now.Year, 10));
                ExpMonth_combobox.Items.AddRange(Utils.Helpers.GetArray(1, 12));
                
                if (_bank != null)
                {
                    BankName_control.InputText = _bank.BankName;
                    CardholderName_control.InputText = _bank.CardHolder;
                    CardNumber_control.InputText = _bank.CardNumber;
                    CVVorCVC_control.InputText = _bank.Cvc;
                    ExpMonth_combobox.SelectedIndex = 0;
                    ExpYear_combobox.SelectedIndex = 0;
                    AddBank_btn.Text = @"UPDATE BANKING DETAILS";
                }
                else
                {
                    AddBank_btn.Text = @"ADD BANKING DETAILS";
                }
            }
        }

        private void PayPartIcon_Click(object sender, EventArgs e)
        {
        }
    }
}