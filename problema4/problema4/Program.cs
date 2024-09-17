using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obrero = new Obrero(1001, "Juan Pérez", 40, 15.50);
            Console.WriteLine("Datos iniciales del obrero:");
            ListarObrero(obrero);

            Console.WriteLine("\nPresione cualquier tecla para procesar...");
            Console.ReadKey();

            // Aumentar en 8 las horas trabajadas
            obrero.Horastrabajadas += 8;

            // Disminuir en 1.5% la tarifa por hora
            obrero.Tarifaporhora *= 0.985;

            Console.WriteLine("\nDespués de modificar horas y tarifa:");
            ListarObrero(obrero);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ListarObrero(Obrero obrero)
        {
            Console.WriteLine($"Código: {obrero.Codigo}");
            Console.WriteLine($"Nombre: {obrero.Nombre}");
            Console.WriteLine($"Horas trabajadas: {obrero.Horastrabajadas}");
            Console.WriteLine($"Tarifa por hora: ${obrero.Tarifaporhora:F2}");
            Console.WriteLine($"Sueldo bruto: ${obrero.sueldobruto():F2}");
            Console.WriteLine($"Descuento AFP: ${obrero.descuentoporAFP():F2}");
            Console.WriteLine($"Descuento EPS: ${obrero.descuentoporEPS():F2}");
            Console.WriteLine($"Sueldo neto: ${obrero.sueldoneto():F2}");
        }
    }
}

        
