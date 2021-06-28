using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2AdapterYhonattanLlanos
{
    class AdaptadorCalculadora : ICalculadora
    {
        CalculadoraArray adaptado = new CalculadoraArray();

        
        // aqui se realiza la adaptacion
        public int Sumar(int pA, int pB)
        {
            double r;
            // creamos el array que nesesita la clase que queremos adaptar
            int[] operadores = { pA, pB };
            // realizamos las operaciones en el adaptado
            r = adaptado.suma(operadores);
            // adaptamos el resultado
            return (int)r;//Para esto hacemos un Cast
        }
    }
}
