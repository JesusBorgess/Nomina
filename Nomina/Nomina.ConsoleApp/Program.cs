using Nominal.Model;

Console.WriteLine("Demostracion de relacion de erencia en una nomina./n");

List<Empleado> empleados = new List<Empleado>();
empleados.Add(new EmpleadoDeBase("Maria", "Moreno", "Moma19570824ABC", new DateTime(2016, 6, 16), 350.0m));
empleados.Add(new EmpleadoDeBase("Alberto", "Arjona", "ARALI19970314DEF", new DateTime(2022, 1, 1), 300.0m));
empleados.Add(new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new DateTime(2020, 1, 1)));
empleados.Add(new EmpleadoConComision("Josefina", "Juarez", "JUJO19950915JKL", new DateTime(2021, 3, 16)));

//for (int i = 0; i < empleados.Count; i++)
//{
//    ImprimirInfoDelEmpleado(empleados[i]);
//}
//Console.WriteLine();

foreach (var empleado in empleados)
{
    ImprimirInfoDelEmpleado(empleado);
}

//EmpleadoDeBase empleadoDeBase1 = new EmpleadoDeBase("Maria", "Moreno", "Moma19570824ABC", new DateTime(2016, 6, 16), 350.0m);
//ImprimirInfoDelEmpleado(empleadoDeBase1);
////ImprimirInfoDeBase(empleadoDeBase1);
//Console.WriteLine();

//Console.WriteLine();
//EmpleadoDeBase empleadoDeBase2 = new EmpleadoDeBase("Alberto", "Arjona", "ARALI19970314DEF", new DateTime(2022, 1, 1), 300.0m);
////ImprimirInfoDeBase(empleadoDeBase2);
//ImprimirInfoDelEmpleado(empleadoDeBase2);
//Console.WriteLine();

//EmpleadoConComision empleadoConComision1 = new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new DateTime(2020, 1, 1));
//empleadoConComision1.ImporteTotalDeVentas = 33250.0M;
//ImprimirInfoDelEmpleado(empleadoConComision1);

////ImprimirInfoDeEmpleadoConComicion(empleadoConComision1);
//Console.WriteLine();


//EmpleadoConComision empleadoConComision2 = new EmpleadoConComision("Josefina", "Juarez", "JUJO19950915JKL", new DateTime(2021, 3, 16));
//empleadoConComision2.ImporteTotalDeVentas = 23345.0M;
//ImprimirInfoDelEmpleado(empleadoConComision2);

//ImprimirInfoDeEmpleadoConComicion(empleadoConComision2);

void ImprimirInfoDelEmpleado(Empleado empleado)
{
    Console.WriteLine($"Nombre Completo: {empleado.NombreCompleto}");
    Console.WriteLine($"Rfc: {empleado.Rfc}");
    Console.WriteLine($"Fecha de Ingreso: {empleado.FechaDeIngreso}");
    Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
}

//void ImprimirInfoDeBase( EmpleadoDeBase empleadoDeBase)
//{
//    Console.WriteLine($"Nombre Completo: {empleadoDeBase.NombreCompleto}");
//    Console.WriteLine($"Rfc: {empleadoDeBase.Rfc}");
//    Console.WriteLine($"Fecha de Ingreso: {empleadoDeBase.FechaDeIngreso}");
//    Console.WriteLine($"Salario Diario: {empleadoDeBase.SalarioDiario}");
//    Console.WriteLine($"Salario Fijo del Periodo: {empleadoDeBase.CalcularSalarioFijoDelPeriodo(15)}");
//    Console.WriteLine($"Estimulo de antiguedad: {empleadoDeBase.CalcularEstimuloPorAntiguedad()}");
//    Console.WriteLine($"Salario del periodo: {empleadoDeBase.CalcularSalario()}");
//}

//void ImprimirInfoDeEmpleadoConComicion(EmpleadoConComision empleado)
//{
//    Console.WriteLine($"Nombre completo:{empleado.NombreCompleto}");
//    Console.WriteLine($"Rfc: {empleado.Rfc}");
//    Console.WriteLine($"Fecga de ingreso: {empleado.FechaDeIngreso}");
//    Console.WriteLine($"Impote total de ventas: {empleado.ImporteTotalDeVentas}");
//    Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
//}

