using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema9
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos;
        private double presionLibras;
        private double diametroCm;
        private double precio;

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCm, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCm = diametroCm;
            this.precio = precio;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double PesoGramos
        {
            get { return pesoGramos; }
            set { pesoGramos = value; }
        }

        public double PresionLibras
        {
            get { return presionLibras; }
            set { presionLibras = value; }
        }

        public double DiametroCm
        {
            get { return diametroCm; }
            set { diametroCm = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double Radio()
        {
            return diametroCm / 2;
        }

        public double Volumen()
        {
            double radio = Radio();
            return 4 * Math.PI * Math.Pow(radio, 3) / 3;
        }

        public double Descuento()
        {
            return precio * 0.10;
        }

        public double ImportePagar()
        {
            return precio - Descuento();
        }
    }
}

