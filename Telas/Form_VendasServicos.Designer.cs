
namespace Vendas
{
    partial class frmVendasServicos
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TecnicoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarTecnico = new System.Windows.Forms.Button();
            this.redtPrecoTotal = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNomeProduto = new System.Windows.Forms.TextBox();
            this.edtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.edtCodOperador = new System.Windows.Forms.TextBox();
            this.redtNotas = new System.Windows.Forms.RichTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.edtQtde = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.edtCodProduto = new System.Windows.Forms.TextBox();
            this.edtCodCliente = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.edtNomeOperador = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(431, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 23);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(512, 420);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(79, 23);
            this.btnDeletar.TabIndex = 28;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(349, 420);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(79, 23);
            this.btnGravar.TabIndex = 26;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Tipo,
            this.Total,
            this.CodTecnico,
            this.TecnicoNome,
            this.Cliente,
            this.ClienteNome,
            this.Produto,
            this.ProdutoNome});
            this.grdDados.Location = new System.Drawing.Point(59, 135);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.Size = new System.Drawing.Size(615, 279);
            this.grdDados.TabIndex = 25;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total(R$)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 60;
            // 
            // CodTecnico
            // 
            this.CodTecnico.HeaderText = "Técnico";
            this.CodTecnico.Name = "CodTecnico";
            this.CodTecnico.ReadOnly = true;
            this.CodTecnico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodTecnico.Width = 50;
            // 
            // TecnicoNome
            // 
            this.TecnicoNome.HeaderText = "Técnico(nome)";
            this.TecnicoNome.Name = "TecnicoNome";
            this.TecnicoNome.ReadOnly = true;
            this.TecnicoNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TecnicoNome.Width = 200;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cliente.Width = 50;
            // 
            // ClienteNome
            // 
            this.ClienteNome.HeaderText = "Cliente(nome)";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.ReadOnly = true;
            this.ClienteNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClienteNome.Width = 200;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 50;
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.HeaderText = "Produto(nome)";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.ReadOnly = true;
            this.ProdutoNome.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisarProduto);
            this.groupBox1.Controls.Add(this.btnPesquisarCliente);
            this.groupBox1.Controls.Add(this.btnPesquisarTecnico);
            this.groupBox1.Controls.Add(this.redtPrecoTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtNomeProduto);
            this.groupBox1.Controls.Add(this.edtNomeCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblOperador);
            this.groupBox1.Controls.Add(this.edtCodOperador);
            this.groupBox1.Controls.Add(this.redtNotas);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.grdDados);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.edtQtde);
            this.groupBox1.Controls.Add(this.lblQtde);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.edtCodProduto);
            this.groupBox1.Controls.Add(this.edtCodCliente);
            this.groupBox1.Controls.Add(this.lblNota);
            this.groupBox1.Controls.Add(this.edtNomeOperador);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.edtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 449);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Image = global::Vendas.Properties.Resources.Lupa24;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(120, 70);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarProduto.TabIndex = 49;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Image = global::Vendas.Properties.Resources.Lupa24;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(120, 44);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarCliente.TabIndex = 48;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnPesquisarTecnico
            // 
            this.btnPesquisarTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarTecnico.Image = global::Vendas.Properties.Resources.Lupa24;
            this.btnPesquisarTecnico.Location = new System.Drawing.Point(200, 15);
            this.btnPesquisarTecnico.Name = "btnPesquisarTecnico";
            this.btnPesquisarTecnico.Size = new System.Drawing.Size(30, 20);
            this.btnPesquisarTecnico.TabIndex = 47;
            this.btnPesquisarTecnico.UseVisualStyleBackColor = true;
            this.btnPesquisarTecnico.Click += new System.EventHandler(this.btnPesquisarTecnico_Click);
            // 
            // redtPrecoTotal
            // 
            this.redtPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redtPrecoTotal.Location = new System.Drawing.Point(553, 68);
            this.redtPrecoTotal.Name = "redtPrecoTotal";
            this.redtPrecoTotal.Size = new System.Drawing.Size(121, 59);
            this.redtPrecoTotal.TabIndex = 46;
            this.redtPrecoTotal.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "TOTAL:";
            // 
            // edtNomeProduto
            // 
            this.edtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtNomeProduto.Location = new System.Drawing.Point(155, 70);
            this.edtNomeProduto.Name = "edtNomeProduto";
            this.edtNomeProduto.Size = new System.Drawing.Size(215, 20);
            this.edtNomeProduto.TabIndex = 43;
            // 
            // edtNomeCliente
            // 
            this.edtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtNomeCliente.Location = new System.Drawing.Point(155, 43);
            this.edtNomeCliente.Name = "edtNomeCliente";
            this.edtNomeCliente.Size = new System.Drawing.Size(449, 20);
            this.edtNomeCliente.TabIndex = 42;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 48);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 41;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(105, 19);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(49, 13);
            this.lblOperador.TabIndex = 40;
            this.lblOperador.Text = "Técnico:";
            // 
            // edtCodOperador
            // 
            this.edtCodOperador.Location = new System.Drawing.Point(155, 15);
            this.edtCodOperador.Name = "edtCodOperador";
            this.edtCodOperador.Size = new System.Drawing.Size(40, 20);
            this.edtCodOperador.TabIndex = 2;
            // 
            // redtNotas
            // 
            this.redtNotas.Location = new System.Drawing.Point(59, 98);
            this.redtNotas.Name = "redtNotas";
            this.redtNotas.Size = new System.Drawing.Size(483, 31);
            this.redtNotas.TabIndex = 7;
            this.redtNotas.Text = "";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(501, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 37;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.ItemHeight = 13;
            this.cbTipo.Items.AddRange(new object[] {
            "VENDA",
            "SERVIÇO"});
            this.cbTipo.Location = new System.Drawing.Point(533, 15);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(73, 21);
            this.cbTipo.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(595, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 23);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(610, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(610, 41);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(64, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // edtQtde
            // 
            this.edtQtde.Location = new System.Drawing.Point(443, 70);
            this.edtQtde.Name = "edtQtde";
            this.edtQtde.Size = new System.Drawing.Size(52, 20);
            this.edtQtde.TabIndex = 6;
            this.edtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtQtde_KeyPress);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(375, 74);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(67, 13);
            this.lblQtde.TabIndex = 11;
            this.lblQtde.Text = "Qtde. Venda";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(10, 74);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 8;
            this.lblProduto.Text = "Produto:";
            // 
            // edtCodProduto
            // 
            this.edtCodProduto.Location = new System.Drawing.Point(59, 70);
            this.edtCodProduto.Name = "edtCodProduto";
            this.edtCodProduto.Size = new System.Drawing.Size(56, 20);
            this.edtCodProduto.TabIndex = 5;
            // 
            // edtCodCliente
            // 
            this.edtCodCliente.Location = new System.Drawing.Point(59, 44);
            this.edtCodCliente.Name = "edtCodCliente";
            this.edtCodCliente.Size = new System.Drawing.Size(56, 20);
            this.edtCodCliente.TabIndex = 4;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(24, 107);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota:";
            // 
            // edtNomeOperador
            // 
            this.edtNomeOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtNomeOperador.Location = new System.Drawing.Point(235, 15);
            this.edtNomeOperador.Name = "edtNomeOperador";
            this.edtNomeOperador.Size = new System.Drawing.Size(260, 20);
            this.edtNomeOperador.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.Location = new System.Drawing.Point(59, 15);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(41, 20);
            this.edtCodigo.TabIndex = 1;
            this.edtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtCodigo_KeyPress);
            // 
            // frmVendasServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmVendasServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Estoque - Vendas e Serviços";
            this.Shown += new System.EventHandler(this.frmVendasServicos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisarTecnico;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox redtNotas;
        private System.Windows.Forms.RichTextBox redtPrecoTotal;
        private System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.TextBox edtCodOperador;
        private System.Windows.Forms.TextBox edtCodigo;
        public System.Windows.Forms.TextBox edtNomeProduto;
        public System.Windows.Forms.TextBox edtNomeCliente;
        public System.Windows.Forms.TextBox edtQtde;
        public System.Windows.Forms.TextBox edtCodProduto;
        public System.Windows.Forms.TextBox edtNomeOperador;
        public System.Windows.Forms.TextBox edtCodCliente;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn TecnicoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoNome;
    }
}