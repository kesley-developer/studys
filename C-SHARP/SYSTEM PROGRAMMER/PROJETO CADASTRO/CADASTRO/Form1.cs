using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADASTRO
{
    public partial class Frm_Window : Form
    {
        public Frm_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Theme1_CheckedChanged(object sender, EventArgs e)
        {
            // Tema 1
            BackgroundImage = Properties.Resources.theme1_img;

            // Alterando propriedades da LABEL
            Lbl_Cadaster.BackColor = Color.DarkBlue;
            Lbl_Dates.BackColor = Color.DarkBlue;            
            
            // Alterando propriedades dos BUTTONS
            Btn_Name.BackColor = Color.Red;
            Btn_LastName.BackColor = Color.DarkBlue;
            Btn_Age.BackColor = Color.Red;
            Btn_Address.BackColor = Color.DarkBlue;
            Btn_Email.BackColor = Color.Red;
            Btn_Telephone.BackColor = Color.DarkBlue;
            Btn_FullDates.BackColor = Color.Red;
            Btn_Active.BackColor = Color.DarkBlue;
            Btn_Disable.BackColor = Color.Red;
            Btn_Clear.BackColor = Color.DarkBlue;

            // Alterando propriedades do PictureBox
            Pic_Info.BackColor = Color.Red;
        }

        private void Rad_Theme2_CheckedChanged(object sender, EventArgs e)
        {
            // Tema 2
            BackgroundImage = Properties.Resources.theme2_img;

            // Alterando propriedades da LABEL
            Lbl_Cadaster.BackColor = Color.RoyalBlue;
            Lbl_Dates.BackColor = Color.RoyalBlue;            

            // Alterando propriedades dos BUTTONS
            Btn_Name.BackColor = Color.RoyalBlue;
            Btn_LastName.BackColor = Color.RoyalBlue;
            Btn_Age.BackColor = Color.RoyalBlue;
            Btn_Address.BackColor = Color.RoyalBlue;
            Btn_Email.BackColor = Color.RoyalBlue;
            Btn_Telephone.BackColor = Color.RoyalBlue;
            Btn_FullDates.BackColor = Color.RoyalBlue;
            Btn_Disable.BackColor = Color.RoyalBlue;
            Btn_Active.BackColor = Color.RoyalBlue;
            Btn_Clear.BackColor = Color.RoyalBlue;

            // Alterando propriedades do PictureBox           
            Pic_Info.BackColor = Color.RoyalBlue;            

        }

        private void Rad_Theme3_CheckedChanged(object sender, EventArgs e)
        {
            // Tema 3
            BackgroundImage = Properties.Resources.theme3_img;

            // Alterando propriedades da LABEL
            Lbl_Cadaster.BackColor = Color.Red;
            Lbl_Dates.BackColor = Color.Red;
            
            // Alterando propriedades dos BUTTONS
            Btn_Name.BackColor = Color.Red;
            Btn_LastName.BackColor = Color.Red;
            Btn_Age.BackColor = Color.Red;
            Btn_Address.BackColor = Color.Red;
            Btn_Email.BackColor = Color.Red;
            Btn_Telephone.BackColor = Color.Red;
            Btn_FullDates.BackColor = Color.Red;
            Btn_Active.BackColor = Color.Red;
            Btn_Disable.BackColor = Color.Red;
            Btn_Clear.BackColor = Color.Red;

            // Alterando propriedades do PictureBox            
            Pic_Info.BackColor = Color.Red;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Tema padrão
            BackgroundImage = Properties.Resources.default_theme_img;

            // Alterando propriedades da LABEL
            Lbl_Cadaster.BackColor = Color.DarkBlue;
            Lbl_Dates.BackColor = Color.DarkBlue;
            
            // Alterando propriedades dos BUTTONS
            Btn_Name.BackColor = Color.DarkBlue;
            Btn_LastName.BackColor = Color.DarkBlue;
            Btn_Age.BackColor = Color.DarkBlue;
            Btn_Address.BackColor = Color.DarkBlue;
            Btn_Email.BackColor = Color.DarkBlue;
            Btn_Telephone.BackColor = Color.DarkBlue;
            Btn_FullDates.BackColor = Color.DarkBlue;
            Btn_Disable.BackColor = Color.DarkBlue;
            Btn_Active.BackColor = Color.DarkBlue;
            Btn_Clear.BackColor = Color.DarkBlue;

            // Alterando prorpiedades do PictureBox
            Pic_Info.BackColor = Color.DarkBlue;
        }

        private void Btn_Disable_Click(object sender, EventArgs e)
        {

            // Desativando objetos
            
            // TextBox
            Txt_Name.Enabled = false;
            Txt_LastName.Enabled = false;
            Txt_Age.Enabled = false;
            Txt_Address.Enabled = false;
            Txt_Email.Enabled = false;
            Txt_Telephone.Enabled = false;

            // Removendo valores do TextBox
            Txt_Name.Clear();
            Txt_LastName.Clear();
            Txt_Age.Clear();
            Txt_Address.Clear();
            Txt_Email.Clear();
            Txt_Telephone.Clear();

            // Buttons
            Btn_Active.Enabled = true; // Ativando Button
            Btn_Disable.Enabled = false;
            Btn_Clear.Enabled = false;
            Btn_Name.Enabled = false;
            Btn_LastName.Enabled = false;
            Btn_Age.Enabled = false;
            Btn_Address.Enabled = false;
            Btn_Email.Enabled = false;
            Btn_Telephone.Enabled = false;
            Btn_FullDates.Enabled = false;

            // GroupBox
            Grp_ThemesGroup.Enabled = false;

            // PictureImage
            Pic_Ilustration.Visible = false;
            Pic_Logo.Visible = false;
            Pic_Info.Visible = false;
            Pic_Dates.Visible = false;

            // Label                       
            Lbl_DatesText.Visible = false;
            Lbl_DatesText.Text = "";
            
        }

        private void Btn_Active_Click(object sender, EventArgs e)
        {
            // Ativando objetos

            // TextBox
            Txt_Name.Enabled = true;
            Txt_LastName.Enabled = true;
            Txt_Age.Enabled = true;
            Txt_Address.Enabled = true;
            Txt_Email.Enabled = true;
            Txt_Telephone.Enabled = true;

            // Buttons
            Btn_Active.Enabled = false; // Desativando Button
            Btn_Disable.Enabled = true;
            Btn_Clear.Enabled = true;
            Btn_Name.Enabled = true;
            Btn_LastName.Enabled = true;
            Btn_Age.Enabled = true;
            Btn_Address.Enabled = true;
            Btn_Email.Enabled = true;
            Btn_Telephone.Enabled = true;
            Btn_FullDates.Enabled = true;
            
            // GroupBox
            Grp_ThemesGroup.Enabled = true;

            // PictureImage
            Pic_Ilustration.Visible = true;
            Pic_Logo.Visible = true;            
          
        }

        private void Btn_Name_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;
            
            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Name.Text;
        }

        private void Btn_LastName_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_LastName.Text;
        }

        private void Btn_Age_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Age.Text;
        }

        private void Btn_Address_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Address.Text;
        }

        private void Btn_Email_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Email.Text;
        }

        private void Btn_Telephone_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valor
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Telephone.Text;
        }

        private void Btn_FullDates_Click(object sender, EventArgs e)
        {
            // Ativando PictureBox
            Pic_Info.Visible = true;
            Pic_Dates.Visible = true;

            // Ativando Label e inserindo valores
            Lbl_DatesText.Visible = true;
            Lbl_DatesText.Text = Txt_Name.Text + "\n" + Txt_LastName.Text + "\n" + Txt_Age.Text + "\n" + Txt_Address.Text + "\n" + Txt_Email.Text + "\n" + Txt_Telephone.Text;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            // Removendo valores do TextBox            
            Txt_Name.Clear();
            Txt_LastName.Clear();
            Txt_Age.Clear();
            Txt_Address.Clear();
            Txt_Email.Clear();
            Txt_Telephone.Clear();

            // Removendo valor do Label
            Lbl_DatesText.Text = "";
        }
    }
}