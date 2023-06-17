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
    public partial class ControleEstoque : UserControl
    {
        public ControleEstoque()
        {
            InitializeComponent();
        }

        public void PreencherLabels(string data, string nome, string descricao, string doadopor)
        {
            labelDataEstoque.Text = data;
            labelNomeEstoque.Text = nome;
            labelDescricaoEstoque.Text = descricao;
            labelDoadoPorEstoque.Text = doadopor;          
        }

        

        private void botaoRemover_MouseEnter(object sender, EventArgs e)
        {

        }

        private void botaoRemover_MouseLeave(object sender, EventArgs e)
        {

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
                string data = labelDataEstoque.Text;

                // Realiza a exclusão do registro no banco de dados
                string connectionString = "Server=localhost;Database=usuários;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constrói a instrução SQL para excluir o registro do banco de dados
                    string sql = "DELETE FROM controle_estoque WHERE DATA = @DATA";


                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Define o parâmetro @data na instrução SQL com o valor da data
                        command.Parameters.AddWithValue("@DATA", data);

                        // Executa a instrução SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    

        private void botaoEditar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void botaoEditar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
