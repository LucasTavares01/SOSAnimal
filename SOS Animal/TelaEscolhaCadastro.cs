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
    public partial class TelaEscolhaCadastro : Form
    {
        TelaCadastro telacadastro = new TelaCadastro(); //INSTANCIA A TELACADASTRO PARA O BOTAO CADASTRAR

        public TelaEscolhaCadastro()
        {
            InitializeComponent();
        }        

        private void botaoFecharEscolha_Click(object sender, EventArgs e)
        {
            TelaLogin telalogin = new TelaLogin(); //INSTANCIA A TELALOGIN PARA O BOTAO CADASTRAR
            this.Hide();
            telalogin.Show();
        }

        private void botaoEscolhaEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            telacadastro.Show();
        }

        private void botaoEscolhaFinanceiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            telacadastro.Show();
        }

        private void botaoEscolhaControleAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            telacadastro.Show();
        }

        private void BotaoEscolhaEstoque_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.estoque_2;

            botaoEscolhaEstoque.BackgroundImage = novaImagem;
        }

        private void BotaoEscolhaEstoque_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.estoque_1;

            botaoEscolhaEstoque.BackgroundImage = novaImagem;
        }
    }
}
