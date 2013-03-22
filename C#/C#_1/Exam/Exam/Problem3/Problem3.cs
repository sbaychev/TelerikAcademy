using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            string cardOne = Console.ReadLine();
            string cardTwo = Console.ReadLine();
            string cardThree = Console.ReadLine();
            string cardFour = Console.ReadLine();
            string cardFive = Console.ReadLine();

            char one = cardOne[0];
            char two = cardTwo[0];
            char three = cardThree[0];
            char four = cardFour[0];
            char five = cardFive[0];

            int oneC = one - '0';
            int twoC = two - '0';
            int threeC = three - '0';
            int fourC = four - '0';
            int fiveC = five- '0';

            if (oneC == 17 || twoC == 17 || threeC == 17 || fourC == 17 || fiveC == 17)
            {
                if (oneC == 17) oneC = 14;
                if (twoC == 17) twoC = 14;
                if (threeC == 17) threeC = 14;
                if (fourC == 17) fourC = 14;
                if (fiveC == 17) fiveC = 14;
            }

            else if (oneC == 26 || twoC == 26 || threeC == 26 || fourC == 26 || fiveC == 26)
            {
                if (oneC == 26) oneC = 11;
                if (twoC == 26) twoC = 11;
                if (threeC == 26) threeC = 11;
                if (fourC == 26) fourC = 11;
                if (fiveC == 26) fiveC = 11;
            }
            else if (oneC == 26 || twoC == 26 || threeC == 26 || fourC == 26 || fiveC == 26)
            {
                if (oneC == 33) oneC = 12;
                if (twoC == 33) twoC = 12;
                if (threeC == 33) threeC = 12;
                if (fourC == 33) fourC = 12;
                if (fiveC == 33) fiveC = 12;
            }
            else if (oneC == 27 || twoC == 27 || threeC == 27 || fourC == 27 || fiveC == 27)
            {
                if (oneC == 27) oneC = 13;
                if (twoC == 27) twoC = 13;
                if (threeC == 27) threeC = 13;
                if (fourC == 27) fourC = 13;
                if (fiveC == 27) fiveC = 13;
            }

            if (cardOne == cardTwo && cardTwo == cardThree && cardThree == cardFour && cardFour == cardFive)
            {
                Console.WriteLine("Impossible");
            }
            else if ((cardOne == cardTwo && cardTwo == cardThree && cardThree == cardFour) || (cardTwo == cardThree && cardThree == cardFour && cardFour == cardFive) ||
            (cardOne == cardTwo && cardFour == cardFive && cardTwo == cardFour) || (cardOne == cardThree && cardThree == cardFour && cardFour == cardFive) || (cardOne == cardTwo && cardTwo == cardThree && cardThree == cardFive))
            {
                Console.WriteLine("Four of a Kind");
            }
            else if ((cardOne == cardTwo && cardTwo == cardThree && cardFour == cardFive) || (cardOne == cardTwo && cardThree == cardFour && cardFour == cardFive) || (cardOne == cardTwo && cardTwo == cardFive && cardThree == cardFour) ||
                (cardOne == cardFour && cardFour == cardFive && cardTwo == cardThree) || (cardOne == cardThree && cardThree == cardFive && cardTwo == cardFour) || (cardOne == cardThree && cardTwo == cardFour && cardFour == cardFive) || (cardOne == cardFour && cardTwo == cardThree && cardThree == cardFive)
                || (cardOne == cardThree && cardThree == cardFour && cardTwo == cardFive) || (cardTwo == cardFour && cardFour == cardFive && cardOne == cardThree) || (cardTwo == cardThree && cardThree == cardFour && cardFive == cardOne) || (cardOne == cardTwo && cardTwo == cardFour && cardThree == cardFive)
                || (cardTwo == cardThree && cardThree == cardFive && cardOne == cardFour))
            {
                Console.WriteLine("Full House");
            }
            else if (oneC == (twoC - 1) && twoC == (threeC - 1) && threeC == (fourC - 1) && fourC == (fiveC - 1))
            {
                Console.WriteLine("Straight");
            }
            else if ((cardOne == cardTwo && cardTwo == cardThree) || (cardTwo == cardThree && cardThree == cardFour) || (cardThree == cardFour && cardFour == cardFive) || (cardFour == cardFive && cardFour == cardOne) || (cardFour == cardOne && cardThree == cardFour)
            || (cardOne == cardThree && cardThree == cardFive) || (cardTwo == cardFour && cardFour == cardFive) || (cardOne == cardTwo && cardTwo == cardFour) || (cardTwo == cardThree && cardThree == cardFive)
                || (cardOne == cardTwo && cardTwo == cardFive) || (cardThree == cardFour && cardFour == cardOne))
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (((oneC ^ twoC ^ threeC ^ fourC ^ fiveC) == oneC) || ((oneC ^ twoC ^ threeC ^ fourC ^ fiveC) == twoC) || ((oneC ^ twoC ^ threeC ^ fourC ^ fiveC) == threeC) || ((oneC ^ twoC ^ threeC ^ fourC ^ fiveC) == fourC) || ((oneC ^ twoC ^ threeC ^ fourC ^ fiveC) == fiveC))
            {
                Console.WriteLine("Two Pairs");
            }
            else if ((cardOne == cardTwo) || (cardTwo == cardThree) || (cardThree == cardFour) || (cardFour == cardFive) || (cardOne == cardThree) || (cardOne == cardFour) || (cardOne == cardFive) || (cardTwo == cardFour) || (cardTwo == cardFive) || (cardThree == cardFive))
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}