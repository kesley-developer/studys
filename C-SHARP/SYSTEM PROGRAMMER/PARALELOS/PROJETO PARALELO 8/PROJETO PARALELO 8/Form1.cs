using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PARALELO_8
{
    public partial class Frm_Project : Form
    {
        decimal bicicleta; //  Guardando preço de cada produto
        int e1; // Guradar o valor de estoque de cada produto
        decimal q1; // Guardar o valor da quantidade de cada produto

        public Frm_Project()
        {
            InitializeComponent();
        }

        private void total() // Criando método total
        {
            // LABEL do total
            Lbl_TotalResult.Text = ((bicicleta * q1)).ToString("c2"); // 
        }

        private void Frm_Project_Load(object sender, EventArgs e)
        {
            // Mensagem de saudações após executar programa
            MessageBox.Show("Seja bem vindo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Chk_Product_CheckedChanged(object sender, EventArgs e)
        {
            bicicleta = 500; // Guardando o preço de cada produto
            e1 = 10; // Guardar o valor de estoque de cada produto

            // Condição ao marcar o CHECKBOX
            if(Chk_Product.Checked == true)
            {
                Chk_Product.Text = "Bicicleta"; // Alterandno para o nome do produto
                Pic_ProductIllustration.BackgroundImage = Properties.Resources.bike_img; // Trocando imagem
                List_Product.Items.Add("Bicicleta"); // Adicionando bicicleta a lista
                List_Description.Items.Add("Aro 35 Speed"); // Adicionando a informação a lista
                List_Value.Items.Add(bicicleta); // Adicionando o preço
                Num_Product.Visible = true; // Tornando o NumericUpDown Visivel
                Num_Product.Maximum = e1; // Limitando a quantidade máxima
                Lbl_Count.Visible = true; // Deixando o estoque visivel
            }

            // Voltando ao padrão ao desmarcar CHECKBOX
            else
            {
                Chk_Product.Text = "Produto";
                Pic_ProductIllustration.BackgroundImage = Properties.Resources.illustration;
                List_Product.Items.Remove("Bicicleta");
                List_Description.Items.Remove("Aro 35 Speed");
                List_Value.Items.Remove(bicicleta);
                Num_Product.Visible = false;
                Num_Product.Value = 0;
                Lbl_Count.Visible = false;
            }
        }

        private void Num_Product_ValueChanged(object sender, EventArgs e)
        {
            // Programando quantidade do NumericUpDown
            q1 = Num_Product.Value;
            Lbl_Count.Text = "Disponivel: " + (e1 - q1);
            total();
        }
    }

}
