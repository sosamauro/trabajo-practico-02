using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio04.Controladores;
using Ejercicio04.Metodos;

namespace Ejercicio04.Pantallas
{
    public static class PantallaJugar
    {
        public static void MostrarPantalla(string[] pPalabras)
        {
            Console.Clear();

            Console.Write("Ingrese el nombre del jugador: ");
            string pJugador = Console.ReadLine();

            Controlador.CrearPartida(pJugador);

            string palabra = Controlador.ObtenerPalabra(pPalabras);

            int cantFallos = PantallaCantidadFallos.MostrarPantalla();

            PantallaEnPartida.MostrarPantalla(palabra, cantFallos);
        }
    }
}
