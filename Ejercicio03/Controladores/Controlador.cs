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
      Parking[] arregloParking = new Parking[10];

      for (int i = 0; i < 10; i++)
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
  }
}
