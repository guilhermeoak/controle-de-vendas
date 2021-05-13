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

namespace Vendas
{
    public partial class frmProduto : Form
    {
        List<Produto> produtos = new List<Produto>();

        public frmProduto()
        {
            InitializeComponent();
            lblResultadoLucro.Text = "";
            lblResultPercent.Text = "";
            Buscar_Produtos();
        }

        public Double calculaLucro(Double valorCusto, Double valorVenda)
        {
            Double Lucro = valorVenda - valorCusto;
            return Lucro >= 0 ? Lucro : 0;
        }

        public double calcularLucroPercentual(Double valorCusto, Double valorVenda)
        {
            Double LucroPercentual = ((valorVenda * 100) / valorCusto) - valorCusto;
            return LucroPercentual >= 0 ? LucroPercentual : 0;
        }


        private void edtPrecoFinal_Leave(object sender, EventArgs e)
        {
            lblResultadoLucro.Text = "";
            Double PrecoCusto = edtPreco.Text != "" ? Convert.ToDouble(edtPreco.Text) : 0;
            Double PrecoFinal = edtPrecoFinal.Text != "" ? Convert.ToDouble(edtPrecoFinal.Text) : 0;

            var lucro = calculaLucro(PrecoCusto, PrecoFinal).ToString();
            var lucroPercentual = calcularLucroPercentual(PrecoCusto, PrecoFinal).ToString("N2");

            lblResultadoLucro.Text = lucro;
            lblResultPercent.Text = lucroPercentual;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar_No_Grid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (var context = new sistema_de_estoqueProduto())
            {
                foreach (Produto produto in produtos)
                {
                    Produto produto_busca = context.Produto.Find(produto.Codprod);

                    if (produto_busca == null)
                    {
                        context.Produto.Add(produto);

                    } else
                    {
                        // Neste bloco fazemos update de um dado já existente no banco
                        Produto produto_existente = context.Produto.First(p => p.Codprod == produto_busca.Codprod);
                        produto_existente.Prodnome = produto.Prodnome;
                        produto_existente.Custo = produto.Custo;
                        produto_existente.Preco_final = produto.Preco_final;
                        produto_existente.Lucro = produto.Lucro;
                        produto_existente.Lucro_percentual = produto.Lucro_percentual;
                    }
                }
                //context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT[dbo].[Produto] OFF");
                context.SaveChanges();
                //context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT[dbo].[Produto] OFF");
            }

            MessageBox.Show("Salvo com sucesso!");
            LimparCampos(2);

        }

        public bool ValidaCampos()
        {
            if (edtNomeProd.Text.Length == 0)
            {
                MessageBox.Show("Favor especificar o nome do produto.");
                edtNomeProd.Focus();
                return false;
            }
            if (edtPreco.Text.Length == 0)
            {
                MessageBox.Show("Favor especificar o preço de compra.");
                edtPreco.Focus();
                return false;
            }
            if (edtPrecoFinal.Text.Length == 0)
            {
                MessageBox.Show("Favor espeficiar o preço de venda.");
                edtPrecoFinal.Focus();
                return false;
            }
            if (edtQtde.Text.Length == 0)
            {
                MessageBox.Show("Favor especificar a quantidade em estoque.");
                edtQtde.Focus();
                return false;
            }

            return true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(2);
        }

        private void LimparCampos(int tudo = 1)
        {
            /// <sumary>
            /// Se usado o numero 2, o metodo irá limpar todos os campos do form.
            /// Se não utilizado nada na chamada do método, o mesmo utilizará por
            /// padrão o código 1, que limpa somente os edtis e labels do form.
            /// </sumary>

            edtCodProd.Text        = "";
            edtNomeProd.Text       = "";
            edtPreco.Text          = "";
            edtPrecoFinal.Text     = "";
            edtQtde.Text           = "";
            lblResultadoLucro.Text = "";
            lblResultPercent.Text  = "";

            if (tudo == 2)
            {
                grdDados.Rows.Clear();

                // Redimenssiona a coluna do nome do produto para ocultar a coluna de código do produto
                grdDados.Columns[1].Width = grdDados.Columns[1].Width + 50;
                grdDados.Columns[0].Visible = false;

                btnGravar.Enabled  = false;
                btnLimpar.Enabled  = false;
                btnDeletar.Enabled = false;
                btnBuscar.Enabled  = true;
            }

            edtCodProd.Enabled = true;
            edtCodProd.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Produtos();
        }

        private void edtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                edtNomeProd.Focus();
                if (edtCodProd.TextLength > 0)
                {
                    Buscar_Produtos();
                }
                else
                {
                    MessageBox.Show("Inserindo novo produto");
                    edtCodProd.Enabled = false;
                    btnBuscar.Enabled  = false;
                    edtNomeProd.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void grdDados_Click(object sender, EventArgs e)
        {
            edtNomeProd.Text = grdDados.Rows[1].ToString();
        }

        private void grdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (edtCodProd.TextLength == 0)
            {
                edtCodProd.Text = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtNomeProd.Text = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtPreco.Text = grdDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtPrecoFinal.Text = grdDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtQtde.Text = grdDados.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblResultadoLucro.Text = grdDados.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblResultPercent.Text = grdDados.Rows[e.RowIndex].Cells[6].Value.ToString();

                var index_celula = grdDados.Rows[e.RowIndex];
                grdDados.Rows.Remove(index_celula);

                btnDeletar.Enabled = true;
                edtCodProd.Enabled = false;
                edtNomeProd.Focus();
            }
        }

