using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Execution
{
    public static void Main()
    {
        Matrix<int> matrixTestOne = new Matrix<int>(5, 5);
        Matrix<int> matrixTestTwo = new Matrix<int>(5, 5);
        Console.WriteLine(matrixTestOne.Cols);

        matrixTestOne[0, 0] = 100;
        matrixTestTwo[0, 0] = 2;
        Console.WriteLine(matrixTestOne + matrixTestTwo);
    }
}
