
namespace PROJETO_PARALELO
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
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Btn_Desativar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Box0 = new System.Windows.Forms.TextBox();
            this.Txt_Box1 = new System.Windows.Forms.TextBox();
            this.Txt_Box2 = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Resultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Ativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ativar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ativar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ativar.Location = new System.Drawing.Point(231, 85);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(101, 30);
            this.Btn_Ativar.TabIndex = 0;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = false;
            this.Btn_Ativar.Click += new System.EventHandler(this.Btn_Ativar_Click);
            // 
            // Btn_Desativar
            // 
            this.Btn_Desativar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Desativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Desativar.Enabled = false;
            this.Btn_Desativar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desativar.ForeColor = System.Drawing.Color.White;
            this.Btn_Desativar.Location = new System.Drawing.Point(343, 85);
            this.Btn_Desativar.Name = "Btn_Desativar";
            this.Btn_Desativar.Size = new System.Drawing.Size(101, 30);
            this.Btn_Desativar.TabIndex = 1;
            this.Btn_Desativar.Text = "Desativar";
            this.Btn_Desativar.UseVisualStyleBackColor = false;
            this.Btn_Desativar.Click += new System.EventHandler(this.Btn_Desativar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Enabled = false;
            this.Btn_Limpar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpar.Location = new System.Drawing.Point(455, 85);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(101, 30);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Box0
            // 
            this.Txt_Box0.Enabled = false;
            this.Txt_Box0.Location = new System.Drawing.Point(319, 135);
            this.Txt_Box0.Name = "Txt_Box0";
            this.Txt_Box0.Size = new System.Drawing.Size(146, 20);
            this.Txt_Box0.TabIndex = 3;
            this.Txt_Box0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Box1
            // 
            this.Txt_Box1.Enabled = false;
            this.Txt_Box1.Location = new System.Drawing.Point(319, 181);
            this.Txt_Box1.Name = "Txt_Box1";
            this.Txt_Box1.Size = new System.Drawing.Size(146, 20);
            this.Txt_Box1.TabIndex = 4;
            this.Txt_Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Box2
            // 
            this.Txt_Box2.Enabled = false;
            this.Txt_Box2.Location = new System.Drawing.Point(319, 227);
            this.Txt_Box2.Name = "Txt_Box2";
            this.Txt_Box2.Size = new System.Drawing.Size(146, 20);
            this.Txt_Box2.TabIndex = 5;
            this.Txt_Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.BackColor = System.Drawing.Color.Black;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.White;
            this.Lbl_Resultado.Location = new System.Drawing.Point(352, 324);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Resultado.TabIndex = 6;
            this.Lbl_Resultado.Text = "Resultado";
            this.Lbl_Resultado.Visible = false;
            // 
            // Btn_Resultado
            // 
            this.Btn_Resultado.BackColor = System.Drawing.Color.Orange;
            this.Btn_Resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Resultado.Enabled = false;
            this.Btn_Resultado.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Resultado.ForeColor = System.Drawing.Color.White;
            this.Btn_Resultado.Location = new System.Drawing.Point(297, 253);
            this.Btn_Resultado.Name = "Btn_Resultado";
            this.Btn_Resultado.Size = new System.Drawing.Size(181, 41);
            this.Btn_Resultado.TabIndex = 7;
            this.Btn_Resultado.Text = "Resultado";
            this.Btn_Resultado.UseVisualStyleBackColor = false;
            this.Btn_Resultado.Click += new System.EventHandler(this.Btn_Resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("mono 07_65", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(232, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "PROJETO PARALELO";
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Imagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Imagem.Location = new System.Drawing.Point(199, 12);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(405, 393);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_Imagem.TabIndex = 9;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Resultado);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Box2);
            this.Controls.Add(this.Txt_Box1);
            this.Controls.Add(this.Txt_Box0);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Desativar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Pic_Imagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Projeto";
            this.Text = "ESTUDO CADASTRO";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.Button Btn_Desativar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Box0;
        private System.Windows.Forms.TextBox Txt_Box1;
        private System.Windows.Forms.TextBox Txt_Box2;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_Imagem;
    }
}

