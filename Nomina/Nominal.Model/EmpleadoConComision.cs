using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nominal.Model
{
    public class EmpleadoConComision : Empleado
    {
        public decimal ImporteTotalDeVentas { get; set; } = decimal.Zero;

        public EmpleadoConComision(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso)
            : base(nombre, apellidos, rfc, fechaDeIngreso)
        {

        }

        public decimal CalcularComision()
        {
            return ImporteTotalDeVentas * PorcentajeDeComicion() / 100;
        }
        private decimal PorcentajeDeComicion()
        {
            if (ImporteTotalDeVentas < 10000M)
            {
                return 0.0M;
            }
            if (ImporteTotalDeVentas < 20000M)
            {
                return 10.0M;
            }
            if (ImporteTotalDeVentas < 30000)
            {
                return 15.0M;
            }
            if (ImporteTotalDeVentas < 40000)
            {
                return 20.0M;
            }
            return 30.0M;
        }
        //public new decimal CalcularSalario()
        //{
        //return CalcularComision();
        //}

        public override decimal CalcularSalario()
        {
            return CalcularComision();
        }

    }
}
