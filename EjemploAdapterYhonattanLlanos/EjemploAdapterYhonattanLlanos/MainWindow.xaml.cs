using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjemploAdapterYhonattanLlanos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMotor_Click(object sender, RoutedEventArgs e)
        {
            IMotor motor = new MotorDiesel();
            /*MotorGasolina motorGasolina = new MotorGasolina();
            MotorElectricoAdapter motorElectrico = new MotorElectricoAdapter();*/
            
            // Motor Diesel
            
            lstMostrar.Items.Add("Motor Diesel: " + "\n" +
                motor.Arrancar() + "\n" +
                motor.Acelerar() + "\n" +
                motor.Detener() + "\n" +
                motor.CargarCombustible() + "\n" );

            //Motor Gasolina
            motor = new MotorGasolina();
            lstMostrar.Items.Add("Motor Gasolina" + "\n" +
                motor.Arrancar() + "\n" +
                motor.Acelerar() + "\n" +
                motor.Detener() + "\n" +
                motor.CargarCombustible() + "\n" );

            //Motor Electrico
            motor = new MotorElectricoAdapter();
            lstMostrar.Items.Add("Motor Electrico" + "\n" +
                motor.Arrancar() + "\n" +
                motor.Acelerar() + "\n" +
                motor.Detener() + "\n" +
                motor.CargarCombustible());
            
        }
    }
}
