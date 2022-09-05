using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class ControladorBanca
    {
        private static readonly List<Banca> _bancaList = new List<Banca>();
        public static void CrearBanca(string pNumero, string pTitular)
        {
            Banca banca = new Banca(pNumero, pTitular);
            AgregarBanca(banca);
        }

        public static void AgregarBanca(Banca banca)
        {
            _bancaList.Add(banca);
        }

        public static Banca ObtenerBanca(string pNumero)
        {
            foreach (Banca banca in _bancaList)
            {
                if (banca.Numero == pNumero)
                {
                    return banca;
                }
            }

            return null;
        }
    }
}
