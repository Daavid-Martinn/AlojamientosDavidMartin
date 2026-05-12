using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlojamientosDavid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formularioPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConsultasGenerales().Show();
        }

        private void verReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormularioVerReservas().Show();
        }

        private void verPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormularioVerPagos().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
