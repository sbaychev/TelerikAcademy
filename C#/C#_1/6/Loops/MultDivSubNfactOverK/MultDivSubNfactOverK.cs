using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultDivSubNfactOverK
{
    class MultDivSubNfactOverK
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            Console.Write("N= ");
            ulong varN = ulong.Parse(Console.ReadLine());
            ulong factN = 1; //where the factorial of N is stored
            Console.Write("K= ");
            ulong varK = ulong.Parse(Console.ReadLine());
            ulong factK = 1; //where the factorial of K is stored
            ulong kMinusN = varK - varN;
            ulong factKminusN = 1;

            for (ulong i = 1; i <= varN; i++)
            {
                factN = factN * i;
            }
            for (ulong i = 1; i <= varK; i++)
            {
                factK = factK * i;
            }
            for (ulong i = 1; i <= kMinusN; i++)
            {
                factKminusN = factKminusN * i;
            }
            ulong factNdivK = (factN * factK)/factKminusN;

            Console.WriteLine("\n{0}\n", factNdivK);
        }
    }
}