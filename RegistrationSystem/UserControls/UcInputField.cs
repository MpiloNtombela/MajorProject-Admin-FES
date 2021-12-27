using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RegistrationSystem.Properties;

namespace RegistrationSystem.UserControls
{
    public partial class UcInputField : UserControl
    {
        public UcInputField()
        {
            InitializeComponent();
            LoadControl();
        }

        public event EventHandler<InputFieldErrorEventArgs> InputFieldError;

        public bool InputHasError { get; set; }

        protected virtual void OnInputFieldError(InputFieldErrorEventArgs e)
        {
            InputFieldError?.Invoke(this, e);
        }


        private void ucInputField_Load(object sender, EventArgs e)
        {
            LoadControl();
        }

        public enum InputTypes
        {
            Text,
            Word,
            Number,
            Email,
            Secrete,
        }

        #region Properties

        private string _label;
        private string _input;

        [Category("Custom Props")]
        public string InputLabel
        {
            get { return _label; }
            set
            {
                _label = value;
                InputLabel_label.Text = value;
            }
        }

        [Category("Custom Props")]
        public string InputText
        {
            get { return _input; }
            set
            {
                _input = value;
                InputField_textbox.Text = value;
            }
        }

        [Category("Custom Props")]
        [Description("Options for type of input")]
        [DefaultValue(InputTypes.Text)]
        public InputTypes InputType { get; set; } = InputTypes.Text;

        [Category("Custom Props")]
        [DefaultValue(0)]
        public int InputMin { get; set; } = 0;

        [Category("Custom Props")]
        [DefaultValue(0)]
        public int InputMax { get; set; } = 0;

        // public string[] InputType { get; set; } = ne

        #endregion

        private void LoadControl()
        {
            InputLabel_label.ForeColor = Color.DarkGray;
            if (!string.IsNullOrWhiteSpace(InputField_textbox.Text)) return;
            InputField_textbox.Text = _label;
            InputField_textbox.ForeColor = Color.DarkGray;
            InputLabel_label.Visible = false;
            InputField_textbox.PasswordChar = new char();
        }

        // just *basic* checks if email is valid
        private static bool IsValidEmail(string email)
        {
            var emailPatten = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            try
            {
                return emailPatten.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // checks if input length entered by user meets the required length
        private Tuple<bool, string> ValidInputLength()
        {
            var length = _input != _label ? _input.Length : 0;
            if (length < InputMin) return Tuple.Create(false, $@"Input must be at least {InputMin} chars long");
            return (length > InputMax && InputMax != 0)
                ? Tuple.Create(false, $@"Input exceeds a limit of {InputMax} chars")
                : Tuple.Create(true, "valid");
        }

        // checks if input entered by user is valid (given InputType)
        private Tuple<bool, string> VerifyInput()
        {
            var input = InputField_textbox.Text.Trim();
            var i = input.Length;
            var validInput = Tuple.Create(true, "valid");
            if (!ValidInputLength().Item1)
            {
                return ValidInputLength();
            }

            switch (InputType)
            {
                case InputTypes.Text:
                    return validInput;
                case InputTypes.Number:
                {
                    double num;
                    return !double.TryParse(input, out num) ? Tuple.Create(false, "Expected a number") : validInput;
                }
                case InputTypes.Email:
                    return !IsValidEmail(input) ? Tuple.Create(false, "Invalid email address") : validInput;
                case InputTypes.Word:
                {
                    var word = input.Trim();
                    double x;
                    if (double.TryParse(word, out x)) return Tuple.Create(false, "must be a word not numbers");
                    return word.Contains(" ") ? Tuple.Create(false, "spaces are not allowed") : validInput;
                }
                // for things like passwords
                case InputTypes.Secrete:
                    return validInput;
                default:
                    throw new ArgumentOutOfRangeException(nameof(InputType), InputType, null);
            }
        }


        private void InputField_textbox_Enter(object sender, EventArgs e)
        {
            InputFieldBorder_panel.BackColor = Color.DarkOrange;
            InputLabel_label.Visible = true;
            InputLabel_label.ForeColor = Color.DarkOrange;
            InputField_textbox.ForeColor = Color.WhiteSmoke;
            if (InputField_textbox.Text == _label)
            {
                InputField_textbox.Clear();
            }

            if (InputType == InputTypes.Secrete)
            {
                InputField_textbox.PasswordChar = char.Parse(@"•");
            }

            if (!InputHasError) return;
            InvalidInput_picturebox.Visible = false; // hides invalid picture box
            var eventArgs = new InputFieldErrorEventArgs { IsResolved = true };
            OnInputFieldError(eventArgs);
            InputHasError = false;
        }


        private void InputField_textbox_Leave(object sender, EventArgs e)
        {
            InputFieldBorder_panel.BackColor = Color.DarkGray;
            LoadControl();
            var isInputValid = VerifyInput();
            if (isInputValid.Item1) return;
            InvalidInput_picturebox.Visible = true;
            InvalidInput_picturebox.Image = Resources.error_icon;
            InputFieldBorder_panel.BackColor = Color.Red;
            // set up a tooltip with text why input is not valid
            InvalidInput_tooltip.SetToolTip(InvalidInput_picturebox, isInputValid.Item2);
            // fires a input field error error event
            var eventArgs = new InputFieldErrorEventArgs {IsResolved = false};
            OnInputFieldError(eventArgs);
            InputHasError = true;
        }

        private void InputField_textbox_TextChanged(object sender, EventArgs e)
        {
            _input = InputField_textbox.Text;
        }

    }

    public class InputFieldErrorEventArgs : EventArgs
    {
        public bool IsResolved { get; set; }
    }
}