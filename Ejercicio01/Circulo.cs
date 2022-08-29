using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = pRadio;
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(this.iRadio, 2); }
        }

        public double Perimetro
        {
            get { return 2 * Math.PI * this.iRadio; }
        }


    }
}
