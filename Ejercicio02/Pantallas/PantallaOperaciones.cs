using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Pantallas
{
    public static class PantallaOperaciones
    {
        public static void OperarConCuentaEnPesos(Banca pBanca)
        {
            Boolean atras = false;
            Boolean sePuedeDebitar = false;
            double pSaldo = 0.0;
            while (atras == false)
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
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"El saldo de la cuenta es: {pBanca.CuentaEnPesos.Saldo} ARS.");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el saldo a acreditar: ");
                        pSaldo = Convert.ToDouble(Console.ReadLine());
                        pBanca.CuentaEnPesos.AcreditarSaldo(pSaldo);
                        Console.Clear();
                        Console.WriteLine("Se ha acreditado exitosamente.");
                        Console.WriteLine($"Su saldo actual es: {pBanca.CuentaEnPesos.Saldo} ARS.");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el saldo a debitar: ");
                        pSaldo = Convert.ToDouble(Console.ReadLine());
                        sePuedeDebitar = pBanca.CuentaEnPesos.DebitarSaldo(pSaldo);
                        if (sePuedeDebitar)
                        {
                            Console.Clear();
                            Console.WriteLine("Se ha debitado exitosamente.");
                            Console.WriteLine($"Su saldo actual es: {pBanca.CuentaEnPesos.Saldo} ARS.");
                            Console.WriteLine();
                            Console.Write("Presione ENTER para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No posee fondos suficientes para realizar esta operacion.");
                            Console.WriteLine();
                            Console.Write("Presione ENTER para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Ingrese el monto en USD a transferir: ");
                        pSaldo = Convert.ToDouble(Console.ReadLine());
                        sePuedeDebitar = ControladorCuenta.SePuedeTransferirPesosADolares(pBanca, pSaldo);
                        if (sePuedeDebitar)
                        {
                            Console.Clear();
                            Console.WriteLine("Se ha transferido exitosamente.");
                            Console.WriteLine($"Su saldo de cuenta en pesos es: {pBanca.CuentaEnPesos.Saldo} ARS.");
                            Console.WriteLine($"Su saldo de cuenta en dolares es: {pBanca.CuentaEnDolares.Saldo} USD.");
                            Console.WriteLine();
                            Console.Write("Presione ENTER para continuar...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No posee fondos suficientes para realizar esta operacion.");
                            Console.WriteLine();
                            Console.Write("Presione ENTER para continuar...");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
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
        }

        public static void OperarConCuentaEnDolares(Banca pBanca)
        {

        }
    }
}
