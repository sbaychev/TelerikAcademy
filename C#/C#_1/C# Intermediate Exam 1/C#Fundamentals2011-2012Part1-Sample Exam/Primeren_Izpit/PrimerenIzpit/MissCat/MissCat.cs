using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissCat
{
    class MissCat
    {
        //The jury of the contest consists of N people who subjectively decide which cat to vote for. In other words each person 
        //votes for just 1 cat that he has most liked, or from whose owner he has received the biggest bribe. The winner of the 
        //contest is the cat that has gathered most votes. If two cats have equal votes, the winner of the contest is the one whose 
        //number is smaller.
        //Your task is to write a computer program that finds the number of the cat that is going to win the contest “Miss cat”
        //Input
        //The input data is being read from the console.
        //The number N is on the first input line.
        //An integer between 1 and 10 is written on each of the next N lines (this is the number of the cat)
        //The input data will always be valid and in the format described. There is no need to check it explicitly.
        //Output
        //The output data must be printed on the console.
        //On the only output line you must print the number of the cat, which has won the contest. 
        //Constraints
        //•	The number N is a positive integer between 1 and 100 000, inclusive.
        //•	The numbers of the cats for which the jury votes are positive integer numbers between 1 and 10, inclusive.
        //•	Allowed working time for your program: 0.25 second.
        //•	Allowed memory: 16 MB.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            int winnerCatNumVot = 0;
            int winnerCat = 0;
            for (int i = 0; i < n; i++)
            {
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        cat[1]++;
                        break;
                    case 2:
                        cat[2]++;
                        break;
                    case 3:
                        cat[3]++;
                        break;
                    case 4:
                        cat[4]++;
                        break;
                    case 5:
                        cat[5]++;
                        break;
                    case 6:
                        cat[6]++;
                        break;
                    case 7:
                        cat[7]++;
                        break;
                    case 8:
                        cat[8]++;
                        break;
                    case 9:
                        cat[9]++;
                        break;
                    case 10:
                        cat[10]++;
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (winnerCatNumVot < cat[i])
                {
                    winnerCatNumVot = cat[i];
                    winnerCat = i;
                }
            }
            Console.WriteLine(winnerCat);   
        }
    }
}