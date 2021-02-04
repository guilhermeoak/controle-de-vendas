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
        public frmProduto()
        {
            InitializeComponent();
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

            lblResultadoLucro.Text = "R$" + lucro;
            lblResultPercent.Text = lucroPercentual + "%";
        }
    }
}
