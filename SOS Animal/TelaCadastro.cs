using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
            TelaLogin telalogin = new TelaLogin(); //INSTANCIA A TELALOGIN PARA O BOTAO CADASTRAR
            this.Hide();
            telalogin.Show();
        }

        private void botaoVoltarCadastro_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaescolhacadastro = new TelaEscolhaCadastro(); //INSTANCIA A TELAESCOLHACADASTRO PARA O BOTAO CADASTRAR
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

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos de texto
            string nome = campoNomeCadastro.Text;
            string senha = campoSenhaCadastro.Text;
            string email = campoEmailCadastro.Text;

            // Salva as informações no banco de dados
            BancoDeDados.SalvarCadastro(nome, senha, email);

            // Limpa os campos de texto após a inserção
            campoNomeCadastro.Clear();
            campoSenhaCadastro.Clear();
            campoEmailCadastro.Clear();

            MessageBox.Show("Cadastro realizado com sucesso!");
        }
    }
}
