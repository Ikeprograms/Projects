using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quintanar_Alvarado_José_Manuel
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amarillo", "Botón amarillo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rojo", "Botón rojo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola!", "Saludo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Azul", "Botón azul");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verde", "Botón verde");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Morado", "Botón morado");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naranja", "Botón naranja");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rosa", "Botón rosa");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {

        }
    }
}
