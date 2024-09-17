using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(1001, "Tutorial de C#", 120.5, 99.99, 3.7);
            Console.WriteLine("Datos Iniciales del video: ");
            ListarVideo(video);

            Console.WriteLine("\npresione cualquier tecla para presionar.....");
            Console.ReadKey();

            video.Precioensoles += 5.50;

            Console.WriteLine("\nDespués de aumentar el precio en 5.50 soles:");
            ListarVideo( video );

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
        static void ListarVideo(Video video)
        {
            Console.WriteLine($"codigo: {video.Codigo}");
            Console.WriteLine($"Nombre del Video : {video.Nombredelvideo}");
            Console.WriteLine($"Duracion : {video.Duracion}");
            Console.WriteLine($"precio en Soles : {video.Precioensoles}");
            Console.WriteLine($"precio en dolares : {video.preciovideoendolares()}");
            Console.WriteLine($"tipo de cambio : {video.TipoCambio}");
        }
    }
}
