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
    public partial class frmCliente : Form
    {
       
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            this.DestroyHandle();
        }
    }
}
