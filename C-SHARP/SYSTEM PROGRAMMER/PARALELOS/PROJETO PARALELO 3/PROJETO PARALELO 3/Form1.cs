using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_3
{
    public partial class Frm_Projeto : Form
    {
        public Frm_Projeto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Red_Click(object sender, EventArgs e)
        {            

        }

        private void Btn_Red_Click_1(object sender, EventArgs e)
        {

            // Alterando propriedade e valor do PictureBox
            Pic_Color.BackColor = Color.Red;
        }

        private void Btn_Green_Click(object sender, EventArgs e)
        {

            Pic_Color.BackColor = Color.Green;
        }

        private void Btn_Blue_Click(object sender, EventArgs e)
        {
            Pic_Color.BackColor = Color.Blue;
        }

        private void Btn_Purple_Click(object sender, EventArgs e)
        {
            Pic_Color.BackColor = Color.Purple;
        }

        private void Btn_Yellow_Click(object sender, EventArgs e)
        {
            Pic_Color.BackColor = Color.Yellow;
        }
    }
}
