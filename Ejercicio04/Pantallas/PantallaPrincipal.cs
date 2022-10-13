using System;
using Ejercicio04.Metodos;
using Ejercicio04.Pantallas;
using Ejercicio04.Controladores;

namespace Ejercicio04.Pantallas
{
    public static class PantallaPrincipal
    {
        public static void MostrarPantalla()
        {
            Boolean salir = false;

            string[] palabras = Controlador.InicializarArregloPalabras();

            while (salir == false)
            {   
                Console.Clear();
                Console.WriteLine("Elija una opción: ");
                Console.WriteLine();
                Console.WriteLine("1) Jugar una partida.");
                Console.WriteLine("2) Listar las 5 partidas ganadas con menor duración.");
                Console.WriteLine();
                Console.WriteLine("3) Salir");
                Console.WriteLine();
                Console.Write("Opción: ");
            
                switch (Console.ReadLine())
                {
                    case "1":
                        PantallaJugar.MostrarPantalla(palabras);
                        break;
                    case "2":
                        break;
                    case "3":
                        Console.Clear();
                        salir = true;
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