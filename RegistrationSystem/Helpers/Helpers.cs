using System;
using System.Windows.Forms;
using RegistrationSystem.UserControls;

namespace RegistrationSystem.Helpers
{
    public class Helpers
    {
        // checks whether things like ID Number or Bank Card Number are valid
        public static bool IsValidDigits(string num)
        {
            var numDigits = num.Length;

            var finalSum = 0;
            var isSecondDigit = false;
            for (var i = numDigits - 1; i >= 0; i--)
            {
                var d = num[i] - '0';
                if (isSecondDigit)
                    d *= 2;
                finalSum += d / 10;
                finalSum += d % 10;

                isSecondDigit = !isSecondDigit;
            }

            return finalSum % 10 == 0;
        }


        // checks whether the input is a valid ID number or Passport depending of the structure and length of the input
        public static Tuple<bool, string> IsValidIdPassNumber(string input)
        {
            var invalidPassport = Tuple.Create(false, "Invalid Passport Number");
            double id;
            if (double.TryParse(input, out id)) // if the entire input is a number checks whether that an ID
            {
                // RSA ID has 13 digits
                if (input.Length == 13)
                {
                    return IsValidDigits(input)
                        ? Tuple.Create(true, "ID valid")
                        : Tuple.Create(false, "Invalid ID Numbers");
                }

                return Tuple.Create(false, "ID Number must be 13 digits long");
            }

            // check valid passport RSA Passport has 1 letter (char) followed by 8 digits
            if (input.Length == 9)
            {
                return char.IsLetter(input[0]) ? Tuple.Create(true, "Passport valid") : invalidPassport;
            }

            return invalidPassport;
        }


        // returns an input text from UcInputField (custom)
        public static string GetCustomControlInput(UcInputField field)
        {
            return field.InputText != field.InputLabel ? field.InputText : "";
        }


        //checks if all the input fields /Textbox are filled,
        // fields to be checked must have a parent Control (grouped using controls like groupBox)
        public static bool AllFieldsChecked(Control parentControl)
        {
            if (!parentControl.HasChildren) return true;
            foreach (Control control in parentControl.Controls)
            {
                // a Tag property must be provided to specify whether the input field is a
                // stock windows control (WinInputControl) or custom control/UcInputField (CustomInputControl)
                try
                {
                    switch ((string)control.Tag)
                    {
                        case "CustomInputControl":
                            if (!string.IsNullOrWhiteSpace(GetCustomControlInput((UcInputField)control))) continue;
                            return false;
                        case "WinInputControl":
                            if (!string.IsNullOrWhiteSpace(control.Text)) continue;
                            return false;
                        default:
                            {
                                if (control.HasChildren && control is GroupBox) AllFieldsChecked(control);
                                continue;
                            }
                    }
                }
                catch (Exception){ /*pass;*/}
            }

            return true;
        }
    }
}
