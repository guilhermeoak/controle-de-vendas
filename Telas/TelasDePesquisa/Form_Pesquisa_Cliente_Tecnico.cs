using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Dados;

namespace Vendas.TelasDePesquisa
{
    public partial class frmPesquisaTecnicoCliente : Form
    {
        public string TipoCadastro;
        frmVendasServicos form_vendas;

        public frmPesquisaTecnicoCliente()
        {

        }

        private void grdDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(TipoCadastro == "OPERADOR")
            {
                form_vendas.edtCodOperador.Text  = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                form_vendas.edtNomeOperador.Text = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                form_vendas.edtCodCliente.Focus();
            }
            else
            {
                form_vendas.edtCodCliente.Text = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                form_vendas.edtNomeCliente.Text = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                form_vendas.edtCodProduto.Focus();
            }
            this.DestroyHandle();
        }

        public void BuscarCliente()
        {
            using (var context = new sistema_de_estoqueCliente())
            {
                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                List<Cliente> Clientes = new List<Cliente>();

                Clientes = context.Cliente.Where(c => c.Tipo == TipoCadastro).ToList();

                foreach (Cliente Cliente in Clientes)
                {
                    grdDados.Rows.Add(Convert.ToString(Cliente.Codigo)
                                        , Cliente.Nome
                                        , Cliente.CPF
                                        , Cliente.RG
                                        , Cliente.DtNascimento
                                        , Cliente.DtCadastro
                                        , Cliente.Tipo);
                }
                if (Clientes.Count == 0)
                {
                    MessageBox.Show("Não há clientes cadastrados.");
                }
            }
        }

        public frmPesquisaTecnicoCliente(frmVendasServicos form)
        {
            InitializeComponent();
            form_vendas = form;
        }

    }
}
