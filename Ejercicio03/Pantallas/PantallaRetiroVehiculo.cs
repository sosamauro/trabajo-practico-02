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
    public static class PantallaRetiroVehiculo
    {
        public static void MostrarPantalla(Parking[] pParking)
        {
            Boolean vehiculoRetirado = false;

            Console.Clear();
            Console.Write("Ingrese la patente del vehículo: ");
            string patente = Console.ReadLine();

            vehiculoRetirado = Controlador.RetirarVehiculo(pParking, patente);

            if (vehiculoRetirado)
            {
                Console.Clear();
                Console.WriteLine("El vehículo se retiró del parking.");
                MetodosDePantalla.Continuar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"No se encontró ningún vehículo con patente '{patente}'.");
                MetodosDePantalla.Continuar();
            }
        }
    }
}