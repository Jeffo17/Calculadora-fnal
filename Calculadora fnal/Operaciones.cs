using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_fnal
{
    class Operaciones
    {
        public int suma(string[] num)
        {
                                      
              int adicion = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != "")
                    adicion = adicion + Convert.ToInt32(num[i]);

            }
            return adicion;
        }

        public int resta(string[] num)
        {

            int Sustraccion = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != "")
                    Sustraccion = Sustraccion - Convert.ToInt32(num[i]);

            }
            return Sustraccion;

        }

        public int Multiplicacion(string[] num)
        {

            int multiplicacion = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != "")
                    multiplicacion= multiplicacion * Convert.ToInt32(num[i]);

            }
            return multiplicacion;

        }

        public int Division(string[] num)
        {

            int division = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != "")
                    division = division * Convert.ToInt32(num[i]);

            }
            return division;
        }


     }

}