using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_ESTAÇÃO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadOutono_CheckedChanged(object sender, EventArgs e)
        {
            // Forma de acessar um recurso de imagem
            PicImgCentro.Image = Properties.Resources.outono; // Acessando imagem do outono                       
            TxtInformativo.Text = "Outono/ 20/03 a 20/06"; // Inserindo texto na propriedade textBox
        }

        private void RadInverno_CheckedChanged(object sender, EventArgs e)
        {
            PicImgCentro.Image = Properties.Resources.inverno; // Acessando imagem do inverno
            TxtInformativo.Text = "Inverno/ 20/06 a 22/09";
        }

        private void RadPrimavera_CheckedChanged(object sender, EventArgs e)
        {
            PicImgCentro.Image = Properties.Resources.primavera; // Acessando imagem da primavera
            TxtInformativo.Text = "Primavera/ 22/09 a 21/12";
        }

        private void RadVerão_CheckedChanged(object sender, EventArgs e)
        {
            PicImgCentro.Image = Properties.Resources.verao; // Acessando imagem do verão
            TxtInformativo.Text = "Verão/ 21/12 a 20/03";
        }
    }
}
