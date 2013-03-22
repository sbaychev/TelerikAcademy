using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using delegates write a class Timer that has can execute certain method at each t seconds.

            Timer objct = new Timer();
            Ticks timer = new Ticks(objct.Ticksing);//the delegate calls the method

            while (true)
            {
                Thread.Sleep(60);//every 60 ms a number is printed
                timer(10);
            }
        }
    }
}