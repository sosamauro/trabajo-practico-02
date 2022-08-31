using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal static class ControladorPunto
    {
        public static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            Punto punto1 = new Punto(x1, y1);
            Punto punto2 = new Punto(x2, y2);

            return Math.Round(punto2.CalcularDistanciaDesde(punto1), 2);
        }
    }
}
