using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Constantes;

namespace Ejercicio02.Controladores
{
    public static class ControladorCuenta
    {
        public static void CrearCuentaUnificada(Banca pBanca)
        {
            Moneda peso = new Moneda("SRA", "Peso argentino", "ARS");
            Moneda dolar = new Moneda("USD", "Dólar estadounidense", "USD");

            Cuenta cuentaPesos = new Cuenta(0.0, peso);
            Cuenta cuentaDolares = new Cuenta(0.0, dolar);

            pBanca.CuentaEnPesos = cuentaPesos;
            pBanca.CuentaEnDolares = cuentaDolares;
        }

        public static bool SePuedeTransferirPesosADolares(Banca pBanca, double pMonto)
        {
            return pBanca.CuentaEnPesos.DebitarSaldo(pMonto * ValorDolar.ValorActual);
        }
    }
}
