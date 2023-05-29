using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO
{
    public partial class Frm_Projeto : Form
    {
        public Frm_Projeto()
        {
            InitializeComponent();
        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            // Desativando BUTTON
            Btn_Ativar.Enabled = false;
            
            // Ativando BUTTON 
            Btn_Desativar.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Resultado.Enabled = true;

            // Ativando TextBox
            Txt_Box0.Enabled = true;
            Txt_Box1.Enabled = true;
            Txt_Box2.Enabled = true;
        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            // Desativando BUTTON
            Btn_Desativar.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Resultado.Enabled = false;

            // Ativando BUTTON
            Btn_Ativar.Enabled = true;

            // Desativando TextBox
            Txt_Box0.Enabled = false;
            Txt_Box1.Enabled = false;
            Txt_Box2.Enabled = false;

            // Removendo valores do TEXTBOX
            Txt_Box0.Clear();
            Txt_Box1.Clear();
            Txt_Box2.Clear();

            // Removendo valores do LABEL
            Lbl_Resultado.Text = "";
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            // Removendo valores do TEXTBOX
            Txt_Box0.Clear();
            Txt_Box1.Clear();
            Txt_Box2.Clear();

            // Removendo valores do LABEL
            Lbl_Resultado.Text = "";
        }

        private void Btn_Resultado_Click(object sender, EventArgs e)
        {

            // Alterando propriedade da LABEL
            Lbl_Resultado.Visible = true;

            // Adicionando valores do TEXTBOX a LABEL
            Lbl_Resultado.Text = Txt_Box0.Text + "\n" + Txt_Box1.Text + "\n" + Txt_Box2.Text; // Concatenando
                        
        }
    }
}
