using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_MATEMÁTICA
{
    public partial class Frm_Calculator : Form
    {
        // Declarando variáveis para realizar conversão de valores
        int number0, number1;        
        
        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
            Frm_Project calculadora = new Frm_Project();
            calculadora.Show();
        }

        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            // Convertendo valores para SOMAR
            number0 = int.Parse(Txt_Value1.Text);
            number1 = int.Parse(Txt_Value2.Text);
            int sum = number0 + number1;
            Txt_Sum.Text = sum.ToString();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Botão de limpar
            Txt_Value1.Clear();
            Txt_Value2.Clear();
            Txt_Sum.Clear();
            Txt_Subt.Clear();
            Txt_Mult.Clear();
            Txt_Divi.Clear();
        }

        private void Txt_Value1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Condições para digitos permitidos no VALOR 1
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                // Condição caso a telca ENTER seja pressionada sem um valor
                if(Txt_Value1.Text == "")
                {
                    MessageBox.Show("DIGITE UM VALOR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Subt_Click(object sender, EventArgs e)
        {
            // Convertendo valores para SUBTRAIR
            number0 = int.Parse(Txt_Value1.Text);
            number1 = int.Parse(Txt_Value2.Text);
            int sum = number0 - number1;
            Txt_Subt.Text = sum.ToString();
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            // Convertendo valores para MULTIPLICAR
            number0 = int.Parse(Txt_Value1.Text);
            number1 = int.Parse(Txt_Value2.Text);
            int sum = number0 * number1;
            Txt_Mult.Text = sum.ToString();
        }

        private void Btn_Divi_Click(object sender, EventArgs e)
        {
            // Convertendo valores para DIVIDIR
            number0 = int.Parse(Txt_Value1.Text);
            number1 = int.Parse(Txt_Value2.Text);
            int sum = number0 / number1;
            Txt_Divi.Text = sum.ToString();
        }

        private void Txt_Value2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Condições para digitos permitidos no VALOR 2
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            if(e.KeyChar == 13)
            {
                // Condição caso a tecla ENTER seja pressionada sem um valor
                if(Txt_Value2.Text == "")
                {
                    MessageBox.Show("DIGITE UM VALOR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
            }
        }
    }
}
