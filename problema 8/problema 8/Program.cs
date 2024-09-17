using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor asesor = new Asesor(10,"josesito",100,0.75);
            Console.WriteLine("Datos iniciales del asesor:");
            ListarAsesor(asesor);

            Console.WriteLine("\nPresione cualquier tecla para procesar...");
            Console.ReadKey();

            // Aumentar en 10 el número de horas y disminuir en 15% la tarifa
            asesor.Horastrabajadas += 10;
            asesor.Tarifaporhora *= 0.85; // Disminuir en 15%

            Console.WriteLine("\nDespués de modificar las horas y la tarifa:");
            ListarAsesor(asesor);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ListarAsesor(Asesor asesor)
        {
            Console.WriteLine($"Código: {asesor.Codigo}");
            Console.WriteLine($"Nombre: {asesor.Nombre}");
            Console.WriteLine($"Horas trabajadas: {asesor.Horastrabajadas}");
            Console.WriteLine($"Tarifa por hora: S/ {asesor.Tarifaporhora:F2}");
            Console.WriteLine($"Sueldo bruto: S/ {asesor.SueldoBruto():F2}");
            Console.WriteLine($"Descuento: S/ {asesor.Descuento():F2}");
            Console.WriteLine($"Sueldo neto: S/ {asesor.SueldoNeto():F2}");
        }
    }
}
