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
    public partial class frmCliente : Form
    {

        List<Cliente> clientes = new List<Cliente>();

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

        public frmCliente()
        {
            InitializeComponent();            
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
            Adicionar_No_Grid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(2);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarCliente();
            LimparCampos(2);
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

        private void Adicionar_No_Grid()
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
                    });

                    grdDados.Rows.Add(edtCodCliente.Text
                                     ,edtNome.Text
                                     ,edtCPF.Text
                                     ,edtRG.Text
                                     ,edtNasc.Text
                                     ,edtDtCadastro.Text
                                     ,cbTipo.Text);
                }

                LimparCampos();
                btnGravar.Enabled  = true;
                btnLimpar.Enabled  = true;
                btnDeletar.Enabled = true;
                codigo_cliente     = 0;
            }
        }

        private void LimparCampos(int tudo = 1)
        {
            /// <sumary>
            /// Se usado o numero 2, o metodo irá limpar todos os campos do form.
            /// Se não utilizado nada na chamada do método, o mesmo utilizará por
            /// padrão o código 1, que limpa somente os edtis e labels do form.
            /// </sumary>

            edtCodCliente.Text   = "";
            edtNome.Text         = "";
            edtCPF.Text          = "";
            edtRG.Text           = "";
            edtNasc.Text         = "";
            edtDtCadastro.Text   = "";
            cbTipo.SelectedIndex = 0;

            if (tudo == 2)
            {
                grdDados.Rows.Clear();

                // Redimenssiona a coluna do nome do Cliente para ocultar a coluna de código do Cliente
                //grdDados.Columns[1].Width = grdDados.Columns[1].Width + 50;
                //grdDados.Columns[0].Visible = false;

                btnGravar.Enabled  = false;
                btnLimpar.Enabled  = false;
                btnDeletar.Enabled = false;
                btnBuscar.Enabled  = true;
            }

            edtCodCliente.Enabled = true;
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
            }
        }

        private void BuscarCliente()
        {
            var codcliente = edtCodCliente.TextLength > 0 ? Convert.ToInt32(edtCodCliente.Text) : 0;

            LimparCampos();
            btnGravar.Enabled = false;
            btnLimpar.Enabled = true;
            edtCodCliente.Enabled = false;

            using (var context = new sistema_de_estoqueCliente())
            {
                //var codcliente = edtCodCliente.TextLength > 0 ? Convert.ToInt32(edtCodCliente.Text) : 0;

                // Esse objeto será usado logo abaixo para realizar uma busca por todos os itens no BD.
                List<Cliente> Clientes = new List<Cliente>();

                btnBuscar.Enabled = true;
                // Neste bloco é feita uma busca por todos os Clientes no banco e em seguida os dados
                // são carregados no gridview.
                if ((edtNome.TextLength == 0) && (codcliente == 0))
                {
                    Clientes = context.Cliente.ToList<Cliente>();

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
                    btnBuscar.Enabled = false;
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
                                            , query.Nome
                                            , query.CPF
                                            , query.RG
                                            , query.DtNascimento
                                            , query.DtCadastro
                                            , query.Tipo);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado. Verifique!");
                    }
                    edtCodCliente.Enabled = true;
                    edtCodCliente.Focus();
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
                    }
                }
                //context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT[dbo].[Cliente] OFF");
                context.SaveChanges();
                //context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT[dbo].[Cliente] OFF");
            }

            MessageBox.Show("Salvo com sucesso!");
            LimparCampos(2);

        }

        private void grdDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (edtCodCliente.TextLength == 0)
            {
                edtCodCliente.Text = grdDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtNome.Text = grdDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtCPF.Text = grdDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtRG.Text = grdDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtNasc.Text = grdDados.Rows[e.RowIndex].Cells[4].Value.ToString();
                edtDtCadastro.Text = grdDados.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbTipo.Text = grdDados.Rows[e.RowIndex].Cells[6].Value.ToString();

                var index_celula = grdDados.Rows[e.RowIndex];
                grdDados.Rows.Remove(index_celula);

                btnDeletar.Enabled = true;
                edtCodCliente.Enabled = false;
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
                    edtCodCliente.Enabled = false;
                    btnBuscar.Enabled = false;
                    edtNome.Focus();
                }
            }
        }
    }
}
