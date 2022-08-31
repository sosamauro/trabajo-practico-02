using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Banca
    {
        private string iNumero, iTitular;

        public Banca(string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
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
