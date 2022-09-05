using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Clases;
using Ejercicio02.Controladores;

namespace Ejercicio02.Pantallas
{
    public static class PantallaCrearCuenta
    {
        public static string CrearCuenta()
        {
            // Validar si ya existe la cuenta.
            // Si ya existe, que salte un mensaje informándolo.
            Banca pBanca;

            Console.Clear();
            Console.WriteLine("Por favor, ingrese los siguientes datos.");
            Console.Write("Número de cuenta (DNI): ");
            string pNumero = Console.ReadLine();
            Console.Write("Nombre del titular: ");
            string pTitular = Console.ReadLine();
            pBanca = ControladorBanca.CrearBanca(pNumero, pTitular);
            ControladorCuenta.CrearCuentaUnificada(pBanca);
            Console.Clear();
            Console.WriteLine("Se ha creado satisfactoriamente la cuenta.");
            Console.WriteLine($"Número de cuenta: {pNumero}");
            Console.WriteLine($"Titular: {pTitular}");
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();

            return pNumero;
        }
    }
}
