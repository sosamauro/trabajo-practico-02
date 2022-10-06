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

        Controlador.MostrarLugaresDisponibles(pParking);

        Console.Write("Ingrese la patente del vehículo: ");
        string patente = Console.ReadLine();

        Console.Write("Ingrese el código de estacionamiento");
        int codigoEstacionamiento = Convert.ToInt16(Console.ReadLine());
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