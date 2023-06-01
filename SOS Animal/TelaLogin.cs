﻿using System;
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
                            TelaCadastro telaCadastro = new TelaCadastro();
                            this.Hide();
                            telaCadastro.Show();
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
    }
}
