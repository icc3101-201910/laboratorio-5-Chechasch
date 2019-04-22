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

namespace Laboratorio_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int i = 1;
            Random random = new Random();
            int valori = random.Next(0,5);
            int valor = Convert.ToInt32(valori);
            int numop = random.Next(0, 5);
            int numopi = Convert.ToInt32(numop);
            Calculadora calculadora = new Calculadora(valor);
            calculadora.calculadoras.Add(new Cuadrado());
            calculadora.calculadoras.Add(new Cubo());
            calculadora.calculadoras.Add(new PerroFactorial());
            calculadora.calculadoras.Add(new PersonaQueSuma5);
            calculadora.calculadoras.Add(new RobotFibonacci());


            while (i <= numopi) {

                var operacion = Console.ReadLine();
                int operacion1 = Convert.ToInt32(operacion);
                calculadora.Calcular(operacion1);
                i += 1;

            }
        }
    }
}
