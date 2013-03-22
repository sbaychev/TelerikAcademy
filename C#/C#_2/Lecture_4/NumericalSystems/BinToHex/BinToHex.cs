using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine( BinaryStringToHexString(Console.ReadLine()) );
            
        }
        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            int modForLen = binary.Length % 8;
            if (modForLen != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X}", Convert.ToByte(eightBits, 2));
            }
            return result.ToString();
        }
    }
}