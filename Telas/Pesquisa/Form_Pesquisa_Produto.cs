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
    public partial class frmPesquisaProduto : Form
    {
        frmVendasServicos form_produto;

        public frmPesquisaProduto()
        {

        }

        public void Buscar_Produtos()
        {
            using (var context = new sistema_de_estoqueProduto())
            {
                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                List<Produto> Produtos = new List<Produto>();
                
                // Neste bloco é feita uma busca por todos os produtos no banco e em seguida os dados
                // são carregados no gridview.
                Produtos = context.Produto.ToList<Produto>();
                foreach (Produto produto in Produtos)
                {
                    grdDados.Rows.Add(Convert.ToString(produto.Codprod)
                                        ,produto.Prodnome
                                        ,Convert.ToString(produto.Custo)
                                        ,Convert.ToString(produto.Preco_final)
                                        ,Convert.ToString(produto.Quantidade)
                                        ,Convert.ToString(produto.Lucro)
                                        ,Convert.ToString(produto.Lucro_percentual));
                }
                if (Produtos.Count == 0)
                {
                    MessageBox.Show("Produto(s) não encontrados. Verifique.");
                }
            }
        }

        public frmPesquisaProduto(frmVendasServicos form)
        {
            InitializeComponent();
            form_produto = form;
        }

        private void grdDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_produto.cod_produto         = Convert.ToInt32(grdDados.Rows[e.RowIndex].Cells[0].Value);
            form_produto.edtCodProduto.Text  = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            form_produto.edtNomeProduto.Text = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            form_produto.preco_produto       = Convert.ToDouble(grdDados.Rows[e.RowIndex].Cells[3].Value);
            form_produto.qtde_produto        = Convert.ToInt32(grdDados.Rows[e.RowIndex].Cells[4].Value);
            form_produto.edtQtde.Focus();
            this.DestroyHandle();
        }
    }
}
