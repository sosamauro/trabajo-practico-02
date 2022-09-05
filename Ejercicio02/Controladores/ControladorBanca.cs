﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Repositorio;

namespace Ejercicio02.Controladores
{
    public static class ControladorBanca
    {
        public static Banca CrearBanca(string pNumero, string pTitular)
        {
            Banca banca = new Banca(pNumero, pTitular);
            RepositorioBanca.Agregar(banca);
            return banca;
        }
    }
}
