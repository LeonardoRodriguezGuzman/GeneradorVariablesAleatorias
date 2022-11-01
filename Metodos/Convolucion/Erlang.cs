using GeneradorVariablesAleatorias.Metodos.TransformadaInversa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.Convolucion
{
    internal class Erlang
    {
        public static double[] ri1(int cantidad) {
            return Uniforme.GenerarRi(cantidad);

        }
        public static double[] ri2(int cantidad) {
            return Uniforme.GenerarRi(cantidad);
        }
        public static double[] r1(int cantidad) {
            double[] r1=ri1(cantidad);
            double[] ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                ri[i] = 1 - r1[i];
            }
            return ri;
        }

        public static double[] r2(int cantidad)
        {
            double[] r1 = ri1(cantidad);
            double[] ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                ri[i] = 1 - r1[i];
            }
            return ri;
        }

        public static double[] tiempo(int media, int k, int cantidad) 
        {
            double[] tiempo = new double[cantidad];
            double[] ri1 = r1(cantidad);
            double[] ri2 = r2(cantidad);
            for (int i = 0; i<cantidad; i++)
            {
                tiempo[i] = (media / k) * Math.Log(ri1[i] * ri2[i]);
            }
            return tiempo;
        }
    }
}
