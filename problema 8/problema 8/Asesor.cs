using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_8
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horastrabajadas;
        private double tarifaporhora;

        public Asesor(int codigo, string nombre, int horastrabajadas, double tarifaporhora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horastrabajadas = horastrabajadas;
            this.tarifaporhora = tarifaporhora;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        { get { return nombre; }
            set { nombre = value; }
        }
        public int Horastrabajadas
        {
            get { return horastrabajadas; }
            set { horastrabajadas = value; }
        }
        public double Tarifaporhora
        {
            get { return tarifaporhora; }
            set { tarifaporhora = value; }
        }

        public double SueldoBruto()
        {
            return horastrabajadas * tarifaporhora;
        }

        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }
        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
           
            
    }
}
