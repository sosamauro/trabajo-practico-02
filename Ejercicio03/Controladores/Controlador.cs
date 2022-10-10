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
            Parking[] arregloParking = new Parking[2];

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
        public static void IngresarVehiculo(Parking[] pParking, string pPatente, int pCodigoEstacionamiento)
        {
            pParking[pCodigoEstacionamiento].Patente = pPatente;
            pParking[pCodigoEstacionamiento].HoraIngreso = DateTime.Now.TimeOfDay;
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

        // Se le pasa un parking y una patente como parámetros. 
        // - Si existe la patente, se la  elimina del parking y devuelve TRUE. 
        // - Si no existe la patente, devuelve FALSE.
        public static Boolean RetirarVehiculo(Parking[] pParking, string pPatente)
        {
            for (int i = 0; i < pParking.Length; i++)
            {
                if (pParking[i].Patente == pPatente)
                {
                    pParking[i].Patente = null;
                    pParking[i].HoraEgreso = DateTime.Now.TimeOfDay;
                    return true;
                }
            }
            return false;
        }

        // public double TiempoOcupado
		// {
		// 	get
		// 	{
		// 		double horaIngresoD = double.Parse(string.Format("{0}.{1}", ((this.HoraIngreso).Split(':'))[0], ((this.HoraIngreso).Split(':'))[1]));
		// 		double horaEgresoD = double.Parse(string.Format("{0}.{1}", ((this.HoraEgreso).Split(':'))[0], ((this.HoraEgreso).Split(':'))[1]));
		// 		return (Math.Round((horaEgresoD - horaIngresoD) * 2) / 2); //Redondear la Hora cada 0.5
		// 	}
		// }
    }
}
