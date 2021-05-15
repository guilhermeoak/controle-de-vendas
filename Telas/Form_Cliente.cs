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
using Vendas.Telas.Complementares;

namespace Vendas
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        List<Cliente> clientes = new List<Cliente>();
        public string senha;
        public string usuario;

        private void frmCliente_Load(object sender, EventArgs e)
        {
            RedefineCampos();
        }

        private void edtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                edtRG.Focus();
            }
        }

        private void edtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                edtNasc.Focus();
            }
        }

        private void edtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                edtDtCadastro.Focus();
            }
        }

        private void edtCPF_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void edtRG_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void edtNasc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void edtDtCadastro_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            this.DestroyHandle();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(cbTipo.SelectedIndex == 1)
            {
                frmCriacaoSenha cadastro_usuario = new frmCriacaoSenha(this);
                cadastro_usuario.Show();
            }
            else
            {
                Adicionar_No_Grid();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            RedefineCampos(2);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarCliente();
            RedefineCampos(2);
            BuscarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        public bool ValidaCampos()
        {
            if (edtNome.Text.Length == 0)
            {
                MessageBox.Show("Favor especificar o nome.");
                edtNome.Focus();
                return false;
            }
            if (edtCPF.Text.Length  == 0)
            {
                MessageBox.Show("Favor especificar o CPF.");
                edtCPF.Focus();
                return false;
            }
            if (edtRG.Text.Length   == 0)
            {
                MessageBox.Show("Favor espeficiar o RG.");
                edtRG.Focus();
                return false;
            }
            if (edtNasc.Text.Length == 0)
            {
                MessageBox.Show("Favor especificar a data de nascimento.");
                edtNasc.Focus();
                return false;
            }

            return true;
        }

        public void Adicionar_No_Grid()
        {
            if (ValidaCampos())
            {
                var codigo_cliente = edtCodCliente.TextLength > 0 ? Convert.ToInt32(edtCodCliente.Text) : 0;

                using (var context = new sistema_de_estoqueCliente())
                {
                    //Cliente cliente_busca = context.Cliente.Find(codigo_cliente);

                    clientes.Add(new Cliente
                    {
                         Codigo       = codigo_cliente
                        ,Nome         = edtNome.Text
                        ,CPF          = edtCPF.Text
                        ,RG           = edtRG.Text
                        ,DtNascimento = Convert.ToDateTime(edtNasc.Text)
                        ,DtCadastro   = Convert.ToDateTime(edtDtCadastro.Text)
                        ,Tipo         = cbTipo.Text
                        ,usuario      = usuario
                        ,senha        = senha
                    });

                    grdDados.Rows.Add(edtCodCliente.Text
                                     ,edtNome.Text
                                     ,edtCPF.Text
                                     ,edtRG.Text
                                     ,edtNasc.Text
                                     ,edtDtCadastro.Text
                                     ,cbTipo.Text);
                }

                RedefineCampos();
                btnGravar.Enabled  = true;
                btnLimpar.Enabled  = true;
                btnDeletar.Enabled = true;                
                codigo_cliente     = 0;
            }
        }

        private void RedefineCampos(int modo = 1)
        {
            /// <sumary>
            /// O modo 1(padrão) limpa somente os controles da tela.
            /// O modo 2 limpa toda a tela, bloqueia os controles e joga o foco para código.
            /// O modo 3 é usado na hora de cadastrar/editar um cliente.
            /// </sumary>

            edtDtCadastro.Enabled = false;
            edtDtCadastro.Text    = DateTime.Now.ToString();
            edtNasc.Enabled       = false;
            edtCPF.Enabled        = false;
            edtRG.Enabled         = false;
            cbTipo.SelectedIndex  = 0;
             

            btnLimpar.Enabled = true;
            if (modo == 2)
            {
                grdDados.Rows.Clear();

                edtNasc.Enabled       = false;
                edtCPF.Enabled        = false;
                edtRG.Enabled         = false;
                cbTipo.SelectedItem   = 0;                              
                btnGravar.Enabled     = false;
                btnDeletar.Enabled    = false;
                btnBuscar.Enabled     = true;
                btnLimpar.Enabled     = true;
                clientes.Clear();
            }
            else if (modo == 3)
            {
                edtNasc.Enabled       = true;
                edtCPF.Enabled        = true;
                edtRG.Enabled         = true;
                edtNasc.Enabled       = true;
                edtCPF.Enabled        = true;
                edtRG.Enabled         = true;
                cbTipo.SelectedIndex  = 0;
                btnBuscar.Enabled     = false;
                return;
            }
            
            edtNome.Text          = "";
            edtCPF.Text           = "";
            edtRG.Text            = "";
            edtNasc.Text          = "";
            cbTipo.SelectedIndex  = 0;
            edtCodCliente.Enabled = true;
            edtCodCliente.Text    = "";
            edtCodCliente.Focus();
        }

        private void DeletarCliente()
        {
            using (var context = new sistema_de_estoqueCliente())
            {
                int codigo_cliente = Convert.ToInt32(edtCodCliente.Text);
                Cliente cliente_busca = context.Cliente.Find(codigo_cliente);
                Cliente cliente_existente = context.Cliente.First(p => p.Codigo == cliente_busca.Codigo);
                context.Cliente.Remove(cliente_existente);
                context.SaveChanges();
                MessageBox.Show("Cliente deletado com sucesso!");
                RedefineCampos(3);
            }
        }

        public void BuscarCliente()
        {
            var codcliente = edtCodCliente.TextLength > 0 ? Convert.ToInt32(edtCodCliente.Text) : 0;
            var tipo = cbTipo.Text;

            RedefineCampos(2);

            using (var context = new sistema_de_estoqueCliente())
            {
                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                List<Cliente> Clientes = new List<Cliente>();

                btnBuscar.Enabled = false;
                // Neste bloco é feita uma busca por todos os Clientes no banco e em seguida os dados
                // são carregados no gridview.
                if ((edtNome.TextLength == 0) && (codcliente == 0))
                {

                    Clientes = context.Cliente.Where(c => c.Tipo == tipo).ToList();
                    

                    //Clientes = context.Cliente.ToList<Cliente>();

                    foreach (Cliente Cliente in Clientes)
                    {
                        grdDados.Rows.Add(Convert.ToString(Cliente.Codigo)
                                            ,Cliente.Nome
                                            ,Cliente.CPF
                                            ,Cliente.RG
                                            ,Cliente.DtNascimento
                                            ,Cliente.DtCadastro
                                            ,Cliente.Tipo);
                    }
                    if (Clientes.Count == 0)
                    {
                        MessageBox.Show("Não há clientes cadastrados.");
                        RedefineCampos(2);
                        return;
                    }
                    btnBuscar.Enabled = true;
                }
                else if ((edtNome.TextLength > 0) || (codcliente > 0))
                {
                    // Se o usuario quer fazer uma busca por nome e não por codigo, o programa entra aqui
                    // e altera a atribuição da query   
                    var query = edtNome.TextLength > 0 ? context.Cliente.Where(p => p.Nome == edtNome.Text).FirstOrDefault<Cliente>()
                                                       : context.Cliente.Where(p => p.Codigo == codcliente).FirstOrDefault<Cliente>();

                    if (query != null)
                    {
                        grdDados.Rows.Add(Convert.ToString(query.Codigo)
                                            ,query.Nome
                                            ,query.CPF
                                            ,query.RG
                                            ,query.DtNascimento
                                            ,query.DtCadastro
                                            ,query.Tipo);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                        RedefineCampos();
                    }
                }
            }
        }

        private void Gravar()
        {
            using (var context = new sistema_de_estoqueCliente())
            {
                foreach (Cliente Cliente in clientes)
                {
                    Cliente cliente_busca = context.Cliente.Find(Cliente.Codigo);

                    if (cliente_busca == null)
                    {
                        context.Cliente.Add(Cliente);

                    }
                    else
                    {
                        // Neste bloco fazemos update de um dado já existente no banco
                        Cliente cliente_existente      = context.Cliente.First(p => p.Codigo == cliente_busca.Codigo);
                        cliente_existente.Nome         = Cliente.Nome;
                        cliente_existente.CPF          = Cliente.CPF;
                        cliente_existente.RG           = Cliente.RG;
                        cliente_existente.DtNascimento = Cliente.DtNascimento;
                        cliente_existente.DtCadastro   = Cliente.DtCadastro;
                        cliente_existente.Tipo         = Cliente.Tipo;
                        cliente_existente.senha        = Cliente.senha;
                        cliente_existente.usuario      = Cliente.usuario;
                    }
                    context.SaveChanges();
                }
            }
            MessageBox.Show("Salvo com sucesso!");
            RedefineCampos(2);
        }

        private void grdDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (edtCodCliente.TextLength == 0)
            {
                edtCodCliente.Text = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtNome.Text       = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtCPF.Text        = grdDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtRG.Text         = grdDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtNasc.Text       = grdDados.Rows[e.RowIndex].Cells[4].Value.ToString();
                edtDtCadastro.Text = grdDados.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbTipo.Text        = grdDados.Rows[e.RowIndex].Cells[6].Value.ToString();

                var index_celula = grdDados.Rows[e.RowIndex];
                grdDados.Rows.Remove(index_celula);

                btnDeletar.Enabled = true;
                btnBuscar.Enabled  = false;
                RedefineCampos(3);
                edtNome.Focus();
            }
        }

        private void edtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                edtNome.Focus();
                if (edtCodCliente.TextLength > 0)
                {
                    BuscarCliente();
                }
                else
                {
                    MessageBox.Show("Inserindo novo cliente");
                    RedefineCampos(3);
                    edtNome.Focus();
                }
            }
        }
    }
}
