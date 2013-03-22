using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntNBitVAtPModBitAtP
{
    class IntNBitVAtPModBitAtP
    {
        static void Main(string[] args)
        {
            /*We are given integer number n, value v (v= 0 or 1) and a position p. Write a sequence of operators that modifies n 
             * to hold the value v at the position p from the binary representation of n. 
             * Example: n = 5 (00000101), p=3, v=1  13 (00001101) n = 5 (00000101), p=2, v=0  1 (00000001)*/
            Console.Write("n = ");
            string consN = Console.ReadLine();
            int intN = int.Parse(consN);
            Console.Write("p = ");
            string consP = Console.ReadLine();
            int posP = int.Parse(consP);
            Console.Write("v = ");
            string consV = Console.ReadLine();
            int valV = int.Parse(consV);
            if (valV == 1)
            {
                int mask = 1 << posP;
                int result = intN | mask;
                Console.WriteLine(result);  
            }
            else
            {
                int mask = ~(1 << posP);
                int result = intN & mask;     
                Console.WriteLine(result);  
            }
        }
    }
}