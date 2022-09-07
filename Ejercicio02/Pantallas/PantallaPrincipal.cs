using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Metodos;
using Ejercicio02.Repositorio;

namespace Ejercicio02.Pantallas
{
    public static class PantallaPrincipal
    {
        public static void MostrarPantalla()
        {
            Boolean salir = false;
            Boolean atras = false;
            Boolean pesos = false;
            string pNumero = null;
            Banca pBanca = null;
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
                        PantallaCrearCuenta.CrearCuenta();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese el número unificado de cuenta: ");
                        pNumero = Console.ReadLine();
                        pBanca = RepositorioBanca.Obtener(pNumero);
                        if (pBanca != null)
                        {
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
                                        PantallaOperaciones.OperarConCuentaEnPesos(pBanca);
                                        break;
                                    case "2":
                                        PantallaOperaciones.OperarConCuentaEnDolares(pBanca);
                                        break;
                                    case "3":
                                        atras = true;
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Ingrese una opción válida.");
                                        MetodosDePantalla.Continuar();
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No se encontró ninguna cuenta.");
                            MetodosDePantalla.Continuar();
                        }                     
                        break;
                    case "3":
                        salir = true;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción válida.");
                        MetodosDePantalla.Continuar();
                        break;
                }

            }
        }
    }
}
