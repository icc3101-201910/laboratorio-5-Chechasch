using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Cubo:CalcularI
    {
        public int Calcular(int numero)
        {

            int cubo = numero * numero * numero;
            return cubo;
        }

    }
}
