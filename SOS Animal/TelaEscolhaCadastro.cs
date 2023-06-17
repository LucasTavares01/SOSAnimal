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
        
        TelaControleAnimal telacontroleanimal = new TelaControleAnimal();


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
            //telacadastro.Show();
        }

        private void botaoEscolhaFinanceiro_Click(object sender, EventArgs e)
        {
            
        }

        private void botaoEscolhaControleAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            telacontroleanimal.Show();
        }

        private void botaoEscolhaEstoque_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEstoque2;
            botaoEscolhaEstoque.BackgroundImage = novaImagem;
        }

        private void botaoEscolhaEstoque_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoEstoque1;
            botaoEscolhaEstoque.BackgroundImage = novaImagem;
        }

        private void botaoEscolhaFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoFinanceiro2;
            botaoEscolhaFinanceiro.BackgroundImage = novaImagem;
        }

        private void botaoEscolhaFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoFinanceiro1;
            botaoEscolhaFinanceiro.BackgroundImage = novaImagem;
        }

        private void botaoEscolhaControleAnimal_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoControleAnimais2;
            botaoEscolhaControleAnimal.BackgroundImage = novaImagem;
        }

        private void botaoEscolhaControleAnimal_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoControleAnimais1;
            botaoEscolhaControleAnimal.BackgroundImage = novaImagem;
        }
    }
}
