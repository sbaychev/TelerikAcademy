using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentAgeAfterTen
{
    class CurrentAgeAfterTen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();
            int uAge = int.Parse(age);
            int afterTen = uAge + 10;
            Console.WriteLine("After 10 Years, you would be: {0} years old", afterTen );
        }
    }
}
