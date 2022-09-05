using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public class Moneda
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
            get { return iCodigoISO; }
            set { iCodigoISO = value; }
        }

        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        public string Simbolo
        {
            get { return iSimbolo; }
            set { iSimbolo = value; }
        }
    }
}
