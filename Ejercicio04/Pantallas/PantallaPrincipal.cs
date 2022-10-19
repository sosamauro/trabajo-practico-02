using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio04.Controladores;
using Ejercicio04.Pantallas;
using Ejercicio04.Metodos;

namespace Ejercicio04.Pantallas
{
    public static class PantallaPrincipal
    {
        public static void MostrasPantalla()
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
                        MetodosPantalla.Continuar();
                        break;
                }
            }
        }
    }
}
