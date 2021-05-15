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

namespace Vendas.Telas.Complementares
{
    public partial class frmLogin : Form
    {
        public Cliente usuario;
        public string usuario_logado;
        public string senha_usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario_logado = edtUsuario.Text;
            senha_usuario  = edtSenha.Text;

            ValidaLogin(usuario_logado, senha_usuario);
        }

        public void ValidaLogin(string login, string senha)
        {
            using (var context = new sistema_de_estoqueCliente())
            {
                usuario = context.Cliente.Where(c => c.usuario == login && c.senha == senha).FirstOrDefault();
                if(usuario != null)
                {
                    Form_Tela_Inicial tela_inicial = new Form_Tela_Inicial(this);
                    this.Visible = false;
                    tela_inicial.Show();
                    MessageBox.Show($"Seja bem-vindo {usuario.Nome}!");
                    senha_usuario = "";
                }
                else if(usuario == null)
                {
                    MessageBox.Show("Usuário/Senha inválidos.\n\nVerifique!");
                    edtUsuario.Focus();
                    senha_usuario = "";
                }
            }
        }

        private void edtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(edtUsuario.TextLength > 2)
                {
                    edtSenha.Focus();
                }
            }
        }

        private void edtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (edtSenha.TextLength > 3)
                {
                    usuario_logado = edtUsuario.Text;
                    senha_usuario = edtSenha.Text;

                    ValidaLogin(usuario_logado, senha_usuario);
                }
            }
        }
    }
}
