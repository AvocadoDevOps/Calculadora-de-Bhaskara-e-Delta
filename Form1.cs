using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Bhaskara_e_Delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double A2, B2, C2, BHASKARA, DELTAPOSITIVO, DELTANEGATIVO;
            A2 = double.Parse(a.Text);
            B2 = double.Parse(b.Text);
            C2 = double.Parse(c.Text);
            BHASKARA = (B2 * B2) - 4 * A2 * C2;
            DELTAPOSITIVO = (- B2 + sqrt(BHASKARA)) / 2 * A2;
            DELTANEGATIVO = (-B2 - sqrt(BHASKARA)) / 2 * A2;
            MessageBox.Show("BHASKARA : " + BHASKARA, "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("DELTAPOSITIVO : " + DELTAPOSITIVO, "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("DELTANEGATIVO : " + DELTANEGATIVO, "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("FATAL ERROR: VOCE EH GAY DEMAIS", "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("VOCE ESCREVEU O NOME DA BRANCH DE DEV ERRADA", "Resultado", MessageBoxButtons.OK);
            double a, b, c, Bhaskara, Delta;

        }

        private double sqrt(double bhaskara)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

