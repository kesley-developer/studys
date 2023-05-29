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
    public partial class Frm_Project : Form
    {
        public Frm_Project()
        {
            InitializeComponent();
        }

        private void Rad_Double_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM2 de DOBRO
            Frm_Double dobro = new Frm_Double();
            Hide();
            dobro.Show();
        }

        private void Rad_AntOrSuc_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM3 de ANTECESSOR E SUCESSOR
            Frm_AntOrSuc ant_ou_suc = new Frm_AntOrSuc();
            Hide();
            ant_ou_suc.Show();
        }

        private void Rad_PairOrOdd_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM4 de PAR OU IMPAR
            Frm_PairOrOdd par_ou_impar = new Frm_PairOrOdd();
            Hide();
            par_ou_impar.Show();
        }

        private void Rad_PosOrNeg_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM5 de POSITIVO OU NEGATIVO
            Frm_PosOrNeg pos_ou_neg = new Frm_PosOrNeg();
            Hide();
            pos_ou_neg.Show();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Encerrando FORM1 após clique no BUTTON
            Application.Exit();
        }

        private void Rad_Calculator_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM6 de OPERAÇÕES ARITMÉTICAS
            Frm_Calculator calculadora = new Frm_Calculator();
            Hide();
            calculadora.Show();
        }

        private void Rad_SameOrDifferent_CheckedChanged(object sender, EventArgs e)
        {
            // Abrindo FORM7 de IGUAL OU DIFERENTE
            Frm_SameOrDifferent igual_ou_diferente = new Frm_SameOrDifferent();
            Hide();
            igual_ou_diferente.Show();
        }
    }
}
