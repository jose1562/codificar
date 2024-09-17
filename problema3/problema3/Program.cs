using semana_02;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Edificio edificio = new Edificio(100,100,230,1000);

        Console.WriteLine("\nPresione cualquier tecla para procesar...");
        Console.ReadKey();

        Listado(edificio);

        edificio.PrecioDepartamento *= 1.2; // Incremento del 20%

        Console.WriteLine("\nDespués de incrementar el precio en 20%:");
        Listado(edificio);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void Listado(Edificio edificio)
    {
        Console.WriteLine("\nDatos del Edificio:");
        Console.WriteLine($"Código: {edificio.Codigo}");
        Console.WriteLine($"Número de departamentos: {edificio.NumeroDepartamentos}");
        Console.WriteLine($"Cantidad de pisos: {edificio.CantidadPisos}");
        Console.WriteLine($"Precio de un departamento: ${edificio.PrecioDepartamento:F2}");
        Console.WriteLine($"Precio total del edificio: ${edificio.PrecioEdificio():F2}");
    }
}
