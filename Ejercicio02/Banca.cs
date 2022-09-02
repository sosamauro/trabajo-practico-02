using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Banca
    {
        private string iNumero, iTitular;
        private Cuenta iCuentaEnDolares, iCuentaEnPesos;

        public Banca(string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
        }

        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }
            set { this.iCuentaEnDolares = value; }
        }

        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaEnPesos; }
            set { this.iCuentaEnPesos = value; }
        }

        public string Numero
        {
            get { return this.iNumero; }
            set { this.iNumero = value; }
        }

        public string Titular
        {
            get { return this.iTitular; }
            set { this.iTitular = value; }
        }
    }
}
