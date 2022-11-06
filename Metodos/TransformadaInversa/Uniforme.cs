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

        private int cantidad;
        private double[] Ri;
        private double[] Xi;
        private int a;
        private int b;

        public Uniforme(int cantidad, int a, int b) {
            setCantidad(cantidad);
            setRi(cantidad);
            setA(a);
            setB(b);
        }

        public void setCantidad(int cantidad) {
            this.cantidad = cantidad;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public void setB(int b)
        {
            this.b = b;
        }
        

        public void setRi(int cantidad)
        {
            Ri = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Ri[i] = Math.Round((new Random()).NextDouble(), 4);
            }
        }

        public  void setXi()
        {   
            Xi = new double[cantidad];
            for (int i=0; i<cantidad; i++) {
                Xi[i] = a + (b - a) * Ri[i];
            }
        }


        public int getCantidad() { return cantidad; }
        public int getA() { return a; }
        public int getB() { return b; }
        public int getRi() { return Ri; }
        public int getXi() { return Xi; }

    }
}
