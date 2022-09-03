using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class ControladorBanca
    {
        public static void CrearBanca(string pNumero, string pTitular)
        {
            Banca banca = new Banca(pNumero, pTitular);
        }
    }
}
