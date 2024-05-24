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
        
    }
}