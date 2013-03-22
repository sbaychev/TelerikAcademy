using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Program
    {
        //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
        //and has the same functionality as Substring in the class String.

        static void Main(string[] args)
        {
            StringBuilder testing = new StringBuilder();
            testing.AppendLine("Some text"); // the bellow values are hardcoded for the examplary function of the task
            Console.WriteLine(testing.SubString(2, 2).ToString());   //takes an index and from it with the specified length returns 
                                                                    //a stringBuilder value of the one that was passed
        }
    }
}