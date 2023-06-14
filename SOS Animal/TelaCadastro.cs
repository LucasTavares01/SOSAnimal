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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void botaoFecharCadastro_Click(object sender, EventArgs e)
        {
            TelaLogin telalogin = new TelaLogin();
            this.Hide();
            telalogin.Show();
        }

        private void botaoVoltarCadastro_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            this.Hide();
            telaLogin.Show();
        }

        private void campoNomeCadastro_Enter(object sender, EventArgs e)
        {
            if (campoNomeCadastro.Text == "NOME COMPLETO")
            {
                campoNomeCadastro.Text = "";
            }
        }

        private void campoNomeCadastro_Leave(object sender, EventArgs e)
        {
            if (campoNomeCadastro.Text == "")
            {
                campoNomeCadastro.Text = "NOME COMPLETO";
            }
        }

        private void campoEmailCadastro_Enter(object sender, EventArgs e)
        {
            if (campoEmailCadastro.Text == "E-MAIL")
            {
                campoEmailCadastro.Text = "";
            }
        }

        private void campoEmailCadastro_Leave(object sender, EventArgs e)
        {
            if (campoEmailCadastro.Text == "")
            {
                campoEmailCadastro.Text = "E-MAIL";
            }
        }

        private void campoSenhaCadastro_Enter(object sender, EventArgs e)
        {
            if (campoSenhaCadastro.Text == "SENHA")
            {
                campoSenhaCadastro.Text = "";
            }

            campoSenhaCadastro.PasswordChar = '•';
        }

        private void campoSenhaCadastro_Leave(object sender, EventArgs e)
        {
            if (campoSenhaCadastro.Text == "")
            {
                campoSenhaCadastro.PasswordChar = '\0';
                campoSenhaCadastro.Text = "SENHA";
            }
        }

        private void TelaCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void CriarTabela(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE IF NOT EXISTS Usuarios (Nome VARCHAR(100), Senha VARCHAR(100), Email VARCHAR(100))";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AdicionarUsuario(string connectionString, string nome, string senha, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Usuarios (Nome, Senha, Email) VALUES (@Nome, @Senha, @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos de texto
            string nome = campoNomeCadastro.Text;
            string senha = campoSenhaCadastro.Text;
            string email = campoEmailCadastro.Text;

            // Verifica se o email é válido
            if (!email.Contains("@") || !email.Contains(".com"))
            {
                avisoNomeInvalido.Visible = true; // Exibe a label de aviso
                return; // Sai do método para evitar a inserção inválida
            }

            // Verifica se o email já está cadastrado
            if (VerificarCadastro("Server=localhost;Database=usuários;Uid=root;Pwd=;", email))
            {
                MessageBox.Show("Este email já está cadastrado. Por favor, insira um email diferente.");
                return; // Sai do método para evitar a inserção inválida
            }

            // Cria a tabela se não existir
            CriarTabela("Server=localhost;Database=usuários;Uid=root;Pwd=;");

            // Adiciona o usuário à tabela
            AdicionarUsuario("Server=localhost;Database=usuários;Uid=root;Pwd=;", nome, senha, email);

            // Limpa os campos de texto após a inserção
            campoNomeCadastro.Clear();
            campoSenhaCadastro.Clear();
            campoEmailCadastro.Clear();

            MessageBox.Show("Cadastro realizado com sucesso!");
        }




        private void campoNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            if (campoNomeCadastro.Text.ToUpper() == "NOME COMPLETO")
            {
                campoNomeCadastro.Text = "NOME COMPLETO";
                campoNomeCadastro.SelectionStart = campoNomeCadastro.Text.Length;
                return; // Sai do evento para evitar a conversão de texto
            }

            if (!string.IsNullOrEmpty(campoNomeCadastro.Text))
            {
                string[] nomes = campoNomeCadastro.Text.Split(' ');
                StringBuilder resultado = new StringBuilder();

                foreach (string nome in nomes)
                {
                    if (resultado.Length > 0)
                        resultado.Append(" ");

                    if (nome.ToLower() == "da" || nome.ToLower() == "do" || nome.ToLower() == "das" ||
                        nome.ToLower() == "dos" || nome.ToLower() == "de" || nome.ToLower() == "e" ||
                        nome.ToLower() == "eles")
                    {
                        resultado.Append(nome.ToLower());
                    }
                    else
                    {
                        if (nome.Length > 0)
                        {
                            string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                            string restante = nome.Substring(1).ToLower();
                            resultado.Append(primeiroCaractere + restante);
                        }
                    }
                }

                campoNomeCadastro.Text = resultado.ToString();
                campoNomeCadastro.SelectionStart = campoNomeCadastro.Text.Length;
            }
        }

        private void campoEmailCadastro_TextChanged(object sender, EventArgs e)
        {
            if (campoEmailCadastro.Text != "E-MAIL")
            {
                campoEmailCadastro.Text = campoEmailCadastro.Text.ToLower();
                campoEmailCadastro.SelectionStart = campoEmailCadastro.Text.Length;
            }
        }

        private bool VerificarCadastro(string connectionString, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Retorna true se houver algum registro com o email no banco de dados
                }
            }
        }

        private void botaoCadastrar_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoCadastrarDados2;
            botaoCadastrar.BackgroundImage = novaImagem;
        }

        private void botaoCadastrar_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoCadastrarDados1;
            botaoCadastrar.BackgroundImage = novaImagem;
        }
    }
}
