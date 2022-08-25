using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    class UserValidEmail
    {
        string Email = "^[a-z]{3,5}['.'][a-z]{3,7}['@'][a-z]{3}$";


        public string ValidEmailCheckusingLambda(string email) => Regex.IsMatch(email, Email) ? "Email is Valid" : "Email is Not Valid";
    }
}
