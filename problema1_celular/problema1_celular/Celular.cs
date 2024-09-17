﻿using System;

namespace semana_02
{
    public class Celular
    {
        private int numero;
        private string usuario;
        private int segundosConsumidos;
        private double precioPorSegundo;

        public Celular(int numero, string usuario, int segundosConsumidos, double precioPorSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioPorSegundo = precioPorSegundo;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int SegundosConsumidos
        {
            get { return segundosConsumidos; }
            set { segundosConsumidos = value; }
        }

        public double PrecioPorSegundo
        {
            get { return precioPorSegundo; }
            set { precioPorSegundo = value; }
        }

        public double CostoPorConsumo()
        {
            return segundosConsumidos * precioPorSegundo;
        }

        public double ImpuestoPorIGV()
        {
            return CostoPorConsumo() * 0.18;
        }

        public double TotalAPagar()
        {
            return CostoPorConsumo() + ImpuestoPorIGV();
        }
    }
}
