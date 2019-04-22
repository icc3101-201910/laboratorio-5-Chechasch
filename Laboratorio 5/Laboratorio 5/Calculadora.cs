using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Calculadora
    {


        private int numero;
        public List<CalcularI> calculadoras;
        Random randint = new Random();

        public Calculadora(int valor) {

            this.numero = valor;
            calculadoras = new List<CalcularI>();

        }

        public void Calcular(int elegido) {

            CalcularI c = calculadoras[elegido];
            numero = c.Calcular(numero);
            Console.WriteLine("El numero es " + numero);

        }

    }
}
