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
            Boolean salir = false;

            while (salir == false)
            {
                try {
                    Console.Clear();
                    Console.Write("Ingrese el código de estacionamiento: ");
                    int codigoEstacionamiento = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"¿Desea retirar el vehículo de patente '{pParking[codigoEstacionamiento].Patente}'?");
                    Console.WriteLine();
                    Console.WriteLine("1) Confirmar");
                    Console.WriteLine("2) Cancelar");
                    Console.WriteLine();

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            double tarifa = Controlador.CalcularTarifa(pParking, codigoEstacionamiento, DateTime.Now);
                            Console.WriteLine($"Vehículo retirado. La tarifa es: ${tarifa}");
                            Controlador.RetirarVehiculo(pParking, codigoEstacionamiento);
                            MetodosDePantalla.Continuar();  
                            salir = true;
                            break;
                        case "2":
                            salir = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ingrese una opción válida.");
                            MetodosDePantalla.Continuar();
                            break;
                    }
                }
                catch (FormatException) {
                    Console.Clear();
                    Console.WriteLine("El código de estacionamiento no es válido.");
                    MetodosDePantalla.Continuar();
                }      
            }

                 
        }
    }
}