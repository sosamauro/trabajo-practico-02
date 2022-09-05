using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;

namespace Ejercicio02.Repositorio
{
    public interface IRepositorioBanca
    {
        Banca Obtener(string pNumero);
        void Agregar(Banca pBanca);
    }
}
