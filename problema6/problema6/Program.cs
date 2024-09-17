using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Paciente con datos fijos
            Paciente paciente = new Paciente("Juan", "Pérez", 17, 1.75, 70.5);

            Console.WriteLine("Datos iniciales del paciente:");
            ListarPaciente(paciente);

            Console.WriteLine("\nPresione cualquier tecla para procesar...");
            Console.ReadKey();

            // Modificar la edad del paciente
            paciente.Edad = 18;

            Console.WriteLine("\nDespués de modificar la edad:");
            ListarPaciente(paciente);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ListarPaciente(Paciente paciente)
        {
            Console.WriteLine($"Nombre: {paciente.Nombre}");
            Console.WriteLine($"Apellido: {paciente.Apellido}");
            Console.WriteLine($"Edad: {paciente.Edad}");
            Console.WriteLine($"Talla: {paciente.Talla:F2} m");
            Console.WriteLine($"Peso: {paciente.Peso:F2} kg");
            Console.WriteLine($"Estado: {paciente.EstadoMayoria()}");
        }
    }
}