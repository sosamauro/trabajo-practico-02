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
            Console.Clear();
            Console.WriteLine("Ingrese el centro del circulo");
            Console.Write("Coordenada en X: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el radio del circulo: ");
            double r = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Area: " + ControladorCirculo.Area(x, y, r));
            Console.WriteLine("Perimetro: " + ControladorCirculo.Perimetro(x, y, r));
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
