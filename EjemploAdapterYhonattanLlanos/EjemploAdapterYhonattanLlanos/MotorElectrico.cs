using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapterYhonattanLlanos
{
    class MotorElectrico
    {
        bool conectado;
        bool activo;
        bool moviendo;


        public string Conectar()
        {
            if (conectado)
                return "El motor ya esta conectado!";

            else
            {
                conectado = true;
                return "Motor Conectado con Exito";
            }
        }

        public string Activar()
        {

            if (!conectado)
                return "No es posible activar a un motor no conectado";

            else
            {
                activo = true;
                return "Motor Activado";

            }

        }

        public string Mover()
        {
            if (conectado && activo)
            {
                moviendo = true;
                return "Moviendo El motor Electrico";

            }
            else
            {
                return "El Motor Debera estar Conectado y Activo";
            }

        }

        public string Parar()
        {

            if (moviendo)
            {
                moviendo = false;
                return "Parando el motor Electrico";
            }
            else
            {
                return "El motor ya esta parado";
            }

        }

        public string Desconectar()
        {
            if (conectado)
            {
                return "Motor Electrico Desconectado";
                //Console.WriteLine("Motor desconectado...");
            }
            else
            {
                return "No puedes desconectar el motor electrico porque no esta conectado";
                //Console.WriteLine("Imposible desconectar un motor que no esté conectado!");
            }

        }

        public string Desactivar()
        {
            if (activo)
            {
                activo = false;
                return "Motor Electrico Desactivado";
               // Console.WriteLine("Motor desactivado...");
            }
            else
            {
                return "No puedes desactivar un motor inactivo";
                //Console.WriteLine("Imposible desactivar un motor que no esté activo!");
            }
        }

        public string Enchufar()
        {
            if (!activo)
            {
                
                activo = false;
                return "Motor Electrico enchufado y cargando";
                //Console.WriteLine("Motor cargando las baterias!...");
            }
            else
            {
                return "No es posible enchufar y cargar un motor electrico";
                //Console.WriteLine("Imposible enchufar un motor activo!");
            }

        }
    }
}
