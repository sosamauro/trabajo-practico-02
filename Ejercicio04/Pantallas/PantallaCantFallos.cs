using System;
using Ejercicio04.Metodos;

namespace Ejercicio04.Pantallas
{
    public static class PantallaCantFallos
    {
        public static int MostrarPantallaCantFallos()
        {
            Boolean continuar = false;
            int cantMaxFallos = 10;

            Console.Clear();
            Console.WriteLine("Seleccione la cantidad máxima de fallos permitidos: ");
            Console.WriteLine("1) Por defecto (10)");
            Console.WriteLine("2) Modificar");
            Console.WriteLine();
            Console.Write("Ingrese una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Cantidad máxima de fallos: 10");
                    MetodosDePantalla.Continuar();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Ingrese un valor: ");
                    try {
                        cantMaxFallos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Cantidad máxima de fallos: {cantMaxFallos}");
                        MetodosDePantalla.Continuar();
                        return cantMaxFallos;
                    }
                    catch (FormatException) {
                        Console.WriteLine("El valor ingresado no es válido.");
                        MetodosDePantalla.Continuar();
                    }
                    break;
                default:
                    break;
            }
            return cantMaxFallos;
        }
    }
}