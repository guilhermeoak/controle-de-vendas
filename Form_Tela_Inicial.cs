using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Form_Tela_Inicial : Form
    {
        public bool ativo = false;
        public Form_Tela_Inicial()
        {
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
            if(ativo == false)
            {
                Form tela_cliente = new frmCliente();
                tela_cliente.Show();
                ativo = true;
            }
        }
    }
}
