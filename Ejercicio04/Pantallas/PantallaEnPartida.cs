using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio04.Metodos;
using Ejercicio04.Controladores;
using System.Collections;

namespace Ejercicio04.Pantallas
{
    public static class PantallaEnPartida
    {
        public static void MostrarPantalla(string pPalabra, int pCantFallos)
        {
            bool salir = false;
            

            Console.Clear();

            string[] arregloPalabra = Controlador.CrearArregloConPalabra(pPalabra);
            ArrayList arregloFallos = Controlador.CrearArregloFallos();

            Controlador.MostrarArreglo(arregloPalabra);

            Console.WriteLine();

            while (salir == false)
            {
                bool huboCoincidencia = false;

                Console.WriteLine();
                Console.Write("Ingrese una letra: ");
                string letra = Console.ReadLine();

                for (int i = 0; i < pPalabra.Length; i++)
                {
                    if (Controlador.HayCoincidencia(pPalabra, letra))
                    {
                        arregloPalabra = Controlador.AgregarLetraCorrecta(arregloPalabra, pPalabra, letra);
                        huboCoincidencia = true;
                    }
                }

                if (huboCoincidencia == false)
                {
                    pCantFallos--;
                    Console.Clear();
                    Controlador.AgregarLetraArregloFallos(arregloFallos, letra);
                    Controlador.MostrarArregloFallos(arregloFallos);
                }

                if (pCantFallos < 0)
                {
                    salir = true;
                    Console.Clear();
                    Console.WriteLine("Se agotaron los intentos.");
                    MetodosPantalla.Continuar();
                }

                Console.Clear();
                Controlador.MostrarArreglo(arregloPalabra);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Letras incorrectas: ");
                Controlador.MostrarArregloFallos(arregloFallos);
                Console.WriteLine();
                Console.WriteLine($"Te quedan {pCantFallos} intentos.");

                if (Controlador.PalabraCompleta(arregloPalabra))
                {
                    salir = true;
                    Console.WriteLine();
                    Console.WriteLine("Ganaste!");
                    MetodosPantalla.Continuar();
                }
            }
        }
    }
}
