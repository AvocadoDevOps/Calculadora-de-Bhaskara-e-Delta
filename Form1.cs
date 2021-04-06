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
<<<<<<< HEAD
            double A2, B2, C2, DELTA, BHASKARAPOSITIVO, BHASKARANEGATIVO;
            A2 = double.Parse(A.Text);
            B2 = double.Parse(B.Text);
            C2 = double.Parse(C.Text);
            DELTA = B2 * B2 - 4 * A2 * C2;
            MessageBox.Show("O valor de Delta é: " + DELTA, "Resultado", MessageBoxButtons.OK);
            BHASKARAPOSITIVO = -B2 + Math.Sqrt(DELTA) / 2 * A2;
            MessageBox.Show("O valor de Bhaskara Positiva é: " + BHASKARAPOSITIVO, "Resultado", MessageBoxButtons.OK);
            BHASKARANEGATIVO = -B2 - Math.Sqrt(DELTA) / 2 * A2;
            MessageBox.Show("O valor de Bhaskara Negativa é: " + BHASKARANEGATIVO, "Resultado", MessageBoxButtons.OK);
        }
=======
            double a, b, c, bsk, dlt;
>>>>>>> f9d659a0bf41c3b3179c0904231aa43fffe1f377

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

    

