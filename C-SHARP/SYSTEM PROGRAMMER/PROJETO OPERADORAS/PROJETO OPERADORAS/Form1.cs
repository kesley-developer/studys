using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_OPERADORAS
{
    public partial class Frm_Background : Form
    {
        public Frm_Background()
        {
            InitializeComponent();
        }

        private void Rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            // Vivo

            // Removendo valores de recarga anteriores
            Txt_Value.Clear();

            // Alterando cor de fundo
            BackColor = Color.DarkViolet;

            // Logo da operadora            
            Pic_OperatorLogo.Visible = true;
            Pic_OperatorLogo.BackgroundImage = Properties.Resources.vivo_logo;

            // Inserindo operadora ao TextBox
            Txt_Operator.Text = "VIVO";
            Txt_Operator.Enabled = false;

            // Ativando ferramentas 

            // Buttons
            Btn_Value0.Enabled = true;
            Btn_Value1.Enabled = true;
            Btn_Value2.Enabled = true;
            Btn_Value3.Enabled = true;
            Btn_Value4.Enabled = true;
            Btn_Value5.Enabled = true;
            Btn_Value6.Enabled = true;
            Btn_Value7.Enabled = true;

            // Labels
            Lbl_Name.Enabled = true;
            Lbl_Operator.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Number.Enabled = true;
            Lbl_Value.Enabled = true;
            Lbl_Days0.Visible = true;
            Lbl_Days1.Visible = true;
            Lbl_Days2.Visible = true;
            Lbl_Days2.Visible = true;
            Lbl_Days3.Visible = true;
            Lbl_Days4.Visible = true;
            Lbl_Days5.Visible = true;
            Lbl_Days6.Visible = true;
            Lbl_Days7.Visible = true;
            Lbl_RechargeOptions.Visible = true;
            Lbl_Welcome.Visible = true;

            // TextBox
            Txt_Name.Enabled = true;            
            Txt_DDD.Enabled = true;
            Txt_Number.Enabled = true;                      

            // Estilização

            // Labels
            Lbl_Name.ForeColor = Color.White;
            Lbl_Operator.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Number.ForeColor = Color.White;
            Lbl_Value.ForeColor = Color.White;
            Lbl_Days0.ForeColor = Color.White;
            Lbl_Days1.ForeColor = Color.White;
            Lbl_Days2.ForeColor = Color.White;
            Lbl_Days3.ForeColor = Color.White;
            Lbl_Days4.ForeColor = Color.White;
            Lbl_Days5.ForeColor = Color.White;
            Lbl_Days6.ForeColor = Color.White;
            Lbl_Days7.ForeColor = Color.White;
            Lbl_RechargeOptions.ForeColor = Color.White;

            // RadioButtons
            Rad_Vivo.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            // GroupBox
            Grp_Operators.ForeColor = Color.White;

            // Buttons
            Btn_Value0.ForeColor = Color.Violet;
            Btn_Value1.ForeColor = Color.Violet;
            Btn_Value2.ForeColor = Color.Violet;
            Btn_Value3.ForeColor = Color.Violet;
            Btn_Value4.ForeColor = Color.Violet;
            Btn_Value5.ForeColor = Color.Violet;
            Btn_Value6.ForeColor = Color.Violet;
            Btn_Value7.ForeColor = Color.Violet;

            // Buttons - Após passar o mouse
            Btn_Value0.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value7.FlatAppearance.MouseOverBackColor = Color.White;

            // Alterando valores de recarga

            // Buttons
            Btn_Value0.Text = "R$ 12,00";
            Btn_Value1.Text = "R$ 15,00";
            Btn_Value2.Text = "R$ 20,00";
            Btn_Value3.Text = "R$ 30,00";
            Btn_Value4.Text = "R$ 35,00";
            Btn_Value5.Text = "R$ 40,00";
            Btn_Value6.Text = "R$ 100,00";
            Btn_Value7.Text = "R$ 200,00";

            // Labels
            Lbl_Days0.Text = "30 Dias";
            Lbl_Days1.Text = "30 Dias";
            Lbl_Days2.Text = "30 Dias";
            Lbl_Days3.Text = "30 Dias";
            Lbl_Days4.Text = "90 Dias";
            Lbl_Days5.Text = "90 Dias";
            Lbl_Days6.Text = "180 Dias";
            Lbl_Days7.Text = "305 Dias";
            
        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            // Claro
            
            // Removendo valores de recarga anteriores
            Txt_Value.Clear();

            // Alterando cor de fundo
            BackColor = Color.Red;

            // Logo da operadora
            Pic_OperatorLogo.Visible = true;
            Pic_OperatorLogo.BackgroundImage = Properties.Resources.claro_logo;

            // Inserindo operadora ao TextBox
            Txt_Operator.Text = "CLARO";
            Txt_Operator.Enabled = false;

            // Ativando ferramentas

            // Buttons
            Btn_Value0.Enabled = true;
            Btn_Value1.Enabled = true;
            Btn_Value2.Enabled = true;
            Btn_Value3.Enabled = true;
            Btn_Value4.Enabled = true;
            Btn_Value5.Enabled = true;
            Btn_Value6.Enabled = true;
            Btn_Value7.Enabled = true;

            // Labels
            Lbl_Name.Enabled = true;
            Lbl_Operator.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Number.Enabled = true;
            Lbl_Value.Enabled = true;
            Lbl_Days0.Visible = true;
            Lbl_Days1.Visible = true;
            Lbl_Days2.Visible = true;
            Lbl_Days3.Visible = true;
            Lbl_Days4.Visible = true;
            Lbl_Days5.Visible = true;
            Lbl_Days6.Visible = true;
            Lbl_Days7.Visible = true;
            Lbl_RechargeOptions.Visible = true;
            Lbl_Welcome.Visible = true;

            // TextBox
            Txt_Name.Enabled = true;            
            Txt_DDD.Enabled = true;
            Txt_Number.Enabled = true;            

            // Estilização

            // Labels
            Lbl_Name.ForeColor = Color.White;
            Lbl_Operator.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Number.ForeColor = Color.White;
            Lbl_Value.ForeColor = Color.White;
            Lbl_Days0.ForeColor = Color.White;
            Lbl_Days1.ForeColor = Color.White;
            Lbl_Days2.ForeColor = Color.White;
            Lbl_Days3.ForeColor = Color.White;
            Lbl_Days4.ForeColor = Color.White;
            Lbl_Days5.ForeColor = Color.White;
            Lbl_Days6.ForeColor = Color.White;
            Lbl_Days7.ForeColor = Color.White;
            Lbl_RechargeOptions.ForeColor = Color.White;            

            // RadioButtons
            Rad_Vivo.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            // GroupBox
            Grp_Operators.ForeColor = Color.White;

            // Buttons
            Btn_Value0.ForeColor = Color.Black;
            Btn_Value1.ForeColor = Color.Black;
            Btn_Value2.ForeColor = Color.Black;
            Btn_Value3.ForeColor = Color.Black;
            Btn_Value4.ForeColor = Color.Black;
            Btn_Value5.ForeColor = Color.Black;
            Btn_Value6.ForeColor = Color.Black;
            Btn_Value7.ForeColor = Color.Black;

            // Buttons - Após passar o mouse
            Btn_Value0.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value7.FlatAppearance.MouseOverBackColor = Color.White;

            // Alterando valores de recarga

            // Buttons
            Btn_Value0.Text = "R$ 12,00";
            Btn_Value1.Text = "R$ 15,00";
            Btn_Value2.Text = "R$ 20,00";
            Btn_Value3.Text = "R$ 25,00";
            Btn_Value4.Text = "R$ 30,00";
            Btn_Value5.Text = "R$ 35,00";
            Btn_Value6.Text = "R$ 50,00";
            Btn_Value7.Text = "R$ 100,00";

            // Labels
            Lbl_Days0.Text = "30 Dias";
            Lbl_Days1.Text = "30 Dias";
            Lbl_Days2.Text = "60 Dias";
            Lbl_Days3.Text = "80 Dias";
            Lbl_Days4.Text = "90 Dias";
            Lbl_Days5.Text = "90 Dias";
            Lbl_Days6.Text = "120 Dias";
            Lbl_Days7.Text = "180 Dias";
        }

        private void Rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            // Tim

            // Removendo valores de recarga anteriores
            Txt_Value.Clear();

            // Alterando cor de fundo
            BackColor = Color.DarkBlue;

            // Logo da operadora
            Pic_OperatorLogo.Visible = true;
            Pic_OperatorLogo.BackgroundImage = Properties.Resources.tim_logo;

            // Inserindo operadora ao TextBox
            Txt_Operator.Text = "TIM";
            Txt_Operator.Enabled = false;

            // Ativando ferramentas

            // Buttons
            Btn_Value0.Enabled = true;
            Btn_Value1.Enabled = true;
            Btn_Value2.Enabled = true;
            Btn_Value3.Enabled = true;
            Btn_Value4.Enabled = true;
            Btn_Value5.Enabled = true;
            Btn_Value6.Enabled = true;
            Btn_Value7.Enabled = true;

            // Labels
            Lbl_Name.Enabled = true;
            Lbl_Operator.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Number.Enabled = true;
            Lbl_Value.Enabled = true;
            Lbl_Days0.Visible = true;
            Lbl_Days1.Visible = true;
            Lbl_Days2.Visible = true;
            Lbl_Days3.Visible = true;
            Lbl_Days4.Visible = true;
            Lbl_Days5.Visible = true;
            Lbl_Days6.Visible = true;
            Lbl_Days7.Visible = true;
            Lbl_RechargeOptions.Visible = true;
            Lbl_Welcome.Visible = true;

            // TextBox
            Txt_Name.Enabled = true;            
            Txt_DDD.Enabled = true;
            Txt_Number.Enabled = true;

            // Estilização

            // Labels
            Lbl_Name.ForeColor = Color.White;
            Lbl_Operator.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Number.ForeColor = Color.White;
            Lbl_Value.ForeColor = Color.White;
            Lbl_Days0.ForeColor = Color.White;
            Lbl_Days1.ForeColor = Color.White;
            Lbl_Days2.ForeColor = Color.White;
            Lbl_Days3.ForeColor = Color.White;
            Lbl_Days4.ForeColor = Color.White;
            Lbl_Days5.ForeColor = Color.White;
            Lbl_Days6.ForeColor = Color.White;
            Lbl_Days7.ForeColor = Color.White;
            Lbl_RechargeOptions.ForeColor = Color.White;

            // RadioButtons
            Rad_Vivo.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            // GroupBox
            Grp_Operators.ForeColor = Color.White;

            // Buttons
            Btn_Value0.ForeColor = Color.RoyalBlue;
            Btn_Value1.ForeColor = Color.RoyalBlue;
            Btn_Value2.ForeColor = Color.RoyalBlue;
            Btn_Value3.ForeColor = Color.RoyalBlue;
            Btn_Value4.ForeColor = Color.RoyalBlue;
            Btn_Value5.ForeColor = Color.RoyalBlue;
            Btn_Value6.ForeColor = Color.RoyalBlue;
            Btn_Value7.ForeColor = Color.RoyalBlue;

            // Buttons - Após passar o mouse
            Btn_Value0.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value7.FlatAppearance.MouseOverBackColor = Color.White;

            // Alterando valores de recarga

            // Buttons
            Btn_Value0.Text = "R$ 10,00";
            Btn_Value1.Text = "R$ 15,00";
            Btn_Value2.Text = "R$ 20,00";
            Btn_Value3.Text = "R$ 30,00";
            Btn_Value4.Text = "R$ 40,00";
            Btn_Value5.Text = "R$ 50,00";
            Btn_Value6.Text = "R$ 60,00";
            Btn_Value7.Text = "R$ 100,00";

            // Labels
            Lbl_Days0.Text = "30 Dias";
            Lbl_Days1.Text = "30 Dias";
            Lbl_Days2.Text = "30 Dias";
            Lbl_Days3.Text = "90 Dias";
            Lbl_Days4.Text = "90 Dias";
            Lbl_Days5.Text = "180 Dias";
            Lbl_Days6.Text = "180 Dias";
            Lbl_Days7.Text = "180 Dias";
        }

        private void Rad_Oi_CheckedChanged(object sender, EventArgs e)
        {
            // Oi

            // Removendo valores de recarga anteriores            
            Txt_Value.Clear();            

            // Alterando cor de fundo
            BackColor = Color.Orange;

            // Logo da operadora
            Pic_OperatorLogo.Visible = true;
            Pic_OperatorLogo.BackgroundImage = Properties.Resources.oi_logo;

            // Inserindo operadora ao TextBox
            Txt_Operator.Text = "OI";
            Txt_Operator.Enabled = false;

            // Ativando ferramentas

            // Buttons
            Btn_Value0.Enabled = true;
            Btn_Value1.Enabled = true;
            Btn_Value2.Enabled = true;
            Btn_Value3.Enabled = true;
            Btn_Value4.Enabled = true;
            Btn_Value5.Enabled = true;
            Btn_Value6.Enabled = true;
            Btn_Value7.Enabled = true;

            // Labels
            Lbl_Name.Enabled = true;
            Lbl_Operator.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Number.Enabled = true;
            Lbl_Value.Enabled = true;
            Lbl_Days0.Visible = true;
            Lbl_Days1.Visible = true;
            Lbl_Days2.Visible = true;
            Lbl_Days3.Visible = true;
            Lbl_Days4.Visible = true;
            Lbl_Days5.Visible = true;
            Lbl_Days6.Visible = true;
            Lbl_Days7.Visible = true;
            Lbl_RechargeOptions.Visible = true;
            Lbl_Welcome.Visible = true;

            // TextBox
            Txt_Name.Enabled = true;            
            Txt_DDD.Enabled = true;
            Txt_Number.Enabled = true;

            // Estilização

            // Labels
            Lbl_Name.ForeColor = Color.White;
            Lbl_Operator.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Number.ForeColor = Color.White;
            Lbl_Value.ForeColor = Color.White;
            Lbl_Days0.ForeColor = Color.White;
            Lbl_Days1.ForeColor = Color.White;
            Lbl_Days2.ForeColor = Color.White;
            Lbl_Days3.ForeColor = Color.White;
            Lbl_Days4.ForeColor = Color.White;
            Lbl_Days5.ForeColor = Color.White;
            Lbl_Days6.ForeColor = Color.White;
            Lbl_Days7.ForeColor = Color.White;
            Lbl_RechargeOptions.ForeColor = Color.White;

            // RadioButtons
            Rad_Vivo.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            // GroupBox
            Grp_Operators.ForeColor = Color.White;

            // Buttons
            Btn_Value0.ForeColor = Color.Gold;
            Btn_Value1.ForeColor = Color.Gold;
            Btn_Value2.ForeColor = Color.Gold;
            Btn_Value3.ForeColor = Color.Gold;
            Btn_Value4.ForeColor = Color.Gold;
            Btn_Value5.ForeColor = Color.Gold;
            Btn_Value6.ForeColor = Color.Gold;
            Btn_Value7.ForeColor = Color.Gold;

            // Buttons - Após passar o mouse
            Btn_Value0.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_Value7.FlatAppearance.MouseOverBackColor = Color.White;

            // Alterando valores de recarga

            // Buttons
            Btn_Value0.Text = "R$ 10,00";
            Btn_Value1.Text = "R$ 15,00";
            Btn_Value2.Text = "R$ 20,00";
            Btn_Value3.Text = "R$ 25,00";
            Btn_Value4.Text = "R$ 30,00";
            Btn_Value5.Text = "R$ 35,00";
            Btn_Value6.Text = "R$ 40,00";
            Btn_Value7.Text = "R$ 50,00";

            // Labels
            Lbl_Days0.Text = "30 Dias";
            Lbl_Days1.Text = "30 Dias";
            Lbl_Days2.Text = "45 Dias";
            Lbl_Days3.Text = "45 Dias";
            Lbl_Days4.Text = "90 Dias";
            Lbl_Days5.Text = "90 Dias";
            Lbl_Days6.Text = "90 Dias";
            Lbl_Days7.Text = "90 Dias";
        }

        private void Pic_OperatorLogo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Value0_Click(object sender, EventArgs e)
        {
            // Valor de recarga 1
            Txt_Value.Text = Btn_Value0.Text;
        }

        private void Btn_Value1_Click(object sender, EventArgs e)
        {
            // Valor de recarga 2
            Txt_Value.Text = Btn_Value1.Text;
        }

        private void Btn_Value2_Click(object sender, EventArgs e)
        {
            // Valor de recarga 3
            Txt_Value.Text = Btn_Value2.Text;
        }

        private void Btn_Value3_Click(object sender, EventArgs e)
        {
            // Valor de recarga 4
            Txt_Value.Text = Btn_Value3.Text;
        }

        private void Btn_Value4_Click(object sender, EventArgs e)
        {
            // Valor de recarga 5
            Txt_Value.Text = Btn_Value4.Text;
        }

        private void Btn_Value5_Click(object sender, EventArgs e)
        {
            // Valor de recarga 6
            Txt_Value.Text = Btn_Value5.Text;
        }

        private void Btn_Value6_Click(object sender, EventArgs e)
        {
            // Valor de recarga 7
            Txt_Value.Text = Btn_Value6.Text;
        }

        private void Btn_Value7_Click(object sender, EventArgs e)
        {
            // Valor de recarga 8
            Txt_Value.Text = Btn_Value7.Text;
        }

        private void Pic_Illustration_Click(object sender, EventArgs e)
        {

        }
    }
}
