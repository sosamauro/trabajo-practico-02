using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Clases
{
    public class Complejo
    {
        private double iReal, iImaginario;
        
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        public double Real
        {
            get { return this.iReal; }
        }

        public double Imaginario
        {
            get { return this.iImaginario; }
        }
        
        public double ArgumentoEnRadianes
        {
            get { return Math.Atan2(this.Imaginario, this.Real); }
        }
        
        public double ArgumentoEnGrados
        {
            get { return (this.ArgumentoEnRadianes * (180 / Math.PI)); }
        }
        public double Conjugado
        {
            get { return ( (-1) * (this.Imaginario) ); }
        }

        public double Magnitud
        {
            get { return Math.Sqrt((Math.Pow(this.Real, 2)) + (Math.Pow(this.Imaginario, 2))); }
        }

        public Boolean EsReal ()
        {
            if (this.Imaginario == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsImaginario ()
        {
            if (this.EsReal() != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsIgual (Complejo pOtroComplejo)
        {
            if (this.Real == pOtroComplejo.Real & this.Imaginario == pOtroComplejo.Imaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsIgual (double pReal, double pImaginario)
        {
            if (this.Real == pReal & this.Imaginario == pImaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Complejo Sumar (Complejo pOtroComplejo)
        {
            Complejo sumaComplejo = new Complejo(pOtroComplejo.Real + this.Real, pOtroComplejo.Imaginario + this.Imaginario);
            return sumaComplejo;
        }

        public Complejo Restar(Complejo pOtroComplejo)
        {
            Complejo restaComplejo = new Complejo(pOtroComplejo.Real - this.Real, pOtroComplejo.Imaginario - this.Imaginario);
            return restaComplejo;
        }

        public Complejo Multiplicar(Complejo pOtroComplejo) //(a + bi) * (c + di) = a*c + a*di + bi*c + bi*di = ac - bd + adi + bic
        {
            Complejo multComplejo = new Complejo((this.Real * pOtroComplejo.Real) + ((-1) * (this.Imaginario * pOtroComplejo.Imaginario)), 
                                                 (this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real));
            //multComplejo.Complejo(real,img);
            return multComplejo;
        }

        public Complejo DividirPor (Complejo pOtroComplejo)
        {
            
            double ac, bd, ad, cb, cd;

            ac = this.Real * pOtroComplejo.Real;
            bd = this.Imaginario * pOtroComplejo.Imaginario;
            ad = this.Real * pOtroComplejo.Imaginario;
            cb = pOtroComplejo.Real * this.Imaginario;
            cd = Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2);

            Complejo divComplejo = new Complejo((ac + bd) / cd, (cb - ad) / cd);

            return divComplejo;
        }
    }
}
