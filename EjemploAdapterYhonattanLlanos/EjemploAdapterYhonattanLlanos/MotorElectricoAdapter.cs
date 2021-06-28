using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterYhonattanLlanos
{
    class MotorElectricoAdapter : IMotor
    {
        MotorElectrico motorElectrico = new MotorElectrico();

        public string Acelerar()
        {
            return motorElectrico.Mover();
        }

        public string Arrancar()
        {
           return motorElectrico.Conectar()+"\n"+motorElectrico.Activar();

        }

        public string CargarCombustible()
        {
            return motorElectrico.Enchufar();
        }

        public string Detener()
        {
           return motorElectrico.Parar() +"\n"+ motorElectrico.Desactivar();
        }
    }
}
