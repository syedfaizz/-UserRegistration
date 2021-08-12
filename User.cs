using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{2}";
        public const string LAST_NAME = "^[A-Z]{1}[a-z]{2}";
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRST_NAME);
            return regex.IsMatch("Faisal");
        }
        public static bool ValidateLastName()
        {
            Regex regex = new Regex(LAST_NAME);
            return regex.IsMatch("Sayed");
        }
    }
}