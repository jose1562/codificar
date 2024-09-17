namespace problema7
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int numerodecelular;
        private double sueldoensoles;

        public Empleado(int codigo, string nombre, int numerodecelular, double sueldoensoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numerodecelular = numerodecelular;
            this.sueldoensoles = sueldoensoles;
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
        public int Numerodecelular
        {
            get { return numerodecelular; }
            set { numerodecelular = value; }
        }
        public double Sueldoensoles
        {
            get { return sueldoensoles; }
            set { sueldoensoles = value; }
        }


        public string Estadosueldo()
        {
            if (sueldoensoles > 3500)
                return "mayor que 3500";
            else if (sueldoensoles < 3500)
                return "menor que 3500";
            else
                return "igual que a 3500";
        }
    }

}
