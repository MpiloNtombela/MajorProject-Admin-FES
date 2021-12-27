using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationSystem.Utils
{
    public static class Validators
    {
        public static bool IsValidDigits(string num)
        {
            if (!long.TryParse(num, out _))
            {
                return false;
            }

            var numDigits = num.Length;

            var finalSum = 0;
            var isSecondDigit = false;
            for (var i = numDigits - 1; i >= 0; i--)
            {
                var d = num[i] - '0';
                if (isSecondDigit)
                {
                    d *= 2;
                }

                finalSum += d / 10;
                finalSum += d % 10;

                isSecondDigit = !isSecondDigit;
            }

            return finalSum % 10 == 0;
        }


        // checks whether the input is a valid ID number
        public static Tuple<bool, string> IsValidIdentityNumber(string input)
        {
            var invalidNum = Tuple.Create(false, "Invalid ID Number");
            if (!long.TryParse(input, out var id))
            {
                return invalidNum;
            }

            // RSA ID has 13 digits
            return input.Length == 13
                ? IsValidDigits(input) && id > 0
                    ? Tuple.Create(true, "ID valid")
                    : invalidNum
                : Tuple.Create(false, "ID Number must be 13 digits long");
        }

        /// <summary>
        /// checks if there are any payment due for the registration
        /// </summary>
        /// <param name="registration">registration</param>
        /// <returns>true if there is payment else false</returns>
        public static bool PaymentRequired(DataAccess.Registration registration)
        {
            return registration.AmountDue > registration.AmountPayed && registration.IsApproved &&
                   registration.NextPayment < DateTime.Now;
        }
    }
}