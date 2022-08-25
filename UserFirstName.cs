using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
   public class UserFirstName
    {
        string Firstname = "^[A-Z]{1}[a-z]{2,7}$";


        public string FirstnameCheckusingLambda(string firstname) => Regex.IsMatch(firstname, Firstname) ? "FirstName is Valid" : "FirstName is Not Valid";
       
    }
}
