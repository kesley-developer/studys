
namespace PROJETO_MATEMÁTICA
{
    partial class Frm_Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calculator));
            this.Pic_Illustration = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Txt_Value2 = new System.Windows.Forms.TextBox();
            this.Txt_Value1 = new System.Windows.Forms.TextBox();
            this.Lbl_Box = new System.Windows.Forms.Label();
            this.Lbl_Value1 = new System.Windows.Forms.Label();
            this.Lbl_Value2 = new System.Windows.Forms.Label();
            this.Txt_Sum = new System.Windows.Forms.TextBox();
            this.Txt_Divi = new System.Windows.Forms.TextBox();
            this.Txt_Mult = new System.Windows.Forms.TextBox();
            this.Txt_Subt = new System.Windows.Forms.TextBox();
            this.Btn_Sum = new System.Windows.Forms.Button();
            this.Btn_Subt = new System.Windows.Forms.Button();
            this.Btn_Mult = new System.Windows.Forms.Button();
            this.Btn_Divi = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Illustration
            // 
            this.Pic_Illustration.BackColor = System.Drawing.Color.White;
            this.Pic_Illustration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Illustration.Location = new System.Drawing.Point(-5, -10);
            this.Pic_Illustration.Name = "Pic_Illustration";
            this.Pic_Illustration.Size = new System.Drawing.Size(809, 64);
            this.Pic_Illustration.TabIndex = 12;
            this.Pic_Illustration.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.White;
            this.Btn_Back.Location = new System.Drawing.Point(730, 12);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(58, 30);
            this.Btn_Back.TabIndex = 13;
            this.Btn_Back.Text = "X";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(48, 80);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(322, 44);
            this.Lbl_Title.TabIndex = 14;
            this.Lbl_Title.Text = "CALCULADORA";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Value2
            // 
            this.Txt_Value2.Location = new System.Drawing.Point(230, 169);
            this.Txt_Value2.Name = "Txt_Value2";
            this.Txt_Value2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Value2.TabIndex = 15;
            this.Txt_Value2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Value2_KeyPress);
            // 
            // Txt_Value1
            // 
            this.Txt_Value1.Location = new System.Drawing.Point(88, 169);
            this.Txt_Value1.Name = "Txt_Value1";
            this.Txt_Value1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Value1.TabIndex = 16;
            this.Txt_Value1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Value1_KeyPress);
            // 
            // Lbl_Box
            // 
            this.Lbl_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Box.Location = new System.Drawing.Point(49, 80);
            this.Lbl_Box.Name = "Lbl_Box";
            this.Lbl_Box.Size = new System.Drawing.Size(321, 316);
            this.Lbl_Box.TabIndex = 17;
            // 
            // Lbl_Value1
            // 
            this.Lbl_Value1.AutoSize = true;
            this.Lbl_Value1.Location = new System.Drawing.Point(117, 153);
            this.Lbl_Value1.Name = "Lbl_Value1";
            this.Lbl_Value1.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Value1.TabIndex = 18;
            this.Lbl_Value1.Text = "Valor 1";
            // 
            // Lbl_Value2
            // 
            this.Lbl_Value2.AutoSize = true;
            this.Lbl_Value2.Location = new System.Drawing.Point(259, 153);
            this.Lbl_Value2.Name = "Lbl_Value2";
            this.Lbl_Value2.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Value2.TabIndex = 19;
            this.Lbl_Value2.Text = "Valor 2";
            // 
            // Txt_Sum
            // 
            this.Txt_Sum.Enabled = false;
            this.Txt_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sum.Location = new System.Drawing.Point(221, 221);
            this.Txt_Sum.Name = "Txt_Sum";
            this.Txt_Sum.Size = new System.Drawing.Size(109, 22);
            this.Txt_Sum.TabIndex = 20;
            // 
            // Txt_Divi
            // 
            this.Txt_Divi.Enabled = false;
            this.Txt_Divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Divi.Location = new System.Drawing.Point(221, 311);
            this.Txt_Divi.Name = "Txt_Divi";
            this.Txt_Divi.Size = new System.Drawing.Size(109, 22);
            this.Txt_Divi.TabIndex = 21;
            // 
            // Txt_Mult
            // 
            this.Txt_Mult.Enabled = false;
            this.Txt_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mult.Location = new System.Drawing.Point(221, 281);
            this.Txt_Mult.Name = "Txt_Mult";
            this.Txt_Mult.Size = new System.Drawing.Size(109, 22);
            this.Txt_Mult.TabIndex = 22;
            // 
            // Txt_Subt
            // 
            this.Txt_Subt.Enabled = false;
            this.Txt_Subt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subt.Location = new System.Drawing.Point(221, 251);
            this.Txt_Subt.Name = "Txt_Subt";
            this.Txt_Subt.Size = new System.Drawing.Size(109, 22);
            this.Txt_Subt.TabIndex = 23;
            // 
            // Btn_Sum
            // 
            this.Btn_Sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sum.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sum.Location = new System.Drawing.Point(88, 221);
            this.Btn_Sum.Name = "Btn_Sum";
            this.Btn_Sum.Size = new System.Drawing.Size(127, 33);
            this.Btn_Sum.TabIndex = 24;
            this.Btn_Sum.Text = "+ Adição";
            this.Btn_Sum.UseVisualStyleBackColor = true;
            this.Btn_Sum.Click += new System.EventHandler(this.Btn_Sum_Click);
            // 
            // Btn_Subt
            // 
            this.Btn_Subt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Subt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Subt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Subt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subt.Location = new System.Drawing.Point(88, 249);
            this.Btn_Subt.Name = "Btn_Subt";
            this.Btn_Subt.Size = new System.Drawing.Size(127, 33);
            this.Btn_Subt.TabIndex = 25;
            this.Btn_Subt.Text = "- Subtração";
            this.Btn_Subt.UseVisualStyleBackColor = true;
            this.Btn_Subt.Click += new System.EventHandler(this.Btn_Subt_Click);
            // 
            // Btn_Mult
            // 
            this.Btn_Mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Mult.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mult.Location = new System.Drawing.Point(88, 277);
            this.Btn_Mult.Name = "Btn_Mult";
            this.Btn_Mult.Size = new System.Drawing.Size(127, 33);
            this.Btn_Mult.TabIndex = 26;
            this.Btn_Mult.Text = "x Multiplicação";
            this.Btn_Mult.UseVisualStyleBackColor = true;
            this.Btn_Mult.Click += new System.EventHandler(this.Btn_Mult_Click);
            // 
            // Btn_Divi
            // 
            this.Btn_Divi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Divi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Divi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divi.Location = new System.Drawing.Point(88, 305);
            this.Btn_Divi.Name = "Btn_Divi";
            this.Btn_Divi.Size = new System.Drawing.Size(127, 33);
            this.Btn_Divi.TabIndex = 27;
            this.Btn_Divi.Text = "÷ Divisão";
            this.Btn_Divi.UseVisualStyleBackColor = true;
            this.Btn_Divi.Click += new System.EventHandler(this.Btn_Divi_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Red;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Clear.Location = new System.Drawing.Point(263, 360);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(107, 36);
            this.Btn_Clear.TabIndex = 28;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Divi);
            this.Controls.Add(this.Btn_Mult);
            this.Controls.Add(this.Btn_Subt);
            this.Controls.Add(this.Btn_Sum);
            this.Controls.Add(this.Txt_Subt);
            this.Controls.Add(this.Txt_Mult);
            this.Controls.Add(this.Txt_Divi);
            this.Controls.Add(this.Txt_Sum);
            this.Controls.Add(this.Lbl_Value2);
            this.Controls.Add(this.Lbl_Value1);
            this.Controls.Add(this.Txt_Value1);
            this.Controls.Add(this.Txt_Value2);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Pic_Illustration);
            this.Controls.Add(this.Lbl_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Illustration;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.TextBox Txt_Value2;
        private System.Windows.Forms.TextBox Txt_Value1;
        private System.Windows.Forms.Label Lbl_Box;
        private System.Windows.Forms.Label Lbl_Value1;
        private System.Windows.Forms.Label Lbl_Value2;
        private System.Windows.Forms.TextBox Txt_Sum;
        private System.Windows.Forms.TextBox Txt_Divi;
        private System.Windows.Forms.TextBox Txt_Mult;
        private System.Windows.Forms.TextBox Txt_Subt;
        private System.Windows.Forms.Button Btn_Sum;
        private System.Windows.Forms.Button Btn_Subt;
        private System.Windows.Forms.Button Btn_Mult;
        private System.Windows.Forms.Button Btn_Divi;
        private System.Windows.Forms.Button Btn_Clear;
    }
}