using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Metodos;

namespace Ejercicio02.Pantallas
{
    public static class PantallaConsultarSaldo
    {
        public static void MostrarPantalla(Cuenta pCuenta, string pMoneda)
        {
            Console.Clear();
            Console.WriteLine($"El saldo de la cuenta es: {pCuenta.Saldo} {pMoneda}");
            MetodosDePantalla.Continuar();
        }
    }
}