        private void Buscar_Produtos()
        {
            var codprod = edtCodProd.TextLength > 0 ? Convert.ToInt32(edtCodProd.Text) : 0;

            LimparCampos();
            btnGravar.Enabled  = false;
            btnLimpar.Enabled  = true;
            edtCodProd.Enabled = false;

            using (var context = new sistema_de_estoqueProduto())
            {
                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                List<Produto> Produtos = new List<Produto>();

                btnBuscar.Enabled = true;
                // Neste bloco é feita uma busca por todos os produtos no banco e em seguida os dados
                // são carregados no gridview.
                if ((edtNomeProd.TextLength == 0) && (codprod == 0))
                {
                    Produtos = context.Produto.ToList<Produto>();
                    foreach (Produto produto in Produtos)
                    {
                        grdDados.Rows.Add(Convert.ToString(produto.Codprod)
                                            , produto.Prodnome
                                            , Convert.ToString(produto.Custo)
                                            , Convert.ToString(produto.Preco_final)
                                            , Convert.ToString(produto.Quantidade)
                                            , Convert.ToString(produto.Lucro)
                                            , Convert.ToString(produto.Lucro_percentual));
                    }
                    if (Produtos.Count == 0)
                    {
                        MessageBox.Show("Produto(s) não encontrados. Verifique.");
                    }
                    btnBuscar.Enabled = false;
                }
                else if ((edtNomeProd.TextLength > 0) || (codprod > 0))
                {
                    // Se o usuario quer fazer uma busca por nome e não por codigo, o programa entra aqui
                    // e altera a atribuição da query   
                    var query = edtNomeProd.TextLength > 0 ? context.Produto.Where(p => p.Prodnome == edtNomeProd.Text).FirstOrDefault<Produto>()
                                                       : context.Produto.Where(p => p.Codprod == codprod).FirstOrDefault<Produto>();

                    if (query != null)
                    {
                        grdDados.Rows.Add(Convert.ToString(query.Codprod)
                                            , query.Prodnome
                                            , Convert.ToString(query.Custo)
                                            , Convert.ToString(query.Preco_final)
                                            , Convert.ToString(query.Quantidade)
                                            , Convert.ToString(query.Lucro)
                                            , Convert.ToString(query.Lucro_percentual));
                    }
                    else
                    {
                        MessageBox.Show("Produto(s) não encontrado. Verifique!");
                    }
                    edtCodProd.Enabled = true;
                    edtCodProd.Focus();
                }
            }         
        }

        private void Deletar_Produto()
        {
            using (var context = new sistema_de_estoqueProduto())
            {
                int codigo_produto = Convert.ToInt32(edtCodProd.Text);
                Produto produto_busca = context.Produto.Find(codigo_produto);
                Produto produto_existente = context.Produto.First(p => p.Codprod == produto_busca.Codprod);
                context.Produto.Remove(produto_existente);
                context.SaveChanges();
                MessageBox.Show("Produto deletado com sucesso!");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar_Produto();
            LimparCampos(2);
            Buscar_Produtos();
        }

        private void Adicionar_No_Grid()
        {
            if (ValidaCampos())
            {
                var codigo_produto = edtCodProd.TextLength > 0 ? Convert.ToInt32(edtCodProd.Text) : 0;

                using (var context = new sistema_de_estoqueProduto())
                {
                    //Produto produto_busca = context.Produto.Find(codigo_produto);

                    produtos.Add(new Produto
                    {
                        Codprod = codigo_produto
                        ,
                        Prodnome = edtNomeProd.Text
                        ,
                        Custo = Convert.ToDouble(edtPreco.Text)
                        ,
                        Preco_final = Convert.ToDouble(edtPrecoFinal.Text)
                        ,
                        Quantidade = Convert.ToInt32(edtQtde.Text)
                        ,
                        Lucro = Convert.ToDouble(lblResultadoLucro.Text)
                        ,
                        Lucro_percentual = Convert.ToDouble(lblResultPercent.Text)
                    });

                    grdDados.Rows.Add(edtCodProd.Text
                                     , edtNomeProd.Text
                                     , edtPreco.Text
                                     , edtPrecoFinal.Text
                                     , edtQtde.Text
                                     , lblResultadoLucro.Text
                                     , lblResultPercent.Text);
                }

                LimparCampos();
                btnGravar.Enabled = true;
                btnLimpar.Enabled = true;
                btnDeletar.Enabled = true;
                codigo_produto = 0;
            }
        }
    }
}
