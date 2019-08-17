using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abaixo do peso < 19,1 < 20,7 
            //no peso normal 19,1 - 25,8 20,7 - 26,4 
            //sobrepeso 25,8 - 27,3 26,4 - 27,8 
            //acima do peso 27,3 - 32,3 27,8 - 31,1 
            //obeso > 32,3 > 31,1

            //criar as variáveis para altura e peso
            //variáveis recebem os valores dos textbox convertidos
            double altura=Double.Parse(textBox1.Text);
            double peso = Double.Parse(textBox2.Text);
            //calculo o IMC
            double IMC = peso / (altura * altura);
            //if para testar o sexo
            if (radioButton1.Checked == true)
            {
                //se feminino testar os intervalos
                if (IMC < 19.1) {
                    MessageBox.Show("abaixo do peso");
                }
                if ((IMC >= 19.1)&&(IMC<25.8))
                {
                    MessageBox.Show("no peso normal");
                }
                if ((IMC >= 25.8) && (IMC < 27.3))
                {
                    MessageBox.Show("sobrepeso");
                }
                if ((IMC >= 27.3) && (IMC < 32.3))
                {
                    MessageBox.Show("acima do peso");
                }
                if (IMC >= 32.3)
                {
                    MessageBox.Show("obeso");
                }
                //retornar uma mensagem dizendo a condição
            }
            else {
                //se masculino testar os intervalos
                if (IMC < 20.7)
                {
                    MessageBox.Show("abaixo do peso");
                }
                if ((IMC >= 20.7) && (IMC < 26.4))
                {
                    MessageBox.Show("no peso normal");
                }
                if ((IMC >= 26.4) && (IMC < 27.8))
                {
                    MessageBox.Show("sobrepeso");
                }
                if ((IMC >= 27.8) && (IMC < 31.1))
                {
                    MessageBox.Show("acima do peso");
                }
                if (IMC >= 31.1)
                {
                    MessageBox.Show("obeso");
                }
                //retornar uma mensagem dizendo a condição
            }



        }
    }
}
