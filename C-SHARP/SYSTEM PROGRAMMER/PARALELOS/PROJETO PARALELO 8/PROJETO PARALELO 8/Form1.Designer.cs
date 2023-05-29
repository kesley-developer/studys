
namespace PROJETO_PARALELO_8
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
            this.Lbl_TotalText = new System.Windows.Forms.Label();
            this.Lbl_TotalResult = new System.Windows.Forms.Label();
            this.Grp_Purchases = new System.Windows.Forms.GroupBox();
            this.Lbl_Value = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Lbl_Product = new System.Windows.Forms.Label();
            this.Pic_ProductIllustration = new System.Windows.Forms.PictureBox();
            this.List_Value = new System.Windows.Forms.ListBox();
            this.List_Description = new System.Windows.Forms.ListBox();
            this.List_Product = new System.Windows.Forms.ListBox();
            this.Num_Product = new System.Windows.Forms.NumericUpDown();
            this.Chk_Product = new System.Windows.Forms.CheckBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Count = new System.Windows.Forms.Label();
            this.Grp_Purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ProductIllustration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TotalText
            // 
            this.Lbl_TotalText.BackColor = System.Drawing.Color.Orange;
            this.Lbl_TotalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_TotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalText.ForeColor = System.Drawing.Color.White;
            this.Lbl_TotalText.Location = new System.Drawing.Point(532, 31);
            this.Lbl_TotalText.Name = "Lbl_TotalText";
            this.Lbl_TotalText.Size = new System.Drawing.Size(94, 32);
            this.Lbl_TotalText.TabIndex = 1;
            this.Lbl_TotalText.Text = "TOTAL";
            this.Lbl_TotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TotalResult
            // 
            this.Lbl_TotalResult.BackColor = System.Drawing.Color.White;
            this.Lbl_TotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_TotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalResult.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TotalResult.Location = new System.Drawing.Point(620, 31);
            this.Lbl_TotalResult.Name = "Lbl_TotalResult";
            this.Lbl_TotalResult.Size = new System.Drawing.Size(133, 32);
            this.Lbl_TotalResult.TabIndex = 2;
            this.Lbl_TotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grp_Purchases
            // 
            this.Grp_Purchases.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Purchases.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grp_Purchases.BackgroundImage")));
            this.Grp_Purchases.Controls.Add(this.Lbl_Count);
            this.Grp_Purchases.Controls.Add(this.Lbl_Value);
            this.Grp_Purchases.Controls.Add(this.Lbl_Description);
            this.Grp_Purchases.Controls.Add(this.Lbl_Product);
            this.Grp_Purchases.Controls.Add(this.Pic_ProductIllustration);
            this.Grp_Purchases.Controls.Add(this.List_Value);
            this.Grp_Purchases.Controls.Add(this.List_Description);
            this.Grp_Purchases.Controls.Add(this.List_Product);
            this.Grp_Purchases.Controls.Add(this.Num_Product);
            this.Grp_Purchases.Controls.Add(this.Chk_Product);
            this.Grp_Purchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Purchases.ForeColor = System.Drawing.Color.White;
            this.Grp_Purchases.Location = new System.Drawing.Point(27, 170);
            this.Grp_Purchases.Name = "Grp_Purchases";
            this.Grp_Purchases.Size = new System.Drawing.Size(741, 268);
            this.Grp_Purchases.TabIndex = 4;
            this.Grp_Purchases.TabStop = false;
            this.Grp_Purchases.Text = "Lista de Compras";
            // 
            // Lbl_Value
            // 
            this.Lbl_Value.AutoSize = true;
            this.Lbl_Value.Location = new System.Drawing.Point(444, 33);
            this.Lbl_Value.Name = "Lbl_Value";
            this.Lbl_Value.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Value.TabIndex = 11;
            this.Lbl_Value.Text = "Preço";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Location = new System.Drawing.Point(248, 33);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Description.TabIndex = 10;
            this.Lbl_Description.Text = "Descrição";
            // 
            // Lbl_Product
            // 
            this.Lbl_Product.AutoSize = true;
            this.Lbl_Product.Location = new System.Drawing.Point(69, 33);
            this.Lbl_Product.Name = "Lbl_Product";
            this.Lbl_Product.Size = new System.Drawing.Size(62, 16);
            this.Lbl_Product.TabIndex = 9;
            this.Lbl_Product.Text = "Produto";
            // 
            // Pic_ProductIllustration
            // 
            this.Pic_ProductIllustration.BackColor = System.Drawing.Color.Transparent;
            this.Pic_ProductIllustration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_ProductIllustration.BackgroundImage")));
            this.Pic_ProductIllustration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_ProductIllustration.Location = new System.Drawing.Point(576, 103);
            this.Pic_ProductIllustration.Name = "Pic_ProductIllustration";
            this.Pic_ProductIllustration.Size = new System.Drawing.Size(142, 111);
            this.Pic_ProductIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_ProductIllustration.TabIndex = 8;
            this.Pic_ProductIllustration.TabStop = false;
            // 
            // List_Value
            // 
            this.List_Value.FormatString = "C2";
            this.List_Value.FormattingEnabled = true;
            this.List_Value.ItemHeight = 16;
            this.List_Value.Location = new System.Drawing.Point(396, 59);
            this.List_Value.Name = "List_Value";
            this.List_Value.Size = new System.Drawing.Size(157, 196);
            this.List_Value.TabIndex = 7;
            // 
            // List_Description
            // 
            this.List_Description.FormattingEnabled = true;
            this.List_Description.ItemHeight = 16;
            this.List_Description.Location = new System.Drawing.Point(212, 59);
            this.List_Description.Name = "List_Description";
            this.List_Description.Size = new System.Drawing.Size(157, 196);
            this.List_Description.TabIndex = 6;
            // 
            // List_Product
            // 
            this.List_Product.FormattingEnabled = true;
            this.List_Product.ItemHeight = 16;
            this.List_Product.Location = new System.Drawing.Point(28, 59);
            this.List_Product.Name = "List_Product";
            this.List_Product.Size = new System.Drawing.Size(157, 196);
            this.List_Product.TabIndex = 5;
            // 
            // Num_Product
            // 
            this.Num_Product.Location = new System.Drawing.Point(678, 67);
            this.Num_Product.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Num_Product.Name = "Num_Product";
            this.Num_Product.Size = new System.Drawing.Size(36, 22);
            this.Num_Product.TabIndex = 5;
            this.Num_Product.Visible = false;
            this.Num_Product.ValueChanged += new System.EventHandler(this.Num_Product_ValueChanged);
            // 
            // Chk_Product
            // 
            this.Chk_Product.AutoSize = true;
            this.Chk_Product.BackColor = System.Drawing.Color.Transparent;
            this.Chk_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chk_Product.ForeColor = System.Drawing.Color.Black;
            this.Chk_Product.Location = new System.Drawing.Point(576, 68);
            this.Chk_Product.Name = "Chk_Product";
            this.Chk_Product.Size = new System.Drawing.Size(81, 20);
            this.Chk_Product.TabIndex = 4;
            this.Chk_Product.Text = "Produto";
            this.Chk_Product.UseVisualStyleBackColor = false;
            this.Chk_Product.CheckedChanged += new System.EventHandler(this.Chk_Product_CheckedChanged);
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.BackgroundImage")));
            this.Pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Logo.Location = new System.Drawing.Point(127, 16);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(55, 38);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Logo.TabIndex = 3;
            this.Pic_Logo.TabStop = false;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("mono 07_55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(18, 16);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(103, 26);
            this.Lbl_Title.TabIndex = 8;
            this.Lbl_Title.Text = "COMPRAS";
            // 
            // Lbl_Count
            // 
            this.Lbl_Count.AutoSize = true;
            this.Lbl_Count.Location = new System.Drawing.Point(580, 228);
            this.Lbl_Count.Name = "Lbl_Count";
            this.Lbl_Count.Size = new System.Drawing.Size(65, 16);
            this.Lbl_Count.TabIndex = 12;
            this.Lbl_Count.Text = "Estoque";
            this.Lbl_Count.Visible = false;
            // 
            // Frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Grp_Purchases);
            this.Controls.Add(this.Lbl_TotalResult);
            this.Controls.Add(this.Lbl_TotalText);
            this.Controls.Add(this.Pic_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Project";
            this.Text = "COMPRAS";
            this.Load += new System.EventHandler(this.Frm_Project_Load);
            this.Grp_Purchases.ResumeLayout(false);
            this.Grp_Purchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ProductIllustration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_TotalText;
        private System.Windows.Forms.Label Lbl_TotalResult;
        private System.Windows.Forms.GroupBox Grp_Purchases;
        private System.Windows.Forms.PictureBox Pic_ProductIllustration;
        private System.Windows.Forms.ListBox List_Value;
        private System.Windows.Forms.ListBox List_Description;
        private System.Windows.Forms.ListBox List_Product;
        private System.Windows.Forms.NumericUpDown Num_Product;
        private System.Windows.Forms.CheckBox Chk_Product;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Value;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Label Lbl_Product;
        private System.Windows.Forms.Label Lbl_Count;
    }
}

