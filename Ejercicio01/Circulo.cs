using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Circulo
    {
        private double _radio;
        private Punto _centro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this._radio = pRadio;
            this._centro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this._centro = new Punto(pX, pY);
            this._radio = pRadio;
        }

        public double Radio
        {
            get { return this._radio; }
            set { this._radio = value; }
        }

        public Punto Centro
        {
            get { return this._centro; }
            set { this._centro = value; }
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(this._radio, 2); }
        }

        public double Perimetro
        {
            get { return 2 * Math.PI * this._radio; }
        }


    }
}
