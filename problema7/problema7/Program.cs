using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(12, "JOSE", 976162831, 3500);
            Console.WriteLine("Datos iniciales del empleado");
            ListarEmpleado(empleado);

            Console.WriteLine("presione cualquier tecla para procesar");
            Console.ReadKey();

            empleado.Numerodecelular = 999877212;
            empleado.Sueldoensoles += 200;

            Console.WriteLine("\nDespués de modificar el número de celular y el sueldo:");
            ListarEmpleado(empleado);
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ListarEmpleado (Empleado empleado)
        {
            Console.WriteLine($"codigo : {empleado.Codigo} ");
            Console.WriteLine($"nombre : {empleado.Nombre} ");
            Console.WriteLine($"numero de celular : {empleado.Numerodecelular}");
            Console.WriteLine($"sueldo en soles : {empleado.Sueldoensoles}");
            Console.WriteLine($"estado de sueldo : {empleado.Estadosueldo()}");
        }
    }
}
