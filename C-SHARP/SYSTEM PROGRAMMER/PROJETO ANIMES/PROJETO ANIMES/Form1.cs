using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_ANIMES
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadAnime_0_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.naruto_img;
            TxtInformativo.Text = "Naruto";
        }

        private void RadAnime_1_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.dbz_img;
            TxtInformativo.Text = "Dragon Ball Z";
        }

        private void RadAnime_2_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.yuyu_img;
            TxtInformativo.Text = "Yu Yu Hakusho";
        }   

        private void RadAnime_3_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.bleach_img;
            TxtInformativo.Text = "Bleach";
        }

        private void RadAnime_4_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.berserk_img;
            TxtInformativo.Text = "Berserk";
        }

        private void RadAnime_5_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.cowboy_img;
            TxtInformativo.Text = "Cowboy Bebop";
        }

        private void RadAnime_6_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.monster_img;
            TxtInformativo.Text = "Monster";
        }

        private void RadAnime_7_CheckedChanged(object sender, EventArgs e)
        {
            PicImage.Image = Properties.Resources.akira_img;
            TxtInformativo.Text = "Akira";
        }
    }
}
