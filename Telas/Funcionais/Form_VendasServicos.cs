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
using Vendas.TelasDePesquisa;
using Vendas.Telas.Complementares;

namespace Vendas
{
    public partial class frmVendasServicos : Form
    {
        public double preco_produto;
        public double preco_total;
        public int qtde_produto;
        public int qtde_atualizada;

        Form_Tela_Inicial tela_inicial;
       
        List<VendasServicos> vendasServicos = new List<VendasServicos>();

        public frmVendasServicos()
        {
            InitializeComponent();
        }

        public frmVendasServicos(Form_Tela_Inicial inicial)
        {
            InitializeComponent();
            tela_inicial = inicial;
        }

        private void btnPesquisarTecnico_Click(object sender, EventArgs e)
        {
            frmPesquisaTecnicoCliente pesquisa = new frmPesquisaTecnicoCliente(this);
            pesquisa.TipoCadastro = "OPERADOR";
            pesquisa.Show();
            pesquisa.BuscarCliente();

        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            frmPesquisaTecnicoCliente pesquisa = new frmPesquisaTecnicoCliente(this);
            pesquisa.TipoCadastro = "CLIENTE";
            pesquisa.Show();
            pesquisa.BuscarCliente();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pesquisa = new frmPesquisaProduto(this);
            pesquisa.Show();
            pesquisa.Buscar_Produtos();
        }

        private void frmVendasServicos_Shown(object sender, EventArgs e)
        {
            edtCodigo.Focus();
            cbTipo.SelectedIndex    = 0;
            edtCodOperador.Text     = Convert.ToString(tela_inicial.usuario.Codigo);
            edtNomeOperador.Text    = tela_inicial.usuario.Nome;
            edtCodOperador.Enabled  = false;
            edtNomeOperador.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Pedidos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar_No_Grid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(2);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private bool ValidaCampos()
        {
            return true;
        }

        private void LimparCampos(int modo = 1)
        {
            /// <sumary>
            /// O modo 1(padrão) limpa somente os controles da tela.
            /// O modo 2 limpa toda a tela, bloqueia os controles e joga o foco para código.
            /// O modo 3 é usado na hora de cadastrar/editar.
            /// </sumary>

            edtNomeOperador.Enabled = false;
            edtNomeCliente.Enabled  = false;
            edtNomeProduto.Enabled  = false;
            edtQtde.Enabled         = true;
            cbTipo.SelectedIndex    = 0;

            btnAdicionar.Text    = "";
            edtCodOperador.Text  = "";
            edtCodigo.Text       = "";
            edtNomeProduto.Text  = "";
            edtNomeCliente.Text  = "";
            edtQtde.Text         = "";
            edtCodProduto.Text   = "";
            edtNomeOperador.Text = "";
            edtCodCliente.Text   = "";
            redtNotas.Text       = ""; 
            redtPrecoTotal.Text  = "";


            btnLimpar.Enabled = true;
            if (modo == 2)
            {
                grdDados.Rows.Clear();

                edtNomeOperador.Enabled = false;
                edtNomeCliente.Enabled  = false;
                edtNomeProduto.Enabled  = false;
                edtQtde.Enabled         = false;
                btnGravar.Enabled       = false;
                btnDeletar.Enabled      = false;
                btnBuscar.Enabled       = true;
                btnLimpar.Enabled       = true;
                cbTipo.SelectedItem     = 0;
                vendasServicos.Clear();
            }

            edtCodigo.Enabled = true;
            edtCodigo.Text    = "";
            edtCodigo.Focus();
        }

        private void edtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(edtQtde.TextLength > 0)
                {
                    preco_total         = preco_produto * Convert.ToInt32(edtQtde.Text);
                    redtPrecoTotal.Text = "R$" + Convert.ToString(preco_total) + ",00";
                    qtde_atualizada     = qtde_produto - Convert.ToInt32(edtQtde.Text);
                    redtNotas.Focus();
                }
            }
        }

        private void Adicionar_No_Grid()
        {
            if (ValidaCampos())
            {
                var codigo_pedido = edtCodigo.TextLength > 0 ? Convert.ToInt32(edtCodigo.Text) : 0;

                vendasServicos.Add(new VendasServicos
                {
                     Codigo        = codigo_pedido
                    ,Descricao     = redtNotas.Text
                    ,CodProdServ   = Convert.ToInt32(edtCodProduto.Text)
                    ,DataTransacao = DateTime.Now
                    ,Tipo          = cbTipo.Text
                    ,Quantidade    = Convert.ToDouble(edtQtde.Text)
                    ,ValorTotal    = preco_total
                    ,CodCli        = Convert.ToInt32(edtCodCliente.Text)
                    ,CodOp         = Convert.ToInt32(edtCodOperador.Text)
                });

                grdDados.Rows.Add(Convert.ToString(codigo_pedido)
                                    ,cbTipo.Text
                                    ,redtPrecoTotal.Text
                                    ,edtCodOperador.Text
                                    ,edtNomeOperador.Text
                                    ,edtCodCliente.Text
                                    ,edtNomeCliente.Text
                                    ,edtCodProduto.Text
                                    ,edtNomeProduto.Text);

                LimparCampos();
                btnGravar.Enabled  = true;
                btnLimpar.Enabled  = true;
                btnDeletar.Enabled = true;
                codigo_pedido      = 0;
            }
        }

