using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS_Animal
{
    public partial class TelaControleEstoque : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";

        public TelaControleEstoque()
        {
            InitializeComponent();
        }

        private void TelaControleEstoque_Load(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Verificar se a tabela já existe
            string checkTableQuery = "SHOW TABLES LIKE 'controle_estoque'";
            MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection);
            object result = checkTableCommand.ExecuteScalar();

            if (result == null) // A tabela não existe, então vamos criá-la
            {
                // Criar a tabela controle_de_animais
                string createTableQuery = "CREATE TABLE controle_estoque (" +
                    "ID_ITEM INT AUTO_INCREMENT PRIMARY KEY," +
                    "DATA VARCHAR(50)," +
                    "NOME VARCHAR(50) NOT NULL," +
                    "DESCRICAO VARCHAR(50)," +
                    "DOADOPOR VARCHAR(50)," +                  
                    "DADOSIMAGEM BLOB" +
                    ")";
                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }

            // Buscar os dados do banco de dados novamente
            string selectQuery = "SELECT * FROM controle_estoque";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = selectCommand.ExecuteReader();

            // Criar os UserPanels e preencher as Labels com os dados
            while (reader.Read())
            {               
                string dataValue = reader["DATA"].ToString();
                string nomeValue = reader["NOME"].ToString();
                string descricaoValue = reader["DESCRICAO"].ToString();
                string doadoporValue = reader["DOADOPOR"].ToString();            

                // Criar uma instância do UserControl ControleAnimal
                ControleEstoque controleEstoque = new ControleEstoque();
                controleEstoque.PreencherLabels(dataValue, nomeValue, descricaoValue, doadoporValue);

                if (reader["DADOSIMAGEM"] != DBNull.Value)
                {
                    byte[] imagemBytes2 = (byte[])reader["DADOSIMAGEM"];

                    // Converter os bytes em uma imagem
                    Image imagemRecuperada = null;
                    using (MemoryStream stream = new MemoryStream(imagemBytes2))
                    {
                        imagemRecuperada = Image.FromStream(stream);
                    }

                    // Redimensionar a imagem para caber na PictureBox
                    Image imagemRedimensionada = new Bitmap(100, 100);
                    using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                    {
                        graphics.DrawImage(imagemRecuperada, 0, 0, 100, 100);
                    }

                    // Tornar a imagem redonda
                    Bitmap imagemRedonda = new Bitmap(100, 100);
                    using (Graphics graphics = Graphics.FromImage(imagemRedonda))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.Clear(Color.Transparent);

                        using (GraphicsPath path = new GraphicsPath())
                        {
                            path.AddEllipse(0, 0, 100, 100);
                            graphics.SetClip(path);
                            graphics.DrawImage(imagemRedimensionada, 0, 0);
                        }
                    }

                    // Atribuir a imagem editada a picboxItem2
                    controleEstoque.picboxItem2.Image = imagemRedonda;
                    controleEstoque.picboxItem2.Refresh(); // Atualizar a exibição da imagem
                }

                // Definir a posição e tamanho do UserControl
                controleEstoque.Location = new Point(0, 0);
                controleEstoque.Size = new Size(flowControleEstoque.Width, controleEstoque.Height);

                // Adicionar o ControleAnimal ao FlowLayoutPanel
                flowControleEstoque.Controls.Add(controleEstoque);
            }

            reader.Close();            
        }

        private void botaoControleEstoque_MouseEnter(object sender, EventArgs e)
        {
            botaoControleEstoque.BackgroundImage = Properties.Resources.botaoControleEstoque2;
        }

        private void botaoControleEstoque_MouseLeave(object sender, EventArgs e)
        {
            botaoControleEstoque.BackgroundImage = Properties.Resources.botaoControleEstoque1;
        }

        private void botaoControleEstoque_Click(object sender, EventArgs e)
        {
            panelControleEstoque.Visible = true;
            panelCadastrarItem.Visible = false;
       
        }

        private void botaoCadastrarItem_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarItem.BackgroundImage = Properties.Resources.botaoCadastrarItem2;
        }

        private void botaoCadastrarItem_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarItem.BackgroundImage = Properties.Resources.botaoCadastrarItem1;
        }

        private void botaoCadastrarItem_Click(object sender, EventArgs e)
        {
            panelControleEstoque.Visible = false;
            panelCadastrarItem.Visible = true;
        }

        private void botaoCadastrarItem2_MouseEnter(object sender, EventArgs e)
        {
            botaoCadastrarItem2.BackgroundImage = Properties.Resources.botaoCadastrarCachorro2;
        }

        private void botaoCadastrarItem2_MouseLeave(object sender, EventArgs e)
        {
            botaoCadastrarItem2.BackgroundImage = Properties.Resources.botaoCadastrarCachorro1;
        }

        private void botaoCadastrarItem2_Click(object sender, EventArgs e)
        {
            // Verificar se as palavras estão presentes nas TextBoxes
            if (textDataItem.Text.ToUpper() == "DATA" || textNomeItem.Text.ToUpper() == "NOME" ||
                textDescricaoItem.Text.ToUpper() == "DESCRIÇÃO" || textDoadoPorItem.Text.ToUpper() == "DOADO POR")
            {
                MessageBox.Show("Por favor, insira os valores corretos.");
                return;
            }

            try
            {
                // Obter a imagem selecionada
                Image imagem;
                if (picboxItem.Image != null)
                {
                    imagem = picboxItem.Image;
                }
                else
                {
                    // Carregar a imagem "brinquedosPet" dos recursos
                    imagem = Properties.Resources.brinquedosPet;
                }

                byte[] imagemBytes = null;
                using (MemoryStream stream = new MemoryStream())
                {
                    imagem.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagemBytes = stream.ToArray();
                }

                // Obter os valores das TextBoxes
                string data = textDataItem.Text;
                string nome = textNomeItem.Text;
                string descricao = textDescricaoItem.Text;
                string doadopor = textDoadoPorItem.Text;

                // Atualizar a query para inserir o campo de imagem
                string query = "INSERT INTO controle_estoque (DATA, NOME, DESCRICAO, DOADOPOR, DADOSIMAGEM) " +
                    "VALUES (@DATA, @NOME, @DESCRICAO, @DOADOPOR, @DADOSIMAGEM)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DATA", data);
                command.Parameters.AddWithValue("@NOME", nome);
                command.Parameters.AddWithValue("@DESCRICAO", descricao);
                command.Parameters.AddWithValue("@DOADOPOR", doadopor);
                command.Parameters.AddWithValue("@DADOSIMAGEM", imagemBytes);

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro de item realizado com sucesso!");

                // Limpar as TextBoxes após o cadastro
                LimparTextBoxes();

                PreencherValoresPadrao();

                // Remover todos os controles do FlowLayoutPanel
                flowControleEstoque.Controls.Clear();

                // Buscar os dados do banco de dados novamente
                string selectQuery = "SELECT * FROM controle_Estoque";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                // Criar os UserPanels e preencher as Labels com os dados
                while (reader.Read())
                {
                    string dataValue = reader["DATA"].ToString();
                    string nomeValue = reader["NOME"].ToString();
                    string descricaoValue = reader["DESCRICAO"].ToString();
                    string doadoporValue = reader["DOADOPOR"].ToString();


                    // Criar uma instância do UserControl ControleEstoque
                    ControleEstoque controleEstoque = new ControleEstoque();
                    controleEstoque.PreencherLabels(dataValue, nomeValue, descricaoValue, doadoporValue);

                    if (reader["DADOSIMAGEM"] != DBNull.Value)
                    {
                        byte[] imagemBytes2 = (byte[])reader["DADOSIMAGEM"];

                        // Converter os bytes em uma imagem
                        Image imagemRecuperada = null;
                        using (MemoryStream stream = new MemoryStream(imagemBytes2))
                        {
                            imagemRecuperada = Image.FromStream(stream);
                        }

                        // Redimensionar a imagem para caber na PictureBox
                        Image imagemRedimensionada = new Bitmap(100, 100);
                        using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                        {
                            graphics.DrawImage(imagemRecuperada, 0, 0, 100, 100);
                        }

                        // Tornar a imagem redonda
                        Bitmap imagemRedonda = new Bitmap(100, 100);
                        using (Graphics graphics = Graphics.FromImage(imagemRedonda))
                        {
                            graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            graphics.Clear(Color.Transparent);

                            using (GraphicsPath path = new GraphicsPath())
                            {
                                path.AddEllipse(0, 0, 100, 100);
                                graphics.SetClip(path);
                                graphics.DrawImage(imagemRedimensionada, 0, 0);
                            }
                        }

                        // Atribuir a imagem editada a picboxItem2
                        controleEstoque.picboxItem2.Image = imagemRedonda;
                        controleEstoque.picboxItem2.Refresh(); // Atualizar a exibição da imagem
                    }

                    // Definir a posição e tamanho do UserControl
                    controleEstoque.Location = new Point(0, 0);
                    controleEstoque.Size = new Size(flowControleEstoque.Width, controleEstoque.Height);

                    // Adicionar o ControleAnimal ao FlowLayoutPanel
                    flowControleEstoque.Controls.Add(controleEstoque);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar item: " + ex.Message);
            }           
        }

        private void LimparTextBoxes()
        {
            textDataItem.Text = "";
            textNomeItem.Text = "";
            textDescricaoItem.Text = "";
            textDoadoPorItem.Text = "";
            picboxItem.Image = null;
        }

        private void PreencherValoresPadrao()
        {
            textDataItem.Text = "DATA";
            textNomeItem.Text = "NOME";
            textDescricaoItem.Text = "DESCRIÇÃO";
            textDoadoPorItem.Text = "DOADO POR";
        }


        private void botaoInserirImagem_MouseEnter(object sender, EventArgs e)
        {
            botaoInserirImagem.BackgroundImage = Properties.Resources.botaoInserirImagem2;
        }

        private void botaoInserirImagem_MouseLeave(object sender, EventArgs e)
        {
            botaoInserirImagem.BackgroundImage = Properties.Resources.botaoInserirImagem1;
        }

        private void botaoInserirImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem (*.jpg; *.jpeg; *.png; *.gif) | *.jpg; *.jpeg; *.png; *.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string nomeArquivo = openFileDialog.FileName;
                    Image imagem = Image.FromFile(nomeArquivo);

                    // Redimensionar a imagem para caber na PictureBox
                    Image imagemRedimensionada = new Bitmap(260, 260);
                    using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                    {
                        graphics.DrawImage(imagem, 0, 0, 260, 260);
                    }

                    // Tornar a PictureBox redonda
                    Bitmap imagemRedonda = new Bitmap(260, 260);
                    using (Graphics graphics = Graphics.FromImage(imagemRedonda))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.Clear(Color.Transparent);

                        using (GraphicsPath path = new GraphicsPath())
                        {
                            path.AddEllipse(0, 0, 260, 260);
                            graphics.SetClip(path);
                            graphics.DrawImage(imagemRedimensionada, 0, 0);
                        }
                    }

                    // Atribuir a imagem redimensionada e arredondada à PictureBox
                    picboxItem.Image = imagemRedonda;
                }
            }
        }


        private void textDataItem_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textDataItem, "DATA");
        }

        private void textDataItem_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textDataItem, "DATA");
        }

        private void textNomeItem_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textNomeItem, "NOME");
        }

        private void textNomeItem_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textNomeItem, "NOME");
        }

        private void textDescricaoItem_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textDescricaoItem, "DESCRIÇÃO");
        }

        private void textDescricaoItem_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textDescricaoItem, "DESCRIÇÃO");
        }

        private void textDoadoPorItem_Enter(object sender, EventArgs e)
        {
            LimparCampoTexto(textDoadoPorItem, "DOADO POR");
        }

        private void textDoadoPorItem_Leave(object sender, EventArgs e)
        {
            RestaurarCampoTexto(textDoadoPorItem, "DOADO POR");
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

        private void botaoVoltarCadastro_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro();
            this.Hide();
            telaEscolhaCadastro.Show();
        }

        private void textDataItem_TextChanged(object sender, EventArgs e)
        {
            string data = textDataItem.Text;

            if (!string.IsNullOrEmpty(data) && !Regex.IsMatch(data, @"^\d{0,2}$") && !data.ToUpper().Contains("DATA"))
            {
                // Remova qualquer caractere não numérico
                data = Regex.Replace(data, @"\D", "");

                // Verifique o comprimento da string de data e formate adequadamente
                if (data.Length >= 3 && data.Length <= 5)
                {
                    data = data.Substring(0, 2) + "/" + data.Substring(2);
                }
                else if (data.Length > 5)
                {
                    data = data.Substring(0, 2) + "/" + data.Substring(2, 2) + "/" + data.Substring(4, Math.Min(4, data.Length - 4));
                }

                // Atualize o texto do TextBox com a data formatada
                textDataItem.TextChanged -= textDataItem_TextChanged; // Desabilite o evento temporariamente para evitar recursão infinita
                textDataItem.Text = data;
                textDataItem.SelectionStart = data.Length;
                textDataItem.TextChanged += textDataItem_TextChanged; // Reabilite o evento
            }
        }

        private void textNomeItem_TextChanged(object sender, EventArgs e)
        {
            string texto = textNomeItem.Text.Trim();

            // Verificar se o texto é igual a "Nome" com letras maiúsculas
            if (texto.ToUpper() == "NOME")
            {
                textNomeItem.Text = "NOME";
                textNomeItem.SelectionStart = textNomeItem.Text.Length;
                return;
            }

            string[] nomes = textNomeItem.Text.Split(' ');
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

            textNomeItem.Text = resultado.ToString();
            textNomeItem.SelectionStart = textNomeItem.Text.Length;
        }

        private void textDoadoPorItem_TextChanged(object sender, EventArgs e)
        {
            string texto = textDoadoPorItem.Text.Trim();

            // Verificar se o texto é igual a "NOME" com letras maiúsculas
            if (texto.ToUpper() == "NOME")
            {
                textDoadoPorItem.Text = "NOME";
                textDoadoPorItem.SelectionStart = textDoadoPorItem.Text.Length;
                return;
            }

            // Verificar se o texto é igual a "DOADO POR" com letras maiúsculas
            if (texto.ToUpper() == "DOADO POR")
            {
                textDoadoPorItem.Text = "DOADO POR";
                textDoadoPorItem.SelectionStart = textDoadoPorItem.Text.Length;
                return;
            }

            string[] nomes = textDoadoPorItem.Text.Split(' ');
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

            textDoadoPorItem.Text = resultado.ToString();
            textDoadoPorItem.SelectionStart = textDoadoPorItem.Text.Length;
        }




        private void AtualizarControlesOrdenados(List<ControleEstoque> controles)
        {
            flowControleEstoque.Controls.Clear();
            foreach (ControleEstoque controle in controles)
            {
                flowControleEstoque.Controls.Add(controle);
            }
        }

        private void AtualizarImagemFiltro2(Button botaoClicado)
        {
            // Define a imagem 2 (filtro2) para o botão clicado
            botaoClicado.Image = Properties.Resources.filtro2;

            // Define a imagem 1 (filtro1) para os outros botões
            btnOrdenarPorData.Image = btnOrdenarPorData == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorNome.Image = btnOrdenarPorNome == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorDescricao.Image = btnOrdenarPorDescricao == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
            btnOrdenarPorDoadoPor.Image = btnOrdenarPorDoadoPor == botaoClicado ? Properties.Resources.filtro2 : Properties.Resources.filtro1;
        }

        private void btnOrdenarPorData_Click(object sender, EventArgs e)
        {
            List<ControleEstoque> controles = flowControleEstoque.Controls.OfType<ControleEstoque>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelDataEstoque.Text, c2.labelDataEstoque.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro2(btnOrdenarPorData);
        }

        private void btnOrdenarPorNome_Click(object sender, EventArgs e)
        {
            List<ControleEstoque> controles = flowControleEstoque.Controls.OfType<ControleEstoque>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelNomeEstoque.Text, c2.labelNomeEstoque.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro2(btnOrdenarPorNome);
        }

        private void btnOrdenarPorDescricao_Click(object sender, EventArgs e)
        {
            List<ControleEstoque> controles = flowControleEstoque.Controls.OfType<ControleEstoque>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelDescricaoEstoque.Text, c2.labelDescricaoEstoque.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro2(btnOrdenarPorDescricao);
        }

        private void btnOrdenarPorDoadoPor_Click(object sender, EventArgs e)
        {
            List<ControleEstoque> controles = flowControleEstoque.Controls.OfType<ControleEstoque>().ToList();
            controles.Sort((c1, c2) => string.Compare(c1.labelDoadoPorEstoque.Text, c2.labelDoadoPorEstoque.Text));
            AtualizarControlesOrdenados(controles);

            AtualizarImagemFiltro2(btnOrdenarPorDoadoPor);
        }

    }
}
