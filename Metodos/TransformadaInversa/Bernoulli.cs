using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.TransformadaInversa
{
    internal class Bernoulli
    {
        
        public static double[] GenerarXi(int probabilidad, int cantidad)
        {
            double[] Ri = Uniforme.GenerarRi(cantidad);
            double[] Xi = new double[cantidad];
            double pX = 1 - probabilidad;
            for (int i = 0; i < cantidad; i++)
            {
                if (Ri[i]<=pX) {
                    Xi[i] = 0;
                }
                else { Xi[i] = 1; }

            }
            return Xi;
        }
        public static string[] Evento(int probabilidad, int cantidad) {
            string[] evento = new string[cantidad];
            double[] Xi = GenerarXi(probabilidad, cantidad);
            for (int i =0;i<cantidad; i++) {
                if (Xi[i] == 0)
                {
                    evento[i] = "No Falla";
                }
                else {
                    evento[i] = "Falla";
                }
            }
            return evento;
        }
    }
}
