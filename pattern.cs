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
        public static string PhoneNumber = @"^[0-9]{2}[ ][0-9]{10,}$";
        public static string Password = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public void patterncheck()
        {
            Regex r1= new Regex(Fullname);
            Console.WriteLine("Enter the FullName:");
            string Fname=Console.ReadLine();
            Console.WriteLine(r1.IsMatch(Fname));   
            Regex r2= new Regex(Email);
            Console.WriteLine("Enter the EmailId:");
            string email=Console.ReadLine();
            Console.WriteLine(r2.IsMatch(email)); 
            Regex r3= new Regex(PhoneNumber);
            Console.WriteLine("Enter the PhoneNumber:");
            string number=Console.ReadLine();
            Console.WriteLine(r3.IsMatch(number)); 
            Regex r4= new Regex(Password);
            Console.WriteLine("Enter the Password:");
            string password=Console.ReadLine();
            Console.WriteLine(r4.IsMatch(password));   
        }
    }
}
