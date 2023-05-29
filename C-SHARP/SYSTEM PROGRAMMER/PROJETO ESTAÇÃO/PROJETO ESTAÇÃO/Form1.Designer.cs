
namespace PROJETO_ESTAÇÃO
{
    partial class Form1
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
            this.GrpEstacao = new System.Windows.Forms.GroupBox();
            this.RadVerão = new System.Windows.Forms.RadioButton();
            this.RadOutono = new System.Windows.Forms.RadioButton();
            this.RadPrimavera = new System.Windows.Forms.RadioButton();
            this.RadInverno = new System.Windows.Forms.RadioButton();
            this.TxtInformativo = new System.Windows.Forms.TextBox();
            this.PicImgCentro = new System.Windows.Forms.PictureBox();
            this.LblInformativo = new System.Windows.Forms.Label();
            this.GrpEstacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImgCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEstacao
            // 
            this.GrpEstacao.Controls.Add(this.RadVerão);
            this.GrpEstacao.Controls.Add(this.RadOutono);
            this.GrpEstacao.Controls.Add(this.RadPrimavera);
            this.GrpEstacao.Controls.Add(this.RadInverno);
            this.GrpEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpEstacao.Location = new System.Drawing.Point(36, 105);
            this.GrpEstacao.Name = "GrpEstacao";
            this.GrpEstacao.Size = new System.Drawing.Size(206, 186);
            this.GrpEstacao.TabIndex = 0;
            this.GrpEstacao.TabStop = false;
            this.GrpEstacao.Text = "AS 4 ESTAÇÕES";
            this.GrpEstacao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RadVerão
            // 
            this.RadVerão.AutoSize = true;
            this.RadVerão.ForeColor = System.Drawing.SystemColors.Control;
            this.RadVerão.Location = new System.Drawing.Point(9, 122);
            this.RadVerão.Name = "RadVerão";
            this.RadVerão.Size = new System.Drawing.Size(68, 20);
            this.RadVerão.TabIndex = 4;
            this.RadVerão.TabStop = true;
            this.RadVerão.Text = "Verão";
            this.RadVerão.UseVisualStyleBackColor = true;
            this.RadVerão.CheckedChanged += new System.EventHandler(this.RadVerão_CheckedChanged);
            // 
            // RadOutono
            // 
            this.RadOutono.AutoSize = true;
            this.RadOutono.ForeColor = System.Drawing.SystemColors.Control;
            this.RadOutono.Location = new System.Drawing.Point(9, 44);
            this.RadOutono.Name = "RadOutono";
            this.RadOutono.Size = new System.Drawing.Size(75, 20);
            this.RadOutono.TabIndex = 1;
            this.RadOutono.TabStop = true;
            this.RadOutono.Text = "Outono";
            this.RadOutono.UseVisualStyleBackColor = true;
            this.RadOutono.CheckedChanged += new System.EventHandler(this.RadOutono_CheckedChanged);
            // 
            // RadPrimavera
            // 
            this.RadPrimavera.AutoSize = true;
            this.RadPrimavera.ForeColor = System.Drawing.SystemColors.Control;
            this.RadPrimavera.Location = new System.Drawing.Point(9, 96);
            this.RadPrimavera.Name = "RadPrimavera";
            this.RadPrimavera.Size = new System.Drawing.Size(97, 20);
            this.RadPrimavera.TabIndex = 3;
            this.RadPrimavera.TabStop = true;
            this.RadPrimavera.Text = "Primavera";
            this.RadPrimavera.UseVisualStyleBackColor = true;
            this.RadPrimavera.CheckedChanged += new System.EventHandler(this.RadPrimavera_CheckedChanged);
            // 
            // RadInverno
            // 
            this.RadInverno.AutoSize = true;
            this.RadInverno.ForeColor = System.Drawing.SystemColors.Control;
            this.RadInverno.Location = new System.Drawing.Point(9, 70);
            this.RadInverno.Name = "RadInverno";
            this.RadInverno.Size = new System.Drawing.Size(77, 20);
            this.RadInverno.TabIndex = 2;
            this.RadInverno.TabStop = true;
            this.RadInverno.Text = "Inverno";
            this.RadInverno.UseVisualStyleBackColor = true;
            this.RadInverno.CheckedChanged += new System.EventHandler(this.RadInverno_CheckedChanged);
            // 
            // TxtInformativo
            // 
            this.TxtInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInformativo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtInformativo.Location = new System.Drawing.Point(36, 36);
            this.TxtInformativo.Name = "TxtInformativo";
            this.TxtInformativo.Size = new System.Drawing.Size(235, 22);
            this.TxtInformativo.TabIndex = 0;
            this.TxtInformativo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PicImgCentro
            // 
            this.PicImgCentro.Location = new System.Drawing.Point(294, 12);
            this.PicImgCentro.Name = "PicImgCentro";
            this.PicImgCentro.Size = new System.Drawing.Size(485, 426);
            this.PicImgCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImgCentro.TabIndex = 1;
            this.PicImgCentro.TabStop = false;
            // 
            // LblInformativo
            // 
            this.LblInformativo.AutoSize = true;
            this.LblInformativo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformativo.Location = new System.Drawing.Point(102, 17);
            this.LblInformativo.Name = "LblInformativo";
            this.LblInformativo.Size = new System.Drawing.Size(94, 18);
            this.LblInformativo.TabIndex = 5;
            this.LblInformativo.Text = "Informações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblInformativo);
            this.Controls.Add(this.PicImgCentro);
            this.Controls.Add(this.TxtInformativo);
            this.Controls.Add(this.GrpEstacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpEstacao.ResumeLayout(false);
            this.GrpEstacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImgCentro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpEstacao;
        private System.Windows.Forms.TextBox TxtInformativo;
        private System.Windows.Forms.RadioButton RadVerão;
        private System.Windows.Forms.RadioButton RadOutono;
        private System.Windows.Forms.RadioButton RadPrimavera;
        private System.Windows.Forms.RadioButton RadInverno;
        private System.Windows.Forms.PictureBox PicImgCentro;
        private System.Windows.Forms.Label LblInformativo;
    }
}

