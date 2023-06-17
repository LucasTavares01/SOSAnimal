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
    public partial class Receitas : UserControl
    {
        public Receitas()
        {
            InitializeComponent();
        }

        public void PreencherLabels(string data, string categoria, string valor, string descricao)
        {
            labelData.Text = data;
            labelCategoria.Text = categoria;
            labelValor.Text = valor;
            labelDescricao.Text = descricao;
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
                string data = labelData.Text;

                // Realiza a exclusão do registro no banco de dados
                string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constrói a instrução SQL para excluir o registro do banco de dados
                    string sql = "DELETE FROM receitas WHERE DATA = @DATA";


                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Define o parâmetro @id na instrução SQL com o valor do ID do animal
                        command.Parameters.AddWithValue("@DATA", data);

                        // Executa a instrução SQL

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
