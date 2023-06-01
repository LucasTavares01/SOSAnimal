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
            TelaEscolhaCadastro telaescolhacadastro = new TelaEscolhaCadastro();
            this.Hide();
            telaescolhacadastro.Show();
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
    }
}
