using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_
{
    internal class pattern
    {
        public static string name = "^[A-Z][a-z]{2,9}$";
        public static string Fullname = "^[A-Z][a-z]{2,9}[ ][A-Z][a-z]{2,9}$";
        public static string Email = @"[a-z]{3,7}.?[a-z0-9]{3,8}[@][a-z]{3,8}.(com|org)$";

        public void patterncheck()
        {
            Regex regex= new Regex(Email);
            Console.WriteLine("Enter the EmailId:");
            string email=Console.ReadLine();
            Console.WriteLine(regex.IsMatch(email));   
        }
    }
}
