using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Cinema
{
    class Empleado : Persona
    {
        protected int _numeroEmpleado;
        protected string _tipoEmpleado;

        public Empleado() :base()
        {
            _id = 1;
        }
        public Empleado(int numero, string tipo)
        {
            _numeroEmpleado = numero;
            _tipoEmpleado = tipo;
        }
        public string NumeroEmpleado
        {
            get; set;
        }
        public string TipoEmpleado { get; set; }
        public override string ToString()
        {
            return base.ToString() + "|Numero de Empleado: " + _numeroEmpleado + " |Tipo Empleado: " + _tipoEmpleado;
        }
    }
}
