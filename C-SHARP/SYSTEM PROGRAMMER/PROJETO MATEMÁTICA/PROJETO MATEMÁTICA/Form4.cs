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
    public partial class Frm_PairOrOdd : Form
    {
        // Declarando variável
        int number;

        public Frm_PairOrOdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Voltando ao FRM_PROJECTS
            Close();
            Frm_Project par_ou_impar = new Frm_Project();
            par_ou_impar.Show();
        }

        private void Txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Programando condições do TextBox
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                if(Txt_Number.Text != "")
                {
                    number = int.Parse(Txt_Number.Text);                                                        

                    // Condição para PAR
                    if(number % 2 == 0)
                    {
                        MessageBox.Show("O número " + Txt_Number.Text + " é PAR ", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                                                               
                    }                    
                    
                    // Condição para ÍMPAR
                    else if(number % 2 != 0)
                    {
                        MessageBox.Show("O número " + Txt_Number.Text + " é ÍMPAR", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);                                               
                    }

                    Txt_Number.Clear();
                    Txt_Number.Focus();
                }

                    // Caso o TextBox não tenha valor
                    else
                {
                    MessageBox.Show("DIGITE UM NÚMERO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Focando no TextBox
                    Txt_Number.Focus();
                }
            }
        }
    }
}
