using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ControladorCirculo
    {
        public static double Area(double x, double y, double r)
        {
            Circulo circulo = new Circulo(x, y, r);

            return Math.Round(circulo.Area, 2);
        }

        public static double Perimetro(double x, double y, double r)
        {
            Circulo circulo = new Circulo(x, y, r);

            return Math.Round(circulo.Perimetro, 2);
        }
    }
}
