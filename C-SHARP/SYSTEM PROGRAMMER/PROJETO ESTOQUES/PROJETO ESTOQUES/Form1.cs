using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_ESTOQUES
{
    public partial class Frm_Estoques : Form
    {
        public Frm_Estoques()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            // Desativando botão ATIVAR
            Btn_Ativar.Enabled = false;
            
            // Ativando botões 
            Btn_Desativar.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Descricao.Enabled = true;

            // Ativando TextBox
            Txt_Produto.Enabled = true;
            Txt_Marca.Enabled = true;
            Txt_Peso.Enabled = true;
        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            // Desativando botões
            Btn_Desativar.Enabled = false;            
            Btn_Limpar.Enabled = false;
            Btn_Descricao.Enabled = false;
           
            // Ativando
            Btn_Ativar.Enabled = true;

            // Desativando TextBox
            Txt_Marca.Enabled = false;
            Txt_Peso.Enabled = false;
            Txt_Produto.Enabled = false;

            // Limpando TextBox
            Txt_Produto.Text = "";
            Txt_Marca.Text = "";
            Txt_Peso.Text = "";

            // Normalizando Labels
            Lbl_ProdResult.Text = "Produto";
            Lbl_MarcaResult.Text = "Marca";
            Lbl_PesoResult.Text = "Peso";

            // Alterando propriedade do LABEL
            Lbl_Erro.Visible = false;

            // Desativando PictureBox
            Pic_Imagem.Visible = false;

            // Desativando botão de enviar
            Btn_Enviar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Descricao_Click(object sender, EventArgs e)
        {            

            // Criando Condições 

            // Se o todos os TextBox não tiverem valor definido
            if(Txt_Produto.Text == "" && Txt_Marca.Text == "" && Txt_Peso.Text == "" ){                                
                
                // Alterando propriedades da LABEL e PICTUREBOX
                Lbl_Erro.Visible = true;
                Pic_Imagem.Visible = false;               
            }
                        
            // Caso contrário
            else
            {
                // Inserindo TextBox na Label
                Lbl_ProdResult.Text = Txt_Produto.Text;
                Lbl_MarcaResult.Text = Txt_Marca.Text;
                Lbl_PesoResult.Text = Txt_Peso.Text;

                // Alterando propriedade da PICTUREBOX
                Pic_Imagem.Visible = true;

                // Alterando propriedade do BUTTON
                Btn_Enviar.Visible = true;

                // Alterando propriedade do LABEL
                Lbl_Erro.Visible = false;
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            // Limpando TextBox
            Txt_Produto.Clear();
            Txt_Marca.Clear();
            Txt_Peso.Clear();
            
            // Normalizando TextBox
            Lbl_ProdResult.Text = "Produto";
            Lbl_MarcaResult.Text = "Marca";
            Lbl_PesoResult.Text = "Peso";

            // Desativando PictureBox
            Pic_Imagem.Visible = false;

            // Desativando botão de enviar
            Btn_Enviar.Visible = false;

            // Alterando propriedade do LABEL
            Lbl_Erro.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Descricao_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Imagem_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
