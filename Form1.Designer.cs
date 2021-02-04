
namespace Vendas
{
    partial class frmProduto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edtCodProd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblResultadoLucro = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.edtPrecoFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtQtde = new System.Windows.Forms.TextBox();
            this.edtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultPercent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // edtCodProd
            // 
            this.edtCodProd.AutoSize = true;
            this.edtCodProd.Location = new System.Drawing.Point(16, 46);
            this.edtCodProd.Name = "edtCodProd";
            this.edtCodProd.Size = new System.Drawing.Size(98, 13);
            this.edtCodProd.TabIndex = 2;
            this.edtCodProd.Text = "Codigo do Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultPercent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.lblResultadoLucro);
            this.groupBox1.Controls.Add(this.lblLucro);
            this.groupBox1.Controls.Add(this.edtPrecoFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtQtde);
            this.groupBox1.Controls.Add(this.edtPreco);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.edtCodProd);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(377, 94);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblResultadoLucro
            // 
            this.lblResultadoLucro.AutoSize = true;
            this.lblResultadoLucro.Location = new System.Drawing.Point(411, 120);
            this.lblResultadoLucro.Name = "lblResultadoLucro";
            this.lblResultadoLucro.Size = new System.Drawing.Size(34, 13);
            this.lblResultadoLucro.TabIndex = 14;
            this.lblResultadoLucro.Text = "";
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Location = new System.Drawing.Point(354, 120);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(57, 13);
            this.lblLucro.TabIndex = 13;
            this.lblLucro.Text = "Lucro(R$):";
            // 
            // edtPrecoFinal
            // 
            this.edtPrecoFinal.Location = new System.Drawing.Point(341, 69);
            this.edtPrecoFinal.Name = "edtPrecoFinal";
            this.edtPrecoFinal.Size = new System.Drawing.Size(100, 20);
            this.edtPrecoFinal.TabIndex = 4;
            this.edtPrecoFinal.Leave += new System.EventHandler(this.edtPrecoFinal_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço de venda:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(458, 94);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(79, 23);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(295, 94);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(79, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qtde.:";
            // 
            // edtQtde
            // 
            this.edtQtde.Location = new System.Drawing.Point(145, 94);
            this.edtQtde.Name = "edtQtde";
            this.edtQtde.Size = new System.Drawing.Size(100, 20);
            this.edtQtde.TabIndex = 5;
            // 
            // edtPreco
            // 
            this.edtPreco.Location = new System.Drawing.Point(145, 68);
            this.edtPreco.Name = "edtPreco";
            this.edtPreco.Size = new System.Drawing.Size(100, 20);
            this.edtPreco.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(16, 75);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(123, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço de compra(custo):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(251, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lucro(%):";
            // 
            // lblResultPercent
            // 
            this.lblResultPercent.AutoSize = true;
            this.lblResultPercent.Location = new System.Drawing.Point(503, 120);
            this.lblResultPercent.Name = "lblResultPercent";
            this.lblResultPercent.Size = new System.Drawing.Size(34, 13);
            this.lblResultPercent.TabIndex = 16;
            this.lblResultPercent.Text = "";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 180);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProduto";
            this.Text = "Vendas - Cadastro de Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label edtCodProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtQtde;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox edtPrecoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultadoLucro;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblResultPercent;
        private System.Windows.Forms.Label label3;
    }
}

