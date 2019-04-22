using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class RobotFibonacci : CalcularI
    {
        public int Calcular(int numero)
        {
            int fib0 = 0;
            int fib1 = 1;

            List<int> lista_fibonacci = new List<int>();
            lista_fibonacci.Add(fib0);
            lista_fibonacci.Add(fib1);

            if (numero == 0) {
                return lista_fibonacci[0];
            }
            else if (numero == 1) {
                return lista_fibonacci[1];
            }
            else {
                for (int i = 2; i <= numero; i+=1) {
                    lista_fibonacci.Add(lista_fibonacci[i - 1] + lista_fibonacci[i - 2]);
                }

                return lista_fibonacci[numero];

            }
        }

    }

}