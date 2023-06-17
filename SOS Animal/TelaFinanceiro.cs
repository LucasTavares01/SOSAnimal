using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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
    public partial class TelaFinanceiro : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";

        public TelaFinanceiro()
        {
            InitializeComponent();
        }

        /////////////////////  CRIAR TABELA DESPESAS //////////////////////  

        private void TelaFinanceiro_Load(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Verificar se a tabela já existe
            string checkTableQuery = "SHOW TABLES LIKE 'despesas'";
            MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection);
            object result = checkTableCommand.ExecuteScalar();

            if (result == null) // A tabela não existe, então vamos criá-la
            {
                // Criar a tabela despesas
                string createTableQuery = "CREATE TABLE despesas (" +
                    "ID_DESPESAS INT AUTO_INCREMENT PRIMARY KEY," +
                    "DATA VARCHAR(50)," +
                    "CATEGORIA VARCHAR(50)," +
                    "VALOR VARCHAR(50)," +
                    "DESCRICAO VARCHAR(50)" +
                    ")";
                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }

            // Buscar os dados do banco de dados novamente
            string selectQuery = "SELECT * FROM despesas";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = selectCommand.ExecuteReader();

            // Criar os UserPanels e preencher as Labels com os dados
            while (reader.Read())
            {                
                string dataValue = reader["DATA"].ToString();
                string categoriaValue = reader["CATEGORIA"].ToString();
                string valorValue = reader["VALOR"].ToString();
                string descricaoValue = reader["DESCRICAO"].ToString();


                // Criar uma instância do UserControl ControleAnimal
                Despesas despesas = new Despesas();
                despesas.PreencherLabels(dataValue, categoriaValue, valorValue, descricaoValue);
                //despesas.trocarImagem(GC);

                // Definir a posição e tamanho do UserControl
                despesas.Location = new Point(0, 0);
                despesas.Size = new Size(flowDespesas.Width, despesas.Height);

                // Adicionar o ControleAnimal ao FlowLayoutPanel
                flowDespesas.Controls.Add(despesas);
            }

            reader.Close();                                                   
        }

        private void AtualizarControlesOrdenados(List<ControleAnimal> controles)
        {
            flowDespesas.Controls.Clear();
            foreach (ControleAnimal controle in controles)
            {
                flowDespesas.Controls.Add(controle);
            }
        }

        private void AtualizarImagemFiltro(Button botaoClicado)
        {
            // Define a imagem 2 (filtro2) para o botão clicado
            botaoClicado.Image = Properties.Resources.filtro2;

            // Define a imagem 1 (filtro1) para os outros botões
            btnOrdenarPorData.Image = btnOrdenarPorData == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorCategoria.Image = btnOrdenarPorCategoria == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorValor.Image = btnOrdenarPorValor == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarDescricao.Image = btnOrdenarDescricao == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin(); ;
            this.Hide();
            telaLogin.Show();
        }

        private void botaoVoltarFinanceiro_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro(); ;
            this.Hide();
            telaEscolhaCadastro.Show();
        }

        private void botaoDespesas_MouseEnter(object sender, EventArgs e)
        {
            botaoDespesas.BackgroundImage = Properties.Resources.botaoDespesas2;
        }

        private void botaoDespesas_MouseLeave(object sender, EventArgs e)
        {
            botaoDespesas.BackgroundImage = Properties.Resources.botaoDespesas1;
        }

        private void botaoDespesas_Click(object sender, EventArgs e)
        {
            this.panelDespesas.Visible = true;
            this.panelReceitas.Visible = false;            
            this.cadastrarDespesas.Visible = false;
            this.cadastrarReceitas.Visible = false;
        }

        private void botaoReceitas_MouseEnter(object sender, EventArgs e)
        {
            botaoReceitas.BackgroundImage = Properties.Resources.botaoReceitas2;
        }

        private void botaoReceitas_MouseLeave(object sender, EventArgs e)
        {
            botaoReceitas.BackgroundImage = Properties.Resources.botaoReceitas1;
        }

        private void botaoReceitas_Click(object sender, EventArgs e)
        {
            this.panelDespesas.Visible = false;
            this.panelReceitas.Visible = true;
            this.cadastrarDespesas.Visible = false;
            this.cadastrarReceitas.Visible = false;
        }

        private void botaoCadastrarDespesas_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarDespesas.BackgroundImage = Properties.Resources.cadastrarDespesas2;
        }

        private void botaoCadastrarDespesas_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarDespesas.BackgroundImage = Properties.Resources.cadastrarDespesas1;
        }

        private void botaoCadastrarDespesas_Click(object sender, EventArgs e)
        {
            this.panelDespesas.Visible = false;
            this.panelReceitas.Visible = false;
            this.cadastrarDespesas.Visible = true;
            this.cadastrarReceitas.Visible = false;
        }

        private void botaoCadastrarReceitas_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarReceitas.BackgroundImage = Properties.Resources.cadastrarReceitas2;
        }

        private void botaoCadastrarReceitas_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarReceitas.BackgroundImage = Properties.Resources.cadastrarReceitas1;
        }

        private void botaoCadastrarReceitas_Click(object sender, EventArgs e)
        {
            this.panelDespesas.Visible = false;
            this.panelReceitas.Visible = false;
            this.cadastrarDespesas.Visible = false;
            this.cadastrarReceitas.Visible = true;
        }

        private void btnOrdenarPorData_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowDespesas.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelID.Text).CompareTo(int.Parse(c2.labelID.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorData);
        }

        private void btnOrdenarPorCategoria_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowDespesas.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelID.Text).CompareTo(int.Parse(c2.labelID.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorCategoria);
        }

        private void btnOrdenarPorValor_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowDespesas.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelID.Text).CompareTo(int.Parse(c2.labelID.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorValor);
        }

        private void btnOrdenarDescricao_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowDespesas.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelID.Text).CompareTo(int.Parse(c2.labelID.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarDescricao);
        }

        private void botaoCadastrarDespesas2_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarDespesas2.BackgroundImage = Properties.Resources.botaoCadastrarCachorro2;
        }

        private void botaoCadastrarDespesas2_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarDespesas2.BackgroundImage = Properties.Resources.botaoCadastrarCachorro1;
        }

        private void botaoCadastrarDespesas2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores das TextBoxes
                string data = textDataDespesas.Text;
                string categoria = textCategoriaDespesas.Text;
                string valor = textValorDespesas.Text;
                string descricao = textDescricaoDespesas.Text;

                // Inserir os dados na tabela controle_de_animais
                string query = "INSERT INTO despesas (DATA, CATEGORIA, VALOR, DESCRICAO) " +
                    "VALUES (@DATA, @CATEGORIA, @VALOR, @DESCRICAO)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DATA", data);
                command.Parameters.AddWithValue("@CATEGORIA", categoria);
                command.Parameters.AddWithValue("@VALOR", valor);
                command.Parameters.AddWithValue("@DESCRICAO", descricao);

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro de despesa realizado com sucesso!");

                // Limpar as TextBoxes após o cadastro
                LimparTextBoxes();

                PreencherValoresPadrao();

                // Remover todos os controles do FlowLayoutPanel
                flowDespesas.Controls.Clear();

                // Buscar os dados do banco de dados novamente
                string selectQuery = "SELECT * FROM despesas";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                // Criar os UserPanels e preencher as Labels com os dados
                while (reader.Read())
                {
                    string dataValue = reader["DATA"].ToString();
                    string categoriaValue = reader["CATEGORIA"].ToString();
                    string valorValue = reader["VALOR"].ToString();
                    string descricaoValue = reader["DESCRICAO"].ToString();


                    // Criar uma instância do UserControl ControleAnimal
                    Despesas despesas = new Despesas();
                    despesas.PreencherLabels(dataValue, categoriaValue, valorValue, descricaoValue);
                    //despesas.trocarImagem(GC);

                    // Definir a posição e tamanho do UserControl
                    despesas.Location = new Point(0, 0);
                    despesas.Size = new Size(flowDespesas.Width, despesas.Height);

                    // Adicionar o ControleAnimal ao FlowLayoutPanel
                    flowDespesas.Controls.Add(despesas);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar gato: " + ex.Message);
            }
        }

        private void LimparTextBoxes()
        {
            textDataDespesas.Text = "";
            textCategoriaDespesas.Text = "";
            textValorDespesas.Text = "";
            textDescricaoDespesas.Text = "";
        }


        private void PreencherValoresPadrao()
        {
            textDataDespesas.Text = "DATA";
            textCategoriaDespesas.Text = "CATEGORIA";
            textValorDespesas.Text = "VALOR";
            textDescricaoDespesas.Text = "DESCRICAO";
        }

        private void LimparCampoTexto(TextBox textBox, string textoPadrao)
        {
            if (textBox.Text == textoPadrao)
            {
                textBox.Text = "";
            }
        }

        private void RestaurarCampoTexto(TextBox textBox, string textoPadrao)
        {
            if (textBox.Text == "")
            {
                textBox.Text = textoPadrao;
            }
        }

        private void botaoCadastrarReceitas2_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarReceitas2.BackgroundImage = Properties.Resources.cadastroCachorro2;
        }

        private void botaoCadastrarReceitas2_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarReceitas2.BackgroundImage = Properties.Resources.cadastroCachorro1;
        }

        private void botaoCadastrarReceitas2_Click(object sender, EventArgs e)
        {

        }

        private void textDataDespesas_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textDataDespesas, "DATA");
        }

        private void textDataDespesas_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textDataDespesas, "DATA");
        }

        private void textCategoriaDespesas_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textCategoriaDespesas, "CATEGORIA");
        }

        private void textCategoriaDespesas_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textCategoriaDespesas, "CATEGORIA");
        }

        private void textValorDespesas_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textValorDespesas, "VALOR");
        }

        private void textValorDespesas_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textValorDespesas, "VALOR");
        }

        private void textDescricaoDespesas_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textDescricaoDespesas, "DESCRIÇÃO");
        }

        private void textDescricaoDespesas_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textDescricaoDespesas, "DESCRIÇÃO");
        }
    }
}
