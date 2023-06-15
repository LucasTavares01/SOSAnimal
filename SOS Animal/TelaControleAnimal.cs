using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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
                    "PORTE VARCHAR(50)" +
                    ")";
                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }

            // Buscar os dados do banco de dados
            string query = "SELECT * FROM controle_de_animais";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            // Criar os UserPanels e preencher as Labels com os dados
            while (reader.Read())
            {
                string idAnimal = reader["ID_ANIMAL"].ToString();
                string nome = reader["NOME"].ToString();
                string idade = reader["IDADE"].ToString();
                string raca = reader["RACA"].ToString();
                string porte = reader["PORTE"].ToString();

                // Criar uma instância do UserControl ControleAnimal
                ControleAnimal controleAnimal = new ControleAnimal();
                controleAnimal.PreencherLabels(idAnimal, nome, idade, raca, porte);

                // Definir a posição e tamanho do UserControl
                controleAnimal.Location = new Point(0, 0);
                controleAnimal.Size = new Size(flowLayoutPanel1.Width, controleAnimal.Height);

                // Adicionar o ControleAnimal ao FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(controleAnimal);
            }

            textIDCachorro.Enabled = false; // Desativar o campo textIDCachorro

            reader.Close();
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

                // Inserir os dados na tabela controle_de_animais
                string query = "INSERT INTO controle_de_animais (NOME, IDADE, RACA, PORTE) " +
                    "VALUES (@NOME, @IDADE, @RACA, @PORTE)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NOME", nome);
                command.Parameters.AddWithValue("@IDADE", idadeCachorro);
                command.Parameters.AddWithValue("@RACA", raca);
                command.Parameters.AddWithValue("@PORTE", porte);
                

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro do cachorro realizado com sucesso!");

                // Limpar as TextBoxes após o cadastro
                LimparTextBoxes();

                // Atualizar o valor do ID na TextBox
                AtualizarIDCachorro();

                PreencherValoresPadrao();


                // Remover todos os controles do FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

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

                    // Criar uma instância do UserControl ControleAnimal
                    ControleAnimal controleAnimal = new ControleAnimal();
                    controleAnimal.PreencherLabels(idAnimalValue, nomeValue, idadeValue, racaValue, porteValue);

                    // Definir a posição e tamanho do UserControl
                    controleAnimal.Location = new Point(0, 0);
                    controleAnimal.Size = new Size(flowLayoutPanel1.Width, controleAnimal.Height);

                    // Adicionar o ControleAnimal ao FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(controleAnimal);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cachorro: " + ex.Message);
            }
        }

        private void PreencherValoresPadrao()
        {
          
            textNomeCachorro.Text = "NOME";
            textIdadeCachorro.Text = "IDADE";
            textRacaCachorro.Text = "RAÇA";
            textPorteCachorro.Text = "PORTE";
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







        private void LimparTextBoxes()
        {
            textIDCachorro.Text = "";
            textNomeCachorro.Text = "";
            textIdadeCachorro.Text = "";
            textRacaCachorro.Text = "";
            textPorteCachorro.Text = "";
        }

        private void botaoControleAnimal_Click(object sender, EventArgs e)
        {
            panelControleAnimal.Visible = true;
            panelCadastrarCachorro.Visible = false;
            panelCadastrarGato.Visible = false;
        }

        private void botaoCachorro_Click(object sender, EventArgs e)
        {
            panelControleAnimal.Visible = false;
            panelCadastrarCachorro.Visible = true;
            panelCadastrarGato.Visible = false;
        }

        private void botaoGato_Click(object sender, EventArgs e)
        {
            panelControleAnimal.Visible = false;
            panelCadastrarCachorro.Visible = false;
            panelCadastrarGato.Visible = true;
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar o formulário: " + ex.Message);
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
    }
}
