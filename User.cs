﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
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
        public static bool ValidateEmail()
        {
            Regex regex = new Regex(EMAIL);
            return regex.IsMatch("abc.xyz@bl.co.in");
        }
    }
}