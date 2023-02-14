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
        public static string Email = @"[a-z]{3,9}.?[a-z0-9]{3,8}[@][a-z]{3,8}[\.](com|org|in|net)$";
        public static string PhoneNumber = @"^[0-9]{2}[ ][0-9]{10}$";

        public void patterncheck()
        {
            Regex regex= new Regex(PhoneNumber);
            Console.WriteLine("Enter the phoneNumber:");
            string Number=Console.ReadLine();
            Console.WriteLine(regex.IsMatch(Number));   
        }
    }
}
