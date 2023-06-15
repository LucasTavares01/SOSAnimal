using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOS_Animal
{
    public partial class TelaLogin : Form
    {
        private TelaCadastro telaCadastro = new TelaCadastro();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void campoEmailLogin_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(campoEmailLogin, "E-MAIL");
        }

        private void campoEmailLogin_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(campoEmailLogin, "E-MAIL");
        }

        private void campoSenhaLogin_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(campoSenhaLogin, "SENHA");
            campoSenhaLogin.PasswordChar = '•';
        }

        private void campoSenhaLogin_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(campoSenhaLogin, "SENHA");
            campoSenhaLogin.PasswordChar = '\0';
        }

        private void BotaoCadastrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCadastro.Show();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            string email = campoEmailLogin.Text;
            string senha = campoSenhaLogin.Text;

            string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";
            string query = "SELECT * FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro();
                        this.Hide();
                        telaEscolhaCadastro.Show();
                    }
                    else
                    {
                        avisoErroLogin.Visible = true;
                    }
                }
            }
        }

        private void LimparCampoTexto(TextBox textBox, string textoPadrao)
        {
            if (textBox.Text == textoPadrao)
            {
                textBox.Text = "";
            }

            avisoErroLogin.Visible = false;
        }

        private void RestaurarCampoTexto(TextBox textBox, string textoPadrao)
        {
            if (textBox.Text == "")
            {
                textBox.Text = textoPadrao;
            }

            avisoErroLogin.Visible = false;
        }

        private void botaoCadastrarLogin_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarLogin.BackgroundImage = Properties.Resources.botaoCadastrar2;
        }

        private void botaoCadastrarLogin_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarLogin.BackgroundImage = Properties.Resources.botaoCadastrar1;
        }

        private void botaoEntrarLogin_MouseEnter(object sender, EventArgs e)
        {
            botaoEntrarLogin.BackgroundImage = Properties.Resources.botaoEntrar2;
        }

        private void botaoEntrarLogin_MouseLeave(object sender, EventArgs e)
        {
            botaoEntrarLogin.BackgroundImage = Properties.Resources.botaoEntrar1;
        }

        private void TelaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede que o caractere Enter seja inserido no campo de texto
                botaoEntrarLogin_Click(sender, e); // Aciona o evento do botão botaoEntrarLogin
            }
        }

    }
}
