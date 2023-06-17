using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS_Animal
{
    public partial class TelaControleAnimal : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";

        public TelaControleAnimal()
        {
            InitializeComponent();
        }

        /////////////////////  CRIAR TABELA CONTROLE DE ANIMAIS //////////////////////  

        private void TelaControleAnimal_Load(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Verificar se a tabela já existe
            string checkTableQuery = "SHOW TABLES LIKE 'controle_de_animais'";
            MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection);
            object result = checkTableCommand.ExecuteScalar();

            if (result == null) // A tabela não existe, então vamos criá-la
            {
                // Criar a tabela controle_de_animais
                string createTableQuery = "CREATE TABLE controle_de_animais (" +
                    "ID_ANIMAL INT AUTO_INCREMENT PRIMARY KEY," +
                    "NOME VARCHAR(50) NOT NULL," +
                    "IDADE INT," +
                    "RACA VARCHAR(50)," +
                    "PORTE VARCHAR(50)," +
                    "GATOCACHORRO VARCHAR(10)," +
                    "DADOSIMAGEM BLOB" +
                    ")";
                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }

            // Buscar os dados do banco de dados novamente
            string selectQuery = "SELECT * FROM controle_de_animais";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = selectCommand.ExecuteReader();

            // Criar os UserPanels e preencher as Labels com os dados
            while (reader.Read())
            {
                string idAnimalValue = reader["ID_ANIMAL"].ToString();
                string nomeValue = reader["NOME"].ToString();
                string idadeValue = reader["IDADE"].ToString();
                string racaValue = reader["RACA"].ToString();
                string porteValue = reader["PORTE"].ToString();
                string GC = reader["GATOCACHORRO"].ToString();

                // Criar uma instância do UserControl ControleAnimal
                ControleAnimal controleAnimal = new ControleAnimal();
                controleAnimal.PreencherLabels(idAnimalValue, nomeValue, idadeValue, racaValue, porteValue);
                controleAnimal.trocarImagem(GC);

                // Definir a posição e tamanho do UserControl
                controleAnimal.Location = new Point(0, 0);
                controleAnimal.Size = new Size(flowControleAnimal.Width, controleAnimal.Height);

                // Adicionar o ControleAnimal ao FlowLayoutPanel
                flowControleAnimal.Controls.Add(controleAnimal);
            }

            reader.Close();

            textIDCachorro.Enabled = false; // Desativar o campo textIDCachorro
            textIDGato.Enabled = false; // Desativar o campo textIDGato                                        
        }


        /////////////////////  TELA CONTROLE ANIMAL /////////////////////////

        private void botaoControleAnimal_Click(object sender, EventArgs e) /////// BOTAO PARA ATIVAR O PAINEL CONTROLE ANIMAL
        {
            panelControleAnimal.Visible = true;
            panelCadastrarCachorro.Visible = false;
            panelCadastrarGato.Visible = false;
        }

        private void botaoControleAnimal_MouseEnter(object sender, EventArgs e)
        {
            botaoControleAnimal.BackgroundImage = Properties.Resources.controleAnimal2;
        }

        private void botaoControleAnimal_MouseLeave(object sender, EventArgs e)
        {
            botaoControleAnimal.BackgroundImage = Properties.Resources.controleAnimal1;
        }

        private void btnOrdenarPorId_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowControleAnimal.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelID.Text).CompareTo(int.Parse(c2.labelID.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorId);
        }

        private void btnOrdenarPorNome_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowControleAnimal.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelNome.Text, c2.labelNome.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorNome);
        }

        private void btnOrdenarPorIdade_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowControleAnimal.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => int.Parse(c1.labelIdade.Text).CompareTo(int.Parse(c2.labelIdade.Text)));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorIdade);
        }

        private void btnOrdenarRaca_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowControleAnimal.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelRaca.Text, c2.labelRaca.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarRaca);
        }

        private void btnOrdenarPorPorte_Click(object sender, EventArgs e)
        {
            List<ControleAnimal> controles = flowControleAnimal.Controls.OfType<ControleAnimal>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelPorte.Text, c2.labelPorte.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro(btnOrdenarPorPorte);
        }

        private void AtualizarControlesOrdenados(List<ControleAnimal> controles)
        {
            flowControleAnimal.Controls.Clear();
            foreach (ControleAnimal controle in controles)
            {
                flowControleAnimal.Controls.Add(controle);
            }
        }

        private void AtualizarImagemFiltro(Button botaoClicado)
        {
            // Define a imagem 2 (filtro2) para o botão clicado
            botaoClicado.Image = Properties.Resources.filtro2;

            // Define a imagem 1 (filtro1) para os outros botões
            btnOrdenarPorId.Image = btnOrdenarPorId == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorNome.Image = btnOrdenarPorNome == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorIdade.Image = btnOrdenarPorIdade == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarRaca.Image = btnOrdenarRaca == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorPorte.Image = btnOrdenarPorPorte == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
        }

        /////////////////////  TELA CADASTRAR CACHORRO /////////////////////////

        private void botaoCadastroCachorro_Click(object sender, EventArgs e)
        {
            panelControleAnimal.Visible = false;
            panelCadastrarCachorro.Visible = true;
            panelCadastrarGato.Visible = false;
        }

        private void botaoCadastroCachorro_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastroCachorro.BackgroundImage = Properties.Resources.cadastroCachorro2;
        }

        private void botaoCadastroCachorro_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastroCachorro.BackgroundImage = Properties.Resources.cadastroCachorro1;
        }

        private void textNomeCachorro_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textNomeCachorro, "NOME");
        }

        private void textNomeCachorro_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textNomeCachorro, "NOME");
        }

        private void textIdadeCachorro_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textIdadeCachorro, "IDADE");
        }

        private void textIdadeCachorro_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textIdadeCachorro, "IDADE");
        }

        private void textRacaCachorro_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textRacaCachorro, "RAÇA");
        }

        private void textRacaCachorro_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textRacaCachorro, "RAÇA");
        }

        private void textPorteCachorro_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textPorteCachorro, "PORTE");
        }

        private void textPorteCachorro_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textPorteCachorro, "PORTE");
        }

        private void botaoCadastrarCachorro_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarCachorro.BackgroundImage = Properties.Resources.botaoCadastrarCachorro2;
        }

        private void botaoCadastrarCachorro_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarCachorro.BackgroundImage = Properties.Resources.botaoCadastrarCachorro1;
        }

        private void botaoCadastrarCachorro_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores das TextBoxes
                string nome = textNomeCachorro.Text;
                string idadeCachorro = textIdadeCachorro.Text;
                string raca = textRacaCachorro.Text;
                string porte = textPorteCachorro.Text;

                // Definir o valor da coluna gatocachorro como 1 (cachorro)
                string gatoCachorro = "1";

                // Inserir os dados na tabela controle_de_animais
                string query = "INSERT INTO controle_de_animais (NOME, IDADE, RACA, PORTE, GATOCACHORRO) " +
                    "VALUES (@NOME, @IDADE, @RACA, @PORTE, @GATOCACHORRO)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NOME", nome);
                command.Parameters.AddWithValue("@IDADE", idadeCachorro);
                command.Parameters.AddWithValue("@RACA", raca);
                command.Parameters.AddWithValue("@PORTE", porte);
                command.Parameters.AddWithValue("@GATOCACHORRO", gatoCachorro);

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro do cachorro realizado com sucesso!");

                // Limpar as TextBoxes após o cadastro
                LimparTextBoxes();

                // Atualizar o valor do ID na TextBox
                AtualizarIDCachorro();

                PreencherValoresPadrao();     

                // Remover todos os controles do FlowLayoutPanel
                flowControleAnimal.Controls.Clear();

                // Buscar os dados do banco de dados novamente
                string selectQuery = "SELECT * FROM controle_de_animais";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = selectCommand.ExecuteReader();                  

                // Criar os UserPanels e preencher as Labels com os dados
                while (reader.Read())
                {
                    string idAnimalValue = reader["ID_ANIMAL"].ToString();
                    string nomeValue = reader["NOME"].ToString();
                    string idadeValue = reader["IDADE"].ToString();
                    string racaValue = reader["RACA"].ToString();
                    string porteValue = reader["PORTE"].ToString();
                    string GC = reader["GATOCACHORRO"].ToString();

                    // Criar uma instância do UserControl ControleAnimal
                    ControleAnimal controleAnimal = new ControleAnimal();
                    controleAnimal.PreencherLabels(idAnimalValue, nomeValue, idadeValue, racaValue, porteValue);
                    controleAnimal.trocarImagem(GC);                    

                    // Definir a posição e tamanho do UserControl
                    controleAnimal.Location = new Point(0, 0);
                    controleAnimal.Size = new Size(flowControleAnimal.Width, controleAnimal.Height);

                    // Adicionar o ControleAnimal ao FlowLayoutPanel
                    flowControleAnimal.Controls.Add(controleAnimal);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cachorro: " + ex.Message);
            }
        }      

        private void AtualizarIDCachorro()
        {
            try
            {
                // Obter o último ID cadastrado
                string query = "SELECT MAX(ID_ANIMAL) FROM controle_de_animais";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int latestID = Convert.ToInt32(result);
                    int nextID = latestID + 1;
                    textIDCachorro.Text = nextID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o próximo ID: " + ex.Message);
            }
        }

        private void panelCadastrarCachorro_VisibleChanged(object sender, EventArgs e)
        {
            if (panelCadastrarCachorro.Visible)
            {
                // Limpar a TextBox de ID
                textIDCachorro.Clear();

                try
                {
                    // Obter o próximo ID disponível
                    string query = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'usuários' AND TABLE_NAME = 'controle_de_animais';";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int nextID = Convert.ToInt32(result);
                        textIDCachorro.Text = nextID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter o próximo ID: " + ex.Message);
                }
            }
        }        

        /////////////////////  TELA CADASTRAR GATO ///////////////////////// 

        private void botaoCadastroGato_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastroGato.BackgroundImage = Properties.Resources.cadastroGato2;
        }

        private void botaoCadastroGato_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastroGato.BackgroundImage = Properties.Resources.cadastroGato1;
        }

        private void botaoCadastroGato_Click(object sender, EventArgs e)
        {
            panelControleAnimal.Visible = false;
            panelCadastrarCachorro.Visible = false;
            panelCadastrarGato.Visible = true;
        }

        private void textNomeGato_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textNomeGato, "NOME");
        }

        private void textNomeGato_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textNomeGato, "NOME");
        }

        private void textIdadeGato_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textIdadeGato, "IDADE");
        }

        private void textIdadeGato_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textIdadeGato, "IDADE");
        }

        private void textRacaGato_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textRacaGato, "RAÇA");
        }

        private void textRacaGato_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textRacaGato, "RAÇA");
        }

        private void textPorteGato_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textPorteGato, "PORTE");
        }

        private void textPorteGato_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textPorteGato, "PORTE");
        }

        private void botaoCadastrarGato_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores das TextBoxes
                string nome = textNomeGato.Text;
                string idadeGato = textIdadeGato.Text;
                string raca = textRacaGato.Text;
                string porte = textPorteGato.Text;

                // Definir o valor da coluna gatocachorro como 0 (gato)
                string gatoCachorro = "0";

                // Inserir os dados na tabela controle_de_animais
                string query = "INSERT INTO controle_de_animais (NOME, IDADE, RACA, PORTE, GATOCACHORRO) " +
                    "VALUES (@NOME, @IDADE, @RACA, @PORTE, @GATOCACHORRO)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NOME", nome);
                command.Parameters.AddWithValue("@IDADE", idadeGato);
                command.Parameters.AddWithValue("@RACA", raca);
                command.Parameters.AddWithValue("@PORTE", porte);
                command.Parameters.AddWithValue("@GATOCACHORRO", gatoCachorro);

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro do gato realizado com sucesso!");

                // Limpar as TextBoxes após o cadastro
                LimparTextBoxes();

                // Atualizar o valor do ID na TextBox
                AtualizarIDGato();

                PreencherValoresPadrao();

                // Remover todos os controles do FlowLayoutPanel
                flowControleAnimal.Controls.Clear();

                // Buscar os dados do banco de dados novamente
                string selectQuery = "SELECT * FROM controle_de_animais";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                // Criar os UserPanels e preencher as Labels com os dados
                while (reader.Read())
                {
                    string idAnimalValue = reader["ID_ANIMAL"].ToString();
                    string nomeValue = reader["NOME"].ToString();
                    string idadeValue = reader["IDADE"].ToString();
                    string racaValue = reader["RACA"].ToString();
                    string porteValue = reader["PORTE"].ToString();
                    string GC = reader["GATOCACHORRO"].ToString();

                    // Criar uma instância do UserControl ControleAnimal
                    ControleAnimal controleAnimal = new ControleAnimal();
                    controleAnimal.PreencherLabels(idAnimalValue, nomeValue, idadeValue, racaValue, porteValue);
                    controleAnimal.trocarImagem(GC);

                    // Definir a posição e tamanho do UserControl
                    controleAnimal.Location = new Point(0, 0);
                    controleAnimal.Size = new Size(flowControleAnimal.Width, controleAnimal.Height);

                    // Adicionar o ControleAnimal ao FlowLayoutPanel
                    flowControleAnimal.Controls.Add(controleAnimal);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar gato: " + ex.Message);
            }
        }

        private void AtualizarIDGato()
        {
            try
            {
                // Obter o último ID cadastrado
                string query = "SELECT MAX(ID_ANIMAL) FROM controle_de_animais";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int latestID = Convert.ToInt32(result);
                    int nextID = latestID + 1;
                    textIDGato.Text = nextID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o próximo ID: " + ex.Message);
            }
        }

        private void panelCadastrarGato_VisibleChanged(object sender, EventArgs e)
        {
            if (panelCadastrarGato.Visible)
            {
                // Limpar a TextBox de ID
                textIDGato.Clear();

                try
                {
                    // Obter o próximo ID disponível
                    string query = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'usuários' AND TABLE_NAME = 'controle_de_animais';";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int nextID = Convert.ToInt32(result);
                        textIDGato.Text = nextID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter o próximo ID: " + ex.Message);
                }
            }
        }

        ////////////////////////// METODOS EM COMUM ///////////////////////////

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

        private void LimparTextBoxes()
        {
            textIDCachorro.Text = "";
            textNomeCachorro.Text = "";
            textIdadeCachorro.Text = "";
            textRacaCachorro.Text = "";
            textPorteCachorro.Text = "";

            textIDGato.Text = "";
            textNomeGato.Text = "";
            textIdadeGato.Text = "";
            textRacaGato.Text = "";
            textPorteGato.Text = "";
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            try
            {
                // Fechar a conexão com o banco de dados
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                // Sair do formulário             

                TelaLogin telaLogin = new TelaLogin();
                this.Hide();
                telaLogin.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar o formulário: " + ex.Message);
            }
        }

        private void PreencherValoresPadrao()
        {
            textNomeCachorro.Text = "NOME";
            textIdadeCachorro.Text = "IDADE";
            textRacaCachorro.Text = "RAÇA";
            textPorteCachorro.Text = "PORTE";

            textNomeGato.Text = "NOME";
            textIdadeGato.Text = "IDADE";
            textRacaGato.Text = "RAÇA";
            textPorteGato.Text = "PORTE";
        }
    }
}
