﻿namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Boolean salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine();
                Console.WriteLine("1) Crear una cuenta");
                Console.WriteLine("2) Realizar una operación");
                Console.WriteLine();
                Console.WriteLine("3) Salir");
                Console.WriteLine();
                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        PantallaCrearCuenta.CrearCuenta();
                        break;
                    case "2":
                        PantallaOperaciones.OperarConCuenta();
                        break;
                    case "3":
                        salir = true;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción válida.");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}