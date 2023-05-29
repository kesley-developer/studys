using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_2
{
    public partial class Frm_Projeto : Form
    {
        public Frm_Projeto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            // Criando condições

            // Caso o TextBox não tenha valor definido
            if(Txt_Nome.Text == "" || Txt_CPF.Text == "")
            {
                
                // Alterando propriedades e valores do LABEL
                Lbl_Erro.Text = "Erro! Preencha os campos corretamente!";
                Lbl_Erro.ForeColor = Color.Red;
                Lbl_Erro.Visible = true;
           }
            
            // Caso contrário
            else
            {
                // Alterando propriedades e valor do LABEL
                Lbl_Erro.Text = "Sucesso! Cadastro realizado!";
                Lbl_Erro.ForeColor = Color.LimeGreen;

                // Mensagem POPUP                
                MessageBox.Show("Cadastro efetuado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            
        }
    }
}
