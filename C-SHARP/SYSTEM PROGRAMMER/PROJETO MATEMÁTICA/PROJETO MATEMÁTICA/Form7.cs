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
    public partial class Frm_SameOrDifferent : Form
    {
        // Declarando variáveis
        int number0, number1 = 0;

        public Frm_SameOrDifferent()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Voltando ao FRM_PROJECT
            Close();
            Frm_Project igual_ou_diferente = new Frm_Project();
            igual_ou_diferente.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }        

        private void Txt_Value1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validando entrada de dados do VALOR 1
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                // Caso a tecla ENTER seja pressionada sem valor   
                if(Txt_Value1.Text == "")
                {
                    MessageBox.Show("DIGITE UM VALOR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                                
            
            }
            
        }

        private void Txt_Value2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validando entrada de dados do VALOR 2
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                // Caso a tecla ENTER seja pressionada sem valor
                if(Txt_Value1.Text == "" || Txt_Value2.Text == "")
                {
                    MessageBox.Show("DIGITE UM VALOR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    number0 = int.Parse(Txt_Value1.Text);
                    number1 = int.Parse(Txt_Value2.Text);
                    
                    // Condição para comparar os VALORES após pressionar ENTER
                    if(number0 == number1)
                    {
                        MessageBox.Show("Os valores são IGUAIS", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Os valores são DIFERENTES", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Txt_Value1_TextChanged(object sender, EventArgs e)
        {
            // Condição caso o VALOR 1 esteja vazio
            if(Txt_Value1.Text == "")
            {
                Lbl_Result.Text = "?";
            }
            
            // Caso contrario
            else
            {
                // Inserindo valor a variável
                number0 = int.Parse(Txt_Value1.Text);

                // Comparando 
                if(number0 == number1)
                {
                    Lbl_Result.Text = "=";
                }
                else
                {
                    Lbl_Result.Text = "!";
                }
            }
        }
        private void Txt_Value2_TextChanged(object sender, EventArgs e)
        {
            // Condição caso o VALOR 2 esteja vazio
            if(Txt_Value2.Text == "")
            {
                Lbl_Result.Text = "?";
            }
            
            // Caso contrario
            else
            {
                // Inserindo valor a variável
                number1 = int.Parse(Txt_Value2.Text);

                // Comparando
                if(number0 == number1)
                {
                    Lbl_Result.Text = "=";

                }
                else
                {
                    Lbl_Result.Text = "!";
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Limpando valores
            Txt_Value1.Clear();
            Txt_Value2.Clear();
        }        

        private void Lbl_Result_Click(object sender, EventArgs e)
        {                   
            
        }
    }
}
