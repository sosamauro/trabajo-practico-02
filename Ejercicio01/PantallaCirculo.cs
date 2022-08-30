using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal static class PantallaCirculo
    {
        public static void MostrarPantalla()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el centro del círculo");
            Console.Write("Coordenada en X: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese el radio del círculo: ");
            double r = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("El área del círculo es: " + ControladorCirculo.Area(x, y, r));
            Console.WriteLine("El perímetro del círculo es: " + ControladorCirculo.Perimetro(x, y, r));
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
