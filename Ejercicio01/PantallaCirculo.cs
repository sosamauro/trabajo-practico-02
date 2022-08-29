using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class PantallaCirculo
    {
        public static void MostrarPantalla()
        {
            double x, y, r;

            Console.Clear();
            Console.WriteLine("Ingrese el centro del circulo");
            Console.Write("Coordenada en X: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            y = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el radio del circulo");
            r = Double.Parse(Console.ReadLine());

            var punto = new Punto(x, y);
            var circulo = new Circulo(punto, r);

            Console.WriteLine();
            Console.WriteLine("Area: " + circulo.Area);
            Console.WriteLine("Perimetro: " + circulo.Perimetro);
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
