using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Moneda
    {
        private string iCodigoISO, iNombre, iSimbolo;

        public Moneda(string iCodigoISO, string iNombre, string iSimbolo)
        {
            this.iCodigoISO = iCodigoISO;
            this.iNombre = iNombre;
            this.iSimbolo = iSimbolo;
        }

        public string CodigoISO
        {
            get { return this.iCodigoISO; }
            set { this.iCodigoISO = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public string Simbolo
        {
            get { return this.iSimbolo; }
            set { this.iSimbolo = value; }
        }
    }
}
