using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Metodos;

namespace Ejercicio02.Pantallas
{
    public static class PantallaDebitarSaldo
    {
        public static void MostrarPantalla(Cuenta pCuenta, string pMoneda)
        {
            Console.Clear();
            Console.Write("Ingrese el saldo a debitar: ");
            double pSaldo = Convert.ToDouble(Console.ReadLine());
            if (pCuenta.DebitarSaldo(pSaldo))
            {
                Console.Clear();
                Console.WriteLine("Se ha debitado exitosamente.");
                Console.WriteLine();
                Console.WriteLine($"Su saldo actual es: {pCuenta.Saldo} {pMoneda}.");
                MetodosDePantalla.Continuar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No posee fondos suficientes para realizar esta operacion.");
                MetodosDePantalla.Continuar();
            }
        }
    }
}
