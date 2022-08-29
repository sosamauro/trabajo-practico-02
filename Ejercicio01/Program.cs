namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Boolean salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine();
                Console.WriteLine("1) Distancia entre 2 puntos");
                Console.WriteLine("2) Área y perímetro de un círculo");
                Console.WriteLine("3) Área y perímetro de un triángulo");
                Console.WriteLine();
                Console.WriteLine("4) Salir");
                Console.WriteLine();
                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        PantallaPunto.MostrarPantalla();
                        break;
                    case "2":
                        PantallaCirculo.MostrarPantalla();
                        break;
                    case "3":
                        PantallaTriangulo.MostrarPantalla();
                        break;
                    case "4":
                        salir = true;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción válida.");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}