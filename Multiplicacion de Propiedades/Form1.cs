using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicacion_de_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiplicacion s = new Multiplicacion();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.Multiplicar().ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void n3_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
