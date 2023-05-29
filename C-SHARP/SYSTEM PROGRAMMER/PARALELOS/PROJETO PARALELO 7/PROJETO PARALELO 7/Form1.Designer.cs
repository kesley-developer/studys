
namespace PROJETO_PARALELO_7
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
            this.Lbl_Number = new System.Windows.Forms.Label();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.Lbl_Bigger = new System.Windows.Forms.Label();
            this.Lbl_Smaller = new System.Windows.Forms.Label();
            this.Pic_Box = new System.Windows.Forms.PictureBox();
            this.Lbl_illustrationTop = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Lbl_biggerResult = new System.Windows.Forms.Label();
            this.Lbl_smallerResult = new System.Windows.Forms.Label();
            this.Lbl_illustrationBottom = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Number
            // 
            this.Lbl_Number.AutoSize = true;
            this.Lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Number.Location = new System.Drawing.Point(212, 176);
            this.Lbl_Number.Name = "Lbl_Number";
            this.Lbl_Number.Size = new System.Drawing.Size(134, 20);
            this.Lbl_Number.TabIndex = 0;
            this.Lbl_Number.Text = "Digite um número";
            // 
            // Txt_Number
            // 
            this.Txt_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Number.Location = new System.Drawing.Point(352, 173);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(125, 26);
            this.Txt_Number.TabIndex = 1;
            this.Txt_Number.TextChanged += new System.EventHandler(this.Txt_Number_TextChanged);
            // 
            // Lbl_Bigger
            // 
            this.Lbl_Bigger.AutoSize = true;
            this.Lbl_Bigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bigger.Location = new System.Drawing.Point(480, 231);
            this.Lbl_Bigger.Name = "Lbl_Bigger";
            this.Lbl_Bigger.Size = new System.Drawing.Size(47, 16);
            this.Lbl_Bigger.TabIndex = 2;
            this.Lbl_Bigger.Text = "Maior";
            this.Lbl_Bigger.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_Smaller
            // 
            this.Lbl_Smaller.AutoSize = true;
            this.Lbl_Smaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Smaller.Location = new System.Drawing.Point(295, 231);
            this.Lbl_Smaller.Name = "Lbl_Smaller";
            this.Lbl_Smaller.Size = new System.Drawing.Size(51, 16);
            this.Lbl_Smaller.TabIndex = 3;
            this.Lbl_Smaller.Text = "Menor";
            this.Lbl_Smaller.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pic_Box
            // 
            this.Pic_Box.Location = new System.Drawing.Point(153, 108);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(508, 202);
            this.Pic_Box.TabIndex = 4;
            this.Pic_Box.TabStop = false;
            // 
            // Lbl_illustrationTop
            // 
            this.Lbl_illustrationTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lbl_illustrationTop.Font = new System.Drawing.Font("mono 07_55", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_illustrationTop.ForeColor = System.Drawing.Color.White;
            this.Lbl_illustrationTop.Location = new System.Drawing.Point(153, 108);
            this.Lbl_illustrationTop.Name = "Lbl_illustrationTop";
            this.Lbl_illustrationTop.Size = new System.Drawing.Size(508, 32);
            this.Lbl_illustrationTop.TabIndex = 5;
            this.Lbl_illustrationTop.Text = "ANTECESSOR E SUCESSOR";
            this.Lbl_illustrationTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.Image")));
            this.Btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Clear.Location = new System.Drawing.Point(483, 171);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Lbl_biggerResult
            // 
            this.Lbl_biggerResult.AutoSize = true;
            this.Lbl_biggerResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_biggerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_biggerResult.Location = new System.Drawing.Point(497, 257);
            this.Lbl_biggerResult.Name = "Lbl_biggerResult";
            this.Lbl_biggerResult.Size = new System.Drawing.Size(18, 20);
            this.Lbl_biggerResult.TabIndex = 7;
            this.Lbl_biggerResult.Text = "?";
            this.Lbl_biggerResult.Click += new System.EventHandler(this.Lbl_biggerResult_Click);
            // 
            // Lbl_smallerResult
            // 
            this.Lbl_smallerResult.AutoSize = true;
            this.Lbl_smallerResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_smallerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_smallerResult.Location = new System.Drawing.Point(314, 257);
            this.Lbl_smallerResult.Name = "Lbl_smallerResult";
            this.Lbl_smallerResult.Size = new System.Drawing.Size(18, 20);
            this.Lbl_smallerResult.TabIndex = 8;
            this.Lbl_smallerResult.Text = "?";
            this.Lbl_smallerResult.Click += new System.EventHandler(this.Lbl_smallerResult_Click);
            // 
            // Lbl_illustrationBottom
            // 
            this.Lbl_illustrationBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.Lbl_illustrationBottom.Location = new System.Drawing.Point(153, 300);
            this.Lbl_illustrationBottom.Name = "Lbl_illustrationBottom";
            this.Lbl_illustrationBottom.Size = new System.Drawing.Size(508, 10);
            this.Lbl_illustrationBottom.TabIndex = 9;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("mono 07_55", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(578, 108);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(83, 32);
            this.Btn_Close.TabIndex = 10;
            this.Btn_Close.Text = "Encerrar";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_illustrationBottom);
            this.Controls.Add(this.Lbl_smallerResult);
            this.Controls.Add(this.Lbl_biggerResult);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Lbl_illustrationTop);
            this.Controls.Add(this.Lbl_Smaller);
            this.Controls.Add(this.Lbl_Bigger);
            this.Controls.Add(this.Txt_Number);
            this.Controls.Add(this.Lbl_Number);
            this.Controls.Add(this.Pic_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Project";
            this.Text = "PROJETO INVISIVEL";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Number;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Label Lbl_Bigger;
        private System.Windows.Forms.Label Lbl_Smaller;
        private System.Windows.Forms.PictureBox Pic_Box;
        private System.Windows.Forms.Label Lbl_illustrationTop;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label Lbl_biggerResult;
        private System.Windows.Forms.Label Lbl_smallerResult;
        private System.Windows.Forms.Label Lbl_illustrationBottom;
        private System.Windows.Forms.Button Btn_Close;
    }
}

