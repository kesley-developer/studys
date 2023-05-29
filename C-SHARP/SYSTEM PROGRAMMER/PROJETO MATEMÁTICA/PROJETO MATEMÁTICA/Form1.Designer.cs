
namespace PROJETO_MATEMÁTICA
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
            this.Rad_Double = new System.Windows.Forms.RadioButton();
            this.Rad_AntOrSuc = new System.Windows.Forms.RadioButton();
            this.Rad_PairOrOdd = new System.Windows.Forms.RadioButton();
            this.Rad_PosOrNeg = new System.Windows.Forms.RadioButton();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Rad_Calculator = new System.Windows.Forms.RadioButton();
            this.Rad_SameOrDifferent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Rad_Double
            // 
            this.Rad_Double.AutoSize = true;
            this.Rad_Double.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Double.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_Double.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Double.ForeColor = System.Drawing.Color.White;
            this.Rad_Double.Location = new System.Drawing.Point(132, 212);
            this.Rad_Double.Name = "Rad_Double";
            this.Rad_Double.Size = new System.Drawing.Size(80, 22);
            this.Rad_Double.TabIndex = 1;
            this.Rad_Double.Text = "DOBRO";
            this.Rad_Double.UseVisualStyleBackColor = false;
            this.Rad_Double.CheckedChanged += new System.EventHandler(this.Rad_Double_CheckedChanged);
            // 
            // Rad_AntOrSuc
            // 
            this.Rad_AntOrSuc.AutoSize = true;
            this.Rad_AntOrSuc.BackColor = System.Drawing.Color.Transparent;
            this.Rad_AntOrSuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_AntOrSuc.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_AntOrSuc.ForeColor = System.Drawing.Color.White;
            this.Rad_AntOrSuc.Location = new System.Drawing.Point(132, 250);
            this.Rad_AntOrSuc.Name = "Rad_AntOrSuc";
            this.Rad_AntOrSuc.Size = new System.Drawing.Size(223, 22);
            this.Rad_AntOrSuc.TabIndex = 2;
            this.Rad_AntOrSuc.Text = "ANTECESSOR E SUCESSOR";
            this.Rad_AntOrSuc.UseVisualStyleBackColor = false;
            this.Rad_AntOrSuc.CheckedChanged += new System.EventHandler(this.Rad_AntOrSuc_CheckedChanged);
            // 
            // Rad_PairOrOdd
            // 
            this.Rad_PairOrOdd.AutoSize = true;
            this.Rad_PairOrOdd.BackColor = System.Drawing.Color.Transparent;
            this.Rad_PairOrOdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_PairOrOdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_PairOrOdd.ForeColor = System.Drawing.Color.White;
            this.Rad_PairOrOdd.Location = new System.Drawing.Point(491, 212);
            this.Rad_PairOrOdd.Name = "Rad_PairOrOdd";
            this.Rad_PairOrOdd.Size = new System.Drawing.Size(142, 22);
            this.Rad_PairOrOdd.TabIndex = 3;
            this.Rad_PairOrOdd.Text = "PAR OU IMPAR";
            this.Rad_PairOrOdd.UseVisualStyleBackColor = false;
            this.Rad_PairOrOdd.CheckedChanged += new System.EventHandler(this.Rad_PairOrOdd_CheckedChanged);
            // 
            // Rad_PosOrNeg
            // 
            this.Rad_PosOrNeg.AutoSize = true;
            this.Rad_PosOrNeg.BackColor = System.Drawing.Color.Transparent;
            this.Rad_PosOrNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_PosOrNeg.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_PosOrNeg.ForeColor = System.Drawing.Color.White;
            this.Rad_PosOrNeg.Location = new System.Drawing.Point(491, 251);
            this.Rad_PosOrNeg.Name = "Rad_PosOrNeg";
            this.Rad_PosOrNeg.Size = new System.Drawing.Size(212, 22);
            this.Rad_PosOrNeg.TabIndex = 4;
            this.Rad_PosOrNeg.Text = "POSITIVO OU NEGATIVO";
            this.Rad_PosOrNeg.UseVisualStyleBackColor = false;
            this.Rad_PosOrNeg.CheckedChanged += new System.EventHandler(this.Rad_PosOrNeg_CheckedChanged);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.Orange;
            this.Lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(-3, -1);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(809, 62);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Projetos";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Btn_Back.TabIndex = 7;
            this.Btn_Back.Text = "X";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Rad_Calculator
            // 
            this.Rad_Calculator.AutoSize = true;
            this.Rad_Calculator.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Calculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_Calculator.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Calculator.ForeColor = System.Drawing.Color.White;
            this.Rad_Calculator.Location = new System.Drawing.Point(132, 288);
            this.Rad_Calculator.Name = "Rad_Calculator";
            this.Rad_Calculator.Size = new System.Drawing.Size(231, 22);
            this.Rad_Calculator.TabIndex = 8;
            this.Rad_Calculator.Text = "OPERAÇÕES ARITMÉTICAS";
            this.Rad_Calculator.UseVisualStyleBackColor = false;
            this.Rad_Calculator.CheckedChanged += new System.EventHandler(this.Rad_Calculator_CheckedChanged);
            // 
            // Rad_SameOrDifferent
            // 
            this.Rad_SameOrDifferent.AutoSize = true;
            this.Rad_SameOrDifferent.BackColor = System.Drawing.Color.Transparent;
            this.Rad_SameOrDifferent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_SameOrDifferent.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_SameOrDifferent.ForeColor = System.Drawing.Color.White;
            this.Rad_SameOrDifferent.Location = new System.Drawing.Point(491, 290);
            this.Rad_SameOrDifferent.Name = "Rad_SameOrDifferent";
            this.Rad_SameOrDifferent.Size = new System.Drawing.Size(202, 22);
            this.Rad_SameOrDifferent.TabIndex = 9;
            this.Rad_SameOrDifferent.Text = "IGUAL OU DIFERENTE";
            this.Rad_SameOrDifferent.UseVisualStyleBackColor = false;
            this.Rad_SameOrDifferent.CheckedChanged += new System.EventHandler(this.Rad_SameOrDifferent_CheckedChanged);
            // 
            // Frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.Rad_SameOrDifferent);
            this.Controls.Add(this.Rad_Calculator);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Rad_PosOrNeg);
            this.Controls.Add(this.Rad_PairOrOdd);
            this.Controls.Add(this.Rad_AntOrSuc);
            this.Controls.Add(this.Rad_Double);
            this.Controls.Add(this.Lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO MATEMÁTICA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Rad_Double;
        private System.Windows.Forms.RadioButton Rad_AntOrSuc;
        private System.Windows.Forms.RadioButton Rad_PairOrOdd;
        private System.Windows.Forms.RadioButton Rad_PosOrNeg;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.RadioButton Rad_Calculator;
        private System.Windows.Forms.RadioButton Rad_SameOrDifferent;
    }
}

