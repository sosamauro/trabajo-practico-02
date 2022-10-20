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
        // Inicializa el arreglo Parking, siendo, cada index del arreglo igual
        // al código de estacionamiento.
        public static Parking[] InicializarParking()
        {
            Parking[] arregloParking = new Parking[10];

            for (int i = 0; i < arregloParking.Length; i++)
            {
                arregloParking[i] = new Parking(i);
            }

            return arregloParking;
        }

        // Devuelve TRUE si encuentra un lugar disponible.
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

        // Muestra los lugares disponibles.
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

        // Asigna la patente al lugar de estacionamiento.
        public static void IngresarVehiculo(Parking[] pParking, string pPatente, int pCodigoEstacionamiento, DateTime pHoraIngreso)
        {
            pParking[pCodigoEstacionamiento].Patente = pPatente;
            pParking[pCodigoEstacionamiento].HoraIngreso = pHoraIngreso;
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

        // Elimina el vehículo del arreglo Parking
        public static void RetirarVehiculo(Parking[] pParking, int pCodigoEstacionamiento)
        {
            pParking[pCodigoEstacionamiento].Patente = null;
        }

        public static double CalcularTarifa(Parking[] pParking, int pCodigoEstacionamiento, DateTime pHoraEgreso)
        {
            double horasTotales = (pHoraEgreso - pParking[pCodigoEstacionamiento].HoraIngreso).TotalHours;
            double tarifa = 200;

            tarifa += Math.Round(horasTotales) * 200;

            return tarifa;
        }
    }
}
