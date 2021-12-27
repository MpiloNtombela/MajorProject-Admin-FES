using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class UcStudent : UserControl
    {

        public UcStudent()
        {
            InitializeComponent();
        }

        private string _studentFullname;
        private string _studentEmail;
        private string _paymentPlan;
        private string _paymentsLeft;
        private string _lastPaymentDate;
        private string _registrationStatus;
        private string _registrationDate;
        private string _numSubjects;

        [Category("Custom props")]
        public string StudentFullName
        {
            get { return _studentFullname;} set { _studentFullname = value;
                StudentFullName_label.Text = value;
            }
        }
        [Category("Custom props")]
        public string StudentEmail
        {
            get { return _studentEmail; }
            set
            {
                _studentEmail = value;
                StudentEmail_label.Text = value;
            }
        }

        [Category("Custom props")]
        public string PaymentPlan
        {
            get { return _paymentPlan; }
            set
            {
                _paymentPlan = value;
                PaymentPlan_label.Text = value;
            }
        }

        [Category("Custom props")]
        public string RegistrationStatus
        {
            get { return _registrationStatus; }
            set
            {
                _registrationStatus = value;
                RegistrationStutus_label.Text = value;
            }
        }

        [Category("Custom props")]
        public string RegistrationDate
        {
            get { return _registrationDate; }
            set
            {
                _registrationDate = value;
                RegistrationDate_label.Text = value;
            }
        }

        [Category("Custom props")]
        public string NumSubs
        {
            get { return _numSubjects; }
            set
            {
                _numSubjects = value;
                NumberOfSubjects_label.Text = value;
            }
        }


    }
}
