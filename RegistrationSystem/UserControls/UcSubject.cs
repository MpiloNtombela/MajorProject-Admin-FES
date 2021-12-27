using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using RegistrationSystem.Properties;

namespace RegistrationSystem.UserControls
{
    public partial class UcSubject : UserControl
    {
        // create a new event that will be fired when subjectSelected bool changes
        public event EventHandler SubjectSelectedChanged;
        public event EventHandler MatricMarkChanged;
        public UcSubject()
        {
            InitializeComponent();
        }

        protected virtual void OnSubjectSelectedChange(EventArgs e)
        {
            SubjectSelectedChanged?.Invoke(this, e);
        }
        // tells evt listners that Matric Matric mark might have changed
        protected virtual void OnMatricMarkChange(EventArgs e)
        {
            MatricMarkChanged?.Invoke(this, e);
        }

        private void LoadControl()
        {
            SelectSubject_picturebox.Visible = SubjectSelectable;
            SubjectCode_label.Text = string.IsNullOrWhiteSpace(_subjectCode) ? $"SCODE{new Random().Next()}" : _subjectCode;
            SubjectName_label.Text = string.IsNullOrWhiteSpace(_subjectName) ? "Subject Name" : _subjectName;
            SubjectDescription_label.Text = string.IsNullOrWhiteSpace(_subjectDescription) ? "Subject Description" : _subjectDescription;
            SubjectPrice_label.Text = string.IsNullOrWhiteSpace(_subjectPrice.ToString(CultureInfo.InvariantCulture)) ? "000.00" : _subjectPrice.ToString(CultureInfo.InvariantCulture);
            MatricMarkContainer_panel.Visible = SubjectSelectable && SubjectSelected;
        }

        #region Properties
        private string _subjectName;
        private string _subjectDescription;
        private decimal _subjectPrice;
        private string _subjectCode;
        private string _matricMark;


        [Category("Custom Props")]
        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; SubjectName_label.Text = value; }
        }

        [Category("Custom Props")]
        public string SubjectDescription
        {
            get { return _subjectDescription; }
            set { _subjectDescription = value; SubjectDescription_label.Text = value; }
        }

        [Category("Custom Props")]
        public decimal SubjectPrice
        {
            get { return _subjectPrice; }
            set { _subjectPrice = value; SubjectPrice_label.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        [Category("Custom Props")]
        public string SubjectCode
        {
            get { return _subjectCode; }
            set { _subjectCode = value; SubjectCode_label.Text = value; }
        }

        [Category("Custom Props")]
        public bool SubjectSelected { get; set; }

        [Category("Custom Props"), Description("Controls whether select or check Icon will be shown to user, rebuild required to see effect")]
        public bool SubjectSelectable { get; set; } = true;

        [Category("Custom Props")]
        public string MatricMark
        {
            get { return _matricMark; }
            set { _matricMark = value; MatricMark_textbox.Text = value; }
        }

        #endregion

        private void SelectSubject_picturebox_Click(object sender, EventArgs e)
        {
            if (!SubjectSelectable) return;
            SubjectSelected = !SubjectSelected;
            SelectSubject_picturebox.Image = SubjectSelected ? Resources.checked_icon : Resources.check_icon;
            MatricMarkContainer_panel.Visible = SubjectSelected;
            OnSubjectSelectedChange(EventArgs.Empty);
        }

        private void ucSubject_Load(object sender, EventArgs e)
        {
            LoadControl();
        }

        private void MatricMark_textbox_TextChanged(object sender, EventArgs e)
        {
            _matricMark = MatricMark_textbox.Text;
        }

        private void bg_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MatricMark_textbox_Leave(object sender, EventArgs e)
        {
            OnMatricMarkChange(EventArgs.Empty);
        }
    }
}
