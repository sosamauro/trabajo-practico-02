using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio03.Clases;

namespace Ejercicio03.Clases
{
    public class Parking
    {
		private string iPatente;
		private DateTime iHoraIngreso;

        private int iCodigo;

		public Parking(int pCodigo)
		{
			iCodigo = pCodigo;
		}

		public int Codigo
		{
			get { return this.iCodigo; }
			set { this.iCodigo = value; }
		}

		public string Patente
		{
			get { return this.iPatente; }
			set { this.iPatente = value; }
		}

		public DateTime HoraIngreso
		{
			get { return this.iHoraIngreso; }
			set { this.iHoraIngreso = value; }
		}
	}
}
