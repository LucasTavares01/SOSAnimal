using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOS_Animal
{
    public partial class TelaLogin : Form
    {
        TelaCadastro telacadastro = new TelaCadastro(); //INSTANCIA A TELACADASTRO PARA O BOTAO CADASTRAR

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
            telacadastro.Show();
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
            string email = campoEmailLogin.Text;
            string senha = campoSenhaLogin.Text;

            // Defina a string de conexão com as configurações corretas
            string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";

            // Crie uma consulta para verificar os dados de login
            string query = "SELECT * FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Se houver um registro correspondente
                        {
                            // Abra a TelaCadastro
                            TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro();
                            this.Hide();
                            telaEscolhaCadastro.Show();
                        }
                        else
                        {
                            // Exiba uma mensagem de erro de login
                            avisoErroLogin.Visible = true;
                        }
                    }
                }
            }
        }

        private void botaoCadastrarLogin_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoCadastrar2;
            botaoCadastrarLogin.BackgroundImage = novaImagem;
        }

        private void botaoCadastrarLogin_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoCadastrar1;
            botaoCadastrarLogin.BackgroundImage = novaImagem;
        }

        private void botaoEntrarLogin_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEntrar2;
            botaoEntrarLogin.BackgroundImage = novaImagem;
        }

        private void botaoEntrarLogin_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEntrar1;
            botaoEntrarLogin.BackgroundImage = novaImagem;
        }
    }
}
