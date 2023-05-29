
namespace PROJETO_MATEMÁTICA
{
    partial class Frm_BiggerAndSmaller
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Pic_Illustration = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).BeginInit();
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
            this.Btn_Back.TabIndex = 17;
            this.Btn_Back.Text = "X";
            this.Btn_Back.UseVisualStyleBackColor = false;
            // 
            // Pic_Illustration
            // 
            this.Pic_Illustration.BackColor = System.Drawing.Color.White;
            this.Pic_Illustration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Illustration.Location = new System.Drawing.Point(-5, -10);
            this.Pic_Illustration.Name = "Pic_Illustration";
            this.Pic_Illustration.Size = new System.Drawing.Size(809, 64);
            this.Pic_Illustration.TabIndex = 16;
            this.Pic_Illustration.TabStop = false;
            // 
            // Frm_BiggerAndSmaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Pic_Illustration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BiggerAndSmaller";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Illustration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox Pic_Illustration;
    }
}