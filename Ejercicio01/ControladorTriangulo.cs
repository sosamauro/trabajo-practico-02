using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ControladorTriangulo
    {
        public static double Area(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto punto1 = new Punto(x1, y1);
            Punto punto2 = new Punto(x2, y2);
            Punto punto3 = new Punto(x3, y3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            return Math.Round(triangulo.Area, 2);
        }

        public static double Perimetro(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto punto1 = new Punto(x1, y1);
            Punto punto2 = new Punto(x2, y2);
            Punto punto3 = new Punto(x3, y3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            return Math.Round(triangulo.Perimetro, 2);
        }
    }
}
