using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa1
{
    public partial class main_op : Form
    {
   
        public main_op()
        {
            InitializeComponent();
        }

         
private void main_op_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ingresarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresarnotas ingnotas = new ingresarnotas();
            ingnotas.ShowDialog();
        }

        private void mostrarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarnotas mostnotas = new mostrarnotas();
            mostnotas.ShowDialog();
        }
    }
}
