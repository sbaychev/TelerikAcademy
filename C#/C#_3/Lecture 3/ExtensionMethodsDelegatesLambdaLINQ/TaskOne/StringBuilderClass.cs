using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public static class StringBuilderClass
    {
        public static StringBuilder SubString(this StringBuilder inputString, int index, int length)
        {
            StringBuilder subString = new StringBuilder();

            if (index + length >= inputString.Length - 1 || index + length <= 0 )
            {
                throw new ArgumentOutOfRangeException("Invalid range");
            }

            int endIndex = index + length;

            for (int i = index; i < endIndex; i++)
            {
                subString.Append(inputString[i]);
            }
            return subString;
        }
    }
}