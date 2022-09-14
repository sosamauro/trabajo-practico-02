using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Estacionamiento
{
    public static class Estacionamiento
    {
        Parking[] Estacionamiento;

        public Estacionamiento(){
            for (int i = 1; i < 11; i++)
            {
                Estacionamiento[i].Parking(i);
            }
        }
    }
}