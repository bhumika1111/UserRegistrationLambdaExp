using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    class UserPasswordRule3
    {
        string UserPass3 = "^[A-Z]{1}[0-9]{1}[A-Z a-z]{7}$";


        public string ValidPasswordCheckusingLambda(string password) => Regex.IsMatch(password, UserPass3) ? "Password is Valid" : "Password is Not Valid";
    }
}
