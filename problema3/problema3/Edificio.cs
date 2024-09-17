using System;

namespace semana_02
{
    class Edificio
    {
        private int codigo;
        private int numeroDepartamentos;
        private int cantidadPisos;
        private double precioDepartamento;

        public Edificio(int codigo, int numeroDepartamentos, int cantidadPisos, double precioDepartamento)
        {
            this.codigo = codigo;
            this.numeroDepartamentos = numeroDepartamentos;
            this.cantidadPisos = cantidadPisos;
            this.precioDepartamento = precioDepartamento;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int NumeroDepartamentos
        {
            get { return numeroDepartamentos; }
            set { numeroDepartamentos = value; }
        }

        public int CantidadPisos
        {
            get { return cantidadPisos; }
            set { cantidadPisos = value; }
        }

        public double PrecioDepartamento
        {
            get { return precioDepartamento; }
            set { precioDepartamento = value; }
        }

        public double PrecioEdificio()
        {
            return numeroDepartamentos * precioDepartamento;
        }
    }
}