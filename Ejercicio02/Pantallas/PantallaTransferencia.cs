using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Constantes;
using Ejercicio02.Metodos;

namespace Ejercicio02.Pantallas
{
    public static class PantallaTransferencia
    {
        public static void MostrarPantallaPesosADolares(Cuenta pCuentaPesos, Cuenta pCuentaDolares)
        {
            double pValorDolar = ValorDolar.ValorActual;
            double pMontoPesos;
            double pMontoDolares;

            Console.Clear();
            Console.Write("Ingrese el monto en ARS a transferir: ");
            pMontoPesos = Convert.ToDouble(Console.ReadLine());
            pMontoDolares = pMontoPesos / pValorDolar;
            pMontoDolares = Math.Round(pMontoDolares, 2);
            
            Console.Clear();
            Console.WriteLine($"Usted está por transferir {pMontoPesos} ARS ({pMontoDolares} USD)");
            Console.WriteLine();
            Console.WriteLine("1) Confirmar operación");
            Console.WriteLine("2) Cancelar");
            Console.WriteLine();
            Console.Write("Opción: ");
            switch (Console.ReadLine())
            {
                case "1":
                    if (pCuentaPesos.DebitarSaldo(pMontoPesos))
                    {
                        pCuentaDolares.AcreditarSaldo(pMontoDolares);

                        Console.Clear();
                        Console.WriteLine("Se ha transferido exitosamente.");
                        Console.WriteLine($"Su saldo de cuenta en pesos es: {pCuentaPesos.Saldo} ARS.");
                        Console.WriteLine($"Su saldo de cuenta en dolares es: {pCuentaDolares.Saldo} USD.");
                        MetodosDePantalla.Continuar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No posee fondos suficientes para realizar esta operacion.");
                        MetodosDePantalla.Continuar();
                    }
                    break;
                case "2":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ingrese una opción válida.");
                    MetodosDePantalla.Continuar();
                    break;
            }
        }

        public static void MostrarPantallaDolaresAPesos(Cuenta pCuentaPesos, Cuenta pCuentaDolares)
        {
            double pValorDolar = ValorDolar.ValorActual;
            double pMontoPesos;
            double pMontoDolares;

            Console.Clear();
            Console.Write("Ingrese el monto en USD a transferir: ");
            pMontoDolares = Convert.ToDouble(Console.ReadLine());
            pMontoPesos = pMontoDolares * pValorDolar;

            Console.Clear();
            Console.WriteLine($"Usted está por transferir {pMontoDolares} USD ({pMontoPesos} ARS)");
            Console.WriteLine();
            Console.WriteLine("1) Confirmar operación");
            Console.WriteLine("2) Cancelar");
            Console.WriteLine();
            Console.Write("Opción: ");
            switch (Console.ReadLine())
            {
                case "1":
                    if (pCuentaDolares.DebitarSaldo(pMontoDolares))
                    {
                        pCuentaPesos.AcreditarSaldo(pMontoPesos);

                        Console.Clear();
                        Console.WriteLine("Se ha transferido exitosamente.");
                        Console.WriteLine($"Su saldo de cuenta en pesos es: {pCuentaPesos.Saldo} ARS.");
                        Console.WriteLine($"Su saldo de cuenta en dolares es: {pCuentaDolares.Saldo} USD.");
                        MetodosDePantalla.Continuar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No posee fondos suficientes para realizar esta operacion.");
                        MetodosDePantalla.Continuar();
                    }
                    break;
                case "2":
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
