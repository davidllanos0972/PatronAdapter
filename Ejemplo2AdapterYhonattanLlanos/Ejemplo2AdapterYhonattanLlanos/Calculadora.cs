using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2AdapterYhonattanLlanos
{
    class Calculadora : ICalculadora
    {
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
    }
}
