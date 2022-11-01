using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.TransformadaInversa
{
    internal class Poisson
    {
        public static double[] pX(int pieza, int cantidad)
        {
            double[] pX = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                pX[i] = (Math.Pow(pieza, i) * Math.Exp(pieza))/factorial(i);
            }
            return pX;
        }

        public static double[] PX(int pieza, int cantidad) {
            double[] PX = new double[cantidad];
            double[] px = pX(pieza, cantidad);
            PX[0] = px[0];
            for(int i = 1; i<cantidad; i++)
            {
                PX[i] = px[i] + px[i-1];
            }
            return PX;
        }
        public static double[,] desicion(int pieza,int cantidad) {
            double[,] desicion = new double[cantidad,2];
            double[] elPX = PX(pieza, cantidad);
            desicion[0,0] = 0;
            desicion[0, 1] = elPX[0];
            for (int i = 1;i<cantidad;i++) {
                desicion[i, 0] = desicion[i - 1, 1];
                desicion[i, 1] = elPX[i];
            }
            return desicion;
        }
        public static int factorial(int n) {
            if (n == 1) {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
