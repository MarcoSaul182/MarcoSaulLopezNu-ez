using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using actividades.Vista;


namespace LigaFutbol

{
    static class Program
    {
        public static LigaFutbol.vista.FormaCampeonato formaCampeonato = null;
            public static LigaFutbol.vista.Principal formaPrincipal = null;
            public static LigaFutbol.vista.FormaJornada jornada = null;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormaJornada());
        }
    }
}
