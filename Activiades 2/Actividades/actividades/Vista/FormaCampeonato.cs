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
    public partial class FormaCampeonato : Form
    {
        public FormaCampeonato()
        {
            InitializeComponent();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {

            Program.formaPrincipal.Show();
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
