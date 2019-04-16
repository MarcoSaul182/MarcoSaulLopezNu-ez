using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividades.Vista
{
    public partial class FormaJornada : Form
    {
        public FormaJornada()
        {
            InitializeComponent();
        }

        private void FormaJornada_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = System.Drawing.Color.Pink;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonCampeonato_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCampeonato_Click(object sender, EventArgs e)
        {
            LigaFutbol.Program.formaCampeonato.Show(); //Mostrar Ventana
            Hide(); //Esconde la ventana actual
        }
    }
}
