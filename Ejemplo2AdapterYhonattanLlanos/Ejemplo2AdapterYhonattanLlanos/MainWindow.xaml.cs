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

namespace Ejemplo2AdapterYhonattanLlanos
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

        private void btnCalculadora_Click(object sender, RoutedEventArgs e)
        {
            int resultado;
            ICalculadora calculadora = new Calculadora();
            resultado = calculadora.Sumar(4, 3);
            lstMostrar.Items.Add("El resultado es: " + resultado);

            //Haciendo Uso del Adaptador
            calculadora = new AdaptadorCalculadora();
            resultado = calculadora.Sumar(5, 6);
            lstMostrar.Items.Add("El resultado es: " + resultado);

        }
    }
}
