namespace Nominal.Model
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Rfc { get; set; }

        public DateTime FechaDeIngreso { get; set; }

        public string NombreCompleto =>$" {Nombre}{Apellido}";

        public Empleado(string nombre, string apellido, string rfc, DateTime fechaDeIngreso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rfc = rfc;
            FechaDeIngreso = fechaDeIngreso;
        }

        public abstract Decimal CalcularSalario();
       

    }
}
