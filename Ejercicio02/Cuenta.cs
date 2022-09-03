using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        public Cuenta(Moneda pMoneda)
        {
            this.iMoneda = pMoneda;
            this.iSaldo = 0.0;
        }

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public void AcreditarSueldo(double pSaldo)   
        {
            
        }

        public Boolean DebitarSueldo(double pSaldo)
        {
            return true;
        }
    }
}
