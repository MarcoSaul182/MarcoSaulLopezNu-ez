using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace actividades.Modelo.Campeonato
{
    class CampeonatoC
    {
        private string path = @"C:\\temp\\campeonato.txt";
        private int _id;
        private String _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechafin;

        public CampeonatoC()
        {
        }
        public override string ToString()
        {
            return _id + "|" + _nombre + "|" + _fechaInicio.ToString("dd/MM/yyyy") + "|" + _fechafin.ToString("dd/MMM/yyyy");



       
        }
    }
}
