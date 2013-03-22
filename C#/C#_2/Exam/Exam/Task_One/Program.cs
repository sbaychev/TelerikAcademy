using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
        {
        string aph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        aph.ToLower();
        char[] alpha = aph.ToCharArray();
            string cons = Console.ReadLine();
            for (int i = cons.Length - 1; i > 0; i--)
            {
                if (cons.Length == 1)
                {
                    var temp = Encoding.ASCII.GetBytes(cons);
                    foreach (byte element in temp)
                        Console.WriteLine(element - 65);
                }
                else if (cons.Length == 2)
                {      
                    int n = 2;
                    int sum = 0;
                    while (n != 0)
                    {
                        if (cons[n - 1].ToString() != cons[n - 1].ToString().ToUpper())
                        {
                            var temp = Encoding.ASCII.GetBytes(cons[n - 1].ToString());
                            sum += int.Parse(temp[i-1].ToString()) - 71;
                        }
                        else
                        {
                            int index1 = Array.IndexOf(alpha, cons[n - 1]) + 1;
                            sum += 26 * index1;
                        }
                        n--;
                    }
                    Console.WriteLine(sum);         
               }
          }
    }
 }