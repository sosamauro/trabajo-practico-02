using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Repositorio;

namespace Ejercicio02.Pantallas
{
    public static class PantallaPrincipal
    {
        public static void MostrarPantalla()
        {
            Boolean salir = false;
            Boolean atras = false;
            string pNumero = null;
            Banca pBanca;
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

                switch (Console.ReadLine())
                {
                    case "1":
                        pNumero = PantallaCrearCuenta.CrearCuenta();
                        break;
                    case "2":
                        atras = false;
                        while (atras == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una cuenta: ");
                            Console.WriteLine();
                            Console.WriteLine("1) Cuenta en pesos");
                            Console.WriteLine("2) Cuenta en dólares");
                            Console.WriteLine();
                            Console.WriteLine("3) Volver atrás");
                            Console.WriteLine();
                            Console.Write("Opción: ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    pBanca = RepositorioBanca.Obtener(pNumero);
                                    PantallaOperaciones.OperarConCuentaEnPesos(pBanca);
                                    break;
                                case "2":
                                    pBanca = RepositorioBanca.Obtener(pNumero);
                                    PantallaOperaciones.OperarConCuentaEnDolares(pBanca);
                                    break;
                                case "3":
                                    atras = true;
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
