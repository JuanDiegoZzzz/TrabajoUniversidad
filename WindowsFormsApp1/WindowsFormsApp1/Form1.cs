using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("¿Quiere salir de la aplicacion", "Registro de Contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)

            {

                Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            int n = dataGridView1.Rows.Add();// agregando filas en "n
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;//guardando
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            textBox1.Text = " " ;//borrando espacios de texto
            textBox2.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";




        }
    }
}
