using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exammen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fahrenheit_Click(object sender, EventArgs e)
        {
            double GF;
            double GC;

            GF = double.Parse(this.textBox2.Text);
            GC = 5.0 / 9.0 * (GF + 32);
            this.textBox1.Text = GC.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double GF;
            double GC;

            GC = double.Parse(this.textBox2.Text);
            GF = (GC * 9 / 5) + 32;
            this.textBox1.Text = GF.ToString();
        }
    }
}
