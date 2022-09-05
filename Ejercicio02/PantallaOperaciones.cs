using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class PantallaOperaciones
    {
        public static void OperarConCuenta()
        {
            string opcion;
            Boolean salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine();
                Console.WriteLine("1) Consultar saldo");
                Console.WriteLine("2) Acreditar saldo");
                Console.WriteLine("3) Debitar saldo");
                Console.WriteLine("4) Realizar una transferencia");
                Console.WriteLine();
                Console.WriteLine("5) Volver atrás");
                Console.WriteLine();
                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "5":
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
