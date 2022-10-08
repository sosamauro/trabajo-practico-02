using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio03.Clases;

namespace Ejercicio03.Controladores
{
    public static class Controlador
    {
        public static Parking[] InicializarParking()
        {
            Parking[] arregloParking = new Parking[2];

            for (int i = 0; i < arregloParking.Length; i++)
            {
                arregloParking[i] = new Parking(i);
            }

            return arregloParking;
        }

        // Devuelve TRUE si encuentra al menos 1 lugar disponible
        public static Boolean HayLugarDisponible(Parking[] pParking)
        {
            for (int i = 0; i < pParking.Length; i++)
            {
                if (pParking[i].Patente == null)
                {
                    return true;
                }
            }
            return false;
        }

        public static void MostrarLugaresDisponibles(Parking[] pParking)
        {
            for (int i = 0; i < pParking.Length; i++)
            {
                if (pParking[i].Patente == null)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void IngresarVehiculo(Parking[] pParking, string pPatente, int pCodigoEstacionamiento)
        {
            pParking[pCodigoEstacionamiento].Patente = pPatente;
        }

        // Devuelve:
        // - TRUE si no hay ninguna patente en el lugar de estacionamiento.
        // - FALSE hay una patente en el lugar de estacionamiento, o
        //   el código de estacionamiento no existe.  
        public static Boolean ComprobarLugarEstacionamiento(Parking[] pParking, int pCodigoEstacionamiento)
        {
            if (pParking[pCodigoEstacionamiento].Patente == null)
            {
                return true;
            }
            return false;
        }
    }
}
