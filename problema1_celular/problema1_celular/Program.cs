using System;

namespace semana_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(123456789, "Juan Pérez", 100, 0.5);

            Console.WriteLine("Presione cualquier tecla para procesar...");
            Console.ReadKey();

            Listado(celular);

            celular.SegundosConsumidos += 20;
            celular.PrecioPorSegundo *= 0.95;

            Console.WriteLine("\nDespués de modificar los datos:");
            Listado(celular);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void Listado(Celular celular)
        {
            Console.WriteLine($"Número: {celular.Numero}");
            Console.WriteLine($"Usuario: {celular.Usuario}");
            Console.WriteLine($"Segundos consumidos: {celular.SegundosConsumidos}");
            Console.WriteLine($"Precio por segundo: {celular.PrecioPorSegundo:C}");
            Console.WriteLine($"Costo por consumo: {celular.CostoPorConsumo():C}");
            Console.WriteLine($"Impuesto IGV: {celular.ImpuestoPorIGV():C}");
            Console.WriteLine($"Total a pagar: {celular.TotalAPagar():C}");
        }
    }
}