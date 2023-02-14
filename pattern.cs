using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_
{
    internal class pattern
    {
        public static string name = "^[A-Z][a-z]{2,9}$";
         
        public void patterncheck()
        {
            Regex regex= new Regex(name);
            Console.WriteLine("Enter the name:");
            string Name=Console.ReadLine();
            Console.WriteLine(regex.IsMatch(Name));    
        }
    }
}
