
namespace PROJETO_ESTOQUES
{
    partial class Frm_Estoques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estoques));
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Peso = new System.Windows.Forms.Label();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Produto = new System.Windows.Forms.TextBox();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Lbl_ProdResult = new System.Windows.Forms.Label();
            this.Lbl_MarcaResult = new System.Windows.Forms.Label();
            this.Lbl_PesoResult = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Btn_Desativar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Descricao = new System.Windows.Forms.Button();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Produto
            // 
            this.Lbl_Produto.AutoSize = true;
            this.Lbl_Produto.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produto.Location = new System.Drawing.Point(123, 159);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(62, 16);
            this.Lbl_Produto.TabIndex = 0;
            this.Lbl_Produto.Text = "Produto";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.Location = new System.Drawing.Point(129, 185);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(51, 16);
            this.Lbl_Marca.TabIndex = 1;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Peso
            // 
            this.Lbl_Peso.AutoSize = true;
            this.Lbl_Peso.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Peso.Location = new System.Drawing.Point(132, 211);
            this.Lbl_Peso.Name = "Lbl_Peso";
            this.Lbl_Peso.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Peso.TabIndex = 2;
            this.Lbl_Peso.Text = "Peso";
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Enabled = false;
            this.Txt_Peso.Location = new System.Drawing.Point(202, 217);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(289, 20);
            this.Txt_Peso.TabIndex = 3;
            // 
            // Txt_Produto
            // 
            this.Txt_Produto.Enabled = false;
            this.Txt_Produto.Location = new System.Drawing.Point(202, 155);
            this.Txt_Produto.Name = "Txt_Produto";
            this.Txt_Produto.Size = new System.Drawing.Size(289, 20);
            this.Txt_Produto.TabIndex = 4;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Enabled = false;
            this.Txt_Marca.Location = new System.Drawing.Point(202, 186);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(289, 20);
            this.Txt_Marca.TabIndex = 5;
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.AutoSize = true;
            this.Lbl_Descricao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Descricao.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descricao.Location = new System.Drawing.Point(123, 76);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(163, 18);
            this.Lbl_Descricao.TabIndex = 6;
            this.Lbl_Descricao.Text = "Descrição do produto";
            this.Lbl_Descricao.Click += new System.EventHandler(this.Lbl_Descricao_Click);
            // 
            // Lbl_ProdResult
            // 
            this.Lbl_ProdResult.AutoSize = true;
            this.Lbl_ProdResult.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ProdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_ProdResult.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProdResult.Location = new System.Drawing.Point(115, 102);
            this.Lbl_ProdResult.Name = "Lbl_ProdResult";
            this.Lbl_ProdResult.Size = new System.Drawing.Size(51, 17);
            this.Lbl_ProdResult.TabIndex = 7;
            this.Lbl_ProdResult.Text = "Produto";
            this.Lbl_ProdResult.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lbl_MarcaResult
            // 
            this.Lbl_MarcaResult.AutoSize = true;
            this.Lbl_MarcaResult.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_MarcaResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_MarcaResult.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MarcaResult.Location = new System.Drawing.Point(191, 102);
            this.Lbl_MarcaResult.Name = "Lbl_MarcaResult";
            this.Lbl_MarcaResult.Size = new System.Drawing.Size(42, 17);
            this.Lbl_MarcaResult.TabIndex = 8;
            this.Lbl_MarcaResult.Text = "Marca";
            this.Lbl_MarcaResult.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lbl_PesoResult
            // 
            this.Lbl_PesoResult.AutoSize = true;
            this.Lbl_PesoResult.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PesoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_PesoResult.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesoResult.Location = new System.Drawing.Point(258, 102);
            this.Lbl_PesoResult.Name = "Lbl_PesoResult";
            this.Lbl_PesoResult.Size = new System.Drawing.Size(33, 17);
            this.Lbl_PesoResult.TabIndex = 9;
            this.Lbl_PesoResult.Text = "Peso";
            this.Lbl_PesoResult.Click += new System.EventHandler(this.label7_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("mono 07_65", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.Lbl_Titulo.Location = new System.Drawing.Point(119, 25);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(405, 39);
            this.Lbl_Titulo.TabIndex = 10;
            this.Lbl_Titulo.Text = "PROJETO ESTOQUES";
            this.Lbl_Titulo.Click += new System.EventHandler(this.label8_Click);
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ativar.Location = new System.Drawing.Point(186, 244);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(74, 28);
            this.Btn_Ativar.TabIndex = 11;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = true;
            this.Btn_Ativar.Click += new System.EventHandler(this.Btn_Ativar_Click);
            // 
            // Btn_Desativar
            // 
            this.Btn_Desativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Desativar.Enabled = false;
            this.Btn_Desativar.Location = new System.Drawing.Point(267, 244);
            this.Btn_Desativar.Name = "Btn_Desativar";
            this.Btn_Desativar.Size = new System.Drawing.Size(74, 28);
            this.Btn_Desativar.TabIndex = 12;
            this.Btn_Desativar.Text = "Desativar";
            this.Btn_Desativar.UseVisualStyleBackColor = true;
            this.Btn_Desativar.Click += new System.EventHandler(this.Btn_Desativar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Enabled = false;
            this.Btn_Limpar.Location = new System.Drawing.Point(348, 244);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(74, 28);
            this.Btn_Limpar.TabIndex = 13;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Descricao
            // 
            this.Btn_Descricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Descricao.Enabled = false;
            this.Btn_Descricao.Location = new System.Drawing.Point(429, 244);
            this.Btn_Descricao.Name = "Btn_Descricao";
            this.Btn_Descricao.Size = new System.Drawing.Size(74, 28);
            this.Btn_Descricao.TabIndex = 14;
            this.Btn_Descricao.Text = "Descrição";
            this.Btn_Descricao.UseVisualStyleBackColor = true;
            this.Btn_Descricao.Click += new System.EventHandler(this.Btn_Descricao_Click);
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Imagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_Imagem.BackgroundImage")));
            this.Pic_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Imagem.Location = new System.Drawing.Point(497, 159);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(344, 298);
            this.Pic_Imagem.TabIndex = 15;
            this.Pic_Imagem.TabStop = false;
            this.Pic_Imagem.Visible = false;
            this.Pic_Imagem.Click += new System.EventHandler(this.Pic_Imagem_Click);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.Font = new System.Drawing.Font("mono 07_55", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Location = new System.Drawing.Point(624, 378);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(93, 38);
            this.Btn_Enviar.TabIndex = 16;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.UseVisualStyleBackColor = false;
            this.Btn_Enviar.Visible = false;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.BackColor = System.Drawing.Color.Red;
            this.Lbl_Erro.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Erro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Erro.Location = new System.Drawing.Point(198, 128);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(306, 21);
            this.Lbl_Erro.TabIndex = 17;
            this.Lbl_Erro.Text = "Preencha os campos corretamente!";
            this.Lbl_Erro.Visible = false;
            // 
            // Frm_Estoques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Btn_Descricao);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Desativar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lbl_PesoResult);
            this.Controls.Add(this.Lbl_MarcaResult);
            this.Controls.Add(this.Lbl_ProdResult);
            this.Controls.Add(this.Lbl_Descricao);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.Txt_Produto);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.Lbl_Peso);
            this.Controls.Add(this.Lbl_Marca);
            this.Controls.Add(this.Lbl_Produto);
            this.Controls.Add(this.Pic_Imagem);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Estoques";
            this.Text = "PROJETO ESTOQUES";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Peso;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_Produto;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Label Lbl_Descricao;
        private System.Windows.Forms.Label Lbl_ProdResult;
        private System.Windows.Forms.Label Lbl_MarcaResult;
        private System.Windows.Forms.Label Lbl_PesoResult;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.Button Btn_Desativar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Descricao;
        private System.Windows.Forms.PictureBox Pic_Imagem;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.Label Lbl_Erro;
    }
}

