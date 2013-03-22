using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcSqMustBePosIntIfNotExcpTryCatcFin
{
    class CalcSqMustBePosIntIfNotExcpTryCatcFin
    {
        public static double Sqrt(double value)
        {
            if (value <= 0)
                throw new System.ArgumentOutOfRangeException("Invalid number");
            return Math.Sqrt(value);
        }

        static void Main(string[] args)
        {
            //Write a program that reads an integer number and calculates and prints its 
            //square root. If the number is invalid or negative, print "Invalid number". 
            //In all cases finally print "Good bye". Use try-catch-finally.
            ReadNum();
        }
        static void ReadNum()
        {
            string str = Console.ReadLine();
            try
            {
                int x = Int32.Parse(str);
                Console.WriteLine(Sqrt(x));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}