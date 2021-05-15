using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Telas.Complementares;
using Vendas.Dados;

namespace Vendas
{
    public partial class Form_Tela_Inicial : Form
    {
        frmLogin tela_login;
        public Cliente usuario;

        public Form_Tela_Inicial()
        {
            InitializeComponent();
        }

        public Form_Tela_Inicial(frmLogin login)
        {
            tela_login   = login;
            usuario = tela_login.usuario;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tela_produto = new frmProduto();
            tela_produto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrodeCliente_Click(object sender, EventArgs e)
        {            
            Form tela_cliente = new frmCliente();
            tela_cliente.Show();
        }

        private void btnServicoVenda_Click(object sender, EventArgs e)
        {
            Form tela_vendas = new frmVendasServicos(this);
            tela_vendas.Show();
        }
    }
}
