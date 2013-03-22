using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentTime
{
    class CurrentTime
    {
        static void Main(string[] args)
        {
            String a = DateTime.Now.ToString();
            Console.WriteLine("{0}", a);
        }
    }
}
