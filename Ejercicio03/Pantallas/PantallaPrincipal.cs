using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio03.Controladores;
using Ejercicio03.Metodos;
using Ejercicio03.Pantallas;
using Ejercicio03.Clases;

namespace Ejercicio03.Pantallas
{
  public static class PantallaPrincipal
  {
    public static void MostrarPantalla()
    {
      Boolean salir = false;

      Parking[] pParking = Controlador.InicializarParking();

      while (salir == false)
      {
        Console.Clear();
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine();
        Console.WriteLine("1) Ingreso de vehículo");
        Console.WriteLine("2) Retiro de vehículo");
        Console.WriteLine();
        Console.WriteLine("3) Salir");
        Console.WriteLine();
        Console.Write("Opción: ");

        switch (Console.ReadLine())
        {
          case "1":
            PantallaIngresoVehiculo.MostrarPantalla(pParking);
            break;
          case "2":
            break;
          case "3":
            salir = true;
            Console.Clear();
            break;
          default:
            Console.Clear();
            Console.WriteLine("Ingrese una opción válida.");
            MetodosDePantalla.Continuar();
            break;
        }
      }
    }
  }
}
