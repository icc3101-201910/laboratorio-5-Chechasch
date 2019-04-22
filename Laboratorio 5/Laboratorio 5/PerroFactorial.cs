using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class PerroFactorial : CalcularI
    {
        public int calcular(int numero)
        {
            int num_fact = 1;
            int num = 1;

            while (num<=12) {
                num_fact = num_fact * num;
                num += 1;

            }
            return num_fact;
        }
    }
}
