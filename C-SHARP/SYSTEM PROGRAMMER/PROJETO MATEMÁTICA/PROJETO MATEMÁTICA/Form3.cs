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
    public partial class Frm_AntOrSuc : Form
    {
        // Declarando variável
        int number;
        
        public Frm_AntOrSuc()
        {
            InitializeComponent();
        }        

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Voltando ao FRM_PROJECT
            Close();
            Frm_Project ant_ou_suc = new Frm_Project();
            ant_ou_suc.Show();
        }

        private void Txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caso o valor digitado seja diferente de um numero
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NUMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn_Ant_Click(object sender, EventArgs e)
        {
            // Programando ANTECESSOR                                                                                                                                                 
            if(Txt_Number.Text.All(char.IsWhiteSpace) == true) // Verificando se o valor no TextBox é um espaço em branco
            {
                MessageBox.Show("Digite um valor númerico", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                number = int.Parse(Txt_Number.Text);
                number = number - 1;
                MessageBox.Show("O antecessor de " + Txt_Number.Text + " é igual a " + number, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void Btn_Suc_Click(object sender, EventArgs e)
        {
            // Programando SUCESSOR                        
            if(Txt_Number.Text.All(char.IsWhiteSpace) == true) // Verificando se o valor no TextBox é um espaço em branco
            {
                MessageBox.Show("Digite um valor númerico", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            { 
                number = int.Parse(Txt_Number.Text);
                number = number + 1;
                MessageBox.Show("O sucessor de " + Txt_Number.Text + " é igual a " + number, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Programando opção de LIMPAR
            Txt_Number.Clear();
        }

        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {
            // Caso o TextBox seja diferente de ""
            if(Txt_Number.Text != "")
            {
                // Alterando propriedade VISIBLE para TRUE
                Btn_Ant.Visible = true;
                Btn_Suc.Visible = true;
                Btn_Clear.Visible = true;
            }
            // Caso contrario
            else
            {
                // Alterando propriedade VISIBLE para FALSE
                Btn_Ant.Visible = false;
                Btn_Suc.Visible = false;
                Btn_Clear.Visible = false;

            }
        }
    }
}
