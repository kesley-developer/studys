
namespace PROJETO_PARALELO_6
{
    partial class Frm_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Window));
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Age = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Age = new System.Windows.Forms.TextBox();
            this.Pic_DatesBox = new System.Windows.Forms.PictureBox();
            this.Lbl_Top = new System.Windows.Forms.Label();
            this.Lbl_Bottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_DatesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(183, 183);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(49, 18);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Nome";
            // 
            // Lbl_Age
            // 
            this.Lbl_Age.AutoSize = true;
            this.Lbl_Age.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Age.Location = new System.Drawing.Point(183, 210);
            this.Lbl_Age.Name = "Lbl_Age";
            this.Lbl_Age.Size = new System.Drawing.Size(43, 18);
            this.Lbl_Age.TabIndex = 1;
            this.Lbl_Age.Text = "Idade";
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.DarkRed;
            this.Lbl_Title.Font = new System.Drawing.Font("mono 07_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(146, 101);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(522, 43);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Validação de dados em C#";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Send
            // 
            this.Btn_Send.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Send.ForeColor = System.Drawing.Color.White;
            this.Btn_Send.Location = new System.Drawing.Point(525, 182);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 3;
            this.Btn_Send.Text = "ENVIAR";
            this.Btn_Send.UseVisualStyleBackColor = false;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(247, 182);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(235, 20);
            this.Txt_Name.TabIndex = 4;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // Txt_Age
            // 
            this.Txt_Age.Location = new System.Drawing.Point(247, 208);
            this.Txt_Age.Name = "Txt_Age";
            this.Txt_Age.Size = new System.Drawing.Size(100, 20);
            this.Txt_Age.TabIndex = 5;
            this.Txt_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Age_KeyPress);
            // 
            // Pic_DatesBox
            // 
            this.Pic_DatesBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pic_DatesBox.Location = new System.Drawing.Point(146, 100);
            this.Pic_DatesBox.Name = "Pic_DatesBox";
            this.Pic_DatesBox.Size = new System.Drawing.Size(522, 169);
            this.Pic_DatesBox.TabIndex = 6;
            this.Pic_DatesBox.TabStop = false;
            this.Pic_DatesBox.Click += new System.EventHandler(this.Pic_DatesBox_Click);
            // 
            // Lbl_Top
            // 
            this.Lbl_Top.BackColor = System.Drawing.Color.DarkRed;
            this.Lbl_Top.Font = new System.Drawing.Font("mono 07_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Top.ForeColor = System.Drawing.Color.White;
            this.Lbl_Top.Location = new System.Drawing.Point(-1, -3);
            this.Lbl_Top.Name = "Lbl_Top";
            this.Lbl_Top.Size = new System.Drawing.Size(801, 71);
            this.Lbl_Top.TabIndex = 8;
            this.Lbl_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Bottom
            // 
            this.Lbl_Bottom.BackColor = System.Drawing.Color.DarkRed;
            this.Lbl_Bottom.Font = new System.Drawing.Font("mono 07_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bottom.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bottom.Location = new System.Drawing.Point(-1, 385);
            this.Lbl_Bottom.Name = "Lbl_Bottom";
            this.Lbl_Bottom.Size = new System.Drawing.Size(801, 71);
            this.Lbl_Bottom.TabIndex = 9;
            this.Lbl_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Bottom);
            this.Controls.Add(this.Lbl_Top);
            this.Controls.Add(this.Txt_Age);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_Age);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Pic_DatesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Window";
            this.Text = "VALIDAÇÃO";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_DatesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Age;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Age;
        private System.Windows.Forms.PictureBox Pic_DatesBox;
        private System.Windows.Forms.Label Lbl_Top;
        private System.Windows.Forms.Label Lbl_Bottom;
    }
}

