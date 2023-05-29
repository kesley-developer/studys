using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_6
{
    public partial class Frm_Window : Form
    {
        public Frm_Window()
        {
            InitializeComponent();
        }

        private void Pic_Illustration_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {                       
            // Button

            // MessageBox
            MessageBox.Show("Arquivo enviado com sucesso!", "Aviso", MessageBoxButtons.OK);            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_DatesBox_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {            
            // Evento de tecla no TextBox NOME - Press 

            
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SÓ É PERMITIDO LETRAS!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                if(Txt_Name.Text != "")
                {
                    Txt_Age.Focus();

                }
                
                    else
                {
                    MessageBox.Show("O NOME NÃO FOI DIGITADO!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Evento de tecla no TextBox IDADE - Press

            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("SÓ É PERMITIDO NÚMEROS!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(e.KeyChar == 13)
            {
                if(Txt_Name.Text != "")
                {
                    Txt_Name.Focus();
                }

                    else
                {
                    MessageBox.Show("A IDADE NÃO FOI DIGITADA!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
