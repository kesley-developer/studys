
namespace PROJETO_MATEMÁTICA
{
    partial class Frm_SameOrDifferent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SameOrDifferent));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Pic_Illustration = new System.Windows.Forms.PictureBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pic_Box = new System.Windows.Forms.PictureBox();
            this.Txt_Value2 = new System.Windows.Forms.TextBox();
            this.Txt_Value1 = new System.Windows.Forms.TextBox();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.White;
            this.Btn_Back.Location = new System.Drawing.Point(732, 9);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(58, 30);
            this.Btn_Back.TabIndex = 15;
            this.Btn_Back.Text = "X";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Pic_Illustration
            // 
            this.Pic_Illustration.BackColor = System.Drawing.Color.White;
            this.Pic_Illustration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Illustration.Location = new System.Drawing.Point(-5, -10);
            this.Pic_Illustration.Name = "Pic_Illustration";
            this.Pic_Illustration.Size = new System.Drawing.Size(809, 64);
            this.Pic_Illustration.TabIndex = 14;
            this.Pic_Illustration.TabStop = false;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.LimeGreen;
            this.Lbl_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(245, 95);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(345, 44);
            this.Lbl_Title.TabIndex = 16;
            this.Lbl_Title.Text = "IGUAL OU DIFERENTE";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_Box
            // 
            this.Pic_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pic_Box.Location = new System.Drawing.Point(245, 138);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(345, 208);
            this.Pic_Box.TabIndex = 17;
            this.Pic_Box.TabStop = false;
            this.Pic_Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Txt_Value2
            // 
            this.Txt_Value2.Location = new System.Drawing.Point(447, 200);
            this.Txt_Value2.Name = "Txt_Value2";
            this.Txt_Value2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Value2.TabIndex = 18;
            this.Txt_Value2.TextChanged += new System.EventHandler(this.Txt_Value2_TextChanged);
            this.Txt_Value2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Value2_KeyPress);
            // 
            // Txt_Value1
            // 
            this.Txt_Value1.Location = new System.Drawing.Point(274, 200);
            this.Txt_Value1.Name = "Txt_Value1";
            this.Txt_Value1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Value1.TabIndex = 18;
            this.Txt_Value1.TextChanged += new System.EventHandler(this.Txt_Value1_TextChanged);
            this.Txt_Value1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Value1_KeyPress);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Result.Font = new System.Drawing.Font("mono 07_55", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(393, 182);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(43, 47);
            this.Lbl_Result.TabIndex = 19;
            this.Lbl_Result.Text = "?";
            this.Lbl_Result.Click += new System.EventHandler(this.Lbl_Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor 2";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Red;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Clear.Location = new System.Drawing.Point(483, 310);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(107, 36);
            this.Btn_Clear.TabIndex = 29;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Frm_SameOrDifferent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Txt_Value1);
            this.Controls.Add(this.Txt_Value2);
            this.Controls.Add(this.Pic_Box);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Pic_Illustration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SameOrDifferent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox Pic_Illustration;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.PictureBox Pic_Box;
        private System.Windows.Forms.TextBox Txt_Value2;
        private System.Windows.Forms.TextBox Txt_Value1;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Clear;
    }
}