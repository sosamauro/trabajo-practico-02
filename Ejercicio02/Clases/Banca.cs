using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Banca
    {
        private string iNumero, iTitular;
        private Cuenta iCuentaEnDolares, iCuentaEnPesos;

        public Banca(string pNumero, string pTitular)
        {
            iNumero = pNumero;
            iTitular = pTitular;
        }

        public Cuenta CuentaEnDolares
        {
            get { return iCuentaEnDolares; }
            set { iCuentaEnDolares = value; }
        }

        public Cuenta CuentaEnPesos
        {
            get { return iCuentaEnPesos; }
            set { iCuentaEnPesos = value; }
        }

        public string Numero
        {
            get { return iNumero; }
            set { iNumero = value; }
        }

        public string Titular
        {
            get { return iTitular; }
            set { iTitular = value; }
        }
    }
}
