using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        public Cuenta(Moneda pMoneda)
        {
            iMoneda = pMoneda;
            iSaldo = 0.0;
        }

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            iSaldo = pSaldoInicial;
            iMoneda = pMoneda;
        }

        public double Saldo
        {
            get { return iSaldo; }
            set { iSaldo = value; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (iSaldo >= pSaldo)
            {
                iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
