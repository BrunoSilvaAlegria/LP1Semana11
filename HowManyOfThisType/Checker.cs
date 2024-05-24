using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        //Returns number of items in an enumerable that are of a specific type
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int count = 0;
            foreach (object item in items)
            {
                if (item is T) count++;
            }
            return count;
        }
    }
}