using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.TransformadaInversa
{
    internal class Exponencial
    {

        public static double[] GenerarXi(int media, int cantidad) {
            double[] Ri= Uniforme.GenerarRi(cantidad);
            double[] Xi = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Xi[i] = -media * Math.Log(1 - Ri[i]);
            }
             return Xi;
        }
    }
}
