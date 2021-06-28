using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterYhonattanLlanos
{
    public  interface IMotor
    {
        string Acelerar();
        string Arrancar();
        string Detener();
        string CargarCombustible();

    }
}
