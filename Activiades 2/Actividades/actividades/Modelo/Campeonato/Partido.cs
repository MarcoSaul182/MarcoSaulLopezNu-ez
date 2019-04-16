using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Campeonato
{
    class Partido
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private bool _isFinalizado;
        private string _observaciones;
        //Se asocia con clase cancha
        private Cancha _cancha;
        //Se asocia Partido con dos Equipos
        private Equipo _local;
        private Equipo _visitante;
        //Se asocia con clase arbitro
        private Arbitro _arbitro;
        private Arbitro _arb1;
        private Arbitro _arb2;
        public Partido()
        {
            this._isFinalizado = false;
            this._id = 1;
            Random alea = new Random();
            int dia = alea.Next(1,31);
            this._fecha = new DateTime(2019,3,dia,16,0,0);
        }

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this._local = equipo1;
            this._visitante = equipo2;
        }
        public void addCancha(Cancha cancha)
        {
            this._cancha = cancha;
        }
        //Se asocia con clase arbitro
        private Arbitro _arbitro1;
        private Arbitro _arbitro2;
        //Private Arbitro() arbitros;
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool IsFinalizado { get; set; }
        public string Observaciones { get; set; }

        public void addArbitro(Arbitro arb)
        {
            this._arbitro = arb;
        }
        public void setarbitros(Arbitro arb1, Arbitro arb2)
        {
            this._arb1 = arb1;
            this._arb2 = arb2;
        }
       
    }
}
