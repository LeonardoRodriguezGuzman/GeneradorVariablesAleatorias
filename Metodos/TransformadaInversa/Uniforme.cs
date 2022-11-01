using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.TransformadaInversa
{
    
    internal class Uniforme
    {

     
        public static double[] GenerarRi(int cantidad) {
            double[] Ri = new double[cantidad];
            for (int i = 0;i<cantidad;i++) { 
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
            return Ri;
        }


        public static double[] GenerarXi(int a, int b, int cantidad)
        {
            double[] Ri = GenerarRi(cantidad);
            double[] Xi = new double[cantidad];
            for (int i=0; i<cantidad; i++) {
                Xi[i] = a + (b - a) * Ri[i];
            }
            return Xi;
        }
    }
}
