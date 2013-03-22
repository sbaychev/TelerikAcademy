using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isFemaleBoolean
{
    class isFemaleBoolean
    {
        static void Main(string[] args)
        {
            /*Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.*/
            bool isFemale = false;
            if (isFemale)
            {
                Console.WriteLine("I am a female.");
            }
            else
            {
                Console.WriteLine("I am a male.");
            }
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}