using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using actividades.Modelo;

namespace actividades
{
    public partial class FormEstudiante : Form
    {
        public FormEstudiante()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Estudiante student01 = new Estudiante();
            student01.NumeroControl = 1218100521;
            student01.Nombre = "Apu Arredondo";
            student01.Edad = 22;
            student01.Genero = 'H';

            textoControl.Text = student01.NumeroControl.ToString();
            textoNombre.Text = student01.Nombre;
            textoEdad.Text = student01.Edad.ToString();
            textoGenero.Text = student01.Genero.ToString();
        }
    }
}
