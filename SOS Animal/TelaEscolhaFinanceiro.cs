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
    public partial class TelaEscolhaFinanceiro : Form
    {
        public TelaEscolhaFinanceiro()
        {
            InitializeComponent();
        }

        private void botaoReceitas_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoReceitas2;
            botaoReceitas.BackgroundImage = novaImagem;
        }

        private void botaoReceitas_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoReceitas1;
            botaoReceitas.BackgroundImage = novaImagem;
        }

        private void botaoDespesas_MouseEnter(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoDespesas2;
            botaoDespesas.BackgroundImage = novaImagem;
        }

        private void botaoDespesas_MouseLeave(object sender, EventArgs e)
        {
            Image novaImagem = Properties.Resources.botaoDespesas1;
            botaoDespesas.BackgroundImage = novaImagem;
        }

        private void botaoVoltarFinanceiro_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaescolhacadastro = new TelaEscolhaCadastro();
            this.Hide();
            telaescolhacadastro.Show();
        }

        private void botaoFecharFinanceiro_Click(object sender, EventArgs e)
        {
            TelaLogin telalogin = new TelaLogin();
            this.Hide();
            telalogin.Show();
        }
    }
}
