using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Cuadrado : CalcularI
    {
        public int Calcular(int numero)
        {

            int cuadrado = numero *numero;
            return cuadrado;
        }

    }
}
