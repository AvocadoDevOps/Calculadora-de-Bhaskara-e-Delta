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
            double A2, B2, C2;
            double DELTA, BHASKARAPOSITIVO, BHASKARANEGATIVO, RAIZ1, t1, t2, d1;
            A2 = double.Parse(A.Text);
            B2 = double.Parse(B.Text);
            C2 = double.Parse(C.Text);
            DELTA = B2 * B2 - 4 * A2 * C2;
            RAIZ1 = Math.Sqrt(DELTA);
            BHASKARAPOSITIVO = -B2 + RAIZ1;
            d1 = 2 * A2;
            t1 = BHASKARAPOSITIVO / d1;
            BHASKARANEGATIVO = -B2 - RAIZ1;
            t2 = BHASKARANEGATIVO / d1;
            MessageBox.Show("Resultado de Delta é: " + DELTA, "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("Resultado de Bhaskara Positivo é: " + t1, "Resultado", MessageBoxButtons.OK);
            MessageBox.Show("Resultado de Bhaskara Negativo é: " + t2, "Resultado", MessageBoxButtons.OK);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    

    

