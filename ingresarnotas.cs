using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa1;

namespace Programa1
{
    public partial class ingresarnotas : Form
    {
        Programa1.metodos meths = new metodos();

        double parcial_1 = 0, parcial_2 = 0, parcial_3 = 0, finalal = 0, notafinalal = 0;

        DataTable datatbl = new DataTable();
        public ingresarnotas()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = true;
            datatbl.Columns.AddRange(new DataColumn[7]{ 
           
            new DataColumn("Nombre", typeof(string)),
            new DataColumn("Clase", typeof(string)),
            new DataColumn("Parcial 1", typeof(double)),
            new DataColumn("Parcial 2", typeof(double)),
            new DataColumn("Parcial 3", typeof(double)),
            new DataColumn("Final", typeof(double)), 
            new DataColumn("Nota Final", typeof(double)) });
        }

        public void button1_Click(object sender, EventArgs e){

            notafinalal = double.Parse(txtparcial1.Text) + double.Parse(txtparcial2.Text) + double.Parse(txtparcial3.Text) + double.Parse(txtfinal.Text);
            dataGridView1.Rows.Add(txtnombrealumno.Text, txtclasealumno.Text, txtparcial1.Text, txtparcial2.Text, txtparcial3.Text, txtfinal.Text,notafinalal);

            txtnombrealumno.Clear();
            txtclasealumno.Clear();
            txtclasealumno.Clear();
            txtparcial1.Clear();
            txtparcial2.Clear();
            txtparcial3.Clear();
            txtfinal.Clear();
        }


        //ignorar esto...
     /*   private void button2_Click(object sender, EventArgs e)
        {

           dataGridView1[6, dataGridView1.Rows.Count + 1].Value = "nombrealumno";
                      
           foreach (DataGridViewRow item in dataGridView1.Rows) {
                int n = item.Index;
                dataGridView1.Rows[n].Cells[6].Value = 
                    (Double.Parse(dataGridView1.Rows[n].Cells[2].Value.ToString()) +
                    Double.Parse(dataGridView1.Rows[n].Cells[3].Value.ToString()) +
                    Double.Parse(dataGridView1.Rows[n].Cells[4].Value.ToString())+
                    Double.Parse(dataGridView1.Rows[n].Cells[5].Value.ToString())).ToString();
                
                
            }
            
        }*/

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Nombre") {
                double.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                double.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                double.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                double.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                notafinalal = parcial_1 + parcial_2 + parcial_3 + finalal;
                dataGridView1.Rows[e.RowIndex].Cells[7].Value = notafinalal;
            }
        }
        }
    }