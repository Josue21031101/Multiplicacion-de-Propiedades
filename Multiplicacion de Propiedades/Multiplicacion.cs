using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_de_Propiedades
{
    internal class Multiplicacion
    {
        double v1, v2;

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }

        public double Multiplicar()
        {
            return V1 * V2;
        }

    }
}
