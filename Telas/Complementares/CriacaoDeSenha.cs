using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.Telas.Complementares
{
    public partial class frmCriacaoSenha : Form
    {
        frmCliente form_cliente;

        public frmCriacaoSenha()
        {
            InitializeComponent();
        }

        public frmCriacaoSenha(frmCliente cliente)
        {
            InitializeComponent();
            form_cliente = cliente;
        }

        private void frmCriacaoSenha_Shown(object sender, EventArgs e)
        {
            edtUsuario.Focus();
        }

        private void edtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (edtUsuario.TextLength > 2)
                {
                    edtSenha.Focus();
                }
                else
                {
                    MessageBox.Show("O nome de usuário deve ter no mínimo 4 caracteres.");
                    edtUsuario.Focus();
                }
            }
        }

        private void brnGravar_Click(object sender, EventArgs e)
        {
            if(edtUsuario.TextLength > 2 && edtSenha.TextLength > 3)
            {
                form_cliente.usuario = edtUsuario.Text;
                form_cliente.senha   = edtSenha.Text;
                MessageBox.Show($"Usuário '{edtUsuario.Text}' criado com sucesso!\n\nGrave o restante dos dados na tela de\ncadastro de Usuário/Clientes.");
                form_cliente.Adicionar_No_Grid();
                this.DestroyHandle();
            }
            else
            {
                if(edtUsuario.TextLength < 3)
                {
                    MessageBox.Show("O nome de usuário deve conter no mínimo 3 caracteres.");
                    edtUsuario.Focus();
                }
                else if (edtSenha.TextLength < 4)
                {
                    MessageBox.Show("A senha deve conter no mínimo 4 caracteres.");
                    edtSenha.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor,\naltere o tipo de cadastro para CLIENTE.");
            this.DestroyHandle();
        }
    }
}
