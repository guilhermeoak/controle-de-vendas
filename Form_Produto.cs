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
    public partial class frmProduto : Form
    {
        List<Produto> produtos = new List<Produto>();

        public frmProduto()
        {
            InitializeComponent();
        }

        public Double calculaLucro(Double valorCusto, Double valorVenda)
        {
            Double Lucro  = valorVenda - valorCusto;
            return Lucro >= 0 ? Lucro : 0;
        }

        public double calcularLucroPercentual(Double valorCusto, Double valorVenda)
        {
            Double LucroPercentual  = ((valorVenda * 100) / valorCusto) - valorCusto;
            return LucroPercentual >= 0 ? LucroPercentual : 0;
        }


        private void edtPrecoFinal_Leave(object sender, EventArgs e)
        {
            lblResultadoLucro.Text                  = "";
            Double PrecoCusto = edtPreco.Text      != "" ? Convert.ToDouble(edtPreco.Text) : 0;
            Double PrecoFinal = edtPrecoFinal.Text != "" ? Convert.ToDouble(edtPrecoFinal.Text) : 0;

            var lucro = calculaLucro(PrecoCusto, PrecoFinal).ToString();
            var lucroPercentual = calcularLucroPercentual(PrecoCusto, PrecoFinal).ToString("N2");

            lblResultadoLucro.Text = lucro;
            lblResultPercent.Text  = lucroPercentual;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                produtos.Add(new Produto
                    (Convert.ToInt32(edtCodProd.Text), edtNomeProd.Text, Convert.ToDouble(edtPreco.Text),
                     Convert.ToDouble(edtPrecoFinal.Text), Convert.ToInt32(edtQtde.Text),
                     Convert.ToDouble(lblResultadoLucro.Text), Convert.ToDouble(lblResultPercent.Text))
                );

                grdDados.Rows.Add(edtCodProd.Text, edtNomeProd.Text,
                      edtPreco.Text, edtPrecoFinal.Text,
                      edtQtde.Text, lblResultadoLucro.Text, lblResultPercent.Text);

                LimparCampos();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var context = new sistema_de_estoqueEntities();
            
            foreach (Produto produto in produtos)
            {
                context.Produto.Add(produto);                
            }
            context.SaveChanges();
            MessageBox.Show("Salvo com sucesso!");

            LimparCampos(2);
        }

        public bool ValidaCampos()
        {            
            if (edtCodProd.Text.Length == 0)
            {
                MessageBox.Show("Favor preencher o código do produto.");
                edtCodProd.Focus();
                return false;
            }
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

            edtCodProd.Text = "";
            edtNomeProd.Text = "";
            edtPreco.Text = "";
            edtPrecoFinal.Text = "";
            edtQtde.Text = "";
            lblResultadoLucro.Text = "";
            lblResultPercent.Text = "";

            if (tudo == 2)
            {
                grdDados.Rows.Clear();
            }

            edtCodProd.Focus();
        }
    }
}
