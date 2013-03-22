using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequencePlusMinus
{
    class SequencePlusMinus
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i < 12; i++)
            {
                count++;
                if ((i % 2) == 0/2)
                {
                    Console.WriteLine("{0}. {1}", count,i);
                }
                else
                {
                    Console.WriteLine("{0}. -{1}", count, i);
                }
                
            }
        }
    }
}
