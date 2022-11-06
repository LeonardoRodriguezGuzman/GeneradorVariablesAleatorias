using System;
using GeneradorVariablesAleatorias.Metodos.Convolucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesAleatorias.Metodos.Convolucion.binomial
{
    internal class Binomial
    {
        private int cantidad;
        private double[] Ri;
        private int[] B1;
        private string[] desision;
        private double defectuoso;
        private int[] pieza;

        public Binomial(double defectuoso, int cantidad, int[] pieza)
        {
            setCantidad(cantidad);
            setRi(cantidad);
            setDefectuso(defectuoso);
            setPieza(pieza);
            B1 = getB1();
            setDesision();
            
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setRi(int cantidad) {
            Ri = GenerarRi(cantidad);
        }

        public void setDefectuso(double defectuoso) {
            this.defectuoso=defectuoso;
        }
        public void setPieza(int[] pieza)
        {
            this.pieza = pieza;
        }

        public double[] GenerarRi(int cantidad)
        {
            double[] Ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
            return Ri;
        }

        public static int[] B1()
        {
            double x = 1 - defectuoso;
            B1 = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                double a = Ri[i];
                if (a <= x)
                {
                    B1[i] = 0;
                }
                else
                {
                    B1[i] = 1;
                }
            }
            return B1;
        }

        public  void setDesision()
        {
            desision = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                if (pieza[i] == 0)
                {
                    desision[i] = "No falla";
                }
                else
                {
                    desision = "Falla";
                }
            }
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public double getDefectuoso()
        {
            return defectuoso;
        }

        public int[] getPieza()
        {
            return pieza;
        }
        public double[] getRi()
        {
            return Ri;
        }

        public int[] getB1()
        {
            return B1;
        }

        public string[] getDesision()
        {
            return desision;
        }

    }
}