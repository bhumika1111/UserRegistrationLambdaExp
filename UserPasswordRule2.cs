﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class UserPasswordRule2
    {
        string UserPass2 = "^[A-Z]{1}[A-z a-z]{8,15}$";


        public string ValidPasswordCheckusingLambda(string password) => Regex.IsMatch(password, UserPass2) ? " Password is Valid" : "Password is Not Valid";
    }
}
