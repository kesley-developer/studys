
namespace PROJETO_PARALELO_4
{
    partial class Frm_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Project));
            this.Lbl_Number0 = new System.Windows.Forms.Label();
            this.Lbl_Number1 = new System.Windows.Forms.Label();
            this.Txt_Number0 = new System.Windows.Forms.TextBox();
            this.Txt_Number1 = new System.Windows.Forms.TextBox();
            this.Pic_Image = new System.Windows.Forms.PictureBox();
            this.Btn_Sum = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Error = new System.Windows.Forms.Label();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Btn_Subt = new System.Windows.Forms.Button();
            this.Btn_Mult = new System.Windows.Forms.Button();
            this.Btn_Divi = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Number0
            // 
            this.Lbl_Number0.AutoSize = true;
            this.Lbl_Number0.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Number0.Location = new System.Drawing.Point(47, 128);
            this.Lbl_Number0.Name = "Lbl_Number0";
            this.Lbl_Number0.Size = new System.Drawing.Size(98, 20);
            this.Lbl_Number0.TabIndex = 0;
            this.Lbl_Number0.Text = "Primeiro Nº";
            // 
            // Lbl_Number1
            // 
            this.Lbl_Number1.AutoSize = true;
            this.Lbl_Number1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Number1.Location = new System.Drawing.Point(42, 215);
            this.Lbl_Number1.Name = "Lbl_Number1";
            this.Lbl_Number1.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Number1.TabIndex = 2;
            this.Lbl_Number1.Text = "Segundo Nº";
            // 
            // Txt_Number0
            // 
            this.Txt_Number0.Location = new System.Drawing.Point(46, 158);
            this.Txt_Number0.Name = "Txt_Number0";
            this.Txt_Number0.Size = new System.Drawing.Size(100, 20);
            this.Txt_Number0.TabIndex = 3;
            this.Txt_Number0.TextChanged += new System.EventHandler(this.Txt_Number0_TextChanged);
            // 
            // Txt_Number1
            // 
            this.Txt_Number1.Location = new System.Drawing.Point(44, 245);
            this.Txt_Number1.Name = "Txt_Number1";
            this.Txt_Number1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Number1.TabIndex = 4;
            // 
            // Pic_Image
            // 
            this.Pic_Image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pic_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_Image.BackgroundImage")));
            this.Pic_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Image.Location = new System.Drawing.Point(202, 6);
            this.Pic_Image.Name = "Pic_Image";
            this.Pic_Image.Size = new System.Drawing.Size(601, 474);
            this.Pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Image.TabIndex = 5;
            this.Pic_Image.TabStop = false;
            this.Pic_Image.Click += new System.EventHandler(this.Pic_Image_Click);
            // 
            // Btn_Sum
            // 
            this.Btn_Sum.BackColor = System.Drawing.Color.Indigo;
            this.Btn_Sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Sum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sum.ForeColor = System.Drawing.Color.White;
            this.Btn_Sum.Location = new System.Drawing.Point(13, 292);
            this.Btn_Sum.Name = "Btn_Sum";
            this.Btn_Sum.Size = new System.Drawing.Size(41, 34);
            this.Btn_Sum.TabIndex = 6;
            this.Btn_Sum.Text = "+";
            this.Btn_Sum.UseVisualStyleBackColor = false;
            this.Btn_Sum.Click += new System.EventHandler(this.Btn_Sum_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Indigo;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(50, 343);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(100, 34);
            this.Btn_Clear.TabIndex = 7;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("mono 07_55", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculator +";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Error
            // 
            this.Lbl_Error.AutoSize = true;
            this.Lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Error.Location = new System.Drawing.Point(11, 394);
            this.Lbl_Error.Name = "Lbl_Error";
            this.Lbl_Error.Size = new System.Drawing.Size(0, 18);
            this.Lbl_Error.TabIndex = 11;
            this.Lbl_Error.Visible = false;
            this.Lbl_Error.Click += new System.EventHandler(this.Lbl_Error_Click);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Result.Font = new System.Drawing.Font("mono 07_55", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(368, 90);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(261, 60);
            this.Lbl_Result.TabIndex = 10;
            this.Lbl_Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Result.Click += new System.EventHandler(this.Lbl_Result_Click);
            // 
            // Btn_Subt
            // 
            this.Btn_Subt.BackColor = System.Drawing.Color.Indigo;
            this.Btn_Subt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Subt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Subt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Subt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Subt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Subt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subt.ForeColor = System.Drawing.Color.White;
            this.Btn_Subt.Location = new System.Drawing.Point(60, 292);
            this.Btn_Subt.Name = "Btn_Subt";
            this.Btn_Subt.Size = new System.Drawing.Size(41, 34);
            this.Btn_Subt.TabIndex = 12;
            this.Btn_Subt.Text = "-";
            this.Btn_Subt.UseVisualStyleBackColor = false;
            this.Btn_Subt.Click += new System.EventHandler(this.Btn_Subt_Click);
            // 
            // Btn_Mult
            // 
            this.Btn_Mult.BackColor = System.Drawing.Color.Indigo;
            this.Btn_Mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Mult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Mult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Mult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mult.ForeColor = System.Drawing.Color.White;
            this.Btn_Mult.Location = new System.Drawing.Point(107, 292);
            this.Btn_Mult.Name = "Btn_Mult";
            this.Btn_Mult.Size = new System.Drawing.Size(41, 34);
            this.Btn_Mult.TabIndex = 13;
            this.Btn_Mult.Text = "x";
            this.Btn_Mult.UseVisualStyleBackColor = false;
            this.Btn_Mult.Click += new System.EventHandler(this.Btn_Mult_Click);
            // 
            // Btn_Divi
            // 
            this.Btn_Divi.BackColor = System.Drawing.Color.Indigo;
            this.Btn_Divi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Divi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Divi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Divi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Divi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divi.ForeColor = System.Drawing.Color.White;
            this.Btn_Divi.Location = new System.Drawing.Point(154, 292);
            this.Btn_Divi.Name = "Btn_Divi";
            this.Btn_Divi.Size = new System.Drawing.Size(41, 34);
            this.Btn_Divi.TabIndex = 14;
            this.Btn_Divi.Text = "÷";
            this.Btn_Divi.UseVisualStyleBackColor = false;
            this.Btn_Divi.Click += new System.EventHandler(this.Btn_Divi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Divi);
            this.Controls.Add(this.Btn_Mult);
            this.Controls.Add(this.Btn_Subt);
            this.Controls.Add(this.Lbl_Error);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Sum);
            this.Controls.Add(this.Txt_Number1);
            this.Controls.Add(this.Txt_Number0);
            this.Controls.Add(this.Lbl_Number1);
            this.Controls.Add(this.Lbl_Number0);
            this.Controls.Add(this.Pic_Image);
            this.Controls.Add(this.button1);
            this.Name = "Frm_Project";
            this.Text = "CALCULADORA";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Number0;
        private System.Windows.Forms.Label Lbl_Number1;
        private System.Windows.Forms.TextBox Txt_Number0;
        private System.Windows.Forms.TextBox Txt_Number1;
        private System.Windows.Forms.PictureBox Pic_Image;
        private System.Windows.Forms.Button Btn_Sum;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Error;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.Button Btn_Subt;
        private System.Windows.Forms.Button Btn_Mult;
        private System.Windows.Forms.Button Btn_Divi;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}

