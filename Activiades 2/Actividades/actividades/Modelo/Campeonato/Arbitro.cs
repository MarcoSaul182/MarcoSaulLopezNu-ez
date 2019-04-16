using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Campeonato
{
    class Arbitro
    {
        private int _añosexperiencia;
        private bool _tienengafete;
        private Partido _addobservaciones;
        private Partido _setisfinalizado;

        public void addObservaciones(Partido observ)
        {
            this._addobservaciones = observ;
        }
        public void setisFinalizado(Partido isfinal)
        {
            this._setisfinalizado = isfinal;
        }
    }
}
