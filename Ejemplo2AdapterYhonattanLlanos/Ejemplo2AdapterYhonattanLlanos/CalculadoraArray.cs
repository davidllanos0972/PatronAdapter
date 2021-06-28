using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2AdapterYhonattanLlanos
{
    class CalculadoraArray
    {
        public double suma(int[] Operandos)
        {
            int n = 0;
            int r = 0;
            for (int i = 0; i < Operandos.Length; i++)
            {
                r += Operandos[i];
                
            }
            return r;
        }
    }
}
