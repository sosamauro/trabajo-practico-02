using System;

namespace Ejercicio04.Metodos
{
    public static class MetodosDePantalla
    {
        public static void Continuar()
        {
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}