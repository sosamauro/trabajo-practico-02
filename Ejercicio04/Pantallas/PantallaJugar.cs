using System;
using Ejercicio04.Controladores;
using Ejercicio04.Pantallas;

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

            

            
            
        }
    }
}