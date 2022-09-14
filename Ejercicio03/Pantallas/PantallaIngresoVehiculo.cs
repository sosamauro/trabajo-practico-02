using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio03.Controladores;
using Ejercicio03.Metodos;

namespace Ejercicio03.Pantallas
{
	public static class PantallaIngresoVehiculo
	{
		public static void MostrarPantalla()
		{
			if (hayLugar)
			{
				Console.Clear();
				Console.WriteLine("Los siguientes lugares se encuentran disponibles:");
				
				// *** Mostrar lugares disponibles ***

				// El usuario ingresa algún lugar y la aplicación comprueba si existe.
				// - Si el lugar existe, se lo elimina del array de lugares disponibles y 
				//   se lo agrega al array de lugares ocupados. 
				// - Si el lugar no existe, se muestra un mensaje notificándolo
				//   y se muestra una pantalla para volver a ingresar un lugar.

				//Clase estacionamiento: Patente, HoraIngreso, HoraEgreso;
				//Disponibilidad - Property
				//Tarucha - Property

				Console.Write("Ingrese la patente del vehículo: ");
				string patente = Console.ReadLine();

				Console.Write("Ingrese el código de estacionamiento");
				int codigoEstacionamiento = Console.ReadLine();

				
	
				
			}
			else
			{
				Console.Clear();
				Console.WriteLine("No hay lugares disponibles");
				MetodosDePantalla.Continuar();
			}
		}
	}
}
