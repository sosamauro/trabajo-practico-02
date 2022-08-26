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
        private double iArea;
        private double iPerimetro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro.X = pX;
            this.iCentro.Y = pY;
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
            get { return this.iArea; }
            set { this.iArea = value; }
        }

        public double Perimetro
        {
            get { return this.iPerimetro; }
            set { this.iPerimetro = value; }
        }


    }
}
