using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    class UserValidEmailId
    {
        string EmailId = "^[a-z]{3,5}['@'][a-z]{3,7}['.'][a-z]{3}$";


        public string ValidEmailCheckusingLambda(string email) => Regex.IsMatch(email, EmailId) ? "Email is Valid" : "Email is Not Valid";
    }
}

