using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Two
{
    class Task_Two
    {
        static void Main(string[] args)
        {
            int[] sudoku = new int[9];
            int temp = 0;
            for (int j = 1; j <= 9; j++)
            {
                bool res = int.TryParse(Console.ReadLine(), out sudoku[j]);
                if (res == false)
                {
                    sudoku[j] = 0;
                }
            }
        }
    }
}