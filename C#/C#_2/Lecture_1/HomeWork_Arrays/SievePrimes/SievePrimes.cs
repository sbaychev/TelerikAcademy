using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SievePrimes
{
    class SievePrimes
    {
        static void Main(string[] args)
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. 
            //Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
            int maxprime = int.Parse(Console.ReadLine());
            ArrayList primelist = sieve(maxprime);

            foreach (int prime in primelist)
            {
                Console.WriteLine(prime);
            }
            Console.WriteLine("Number of Prime integers in the range [1...{1}] = {0}", primelist.Count, maxprime);
        }
        static ArrayList sieve(int arg_max_prime)
        {
            BitArray al = new BitArray(arg_max_prime, true);

            int lastprime = 1;
            int lastprimeSquare = 1;

            while (lastprimeSquare <= arg_max_prime)
            {
                lastprime++;

                while (!(bool)al[lastprime])//checking the Bitarray, so that we can make sure that we are moving ahead
                {                           //to remove below (by making them false) all squares of prime numbers in the 
                    lastprime++;            //arg_max_prime domain
                }
                lastprimeSquare = lastprime * lastprime;

                for (int i = lastprimeSquare; i < arg_max_prime; i += lastprime)//here we go about removing (making false)                   
                {                                                               //all multiples and squares of a prime number
                    if (i > 0)
                    {
                        al[i] = false;
                    }
                }
            }
            ArrayList sieve_2_return = new ArrayList();

            for (int i = 2; i < arg_max_prime; i++)
            {
                if (al[i])//adding all prime - true values to the ArrayList
                {
                    sieve_2_return.Add(i);
                }
            }
            return sieve_2_return;
        }
    }
}