using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    internal class Video
    {
        private int codigo;
        private string nombredelvideo;
        private double duracion;
        private double precioensoles;
        private double tipodecambio;


        public Video(int codigo, string nombredelvideo, double duracion, double precioensoles,double tipodecambio)
        {
            this.codigo = codigo;
            this.nombredelvideo = nombredelvideo;
            this.duracion = duracion;
            this.precioensoles = precioensoles;
            this.tipodecambio = tipodecambio;   
        }

        public int Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }
        public string Nombredelvideo
        {
            get { return nombredelvideo; }
            set { nombredelvideo = value; }
        }
        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public double Precioensoles
        {
            get { return precioensoles; }
            set { precioensoles = value; }
        }
        public double TipoCambio
        { get { return tipodecambio; } set { tipodecambio = value; } }

         public double preciovideoendolares()
        {
            return precioensoles / tipodecambio;
        }

    }
}
