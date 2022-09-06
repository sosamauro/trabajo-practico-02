using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Repositorio;

namespace Ejercicio02.Controladores
{
    public static class Controlador
    {
        public static void CrearBanca(string pNumero, string pTitular)
        {
            Banca pBanca = new Banca(pNumero, pTitular);

            Moneda pMonedaPeso = new Moneda("SRA", "Peso argentino", "ARS");
            Moneda pMonedaDolar = new Moneda("USD", "Dólar estadounidense", "USD");

            Cuenta pCuentaPesos = new Cuenta(0.0, pMonedaPeso);
            Cuenta pCuentaDolares = new Cuenta(0.0, pMonedaDolar);

            pBanca.CuentaEnPesos = pCuentaPesos;
            pBanca.CuentaEnDolares = pCuentaDolares;

            RepositorioBanca.Agregar(pBanca);
        }
    }
}
