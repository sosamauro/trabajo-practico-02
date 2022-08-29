using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class PantallaPunto
    {
        public static void MostrarPantalla()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer punto");
            Console.Write("Coordenada en X: ");
            double x1 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese el segundo punto");
            Console.Write("Coordenada en X: ");
            double x2 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y2 = Double.Parse(Console.ReadLine());
          
            Console.WriteLine();
            Console.WriteLine("La distancia entre los dos puntos es: " + ControladorPunto.Distancia(x1,y1,x2,y2));
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
