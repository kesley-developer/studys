using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_LOJA
{
    public partial class Frm_Project : Form
    {
        decimal bicicleta, calculadora, camera, CD, celular, churrasqueira, despertador, computador; // Guardando o preço de cada produto                                    
        decimal q1, q2, q3, q4, q5, q6, q7, q8; // Variáveis da quantidade dos produtos                                        
        int e1, e2, e3, e4, e5, e6, e7, e8; // Variáveis do estoque de cada produto

        public Frm_Project()
        {
            InitializeComponent();
        }        
        private void total()
        {
            // Adicionando valor da compra ao LABEL através do método TOTAL
            Lbl_TotalValue.Text = (bicicleta * q1 + calculadora * q2 + camera * q3 + CD * q4 + celular * q5 + churrasqueira * q6 + despertador * q7 + computador * q8).ToString("c2");
        }    
        private void Num_Product1_ValueChanged(object sender, EventArgs e)
        {
            // Estoque da BICICLETA
            q1 = Num_Product1.Value;
            Lbl_Product1.Text = "Disponivel: " + (e1 - q1);
            total();
        }

        private void Num_Product2_ValueChanged(object sender, EventArgs e)
        {
            // Estoque da CALCULADORA
            q2 = Num_Product2.Value;
            Lbl_Product2.Text = "Disponivel: " + (e2 - q2);
            total();
        }
        private void Num_Product3_ValueChanged(object sender, EventArgs e)
        {
            // Estoque da CÂMERA
            q3 = Num_Product3.Value;
            Lbl_Product3.Text = "Disponivel: " + (e3 - q3);
            total();
        }
        private void Num_Product4_ValueChanged(object sender, EventArgs e)
        {
            // Estoque do CD
            q4 = Num_Product4.Value;
            Lbl_Product4.Text = "Disponivel: " + (e4 - q4);
            total();
        }
        private void Num_Product5_ValueChanged(object sender, EventArgs e)
        {
            // Estoque do CELULAR
            q5 = Num_Product5.Value;
            Lbl_Product5.Text = "Disponivel: " + (e5 - q5);
            total();
        }
        private void Num_Product6_ValueChanged(object sender, EventArgs e)
        {
            // Estoque da CHURRASQUEIRA
            q6 = Num_Product6.Value;
            Lbl_Product6.Text = "Disponivel: " + (e6 - q6);
            total();
        }
        private void Num_Product7_ValueChanged(object sender, EventArgs e)
        {
            // Estoque do DESPERTADOR
            q7 = Num_Product7.Value;
            Lbl_Product7.Text = "Disponivel: " + (e7 - q7);
            total();
        }
        private void Num_Product8_ValueChanged(object sender, EventArgs e)
        {
            // Estoque do COMPUTADOR
            q8 = Num_Product8.Value;
            Lbl_Product8.Text = "Disponivel: " + (e8 - q8);
            total();
        }
        private void Chk_Product1_CheckedChanged(object sender, EventArgs e)
        {
            // Bicicleta - Adicionando informações ao marcar CHECKBOX
            bicicleta = 500;
            e1 = 10;
            if(Chk_Product1.Checked == true)
            {
                Chk_Product1.Text = "Bicicleta";
                Pic_Product1.Image = Properties.Resources.bike_img;
                List_Product.Items.Add("Bicicleta");
                List_Description.Items.Add("Aro 26 Caloi");
                List_Value.Items.Add(bicicleta);
                Num_Product1.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product1.Text = "Produto 1";
                Pic_Product1.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Bicicleta");
                List_Description.Items.Remove("Aro 26 Caloi");
                List_Value.Items.Remove(bicicleta);
                Num_Product1.Visible = false;
            }            
        }

        private void Chk_Product2_CheckedChanged(object sender, EventArgs e)
        {
            // Calculadora - Adicionando informações ao marcar CHECKBOX
            calculadora = 25;
            e2 = 20;                        
            if (Chk_Product2.Checked == true)
            {
                Chk_Product2.Text = "Calculadora";
                Pic_Product2.Image = Properties.Resources.calculator_img;
                List_Product.Items.Add("Calculadora");
                List_Description.Items.Add("Comercial eletrônica 12 digitos");
                List_Value.Items.Add(calculadora);
                Num_Product2.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product2.Text = "Produto 2";
                Pic_Product2.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Calculadora");
                List_Description.Items.Remove("Comercial eletrônica 12 digitos");
                List_Value.Items.Remove(calculadora);
                Num_Product2.Visible = false;
            }

        }
        private void Chk_Product3_CheckedChanged(object sender, EventArgs e)
        {
            // Câmera - Adicionando informações ao marcar CHECKBOX
            camera = 3000;
            e3 = 7;
            if(Chk_Product3.Checked == true)
            {
                Chk_Product3.Text = "Câmera";
                Pic_Product3.Image = Properties.Resources.camera_img;
                List_Product.Items.Add("Câmera");
                List_Description.Items.Add("Nikon compacta");
                List_Value.Items.Add(camera);
                Num_Product3.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product3.Text = "Produto 3";
                Pic_Product3.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Câmera");
                List_Description.Items.Remove("Nikon compacta");
                List_Value.Items.Remove(camera);
                Num_Product3.Visible = false;
            }
        }
        private void Chk_Product4_CheckedChanged(object sender, EventArgs e)
        {
            // CD - Adicionando informações ao marcar CHECKBOX
            CD = 5;
            e4 = 65;
            if(Chk_Product4.Checked == true)
            {
                Chk_Product4.Text = "CD";
                Pic_Product4.Image = Properties.Resources.cd_img;
                List_Product.Items.Add("CD");
                List_Description.Items.Add("Maxprint 700 MB");
                List_Value.Items.Add(CD);
                Num_Product4.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product4.Text = "Produto 4";
                Pic_Product4.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("CD");
                List_Description.Items.Remove("Maxprint 700 MB");
                List_Value.Items.Remove(CD);
                Num_Product4.Visible = false;

            }
        }

        private void Chk_Product5_CheckedChanged(object sender, EventArgs e)
        {
            // Celular - Adicionando informações ao marcar CHECKBOX
            celular = 2500;
            e5 = 15;
            if(Chk_Product5.Checked == true)
            {
                Chk_Product5.Text = "Celular";
                Pic_Product5.Image = Properties.Resources.phone_img;
                List_Product.Items.Add("Celular");
                List_Description.Items.Add("64 GB - IOS - Impressão digital");
                List_Value.Items.Add(celular);
                Num_Product5.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product5.Text = "Produto 5";
                Pic_Product5.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Celular");
                List_Description.Items.Remove("64 GB - IOS - Impressão digital");
                List_Value.Items.Remove(celular);
                Num_Product5.Visible = false;
            }
        }

        private void Chk_Product6_CheckedChanged(object sender, EventArgs e)
        {
            // Churrasqueira - Adicionando informações ao marcar CHECKBOX
            churrasqueira = 160;
            e6 = 8;
            if(Chk_Product6.Checked == true)
            {
                Chk_Product6.Text = "Churrasqueira";
                Pic_Product6.Image = Properties.Resources.grill_img;
                List_Product.Items.Add("Churrasqueira");
                List_Description.Items.Add("Portátil");
                List_Value.Items.Add(churrasqueira);
                Num_Product6.Visible = true;

            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product6.Text = "Produto 6";
                Pic_Product6.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Churrasqueira");
                List_Description.Items.Remove("Portátil");
                List_Value.Items.Remove(churrasqueira);
                Num_Product6.Visible = false;
            }            
        }
        private void Chk_Product7_CheckedChanged(object sender, EventArgs e)
        {
            // Despertador - Adicionando informações ao marcar CHECKBOX
            despertador = 50;
            e7 = 10;
            if(Chk_Product7.Checked == true)
            {
                Chk_Product7.Text = "Despertador";
                Pic_Product7.Image = Properties.Resources.clock_img;
                List_Product.Items.Add("Despertador");
                List_Description.Items.Add("Relógio de mesa");
                List_Value.Items.Add(despertador);
                Num_Product7.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product7.Text = "Produto 7";
                Pic_Product7.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Despertador");
                List_Description.Items.Remove("Relógio de mesa");
                List_Value.Items.Remove(despertador);
                Num_Product7.Visible = false;
            }
        }

        private void Chk_Product8_CheckedChanged(object sender, EventArgs e)
        {
            // Computador - Adicionando informações ao marcar CHECKBOX
            computador = 2000;
            e8 = 6;
            if(Chk_Product8.Checked == true)
            {
                Chk_Product8.Text = "Computador";
                Pic_Product8.Image = Properties.Resources.computer_img;
                List_Product.Items.Add("Computador");
                List_Description.Items.Add("i5 - 8 GB DE RAM - 500 GB DE HD");
                List_Value.Items.Add(computador);
                Num_Product8.Visible = true;
            }
            // Voltando a normalidade ao desmarcar CHECKBOX
            else
            {
                Chk_Product8.Text = "Produto 8";
                Pic_Product8.Image = Properties.Resources.default_img;
                List_Product.Items.Remove("Computador");
                List_Description.Items.Remove("i5 - 8 GB DE RAM - 500 GB DE HD");
                List_Value.Items.Remove(computador);
                Num_Product8.Visible = false;
            }
        }

    }
}
