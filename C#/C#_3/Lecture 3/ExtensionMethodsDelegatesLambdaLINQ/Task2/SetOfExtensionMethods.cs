using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class SetOfExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> something) where T : IComparable
        {
            dynamic sum = 0;//dynamic because we do not know what we are going to hold, dynamic holds it all
                            //the same goes for the other methods that follow

            foreach (var item in something)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> something) where T : IComparable
        {
            dynamic product = 1;

            foreach (var item in something)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> something) where T : IComparable
        {
            dynamic min = int.MaxValue;

            foreach (var item in something)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> something) where T : IComparable
        {
            dynamic max = int.MinValue;

            foreach (var item in something)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> something) where T : IComparable
        {
            dynamic sum = 0;
            int counter = 0;

            foreach (var item in something)
            {
                sum += item;
                counter++;
            }

            return sum / counter;
        }
    }
}