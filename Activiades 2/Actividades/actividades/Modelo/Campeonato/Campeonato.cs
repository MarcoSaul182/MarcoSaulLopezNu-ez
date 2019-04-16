using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechainicio;
        private DateTime _fechafin;

        public Campeonato()
        {
            this._nombre = "Campeonato de la segunda division dolorense";
            this._id = 1;

            for (int i = 1; i <= 20; i++)
            {
                Jornada jornada = new Jornada();
                _jornadas.Add(jornada);
            }

        }
        public Campeonato(int id)
        {
            this._id = id;
        }
        public Campeonato(string nom,DateTime f1, DateTime f2)
        {
            this._nombre = nom;
            this._fechainicio = f1;
            this._fechafin = f2;
        }

        private List<Jornada> _jornadas = new List<Jornada>();
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
