using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace José_Manuel_Quintanar_Alvarado
{
    public partial class Form1 : Form
    {
        int contador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador <= 25)
            {
                textBox1.Text = Convert.ToString(contador);
                contador += 1;
            }
            else
            {
                MessageBox.Show("Límite de números: 25");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("La casilla está vacía");
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
