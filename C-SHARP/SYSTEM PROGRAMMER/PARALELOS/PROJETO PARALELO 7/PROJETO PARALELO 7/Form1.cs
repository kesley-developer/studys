using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_7
{
    public partial class Frm_Project : Form
    {
        // Declaração de variável
        int number;

        public Frm_Project()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {
            // Condição caso o TextBox seja diferente de ""
            if(Txt_Number.Text != "")
            {
                // Alterando valor da propriedade VISIBLE para TRUE
                Lbl_Bigger.Visible = true;
                Lbl_Smaller.Visible = true;
                Btn_Clear.Visible = true;

            }
            // Caso contrário
            else
            {
                // Alterando valor da propriedade VISIBLE para FALSE
                Lbl_Bigger.Visible = false;
                Lbl_Smaller.Visible = false;
                Btn_Clear.Visible = false;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Programando BOTÃO de limpar
            Txt_Number.Clear();
            Lbl_biggerResult.Text = "?";
            Lbl_smallerResult.Text = "?";
            Txt_Number.Focus();
        }

        private void Lbl_biggerResult_Click(object sender, EventArgs e)
        {
            number = int.Parse(Txt_Number.Text);
            number = number + 1;
            Lbl_biggerResult.Text = number.ToString();
        }

        private void Lbl_smallerResult_Click(object sender, EventArgs e)
        {
            number = int.Parse(Txt_Number.Text);
            number = number - 1;
            Lbl_smallerResult.Text = number.ToString();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
