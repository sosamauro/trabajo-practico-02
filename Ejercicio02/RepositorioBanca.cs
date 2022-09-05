using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class RepositorioBanca
    {
        private static Banca[] iArregloBanca = new Banca[10];
        private static int i = 0;
        public static Banca Obtener(string pNumero)
        {
            foreach (Banca arregloBanca in iArregloBanca)
            {
                if (pNumero == arregloBanca.Numero)
                {
                    return arregloBanca;
                }
            }
            return null;
        }

        public static void Agregar(Banca pBanca)
        {
            iArregloBanca[i] = pBanca;
            i++;
        }
    }
}
