using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    class UserLastName
    {
        string Lastname = "^[A-Z]{1}[a-z]{2,7}$";


        public string LastnameCheckusingLambda(string lastname) => Regex.IsMatch(lastname, Lastname) ? "LastName is Valid" : "LastName is Not Valid";
    }
}
