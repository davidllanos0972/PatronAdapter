using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterYhonattanLlanos
{
    class MotorGasolina : IMotor
    {
        public string Acelerar()
        {
            return "Acelerando motor Gasolina";
        }

        public  string Arrancar()
        {
            return "Arrancando el motor Gasolina";
        }

        public  string CargarCombustible()
        {
            return "Cargando Comnbustible al motor Gasolina";
        }

        public  string Detener()
        {
            return "Detenientdo Motor Gasolina";
        }
    }
}
