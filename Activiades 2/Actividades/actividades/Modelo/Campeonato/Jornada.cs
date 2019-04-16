using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Campeonato
{
    class Jornada
    {
        //propiedades
        private int _id;
        private DateTime _fechainicio;
        private DateTime _fechafin;
        private bool _isConcluida;

        //constructor
        public Jornada()
        {
            this._fechainicio = DateTime.Today;
            this._isConcluida = false;
        }

        //Metodos Getter`s y Setter`s
        public int Id { get; set; }
        public DateTime Fechainicio
        {
            get { return this._fechainicio; }
            set
            {
                if(value > DateTime.Today)
                {
                    this._fechainicio = value;
                }
            }
        }
        public DateTime FechaFin
        {
            get
            {
                return this._fechafin;
            }
            set
            {
                DateTime Fin = new DateTime(2019,4,8);
                if(value <= Fin)
                {
                    this._fechafin = value;
                }
            }
        }
        public bool IsConcluida { get; set; }
    }
}
