using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio03.Clases;
using Ejercicio03.Controladores;
using Ejercicio03.Metodos;

namespace Ejercicio03.Pantallas
{
	public static class PantallaIngresoVehiculo
	{
		public static void MostrarPantalla(Parking[] pParking)
		{
			
			Boolean hayLugar = Controlador.HayLugarDisponible(pParking);

			if (hayLugar)
			{
				Console.Clear();
				Console.WriteLine("Los siguientes lugares se encuentran disponibles:");

				Console.WriteLine();	
				Controlador.MostrarLugaresDisponibles(pParking);
				Console.WriteLine();

				try {
					Console.Write("Ingrese el código de estacionamiento: ");
					int codigoEstacionamiento = Convert.ToInt32(Console.ReadLine());	

					if (Controlador.ComprobarLugarEstacionamiento(pParking, codigoEstacionamiento))
					{
						Console.WriteLine();
						Console.Write("Ingrese la patente del vehículo: ");
						string patente = Console.ReadLine();

						Controlador.IngresarVehiculo(pParking, patente, codigoEstacionamiento);
						
						Console.Clear();
						Console.WriteLine();
						Console.WriteLine($"El vehiculo de patente '{pParking[codigoEstacionamiento].Patente}' será ubicado en el parking número {pParking[codigoEstacionamiento].Codigo}.");
						Console.WriteLine($"Hora de ingreso: {pParking[codigoEstacionamiento].HoraIngreso}");
						MetodosDePantalla.Continuar();
					}
					else
					{
						Console.Clear();
						Console.WriteLine("El lugar ingresado está ocupado.");
						MetodosDePantalla.Continuar();
					}
				}
				catch (FormatException) {
					Console.Clear();
					Console.WriteLine("El código de estacionamiento no es válido.");
					MetodosDePantalla.Continuar();
				}				
			}
			else
			{
				Console.Clear();
				Console.WriteLine("No hay lugares disponibles.");
				MetodosDePantalla.Continuar();
			}
		}
	}
}