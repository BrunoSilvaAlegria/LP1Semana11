using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T g1;
        private T g2;
        private T g3;

        public Guarda3()
        {
            //Inicialização de valores por omissão
            g1 = default(T);
            g2 = default(T);
            g3 = default(T);
        }
        
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0: return g1;
                case 1: return g2;
                case 2: return g3;
                default: throw new IndexOutOfRangeException();                
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0: g1 = item;
                    break;
                case 1: g2 = item;
                    break;
                case 2: g3 = item;
                    break;
                default: throw new IndexOutOfRangeException();                
            }
        }
    }
}