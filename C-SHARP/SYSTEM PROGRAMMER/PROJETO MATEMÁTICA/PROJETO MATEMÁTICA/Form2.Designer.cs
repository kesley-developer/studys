
namespace PROJETO_MATEMÁTICA
{
    partial class Frm_Double
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Double));
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Digit = new System.Windows.Forms.Label();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Pic_Illustration = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(73, 135);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(327, 21);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "MOSTRAR O DOBRO DO NÚMERO";
            // 
            // Lbl_Digit
            // 
            this.Lbl_Digit.AutoSize = true;
            this.Lbl_Digit.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digit.ForeColor = System.Drawing.Color.White;
            this.Lbl_Digit.Location = new System.Drawing.Point(74, 205);
            this.Lbl_Digit.Name = "Lbl_Digit";
            this.Lbl_Digit.Size = new System.Drawing.Size(128, 16);
            this.Lbl_Digit.TabIndex = 1;
            this.Lbl_Digit.Text = "Digite um número";
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(223, 201);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(94, 20);
            this.Txt_Number.TabIndex = 2;
            this.Txt_Number.TextChanged += new System.EventHandler(this.Txt_Number_TextChanged);
            this.Txt_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Number_KeyPress);
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
            this.Btn_Back.TabIndex = 6;
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
            this.Pic_Illustration.Size = new System.Drawing.Size(809, 62);
            this.Pic_Illustration.TabIndex = 7;
            this.Pic_Illustration.TabStop = false;
            // 
            // Frm_Double
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Txt_Number);
            this.Controls.Add(this.Lbl_Digit);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Pic_Illustration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Double";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Digit;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox Pic_Illustration;
    }
}