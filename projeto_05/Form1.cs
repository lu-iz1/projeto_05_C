using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_05
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

        private void button1_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            double imc;

            peso = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);
            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                label3.Text = "Seu imc é: " + imc + "Você está classificado como Desnutrido";
            }
            else if (imc < 25)
            {
                label3.Text = "Seu imc é: " + imc + "Você está classificado como Adequado";
            }
            else if (imc < 30)
            {
                label3.Text = "Seu imc é: " + imc + "Você está classificado como Pré-Obeso";
            }
            else if (imc < 35)
            {
                label3.Text = "Seu imc é: " + imc + "Você está classificado como Obesidade Nível I";
            }
            else
                label3.Text = "Seu imc é: " + imc + "Você está classificado como Obesidade Nível II";

        }
    }
}
