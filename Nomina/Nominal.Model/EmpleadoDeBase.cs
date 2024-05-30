namespace Nominal.Model
{
    public class EmpleadoDeBase : Empleado
    {
        public readonly decimal EstimuloPorAniosTrabajados = 50.0m;
        public readonly int MinimoDeAniosSinRecibirEstimulo = 5;
        public readonly int NumeroDeDiasDelPeriodo = 15;

        public decimal SalarioDiario { get; set; }

        public EmpleadoDeBase (string nombre, string apellido, string rfc, DateTime fechaDeIngreso, 
            decimal salarioDiario) :
            base(nombre, apellido, rfc, fechaDeIngreso)
        {
            SalarioDiario = salarioDiario;
        }

        public decimal CalcularSalarioFijoDelPeriodo(int numeroDeDiasTrabajados)
        {
            return SalarioDiario * numeroDeDiasTrabajados;
        }
        public decimal CalcularEstimuloPorAntiguedad()
        {
          int aniosLaborados = 0;
          decimal estimulo = 0;

          if (FechaDeIngreso < DateTime.Now)
          {
                DateTime momentoCero = new DateTime(1, 1, 1);
                TimeSpan lapso = DateTime.Now - FechaDeIngreso;
                aniosLaborados = (momentoCero + lapso).Year - 1;
          }
          if (aniosLaborados > MinimoDeAniosSinRecibirEstimulo)
          {
                estimulo = (aniosLaborados - MinimoDeAniosSinRecibirEstimulo) * EstimuloPorAniosTrabajados;
          }
            return estimulo;
        }

        
        //public new decimal CalcularSalario()
        //{
        //return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) + CalcularEstimuloPorAntiguedad();
        //}

        public override decimal CalcularSalario()
        {
         return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) + CalcularEstimuloPorAntiguedad();
        }



    }
}
