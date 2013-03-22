using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPol
{
    class TwoPol
    {
        //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
        //x2 + 5 = 1x2 + 0x + 5 

        static void SumOfPolinomials(decimal[] firstPol, decimal[] secPol, decimal[] result)
        {
            int minLen = 0;
            int smalerPol = 0;

            if (firstPol.Length > secPol.Length)
            {
                minLen = secPol.Length;
                smalerPol = 2;
            }
            else
            {
                minLen = firstPol.Length;
                smalerPol = 1;
            }

            for (int i = 0; i < minLen; i++)
            {
                result[i] = firstPol[i] + secPol[i];
            }

            for (int i = minLen; i < result.Length; i++)
            {
                if (smalerPol == 1)
                {
                    result[i] = secPol[i];
                }
                else
                {
                    result[i] = firstPol[i];
                }
            }
        }

        //substraction of polinomials
        static void SubstractionOfPolinomials(decimal[] firstPol, decimal[] secondPol, decimal[] result)
        {
            int minLenght = 0;
            int smallerPolinomial = 0;

            if (firstPol.Length > secondPol.Length)
            {
                minLenght = secondPol.Length;
                smallerPolinomial = 2;
            }
            else
            {
                minLenght = firstPol.Length;
                smallerPolinomial = 1;
            }

            for (int i = 0; i < minLenght; i++)
            {
                result[i] = firstPol[i] - secondPol[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPolinomial == 1)
                {
                    result[i] = secondPol[i] * (-1);
                }
                else
                {
                    result[i] = firstPol[i];
                }
            }
        }

        //multiplication of polinomials
        static void MultiplyPolinomials(decimal[] firstPol, decimal[] secPol, decimal[] result)
        {
            //declare zeros at result polinom
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < firstPol.Length; i++)
            {
                for (int j = 0; j < secPol.Length; j++)
                {
                    int position = i + j;
                    result[position] += (firstPol[i] * secPol[j]);
                }
            }
        }

        //print polinomial
        static void PrintPolinomial(decimal[] poli)
        {
            for (int i = poli.Length - 1; i >= 0; i--)
            {
                if (poli[i] != 0 && i != 0)
                {
                    if (poli[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, poli[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, poli[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", poli[i]);
                }
            }

            Console.WriteLine();
        }

        static void Main()
        {
            //input data
            decimal[] firstPolinomial = { 5, -1 };
            Console.Write("First polinomial:\t\t\t");
            PrintPolinomial(firstPolinomial);

            decimal[] secondPolinomial = { 10, -5, 6 };
            Console.Write("Second polinomial:\t\t\t");
            PrintPolinomial(secondPolinomial);

            int maxLenght = 0;
            if (firstPolinomial.Length > secondPolinomial.Length)
            {
                maxLenght = firstPolinomial.Length;
            }
            else
            {
                maxLenght = secondPolinomial.Length;
            }

            decimal[] result = new decimal[maxLenght];
            Console.WriteLine();

            //sum the polinomials into result
            SumOfPolinomials(firstPolinomial, secondPolinomial, result);

            //print the sum
            Console.Write("Sum:\t\t\t\t\t");
            PrintPolinomial(result);

            //substract the polinomials into result
            SubstractionOfPolinomials(firstPolinomial, secondPolinomial, result);

            //print the substraction
            Console.Write("Substraction:\t\t\t\t");
            PrintPolinomial(result);

            decimal[] multiply = new decimal[firstPolinomial.Length + secondPolinomial.Length];

            //multiply the polinomials
            MultiplyPolinomials(firstPolinomial, secondPolinomial, multiply);

            //print multiplication
            Console.Write("Multiplication:\t\t\t\t");
            PrintPolinomial(multiply);
        }
    }
}