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
		private string iPatente, iHoraIngreso, iHoraEgreso;
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

		public string HoraIngreso
		{
			get { return this.iHoraIngreso; }
			set { this.iHoraIngreso = value; }
		}

		public string HoraEgreso
		{
			get { return this.iHoraEgreso; }
			set { this.iHoraEgreso = value; }
		}

		public double TiempoOcupado
		{
			get
			{
				double horaIngresoD = double.Parse(string.Format("{0}.{1}", ((this.HoraIngreso).Split(':'))[0], ((this.HoraIngreso).Split(':'))[1]));
				double horaEgresoD = double.Parse(string.Format("{0}.{1}", ((this.HoraEgreso).Split(':'))[0], ((this.HoraEgreso).Split(':'))[1]));
				return (Math.Round((horaEgresoD - horaIngresoD) * 2) / 2); //Redondear la Hora cada 0.5
			}
		}

		public double Tarifa
		{
			get { return this.TiempoOcupado * 200; }
		}

		// **** INGRESAR HORA **** 
		// int hours = 5;
		// int minutes = 55;
		// int seconds = 7;
		// TimeSpan ts = new TimeSpan(hours, minutes, seconds);
		// Console.WriteLine("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
	}
}
