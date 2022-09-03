using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class PantallaCrearCuenta
    {
        public static void CrearCuenta()
        {
            string opcion;
            Boolean salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine();
                Console.WriteLine("1) Crear una cuenta nueva");
                Console.WriteLine();
                Console.WriteLine("4) Volver atrás");
                Console.WriteLine();
                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese los siguientes datos.");
                        Console.Write("Número de cuenta (DNI): ");
                        string pNumero = Console.ReadLine();
                        Console.Write("Nombre del titular: ");
                        string pTitular = Console.ReadLine();
                        ControladorBanca.CrearBanca(pNumero, pTitular);
                        Console.Clear();
                        Console.WriteLine("Se ha creado satisfactoriamente la cuenta.");
                        Console.WriteLine($"Número de cuenta: {pNumero}");
                        Console.WriteLine($"Titular: {pTitular}");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
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
