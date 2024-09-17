using System;

namespace semana_02
{
    public class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double precioDolares;

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double PrecioDolares
        {
            get { return precioDolares; }
            set { precioDolares = value; }
        }

        public double PrecioSoles()
        {
            return precioDolares * 3.35;
        }

        public double PrecioEuros()
        {
            return precioDolares / 1.20;
        }
    }
}


