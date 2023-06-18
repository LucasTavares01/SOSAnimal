using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            // Verificar se os valores das labels são inválidos
            if (textNomeCachorro.Text.ToUpper() == "NOME" || textIdadeCachorro.Text.ToUpper() == "IDADE" ||
                textRacaCachorro.Text.ToUpper() == "RAÇA" || textPorteCachorro.Text.ToUpper() == "PORTE")
            {
                MessageBox.Show("Os dados são inválidos. Por favor, preencha todos os campos corretamente.");
                return;
            }

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

        private void botaoCadastrarGato_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarGato.BackgroundImage = Properties.Resources.botaoCadastrarCachorro2;
        }

        private void botaoCadastrarGato_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarGato.BackgroundImage = Properties.Resources.botaoCadastrarCachorro1;
        }

        private void botaoCadastrarGato_Click(object sender, EventArgs e)
        {
            // Verificar se os valores das labels são inválidos
            if (textNomeGato.Text.ToUpper() == "NOME" || textIdadeGato.Text.ToUpper() == "IDADE" ||
                textRacaGato.Text.ToUpper() == "RAÇA" || textPorteGato.Text.ToUpper() == "PORTE")
            {
                MessageBox.Show("Os dados são inválidos. Por favor, preencha todos os campos corretamente.");
                return;
            }

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

        private void botaoVoltarCadastro_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro();
            this.Hide();
            telaEscolhaCadastro.Show();
        }

        private void textNomeCachorro_TextChanged(object sender, EventArgs e)
        {
            if (textNomeCachorro.Text.ToUpper() == "NOME")
            {
                textNomeCachorro.Text = "NOME";
                textNomeCachorro.SelectionStart = textNomeCachorro.Text.Length;
                return; // Sai do evento para evitar a conversão de texto
            }

            if (!string.IsNullOrEmpty(textNomeCachorro.Text))
            {
                string[] nomes = textNomeCachorro.Text.Split(' ');
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

                textNomeCachorro.Text = resultado.ToString();
                textNomeCachorro.SelectionStart = textNomeCachorro.Text.Length;
            }
        }

        private void textIdadeCachorro_TextChanged(object sender, EventArgs e)
        {
            // Verificar se o texto é diferente de "IDADE"
            if (textIdadeCachorro.Text != "IDADE")
            {
                string numero = string.Empty;
                foreach (char c in textIdadeCachorro.Text)
                {
                    if (char.IsDigit(c))
                    {
                        numero += c;
                    }
                }

                textIdadeCachorro.Text = numero;
            }
        }

        private void textRacaCachorro_TextChanged(object sender, EventArgs e)
        {
            string texto = textRacaCachorro.Text.Trim();

            // Verificar se o texto é igual a "Raça" com letras maiúsculas
            if (texto.ToUpper() == "RAÇA")
            {
                textRacaCachorro.Text = "RAÇA";
                textRacaCachorro.SelectionStart = textRacaCachorro.Text.Length;
                return;
            }

            string[] nomes = textRacaCachorro.Text.Split(' ');
            StringBuilder resultado = new StringBuilder();

            foreach (string nome in nomes)
            {
                if (resultado.Length > 0)
                    resultado.Append(" ");

                if (nome.Length > 0)
                {
                    string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                    string restante = nome.Substring(1).ToLower();
                    resultado.Append(primeiroCaractere + restante);
                }
            }

            textRacaCachorro.Text = resultado.ToString();
            textRacaCachorro.SelectionStart = textRacaCachorro.Text.Length;
        }



        private void textPorteCachorro_TextChanged(object sender, EventArgs e)
        {
            string texto = textPorteCachorro.Text.Trim();

            // Verificar se o texto é igual a "Raça" com letras maiúsculas
            if (texto.ToUpper() == "PORTE")
            {
                textPorteCachorro.Text = "PORTE";
                textPorteCachorro.SelectionStart = textPorteCachorro.Text.Length;
                return;
            }

            string[] nomes = textPorteCachorro.Text.Split(' ');
            StringBuilder resultado = new StringBuilder();

            foreach (string nome in nomes)
            {
                if (resultado.Length > 0)
                    resultado.Append(" ");

                if (nome.Length > 0)
                {
                    string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                    string restante = nome.Substring(1).ToLower();
                    resultado.Append(primeiroCaractere + restante);
                }
            }

            textPorteCachorro.Text = resultado.ToString();
            textPorteCachorro.SelectionStart = textPorteCachorro.Text.Length;
        }

        private void panelCadastrarCachorro_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelLateralControleAnimal_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textNomeGato_TextChanged(object sender, EventArgs e)
        {
            if (textNomeGato.Text.ToUpper() == "NOME")
            {
                textNomeGato.Text = "NOME";
                textNomeGato.SelectionStart = textNomeGato.Text.Length;
                return; // Sai do evento para evitar a conversão de texto
            }

            if (!string.IsNullOrEmpty(textNomeGato.Text))
            {
                string[] nomes = textNomeGato.Text.Split(' ');
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

                textNomeGato.Text = resultado.ToString();
                textNomeGato.SelectionStart = textNomeGato.Text.Length;
            }
        }

        private void textIdadeGato_TextChanged(object sender, EventArgs e)
        {
            // Verificar se o texto é diferente de "IDADE"
            if (textIdadeGato.Text != "IDADE")
            {
                string numero = string.Empty;
                foreach (char c in textIdadeGato.Text)
                {
                    if (char.IsDigit(c))
                    {
                        numero += c;
                    }
                }

                textIdadeGato.Text = numero;
            }
        }

        private void textRacaGato_TextChanged(object sender, EventArgs e)
        {
            string texto = textRacaGato.Text.Trim();

            // Verificar se o texto é igual a "Raça" com letras maiúsculas
            if (texto.ToUpper() == "RAÇA")
            {
                textRacaGato.Text = "RAÇA";
                textRacaGato.SelectionStart = textRacaGato.Text.Length;
                return;
            }

            string[] nomes = textRacaGato.Text.Split(' ');
            StringBuilder resultado = new StringBuilder();

            foreach (string nome in nomes)
            {
                if (resultado.Length > 0)
                    resultado.Append(" ");

                if (nome.Length > 0)
                {
                    string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                    string restante = nome.Substring(1).ToLower();
                    resultado.Append(primeiroCaractere + restante);
                }
            }

            textRacaGato.Text = resultado.ToString();
            textRacaGato.SelectionStart = textRacaGato.Text.Length;
        }


        private void textPorteGato_TextChanged(object sender, EventArgs e)
        {
            string texto = textPorteGato.Text.Trim();

            // Verificar se o texto é igual a "Raça" com letras maiúsculas
            if (texto.ToUpper() == "PORTE")
            {
                textPorteGato.Text = "PORTE";
                textPorteGato.SelectionStart = textPorteGato.Text.Length;
                return;
            }

            string[] nomes = textPorteGato.Text.Split(' ');
            StringBuilder resultado = new StringBuilder();

            foreach (string nome in nomes)
            {
                if (resultado.Length > 0)
                    resultado.Append(" ");

                if (nome.Length > 0)
                {
                    string primeiroCaractere = nome.Substring(0, 1).ToUpper();
                    string restante = nome.Substring(1).ToLower();
                    resultado.Append(primeiroCaractere + restante);
                }
            }

            textPorteGato.Text = resultado.ToString();
            textPorteGato.SelectionStart = textPorteGato.Text.Length;
        }

    }
}
