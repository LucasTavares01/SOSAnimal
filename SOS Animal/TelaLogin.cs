using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS_Animal
{
    public partial class TelaLogin : Form
    {
        TelaEscolhaCadastro telaescolhacadastro = new TelaEscolhaCadastro(); //INSTANCIA A TELAESCOLHACADASTRO PARA O BOTAO CADASTRAR

        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void campoEmailLogin_Enter(object sender, EventArgs e)
        {
            if (campoEmailLogin.Text == "E-MAIL")
            {
                campoEmailLogin.Text = "";
            }

            avisoErroLogin.Visible = false;
        }

        private void campoEmailLogin_Leave(object sender, EventArgs e)
        {
            if (campoEmailLogin.Text == "")
            {
                campoEmailLogin.Text = "E-MAIL";
            }

            avisoErroLogin.Visible = false;
        }

        private void campoSenhaLogin_Enter(object sender, EventArgs e)
        {
            if (campoSenhaLogin.Text == "SENHA")
            {
                campoSenhaLogin.Text = "";
            }

            campoSenhaLogin.PasswordChar = '•';
        }

        private void campoSenhaLogin_Leave(object sender, EventArgs e)
        {
            if (campoSenhaLogin.Text == "")
            {
                campoSenhaLogin.PasswordChar = '\0';
                campoSenhaLogin.Text = "SENHA";
            }
        }

        private void BotaoCadastrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaescolhacadastro.Show();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_MouseDown(object sender, MouseEventArgs e) //Quando clicar na tela, todas as ciaxas selecionadas serão desselecionadas
        {
            this.ActiveControl = null;
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            
        }

    }
}
