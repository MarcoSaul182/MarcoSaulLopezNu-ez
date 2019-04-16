using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Campeonato
{
    class Jugador
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private byte _numero;
        private Equipo _idEquipo;

        public Jugador()
        {
            this._nombre = "Link";
            this._apellidos = "Hyrule";
            this._fechaNacimiento = DateTime.Today;
        }
        public int Id
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public string Apellidos
        {
            get;
            set;
        }
        public DateTime FechaNacimiento
        {
            get;
            set;
        }
        public byte Numero
        {
            get;
            set;
        }
        public Equipo IdEquipo
        {
            get
            {
                return this._idEquipo;
            }
            set
            {
                if(value != null || !((Equipo)value).Nombre.ToLower().Equals("irapuato"))
                {
                    this._idEquipo = value;
                }    
            }
        }
    }
}
