using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Triangulo
    {
        private Punto iPunto1, iPunto2, iPunto3;

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        public double Area
        {
            // Se utiliza la fórmula de Herón:
            // P = Perimetro
            // L = Lado
            // Math.Sqrt( P/2 * (P/2 - L1) * (P/2 - L2) * (P/2 - L3) )

            get { return Math.Sqrt( (Perimetro / 2) * ((Perimetro / 2) - iPunto1.CalcularDistanciaDesde(iPunto2)) * ((Perimetro / 2) - iPunto1.CalcularDistanciaDesde(iPunto3)) * ((Perimetro / 2) - iPunto2.CalcularDistanciaDesde(iPunto3))); }
        }

        public double Perimetro
        {
            get { return iPunto1.CalcularDistanciaDesde(iPunto2) + iPunto1.CalcularDistanciaDesde(iPunto3) + iPunto2.CalcularDistanciaDesde(iPunto3); }
        }

    }
}
