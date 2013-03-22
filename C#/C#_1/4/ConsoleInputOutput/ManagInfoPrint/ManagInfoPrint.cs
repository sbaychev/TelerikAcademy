using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagInfoPrint
{
    class ManagInfoPrint
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name,
             * age and a phone number. Write a program that reads the information about a company and its manager and prints them
             * on the console.*/
            Console.Write("Company Name: ");
            string compName = Console.ReadLine();
            Console.Write("\nCompany Address: ");
            string compAddress = Console.ReadLine();
            Console.Write("\nCompany Phone Number: ");
            uint compPhone = uint.Parse(Console.ReadLine());
            Console.Write("\nCompany Fax Number: ");
            uint compFax = uint.Parse(Console.ReadLine());
            Console.Write("\nCompany Web Site: ");
            string compWeb = Console.ReadLine();
            Console.Write("\nCompany Manager, First Name: ");
            string compMangFirN = Console.ReadLine();
            Console.Write("\nCompany Manager, Last Name: ");
            string compMangLaN = Console.ReadLine();
            Console.Write("\nCompany Manager Age: ");
            byte compMangAge = byte.Parse(Console.ReadLine());
            Console.Write("\nCompany Manager, Phone Number: ");
            uint compMangPhon = uint.Parse(Console.ReadLine());
            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", compName, compAddress, compPhone, compFax, compWeb,
                                                                            compMangFirN, compMangLaN,compMangAge, compMangPhon);
        }
    }
}