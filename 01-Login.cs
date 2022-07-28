using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livros
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Variaveis.usuario = txtUsuario.Text;
            Variaveis.senha = txtSenha.Text;

            if (Variaveis.usuario == "Patrick" && Variaveis.senha == "123")
            {
                Variaveis.idade = 25;
                new frmLivros().Show();
                Hide();

            }
            else if (Variaveis.usuario == "Cleber" && Variaveis.senha == "321")
            {
                Variaveis.idade = 15;
                new frmLivros().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Acesso negado", "Atenção");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtSenha.Enabled = true;
                txtSenha.Text = "";
            }
            else
            {
                txtSenha.Enabled = false;
            }
        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
