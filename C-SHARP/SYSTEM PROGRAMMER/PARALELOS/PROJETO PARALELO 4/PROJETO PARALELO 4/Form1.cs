using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_4
{
    public partial class Frm_Project : Form
    {
        public Frm_Project()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            // Criando condições
            
            // Se não houver valor no TextBox
            if(Txt_Number0.Text == "" && Txt_Number1.Text == "")
            {
                // Alterando propriedades do Label
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Insira um valor para soma!";                
            }            
           
            // Caso contrário
            else
            {
                // Alterando propriedade do Label
                Lbl_Error.Visible = false;
                
                // Convertendo valores do TextBox em números inteiros
                int num0 = Convert.ToInt32(Txt_Number0.Text);
                int num1 = Convert.ToInt32(Txt_Number1.Text);

                // Somando valores
                int result = num0+num1;

                // Inserindo resultado a Label
                Lbl_Result.Text = result.ToString();

                // Resultado da soma em POP-UP
                MessageBox.Show(result.ToString());                
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Error_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Result_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Limpando valores do TextBox e Label
            Txt_Number0.Clear();
            Txt_Number1.Clear();
            Lbl_Result.Text = "";
            Lbl_Error.Text = "";
        }

        private void Btn_Subt_Click(object sender, EventArgs e)
        {
            if(Txt_Number0.Text == "" && Txt_Number1.Text == "")
            {                
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Insira um valor para soma!";
            }

            else
            {
                Lbl_Error.Visible = false;

                int num0 = Convert.ToInt32(Txt_Number0.Text);
                int num1 = Convert.ToInt32(Txt_Number1.Text);

                int result = num0 - num1;

                Lbl_Result.Text = result.ToString();

                MessageBox.Show(result.ToString());
            }
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            if(Txt_Number0.Text == "" && Txt_Number1.Text == "")
            {
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Insira um valor para soma!";
            }

            else
            {
                Lbl_Error.Visible = false;

                int num0 = Convert.ToInt32(Txt_Number0.Text);
                int num1 = Convert.ToInt32(Txt_Number1.Text);

                int result = num0 * num1;

                Lbl_Result.Text = result.ToString();

                MessageBox.Show(result.ToString());
            }
        }

        private void Btn_Divi_Click(object sender, EventArgs e)
        {
            if(Txt_Number0.Text == "" && Txt_Number1.Text == "")
            {
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Insira um valor para soma!";
            }

            else
            {
                Lbl_Error.Visible = false;

                int num0 = Convert.ToInt32(Txt_Number0.Text);
                int num1 = Convert.ToInt32(Txt_Number1.Text);

                int result = num0 / num1;

                Lbl_Result.Text = result.ToString();

                MessageBox.Show(result.ToString());
            }
        }

        private void Pic_Image_Click(object sender, EventArgs e)
        {
        
        }

        private void Btn_Error_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Number0_TextChanged(object sender, EventArgs e)
        {
            Txt_Number0.Focus();
        }
    }
}
