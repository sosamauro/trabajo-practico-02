namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X1,Y1,X2,Y2;

            Console.Clear();
            Console.WriteLine("Seleccione una opción")
            Console.WriteLine("")
        
            Console.WriteLine("Ingrese el primer punto.");
            Console.Write("Coordenada en X: ");
            X1 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            Y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese el segundo punto.");
            Console.Write("Coordenada en X: ");
            X2 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            Y2 = Double.Parse(Console.ReadLine());

            var punto1 = new Punto(X1, Y1);
            var punto2 = new Punto(X2, Y2);
            var distancia = punto2.CalcularDistanciaDesde(punto1);

            Console.WriteLine();
            Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
        }
    }
}