        private void Gravar()
        {
            using (var context = new sistema_de_estoqueVendasServicos())
            {
                foreach (VendasServicos VendasServicos in vendasServicos)
                {
                    VendasServicos operacao_busca = context.VendasServicos.Find(VendasServicos.Codigo);

                    if (operacao_busca == null)
                    {
                        context.VendasServicos.Add(VendasServicos);
                    }
                    else
                    {
                        // Neste bloco fazemos update de um dado já existente no banco
                        /* VendasServicos operacao_existente = context.VendasServicos.First(p => p.Codprod == operacao_busca.Codprod);
                        operacao_existente.Prodnome = VendasServicos.Prodnome;
                        operacao_existente.Custo = VendasServicos.Custo;
                        operacao_existente.Preco_final = VendasServicos.Preco_final;
                        operacao_existente.Lucro = VendasServicos.Lucro;
                        operacao_existente.Lucro_percentual = VendasServicos.Lucro_percentual;*/
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show("Pedido efetuado com sucesso!");
            LimparCampos(2);
        }

        private void Buscar_Pedidos()
        {
            var codprod = edtCodigo.TextLength > 0 ? Convert.ToInt32(edtCodigo.Text) : 0;
            var tipo = cbTipo.Text;

            LimparCampos();
            btnGravar.Enabled = false;
            btnLimpar.Enabled = true;

            using (var context = new sistema_de_estoqueVendasServicos())
            {
                var contextproduto = new sistema_de_estoqueProduto();               
                var contextcliente = new sistema_de_estoqueCliente();
                var contextoperador = new sistema_de_estoqueCliente();

                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                //List<VendasServicos> vendasServicos = new List<VendasServicos>();

                btnBuscar.Enabled = true;
                // Neste bloco é feita uma busca por todos os produtos no banco e em seguida os dados
                // são carregados no gridview.
                if ((edtCodigo.TextLength == 0) && (codprod == 0))
                {
                    List<VendasServicos> vendasServicos = context.VendasServicos.Where(vs => vs.Tipo == tipo).ToList();
                    //List<VendasServicos> vendasServicos = context.VendasServicos.ToList<VendasServicos>();
                    foreach (VendasServicos pedidos in vendasServicos)
                    {
                        var cliente              = contextcliente.Cliente.Find(pedidos.CodCli);
                        var operador             = contextoperador.Cliente.Find(pedidos.CodOp);
                        var produto              = contextproduto.Produto.Find(pedidos.CodProdServ);

                        grdDados.Rows.Add(Convert.ToString(pedidos.Codigo)
                                            ,pedidos.Tipo
                                            ,Convert.ToString(pedidos.ValorTotal)
                                            ,Convert.ToString(pedidos.CodOp)
                                            ,Convert.ToString(operador.Nome)
                                            ,Convert.ToString(pedidos.CodCli)
                                            ,Convert.ToString(cliente.Nome)
                                            ,Convert.ToString(pedidos.CodProdServ)
                                            ,Convert.ToString(produto.Prodnome));
                    }
                    if (vendasServicos.Count == 0)
                    {
                        MessageBox.Show("Pedido(s) não encontrados. Verifique.");
                    }
                    btnBuscar.Enabled = false;
                }
                else if ((edtCodCliente.TextLength > 0) || (edtCodOperador.TextLength > 0))
                { 
                    var query = edtCodOperador.TextLength > 0 ? context.VendasServicos.Where(vs=> vs.CodOp == Convert.ToInt32(edtCodOperador.Text)).FirstOrDefault<VendasServicos>()
                                                              : context.VendasServicos.Where(vs => vs.CodCli == Convert.ToInt32(edtCodCliente.Text)).FirstOrDefault<VendasServicos>();

                    if (query != null)
                    {
                        grdDados.Rows.Add(Convert.ToString(query.Codigo)
                                            ,query.Tipo
                                            ,Convert.ToString(query.ValorTotal)
                                            ,Convert.ToString(query.CodOp)
                                            ,Convert.ToString("")
                                            ,Convert.ToString(query.CodCli)
                                            ,Convert.ToString("")
                                            ,Convert.ToString(query.CodProdServ)
                                            ,Convert.ToString(""));
                    }
                    else
                    {
                        MessageBox.Show("Pedido(s) não encontrado. Verifique!");
                    }
                    edtCodigo.Enabled = true;
                    edtCodigo.Focus();
                }
            }
        }

        private void edtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (edtCodCliente.TextLength > 0)
                {
                    Buscar_Pedidos();
                }
                else
                {
                    MessageBox.Show("Realizando novo pedido");
                    LimparCampos();
                    edtCodigo.Enabled = false;
                    edtCodOperador.Focus();
                }
            }
        }
    }
}
