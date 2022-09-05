using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public interface IRepositorioBanca
    {
        Banca Obtener(string pNumero);
        void Agregar(Banca pBanca);
    }
}
