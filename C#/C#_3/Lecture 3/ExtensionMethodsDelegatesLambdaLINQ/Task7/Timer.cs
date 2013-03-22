using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public delegate void Ticks(int start);
    class Timer
    {
        public int Numbs { get; set; }

        public void Ticksing(int start)
        {
            Console.WriteLine(this.Numbs);
            this.Numbs++; 
        }
    }
}