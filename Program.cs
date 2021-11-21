using System;
using System.Collections.Generic;
using System.Linq;

namespace Master_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Empleado> empleados = new List<Empleado>() {
             new Empleado() { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio = "Salta 314", Localidad = "Ciudad", Salario = 30000, DiasInasistencia = 0 } ,
             new Empleado() { Id = 2, Nombre = "Pedro", Apellido = "Hernandez", Domicilio = "SanMartin 456", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 1 } ,
             new Empleado() { Id = 3, Nombre = "Jose", Apellido = "Chatruc", Domicilio = "Lavalle789", Localidad = "Lujan", Salario = 28000, DiasInasistencia = 12 } ,
             new Empleado() { Id = 4, Nombre = "Carlos" , Apellido = "Alonso", Domicilio = "Rioja14", Localidad = "Guaymallen", Salario = 45000, DiasInasistencia = 5 } ,
             new Empleado() { Id = 5, Nombre = "Claudio" , Apellido = "Ahumada", Domicilio = "Lima125", Localidad = "Tupungato", Salario = 38000, DiasInasistencia = 0 } ,
             new Empleado() { Id = 5, Nombre = "Sebastian" , Apellido = "Tobar", Domicilio = "Rawson123", Localidad = "Lujan", Salario = 42000, DiasInasistencia = 2 } ,
             new Empleado() { Id = 5, Nombre = "Javier" , Apellido = "Puebla", Domicilio = "Italia987", Localidad = "Ciudad", Salario = 33000, DiasInasistencia = 4 } ,
             new Empleado() { Id = 5, Nombre = "Fabian" , Apellido = "Gilar", Domicilio = "Las Viñas987", Localidad = "Guaymallen", Salario = 38000, DiasInasistencia = 0 } ,
             new Empleado() { Id = 5, Nombre = "Victor" , Apellido = "Pereira", Domicilio = "25 deMayo 654", Localidad = "Tupungato", Salario = 37000, DiasInasistencia = 8 } ,
             new Empleado() { Id = 5, Nombre = "Nelson" , Apellido = "Piquet", Domicilio = "Peru987", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 3 }
            };

            //Filtrado por Empleados de Ciudad
            Console.WriteLine("Empleados de ciudad");
            List<Empleado> empleadosFiltrados = (from emp in empleados where (emp.Localidad == "Ciudad") select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Apellido inicie con A
            Console.WriteLine("Empleados cuyo apellido empiece con A");
            empleadosFiltrados = (from emp in empleados where (emp.Apellido.ToLower()[0] == 'a') select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);


            //Empleados que no tengan inacistencias laborales
            Console.WriteLine("Empleados que no tengan inasistencias laborales");
            empleadosFiltrados = (from emp in empleados where (emp.DiasInasistencia == 0) select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Empleados que sean de ciudad y cuyo salario sea mayor 35000
            Console.WriteLine("Empleados que sean de ciudad y cuyo salario sea mayor 35000");
            empleadosFiltrados = (from emp in empleados where (emp.Localidad.ToLower() == "ciudad" && emp.Salario > 35000) select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Empleados que terminen con n
            Console.WriteLine("Empleados que terminen con n");
            empleadosFiltrados = (from emp in empleados where (emp.Nombre[^1] == 'n') select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Seleccione todos los empleados ordenados por salario en forma ascendente.
            Console.WriteLine("Seleccione todos los empleados ordenados por salario en forma ascendente");
            empleadosFiltrados = (from emp in empleados orderby emp.Salario ascending select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Seleccione todos los empleados ordenados por salario en forma ascendente.
            Console.WriteLine("Seleccione todos los empleados ordenados por dias de inacistencia de forma desendente");
            empleadosFiltrados = (from emp in empleados orderby emp.DiasInasistencia descending select emp).ToList();
            MostrarEmpleados(empleadosFiltrados);

            //Seleccione todos los empleados ordenados por salario en forma ascendente.
            Console.WriteLine("Seleccione todos los empleados ordenados por dias de inacistencia de forma desendente");
            var empleadosGroup = (from emp in empleados group emp by new { emp.Localidad } into totals  select totals).ToList();
            foreach(var emp in empleadosGroup)
            {
                Console.WriteLine(emp.Key.Localidad);
            }

            //Seleccione todos los empleados ordenados por salario en forma ascendente.
            Console.WriteLine("Seleccione todos los empleados ordenados por dias de inacistencia de forma desendente");
            List<int> salariosDeEmpleados = (from emp in empleados select emp.Salario).ToList();
            
                Console.WriteLine("total salarios:" + salariosDeEmpleados.Sum());
                Console.WriteLine("maximo salario:" + salariosDeEmpleados.Max()); // maximo
                Console.WriteLine("promedio salarios:" + salariosDeEmpleados.Average()); // promedio
                Console.WriteLine("1ro lista:" + salariosDeEmpleados.First()); //
            
        }

        public static void MostrarEmpleados(List<Empleado> empleados)
        {
            Console.WriteLine("Nombre - Apellido - Salario - Localidad - Domicilio - Dias Inacistencia");
            foreach (Empleado em in empleados)
                Console.WriteLine(em.Nombre + " - "+ em.Apellido +" - " + em.Salario + " - " + em.Localidad + " - " +em.Domicilio +" - " + em.DiasInasistencia);
            Console.WriteLine("\n\n");
        }
    }
}
