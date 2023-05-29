
namespace PROJETO_PARALELO_2
{
    partial class Frm_Projeto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Projeto));
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Btn_Cadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(251, 223);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(60, 20);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CPF.ForeColor = System.Drawing.Color.White;
            this.Lbl_CPF.Location = new System.Drawing.Point(251, 264);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(48, 20);
            this.Lbl_CPF.TabIndex = 1;
            this.Lbl_CPF.Text = "CPF:";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(330, 225);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(173, 20);
            this.Txt_Nome.TabIndex = 2;
            this.Txt_Nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(330, 264);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(173, 20);
            this.Txt_CPF.TabIndex = 3;
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastro.ForeColor = System.Drawing.Color.White;
            this.Btn_Cadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cadastro.Image")));
            this.Btn_Cadastro.Location = new System.Drawing.Point(389, 305);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(114, 35);
            this.Btn_Cadastro.TabIndex = 4;
            this.Btn_Cadastro.Text = "Cadastrar";
            this.Btn_Cadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Cadastro.UseVisualStyleBackColor = false;
            this.Btn_Cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(218, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mono 07_55", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Acesse sua conta";
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Erro.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Erro.Location = new System.Drawing.Point(258, 350);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(41, 16);
            this.Lbl_Erro.TabIndex = 10;
            this.Lbl_Erro.Text = "Erro!";
            this.Lbl_Erro.Visible = false;
            // 
            // Frm_Projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.Txt_CPF);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Lbl_Nome);
            this.Name = "Frm_Projeto";
            this.Text = "MessageBox1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Button Btn_Cadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Erro;
    }
}

