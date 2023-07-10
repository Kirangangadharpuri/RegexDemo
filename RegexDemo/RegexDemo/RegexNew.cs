using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    //A regex (Regular expression) is a pattern that is used to check whether a given string matches that pattern.
    public class RegexNew
    {
        static string pattern = "^cen$";
        // ^ it wii indicate  string start 
        // $ it wii indicate the end of the string

        public void MyRegex()
        {
            // we have created object of class
            // we have pass a parameter pattern in given class constructor
            Regex regex = new Regex(pattern);
            //Ismatch return true if its matechess the string otherwise it return false
            if(regex.IsMatch("kiran"))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string doen not match the pattern");
            }
        }

        public void CheckName(string name)
        {
            //? will check value we are using that return th same thing.(0 or 1) 
            string myName = "^[A-Z][a-z]{3,}?$";
            if(Regex.IsMatch(name,myName))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string doen not match the pattern");
            }

        }
        public void LastName(string lastName)
        {
           string myLastName = "^[A-Z][a-z]{3,}?$";
           if(Regex.IsMatch(lastName, myLastName))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("string doen not match the pattern");
            }
        }
        
    }
}
