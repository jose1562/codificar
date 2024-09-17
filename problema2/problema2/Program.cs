using System;

namespace semana_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(1001, "Dell", "Negro", 1000);

            Console.WriteLine("Presione cualquier tecla para procesar...");
            Console.ReadKey();

            Listado(computadora);

            computadora.PrecioDolares *= 0.90; // Disminuye el precio en 10%

            Console.WriteLine("\nDespués de disminuir el precio en 10%:");
            Listado(computadora);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void Listado(Computadora computadora)
        {
            Console.WriteLine($"Código: {computadora.Codigo}");
            Console.WriteLine($"Marca: {computadora.Marca}");
            Console.WriteLine($"Color: {computadora.Color}");
            Console.WriteLine($"Precio en dólares: ${computadora.PrecioDolares:F2}");
            Console.WriteLine($"Precio en soles: S/{computadora.PrecioSoles():F2}");
            Console.WriteLine($"Precio en euros: €.{computadora.PrecioEuros():F2}");
        }
    }
}