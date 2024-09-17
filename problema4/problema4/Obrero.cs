using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horastrabajadas;
        private double tarifaporhora;



        public Obrero(int codigo, string nombre, int horastrabajadas, double tarifaporhora)
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
        {
            get { return nombre; }
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
        

        public double sueldobruto()
        {
            return horastrabajadas * tarifaporhora;
        }

        public double descuentoporAFP()
        {
            return sueldobruto() * 0.10;
        }
        public double descuentoporEPS()
        {
            return sueldobruto() * 0.05;
        }
        public double sueldoneto()
        {
            return sueldobruto() - descuentoporAFP() - descuentoporEPS(); 
        }
    }
}
