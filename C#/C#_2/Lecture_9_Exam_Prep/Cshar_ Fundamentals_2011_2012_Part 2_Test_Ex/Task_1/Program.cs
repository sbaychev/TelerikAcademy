using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_content
            //In modern molecular biology and genetics, the genome is the entirety of an organism's hereditary information. 
//A genome sequence is a combination of the 4 Latin letters A, G, T and C.
//An encoded genome is a genome sequence where all sub-sequences of same consecutive letters (with length at least 2) 
//are replaced with the length of the sub-sequence followed by the letter that is repeating. For example the genome sequence “AAGGGCTTT” will be 
//encoded as “2A3GC3T”. The decoded genome is the original genome that is used for generating the encoded genome. In the given example the encoded 
//genome is 2A3GC3T and the decoded genome is AAGGGCTTT.
//You will be given an encoded genome and your task is to decode it and then output it in a special format. You should output only N letters per line. 
//On each line every M letters must be separated by a single space. At the start of each line you should print the line number (starting from 1) 
//followed by a space. The line numbers should be aligned to the right using empty spaces (as shown in the second example). The last output line should 
//not contain any spaces at the beginning nor the ending of the line.
            //N will be an integer number between 1 and 1000, inclusive.
            // M will be an integer between 1 and 1000, inclusive. M will be always lower than or equal to N.
            // The encoded genome will contain only digits and the capital Latin letters ‘A’, ‘C’, ‘G’ and ‘T’.
            // The length of the decoded genome will be between 1 and 100 000, inclusive.
            // Allowed working time for your program: 0.15 seconds. Allowed memory: 16 MB
            #endregion
            string nAndM = Console.ReadLine();
            string[] nAndMParts = nAndM.Split(new string[] { " " }, StringSplitOptions.None);
            int n = int.Parse(nAndMParts[0]);
            int m = int.Parse(nAndMParts[1]);
            string genome = Console.ReadLine();
            List<string> genomeCode = new List<string>();           
            StringBuilder sb = new StringBuilder();
            int inPair = 0;
            #region logic
            for (int i = 0; i < genome.Length; i++)
            {
                if (char.IsDigit(genome[i]))
                {
                    sb.Append(genome[i]);
                    inPair = 1;
                }
                else if (char.IsLetter(genome[i]))
                {
                    if (inPair == 1)
                    {
                        sb.Append(genome[i]);
                        genomeCode.Add(TimesLetter(sb.ToString()));
                        sb.Clear();
                        inPair = 0;
                    }
                    else if (i > 0 && char.IsLetter(genome[i - 1]))
                    {
                        sb.Append(genome[i]);
                        genomeCode.Add(sb.ToString());
                        sb.Clear();
                    }
                }
            }
            #endregion logic

            sb.Clear();
            for (int i = 0; i < genomeCode.Count; i++)
            {
                sb.Append(genomeCode[i]);
            }
                     
            int maxRowNumber = (int)Math.Ceiling((decimal)sb.Length / (decimal)n);
            int padSize = maxRowNumber.ToString().Length;
            for (int i = 1; i <= maxRowNumber; i++)
            {
                StringBuilder line = new StringBuilder();
                line.Append(new string(' ', padSize - i.ToString().Length));
                line.Append(i);
                for (int j = (i - 1) * n; j <= i * n - 1; j++)
                {
                    if ((j - (i - 1) * n) % m == 0) line.Append(' ');
                    if (j >= sb.Length) break;
                    line.Append(sb[j]);
                }
                Console.WriteLine(line.ToString());
             }
        }
        static string TimesLetter(string pair)
        {
            char letter = '\0';
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < pair.Length; i++)
            {
                if (char.IsDigit(pair[i]))
                {
                    b.Append(pair[i]);
                }
                else
                {
                    letter = pair[i];
                }
            }
            int times = int.Parse(b.ToString());
            b.Clear();
            for (int i = 0; i < times; i++)
            {
                b.Append(letter);
            }
            return b.ToString();
        }
    }
}