using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;

namespace Ejercicio02.Repositorio
{
    public static class RepositorioBanca
    {
        private static Banca[] iArregloBanca;
        private static int i = 1;
        public static Banca Obtener(string pNumero)
        {
            if (iArregloBanca == null)
            {
                return null;
            }
            elsed
            {
                foreach (Banca arregloBanca in iArregloBanca)
                {
                    if (arregloBanca == null)
                    {
                        return null;
                    } 
                    else if (pNumero == arregloBanca.Numero)
                    {
                        return arregloBanca;
                    }
                }
            }
            return null;
        }

        public static void Agregar(Banca pBanca)
        {
            if (iArregloBanca == null)
            {
                iArregloBanca = new Banca[10];
                iArregloBanca[0] = pBanca;
            }
            else
            {
                iArregloBanca[i] = pBanca;
                i++;
            }
        }
    }
}
