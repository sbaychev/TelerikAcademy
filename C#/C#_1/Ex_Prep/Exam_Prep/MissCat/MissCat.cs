using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            /*There are two things that cats love most: 1) sleeping and 2) attending beauty contests. The most important thing 
             * for each female cat is the contest “Miss Cat”. There are always ten cats that participate in the final round of 
             * the contest, numbered 1 to 10. 
                The jury of the contest consists of N people who subjectively decide which cat to vote for. In other words each 
             * person votes for just 1 cat that he has most liked, or from whose owner he has received the biggest bribe. 
             * The winner of the contest is the cat that has gathered most votes. If two cats have equal votes, the winner of 
             * the contest is the one whose number is smaller.
                Your task is to write a computer program that finds the number of the cat that is going to win the contest“Miss cat”
                Input
                The input data is being read from the console.
                The number N is on the first input line.
                An integer between 1 and 10 is written on each of the next N lines (this is the number of the cat)
                The input data will always be valid and in the format described. There is no need to check it explicitly.
                Output
                The output data must be printed on the console.
                On the only output line you must print the number of the cat, which has won the contest. 
                Constraints
            •	The number N is a positive integer between 1 and 100 000, inclusive.
            •	The numbers of the cats for which the jury votes are positive integer numbers between 1 and 10, inclusive.*/

            int nVarC = int.Parse(Console.ReadLine());
            //massif is easier (cats[cat]++)  
            int[] cat = new int[nVarC];
            int cats = 0;
            for (int i = 0; i < nVarC; i++)
            {
                      cat [i] = int.Parse(Console.ReadLine());
                      //cats[cat]++;
            }
                Console.WriteLine();
                Console.WriteLine("{0}",cats);
        }
    }
}