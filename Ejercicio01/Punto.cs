using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Punto
    {
        // Atributos
        private double _x, _y;

        // Constructor
        public Punto(double pX, double pY)
        {
            this._x = pX;
            this._y = pY;
        }

        // Propiedades
        public double X 
        {  
            get { return this._x; }
            set { this._x = value; }
        }
        public double Y 
        {  
            get { return this._y; }
            set { this._y = value; }
        }

        //Método
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            // Para calcular la distancia entre P1(X1;X2) y P2(X2;Y2) se utiliza:
            // Sqrt( (X2-X1)^2 + (Y2-Y1)^2 )
            return Math.Sqrt(Math.Pow((this._x - pPunto.X), 2) + Math.Pow((this._y - pPunto.Y), 2));
        }

    }
}
