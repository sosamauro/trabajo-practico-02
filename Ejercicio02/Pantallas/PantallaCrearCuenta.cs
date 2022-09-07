using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Controladores;
using Ejercicio02.Metodos;
using Ejercicio02.Repositorio;

namespace Ejercicio02.Pantallas
{
    public static class PantallaCrearCuenta
    {
        public static void CrearCuenta()
        {
            // Validar si ya existe la cuenta.
            // Si ya existe, que salte un mensaje informándolo.
            Console.Clear();
            Console.WriteLine("Por favor, ingrese los siguientes datos.");
            Console.Write("Número de cuenta (DNI): ");
            string pNumero = Console.ReadLine();
            Console.Write("Nombre del titular: ");
            string pTitular = Console.ReadLine();
            Banca pBanca = RepositorioBanca.Obtener(pNumero);
            if (pBanca == null)
            {
                Controlador.CrearBanca(pNumero, pTitular);
                Console.Clear();
                Console.WriteLine("Se ha creado satisfactoriamente la cuenta.");
                Console.WriteLine();
                Console.WriteLine($"Número de cuenta: {pNumero}");
                Console.WriteLine($"Titular: {pTitular}");
                MetodosDePantalla.Continuar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ya existe una cuenta con ese número de cuenta.");
                MetodosDePantalla.Continuar();
            }
        }
    }
}
