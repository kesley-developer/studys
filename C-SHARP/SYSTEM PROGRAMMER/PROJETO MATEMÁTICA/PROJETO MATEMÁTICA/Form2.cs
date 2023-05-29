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
    public partial class Frm_Double : Form
    {
        // Declarando variável que vai receber um valor inteiro
        int number;

        public Frm_Double()
        {
            InitializeComponent();
        }

        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            // Voltando ao FRM_PROJECT
            Close();
            Frm_Project dobro = new Frm_Project();            
            dobro.Show();
        }

        private void Txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validação aceitar somente numeros e o uso da tecla de controle
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Liberando a digitação de numeros e armazenando a tecla
            {
                e.Handled = true; // Verificando se a tecla armazenada é numero
                MessageBox.Show("SOMENTE NÚMEROS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensagem de erro
            }

            // Programação da tecla enter
            if (e.KeyChar == 13)
            {
                // Condição para verificar se o numero foi digitado
                if (Txt_Number.Text != "")
                {
                    // A variável esta recebendo o numero que foi digitado e convertido
                    number = int.Parse(Txt_Number.Text);

                    // Calculo do dobro
                    number = number * 2;

                    // Mostrando o resultado
                    MessageBox.Show("O dobro de " + Txt_Number.Text + " é igual a " + number, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Removendo o valor digitado
                    Txt_Number.Clear();                 
                }

                    
                    // Caso a tecla ENTER seja pressionada e não tenha valor no TextBox 
                    else
                {
                    MessageBox.Show("DIGITE UM NÚMERO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
