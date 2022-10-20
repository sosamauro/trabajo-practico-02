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
            get { return Math.Atan2(this.getImaginario, this.getReal); }
        }
        
        public double ArgumentoEnGrados
        {
            get { return (this.ArgumentoEnRadianes*(180/Math.PI)); }
        }
        public double Conjugado
        {
            get { return ((-1)*(this.getImaginario)); }
        }
        public double Magnitud
        {
            get { return Math.sqrt((Math.Pow(this.getReal,2))+(Math.Pow(this.getImaginario,2))) }
        }
        public boolean EsReal(){
            if(this.getImaginario = 0){
                return true;
            }else{
                return false;
            }
        }
        public boolean EsImaginario(){
            if(not this.EsReal()){
                return true;
            }else{
                return false;
            }
        }
        public boolean EsIgual(pOtroComplejo: Complejo){
            if ((this.getReal = pOtroComplejo.getReal) & (this.getImaginario = pOtroComplejo.getImaginario)){
                return true;
            }else{
                return false;
            }
        }
        public boolean EsIgual(pReal: double, pImaginario: double){
            if ((this.getReal = pReal) & (this.getImaginario = pImaginario)){
                return true;
            }else{
                return false;
            }
        }
        public Complejo Sumar(pOtroComplejo: Complejo){
            var
                Complejo sumaComplejo = new Complejo;
            sumaComplejo.Complejo(pOtroComplejo.getReal + this.getReal,pOtroComplejo.getImaginario + this.getImaginario);
            return sumaComplejo;
        }
        public Complejo Restar(pOtroComplejo: Complejo){
            var
                Complejo restaComplejo = new Complejo;
            restaComplejo.Complejo(pOtroComplejo.getReal - this.getReal,pOtroComplejo.getImaginario - this.getImaginario);
            return restaComplejo;
        }
        public Complejo Multiplicar(pOtroComplejo: Complejo){
            var
                Complejo multComplejo = new Complejo;
                //multComplejo.Complejo(real,img);
            multComplejo.Complejo((this.getReal*pOtroComplejo.getReal)+(-1)*(this.getImaginario*pOtroComplejo.getImaginario),(this.getReal*pOtroComplejo.getImaginario)+(this.getImaginario*pOtroComplejo.getReal));
            return multComplejo;
        }
        public Complejo DividirPor(pOtroComplejo: Complejo){
            var
                Complejo divComplejo = new Complejo;
                double ac, bd, ad, cb, cd;

            ac = this.getReal*pOtroComplejo.getReal;
            bd = this.getImaginario*pOtroComplejo.getImaginario;
            ad = this.getReal*pOtroComplejo.getImaginario;
            cb = pOtroComplejo.getReal*this.getImaginario;
            cd = Math.Pow(pOtroComplejo.getReal,2)+Math.Pow(getImaginario.getReal,2);
            divComplejo.Complejo((ac+bd)/cd,(cb-ad)/cd);
            return divComplejo;
        }
    }
}
