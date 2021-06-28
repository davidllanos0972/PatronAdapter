using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterYhonattanLlanos
{
    class MotorDiesel : IMotor
    {
        public  string Acelerar()
        {
            return "Acelerando motor Diesel";
        }

        public  string Arrancar()
        {
            return "Arrancando el motor Diesel";
        }

        public string CargarCombustible()
        {
            return "Cargando Comnbustible al motor diesel";
        }

        public  string Detener()
        {
            return "Detenientdo Motor Diesel";
        }
    }
}
