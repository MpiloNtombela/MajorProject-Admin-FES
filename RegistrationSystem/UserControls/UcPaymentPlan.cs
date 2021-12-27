using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RegistrationSystem.Properties;

namespace RegistrationSystem.UserControls
{
    public partial class UcPaymentPlan : UserControl
    {
        // create a new event that will be fired when subjectSelected bool changes
        public event EventHandler SelectedPaymentPlanChanged;

        public UcPaymentPlan()
        {
            InitializeComponent();
        }

        private void LoadControl()
        {
            SelectPayment_picturebox.Image = PaymentPlanSelected
                ? Resources.checked_icon
                : Resources.check_icon;
            _expectedPay = !string.IsNullOrWhiteSpace(_expectedPay) ? _expectedPay : "Expected Pay";
            _paymentPlanTitle = !string.IsNullOrWhiteSpace(_paymentPlanTitle) ? _paymentPlanTitle : $@"Payment plan {new Random().Next(1, 10)}";
            _paymentPlanDescription = !string.IsNullOrWhiteSpace(_paymentPlanDescription) ? _paymentPlanDescription : "Payment plan description";
            _paymentPlanLength = !string.IsNullOrWhiteSpace(_paymentPlanLength) ? _paymentPlanLength : "Payment Plan Length";
        }

        private void UcPaymentPlan_Load(object sender, EventArgs e)
        {
            LoadControl();
        }

        protected virtual void OnSelectedPaymentPlanChanged(EventArgs e)
        {
            SelectedPaymentPlanChanged?.Invoke(this, e);
        }

        #region Properties

        private string _expectedPay;
        private string _paymentPlanTitle;
        private string _paymentPlanDescription;
        private string _paymentPlanLength;
        private Image _selectIcon;

        public bool PaymentPlanSelected { get; set; }

        [Category("Custom Props")]
        public string PaymentPlanId { get; set; }

        [Category("Custom Props")]
        public string ExpectedPay
        {
            get { return _expectedPay; }
            set
            {
                _expectedPay = value;
                ExpectedPay_label.Text = value;
            }
        }

        [Category("Custom Props")]
        public string PaymentPlanTitle
        {
            get { return _paymentPlanTitle; }
            set { _paymentPlanTitle = value;
                PaymentPlanTitle_label.Text =value;
            }
        }

        [Category("Custom Props")]
        public string PaymentPlanDescription
        {
            get { return _paymentPlanDescription; }
            set
            {
                _paymentPlanDescription = value;
                PaymentPlanDescription_label.Text = value;
            }
        }

        [Category("Custom props"), Description("A display icon indicating whether the payment is selected or not")]
        public Image SelectIcon
        {
            get { return _selectIcon;}
            set { _selectIcon = value;
                SelectPayment_picturebox.Image = value;
            }
        }

        [Category("Custom Props")]
        public string PaymentPlanLength
        {
            get { return _paymentPlanLength; }
            set
            {
                _paymentPlanLength = value;
                PaymentPlanLength_label.Text = value;
            }
        }


        #endregion

        private void SelectPayment_picturebox_Click(object sender, EventArgs e)
        {
            PaymentPlanSelected = !PaymentPlanSelected;

            // sends a payment change event to listeners
            OnSelectedPaymentPlanChanged(EventArgs.Empty);
        }

        
    }
}
