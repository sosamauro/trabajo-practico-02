using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Pantallas
{
    public static class PantallaCantidadFallos
    {
        public static int MostrarPantalla()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de fallos permitidos.");
            Console.WriteLine("Presione ENTER para dejar el valor por defecto (10).");
            Console.WriteLine();
            Console.Write("Opción: ");
            string cantFallos = Console.ReadLine();

            if (string.IsNullOrEmpty(cantFallos))
                return 10;
            else
                return Convert.ToInt32(cantFallos);
        }
    }
}
