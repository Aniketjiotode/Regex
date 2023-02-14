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
         
        public void patterncheck()
        {
            Regex regex= new Regex(Fullname);
            Console.WriteLine("Enter the Fullname:");
            string FName=Console.ReadLine();
            Console.WriteLine(regex.IsMatch(FName));    
        }
    }
}
