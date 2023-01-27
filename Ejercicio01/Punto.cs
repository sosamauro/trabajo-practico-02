using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Punto
    {
        // Atributos
        private double iX, iY;

        // Constructor
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        // Propiedades
        public double X 
        {  
            get { return this.iX; }
            set { this.iX = value; }
        }
        public double Y 
        {  
            get { return this.iY; }
            set { this.iY = value; }
        }

        //Método
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            // Para calcular la distancia entre P1(X1;X2) y P2(X2;Y2) se utiliza:
            // Sqrt( (X2-X1)^2 + (Y2-Y1)^2 )
            return Math.Sqrt(Math.Pow((this.iX - pPunto.X), 2) + Math.Pow((this.iY - pPunto.Y), 2));
        }

    }
}
