using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;

namespace Ejercicio02.Pantallas
{
    public static class PantallaAcreditarSaldo
    {
        public static void MostrarPantalla(Cuenta pCuenta, string pMoneda)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el saldo a acreditar: ");
            double pSaldo = Convert.ToDouble(Console.ReadLine());
            pCuenta.AcreditarSaldo(pSaldo);
            Console.Clear();
            Console.WriteLine("Se ha acreditado exitosamente.");
            Console.WriteLine($"Su saldo actual es: {pCuenta.Saldo} {pMoneda}");
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
        }
    }
}
