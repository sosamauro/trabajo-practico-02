using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Controladores;
using Ejercicio02.Metodos;

namespace Ejercicio02.Pantallas
{
    public static class PantallaOperaciones
    {
        public static void OperarConCuentaEnPesos(Banca pBanca)
        {
            Boolean atras = false;
            string pMoneda = "ARS";
            while (atras == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine();
                Console.WriteLine("1) Consultar saldo");
                Console.WriteLine("2) Acreditar saldo");
                Console.WriteLine("3) Debitar saldo");
                Console.WriteLine("4) Realizar una transferencia a cuenta en dólares");
                Console.WriteLine();
                Console.WriteLine("5) Volver atrás");
                Console.WriteLine();
                Console.Write("Opción: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        PantallaConsultarSaldo.MostrarPantalla(pBanca.CuentaEnPesos, pMoneda);
                        break;
                    case "2":
                        PantallaAcreditarSaldo.MostrarPantalla(pBanca.CuentaEnPesos, pMoneda);
                        break;
                    case "3":
                        PantallaDebitarSaldo.MostrarPantalla(pBanca.CuentaEnPesos, pMoneda);
                        break;
                    case "4":
                        PantallaTransferencia.MostrarPantallaPesosADolares(pBanca.CuentaEnPesos, pBanca.CuentaEnDolares);
                        break;
                    case "5":
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

        public static void OperarConCuentaEnDolares(Banca pBanca)
        {
            Boolean atras = false;
            string pMoneda = "USD";
            while (atras == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine();
                Console.WriteLine("1) Consultar saldo");
                Console.WriteLine("2) Acreditar saldo");
                Console.WriteLine("3) Debitar saldo");
                Console.WriteLine("4) Realizar una transferencia a cuenta en pesos");
                Console.WriteLine();
                Console.WriteLine("5) Volver atrás");
                Console.WriteLine();
                Console.Write("Opción: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        PantallaConsultarSaldo.MostrarPantalla(pBanca.CuentaEnDolares, pMoneda);
                        break;
                    case "2":
                        PantallaAcreditarSaldo.MostrarPantalla(pBanca.CuentaEnDolares, pMoneda);
                        break;
                    case "3":
                        PantallaDebitarSaldo.MostrarPantalla(pBanca.CuentaEnDolares, pMoneda);
                        break;
                    case "4":
                        PantallaTransferencia.MostrarPantallaDolaresAPesos(pBanca.CuentaEnPesos, pBanca.CuentaEnDolares);
                        break;
                    case "5":
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
    }
}
