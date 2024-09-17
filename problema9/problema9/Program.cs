using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema9
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         // Crear un objeto Pelota con datos fijos
           Pelota pelota = new Pelota("Nike", 450, 8.5, 22, 89.99);

        Console.WriteLine("Datos iniciales de la pelota:");
            ListarPelota(pelota);

        Console.WriteLine("\nPresione cualquier tecla para procesar...");
            Console.ReadKey();

            // Disminuir en 25% el precio y aumentar en 1 centímetro el diámetro
            pelota.Precio *= 0.75; // Disminuir en 25%
            pelota.DiametroCm += 1;

            Console.WriteLine("\nDespués de modificar el precio y el diámetro:");
            ListarPelota(pelota);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

    static void ListarPelota(Pelota pelota)
    {
        Console.WriteLine($"Marca: {pelota.Marca}");
        Console.WriteLine($"Peso: {pelota.PesoGramos} gramos");
        Console.WriteLine($"Presión: {pelota.PresionLibras} libras");
        Console.WriteLine($"Diámetro: {pelota.DiametroCm} cm");
        Console.WriteLine($"Radio: {pelota.Radio():F2} cm");
        Console.WriteLine($"Volumen: {pelota.Volumen():F2} cm³");
        Console.WriteLine($"Precio: S/ {pelota.Precio:F2}");
        Console.WriteLine($"Descuento: S/ {pelota.Descuento():F2}");
        Console.WriteLine($"Importe a pagar: S/ {pelota.ImportePagar():F2}");
    }
}
}
