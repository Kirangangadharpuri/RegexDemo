using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Check pattern matching using regex");
                Console.WriteLine("2-Check name matching or not using pattern");
                Console.WriteLine("3-Check last name matching or not using pattern");
                Console.WriteLine("4-Check mobile number matching or not using parameter");

                Console.WriteLine("Choose above option");
                int option=Convert.ToInt32(Console.ReadLine());
                RegexNew regexNew = new RegexNew();

                switch (option)
                {
                    case 1:
                        regexNew.MyRegex();
                        break;
                        case 2:
                        regexNew.CheckName("Kiran");
                        break;
                        case 3:
                        regexNew.LastName("Puri");
                        break;
                        case 4:
                        regexNew.ValidateMobileNumber("91 8234567891");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

        }
    }
}
