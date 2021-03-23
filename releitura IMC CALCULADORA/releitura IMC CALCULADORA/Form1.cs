using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace releitura_IMC_CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float peso;
        float altura;
        float res;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(textBox1.Text);
            float altura = float.Parse(textBox2.Text);
            float resultado = peso / (altura * altura);
            textBox3.Text = resultado.ToString();
            

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
