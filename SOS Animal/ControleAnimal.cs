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
    public partial class ControleAnimal : UserControl
    {

        public ControleAnimal()
        {
            InitializeComponent();
        }

        public void PreencherLabels(string idAnimal, string nome, string idade, string raca, string porte)
        {
            labelID.Text = idAnimal;
            labelNome.Text = nome;
            labelIdade.Text = idade;
            labelRaca.Text = raca;
            labelPorte.Text = porte;
        }

        public void trocarImagem(string GC)
        {
            if (GC == "0")
            {
                avatarAnimal.Image = Properties.Resources.avatarGato;

                Image originalImage = Properties.Resources.avatarGato; // Substitua "nome_da_imagem" pelo nome do recurso de imagem

                int larguraDesejada = avatarAnimal.Width;
                int alturaDesejada = avatarAnimal.Height;

                Image imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
                using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                {
                    graphics.DrawImage(originalImage, 0, 0, larguraDesejada, alturaDesejada);
                }

                avatarAnimal.Image = imagemRedimensionada;                
            }
            else if (GC == "1")
            {
                avatarAnimal.Image = Properties.Resources.avatarCachorro;

                Image originalImage = Properties.Resources.avatarCachorro; // Substitua "nome_da_imagem" pelo nome do recurso de imagem

                int larguraDesejada = avatarAnimal.Width;
                int alturaDesejada = avatarAnimal.Height;

                Image imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
                using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                {
                    graphics.DrawImage(originalImage, 0, 0, larguraDesejada, alturaDesejada);
                }

                avatarAnimal.Image = imagemRedimensionada;            
            }
        }
        
        private void botaoRemover_Click(object sender, EventArgs e)
        {
            // Obtém o contêiner pai do UserControl
            var parentContainer = this.Parent as Panel;

            if (parentContainer != null)
            {
                // Remove o UserControl do contêiner pai
                parentContainer.Controls.Remove(this);

                // Obtém o ID do animal que está sendo removido
                string idAnimal = labelID.Text;

                // Realiza a exclusão do registro no banco de dados
                string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constrói a instrução SQL para excluir o registro do banco de dados
                    string sql = "DELETE FROM controle_de_animais WHERE ID_ANIMAL = @id";


                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Define o parâmetro @id na instrução SQL com o valor do ID do animal
                        command.Parameters.AddWithValue("@id", idAnimal);

                        // Executa a instrução SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void botaoRemover_MouseEnter(object sender, EventArgs e)
        {
            botaoRemover.BackgroundImage = Properties.Resources.botaoDeletar2;
        }

        private void botaoRemover_MouseLeave(object sender, EventArgs e)
        {
            botaoRemover.BackgroundImage = Properties.Resources.botaoDeletar1;
        }

        private void botaoEditar_MouseEnter(object sender, EventArgs e)
        {
            botaoEditar.BackgroundImage = Properties.Resources.botaoEditar2;
        }

        private void botaoEditar_MouseLeave(object sender, EventArgs e)
        {
            botaoEditar.BackgroundImage = Properties.Resources.botaoEditar1;
        }
    }
}

