using System;
using Ejercicio04.Metodos;

namespace Ejercicio04.Pantallas
{
    public static class PantallaCantFallos
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