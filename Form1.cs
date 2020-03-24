using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Programa1
{
    public partial class Form1 : Form
    {


        public static string nombre_catedratico;
        public static string clase_catedratico;

               
        static void Camponulo(string s) {
            if (s == null) {
                throw new ArgumentNullException();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            nombre_catedratico = txtnomcat.Text;
            clase_catedratico = txtclass.Text;


            if ((nombre_catedratico.Trim().Equals("")) || (clase_catedratico.Trim().Equals(""))){
                MessageBox.Show("Asegurese que lleno ambos campos.\n\nAlguno de los campos estan incompletos.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                this.Hide();
                main_op mop = new main_op();
                mop.Show();

            }
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
