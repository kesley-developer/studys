
namespace PROJETO_PARALELO_3
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
            this.Btn_Red = new System.Windows.Forms.Button();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.Btn_Blue = new System.Windows.Forms.Button();
            this.Btn_Purple = new System.Windows.Forms.Button();
            this.Btn_Yellow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Color = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Red
            // 
            this.Btn_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Red.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Red.FlatAppearance.BorderSize = 3;
            this.Btn_Red.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Red.Location = new System.Drawing.Point(103, 134);
            this.Btn_Red.Name = "Btn_Red";
            this.Btn_Red.Size = new System.Drawing.Size(94, 45);
            this.Btn_Red.TabIndex = 0;
            this.Btn_Red.Text = "Color Red";
            this.Btn_Red.UseVisualStyleBackColor = true;
            this.Btn_Red.Click += new System.EventHandler(this.Btn_Red_Click_1);
            // 
            // Btn_Green
            // 
            this.Btn_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Green.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Green.FlatAppearance.BorderSize = 3;
            this.Btn_Green.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.Btn_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Green.Location = new System.Drawing.Point(228, 134);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(94, 45);
            this.Btn_Green.TabIndex = 1;
            this.Btn_Green.Text = "Color Green";
            this.Btn_Green.UseVisualStyleBackColor = true;
            this.Btn_Green.Click += new System.EventHandler(this.Btn_Green_Click);
            // 
            // Btn_Blue
            // 
            this.Btn_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Blue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Blue.FlatAppearance.BorderSize = 3;
            this.Btn_Blue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Blue.Location = new System.Drawing.Point(353, 134);
            this.Btn_Blue.Name = "Btn_Blue";
            this.Btn_Blue.Size = new System.Drawing.Size(94, 45);
            this.Btn_Blue.TabIndex = 2;
            this.Btn_Blue.Text = "Color Blue";
            this.Btn_Blue.UseVisualStyleBackColor = true;
            this.Btn_Blue.Click += new System.EventHandler(this.Btn_Blue_Click);
            // 
            // Btn_Purple
            // 
            this.Btn_Purple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Purple.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Purple.FlatAppearance.BorderSize = 3;
            this.Btn_Purple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.Btn_Purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Purple.Location = new System.Drawing.Point(478, 134);
            this.Btn_Purple.Name = "Btn_Purple";
            this.Btn_Purple.Size = new System.Drawing.Size(94, 45);
            this.Btn_Purple.TabIndex = 3;
            this.Btn_Purple.Text = "Color Purple";
            this.Btn_Purple.UseVisualStyleBackColor = true;
            this.Btn_Purple.Click += new System.EventHandler(this.Btn_Purple_Click);
            // 
            // Btn_Yellow
            // 
            this.Btn_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Yellow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Yellow.FlatAppearance.BorderSize = 3;
            this.Btn_Yellow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Btn_Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Yellow.Location = new System.Drawing.Point(603, 134);
            this.Btn_Yellow.Name = "Btn_Yellow";
            this.Btn_Yellow.Size = new System.Drawing.Size(94, 45);
            this.Btn_Yellow.TabIndex = 4;
            this.Btn_Yellow.Text = "Color Yellow";
            this.Btn_Yellow.UseVisualStyleBackColor = true;
            this.Btn_Yellow.Click += new System.EventHandler(this.Btn_Yellow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select  Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pic_Color
            // 
            this.Pic_Color.Location = new System.Drawing.Point(296, 236);
            this.Pic_Color.Name = "Pic_Color";
            this.Pic_Color.Size = new System.Drawing.Size(223, 128);
            this.Pic_Color.TabIndex = 6;
            this.Pic_Color.TabStop = false;
            // 
            // Frm_Projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic_Color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Yellow);
            this.Controls.Add(this.Btn_Purple);
            this.Controls.Add(this.Btn_Blue);
            this.Controls.Add(this.Btn_Green);
            this.Controls.Add(this.Btn_Red);
            this.Name = "Frm_Projeto";
            this.Text = "EFEITOS DOS BOTÕES";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Red;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.Button Btn_Blue;
        private System.Windows.Forms.Button Btn_Purple;
        private System.Windows.Forms.Button Btn_Yellow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_Color;
    }
}

