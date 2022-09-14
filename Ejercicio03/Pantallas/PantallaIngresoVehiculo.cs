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
			Boolean hayLugar = Controlador.ComprobarLugaresDisponibles();

			if (hayLugar)
			{

			}
			else
			{
				Console.Clear();
				Console.WriteLine(value: "No hay lugares disponibles");
				MetodosDePantalla.Continuar();
			}
		}
	}
}
