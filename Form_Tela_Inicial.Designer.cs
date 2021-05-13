
namespace Vendas
{
    partial class Form_Tela_Inicial
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
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrodeCliente = new System.Windows.Forms.Button();
            this.btnServicoVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(120, 100);
            this.btnCadastroProduto.TabIndex = 0;
            this.btnCadastroProduto.Text = "Cadastro de Produto";
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(611, 696);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 53);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastrodeCliente
            // 
            this.btnCadastrodeCliente.Location = new System.Drawing.Point(183, 12);
            this.btnCadastrodeCliente.Name = "btnCadastrodeCliente";
            this.btnCadastrodeCliente.Size = new System.Drawing.Size(120, 100);
            this.btnCadastrodeCliente.TabIndex = 2;
            this.btnCadastrodeCliente.Text = "Cadastro de Cliente";
            this.btnCadastrodeCliente.UseVisualStyleBackColor = true;
            this.btnCadastrodeCliente.Click += new System.EventHandler(this.btnCadastrodeCliente_Click);
            // 
            // btnServicoVenda
            // 
            this.btnServicoVenda.Location = new System.Drawing.Point(354, 12);
            this.btnServicoVenda.Name = "btnServicoVenda";
            this.btnServicoVenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServicoVenda.Size = new System.Drawing.Size(120, 100);
            this.btnServicoVenda.TabIndex = 3;
            this.btnServicoVenda.Text = "Serviço / Venda";
            this.btnServicoVenda.UseVisualStyleBackColor = true;
            // 
            // Form_Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 761);
            this.Controls.Add(this.btnServicoVenda);
            this.Controls.Add(this.btnCadastrodeCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Estoque e Gerenciamento de Vendas e Serviços";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrodeCliente;
        private System.Windows.Forms.Button btnServicoVenda;
    }
}