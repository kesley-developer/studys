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
    public partial class Frm_PosOrNeg : Form
    {
        // Variável
        int number;

        public Frm_PosOrNeg()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Voltamdo ao FRM_PROJECT
            Close();
            Frm_Project pos_ou_neg = new Frm_Project();
            pos_ou_neg.Show();
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Criando condições para caractéres não permitidos
            
            // !(e.KeyChar == '') = Passando os caratéres desejados
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-') && !(e.KeyChar == '+'))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Condição para tecla ENTER
            if(e.KeyChar == 13)
            {
                // Caso o TextBox tenha valor
                if(Txt_Number.Text != "") 
                {                                        
                    // Variável principal
                    number = int.Parse(Txt_Number.Text);

                    // Condição para POSITIVO
                    if(number > 0)
                    {
                        MessageBox.Show("POSITIVO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Condição para NEGATIVO
                    else if(number < 0)
                    {
                        MessageBox.Show("NEGATIVO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                            
                    
                    // Condição para NEUTRO
                    else
                    {
                        MessageBox.Show("NEUTRO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Removendo valores e focando no TextBox
                    Txt_Number.Clear();
                    Txt_Number.Focus();
                }               

                    // Caso a tecla ENTER seja pressionada sem valor no TextBox
                    else
                {
                    MessageBox.Show("DIGITE UM NÚMERO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {

        }

  
    }
}
