using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_LinQ
{
    class Empleado
    {
        private long id;
        private string nombre;
        private string apellido;
        private int salario;
        private string domicilio;
        private string localidad;
        private int diasInasistencia;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Salario { get => salario; set => salario = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int DiasInasistencia { get => diasInasistencia; set => diasInasistencia = value; }
    }

}
