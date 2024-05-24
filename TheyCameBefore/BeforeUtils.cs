using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> itens, 
        T item) where T : IComparable<T>
        {
            return itens.Where(i => i.CompareTo(item) < 0);
        } 
    }
}