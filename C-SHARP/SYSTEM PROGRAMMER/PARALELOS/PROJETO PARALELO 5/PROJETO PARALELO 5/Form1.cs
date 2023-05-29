using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_5
{
    public partial class Frm_Project : Form
    {
        public Frm_Project()
        {
            InitializeComponent();
        }

        private void Lbl_Red_Click(object sender, EventArgs e)
        {
            
            // Adicionando função para piscar o cursor no TextBox
            Txt_Red.Focus();
            
            // Alterando propriedade do Label
            Lbl_Background.BackColor = Color.Red;            
        }        

        private void Lbl_Yellow_Click(object sender, EventArgs e)
        {
            Txt_Yellow.Focus();
            Lbl_Background.BackColor = Color.Yellow;
            
        }

        private void Lbl_Purple_Click(object sender, EventArgs e)
        {
            Txt_Purple.Focus();
            Lbl_Background.BackColor = Color.Purple;            
        }

        private void Lbl_Green_Click(object sender, EventArgs e)
        {
            Txt_Green.Focus();
            Lbl_Background.BackColor = Color.Green;            

        }

        private void Lbl_Blue_Click_1(object sender, EventArgs e)
        {
            Txt_Blue.Focus();
            Lbl_Background.BackColor = Color.Blue;         
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Removendo valores do TextBox
            Txt_Red.Clear();
            Txt_Blue.Clear();
            Txt_Yellow.Clear();
            Txt_Purple.Clear();
            Txt_Green.Clear();
        }        
    }
}
