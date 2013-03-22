using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsciiPrint
{
    class AsciiPrint
    {
        static void Main(string[] args)
        {   /*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program 
             * that prints the entire ASCII table of characters on the console.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8; 
                                           /* I am using the UTF8 encoding since it is backward-compatible with ASCII 
                                            * http://en.wikipedia.org/wiki/UTF-8. And also printing out all the 
                                            * characters after the first 32 control characters, because The first 32 characters in the
                                            * ASCII-table are unprintable control codes and are used to control peripherals such as printers.*/
            int column = 0;
            for (int counter = 32; counter <= 255; counter++)
            {
                Console.Write(" {0}  ", (char)counter);
                if (++column > 15)
                {
                    column = 0;
                    Console.WriteLine();
                }
            }
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}