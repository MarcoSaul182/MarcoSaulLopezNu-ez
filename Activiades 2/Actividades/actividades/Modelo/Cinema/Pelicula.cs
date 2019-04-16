using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Cinema
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private byte _duracion;
        private string _clasificacion;
        private string _genero;
        private string _idioma;
        private string _resumen;

        public Pelicula() : base()
        {
            _id = 1;
        }
        public Pelicula(string nombre)
        {
            _nombre = nombre;
        }
        public Pelicula(string nombre,string director)
        {
            _nombre = nombre;
            _director = director;
        }

        public string Duracion
        {
            get;
            set;
        }
    }
}
