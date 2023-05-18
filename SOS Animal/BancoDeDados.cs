using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SOS_Animal
{
    internal class BancoDeDados
    {
        private static string nomeBancoDeDados = "cadastro.db";
        private static SQLiteConnection conexao;

        public static void CriarBancoDeDados()
        {
            SQLiteConnection.CreateFile("CadastroFuncionarios.db");
            SQLiteConnection conexao = new SQLiteConnection("Data Source=CadastroFuncionarios.db;Version=3;");
            conexao.Open();

            string comandoSQL = "CREATE TABLE IF NOT EXISTS Funcionarios (Nome VARCHAR(50), Email VARCHAR(50), Senha VARCHAR(50))";
            SQLiteCommand comando = new SQLiteCommand(comandoSQL, conexao);
            comando.ExecuteNonQuery();
        }

        public static void SalvarCadastro(string nome, string senha, string email)
        {
            conexao = new SQLiteConnection("Data Source=" + nomeBancoDeDados + ";Version=3;");
            conexao.Open();

            string comandoSQL = "INSERT INTO cadastro (nome, senha, email) VALUES ('" + nome + "', '" + senha + "', '" + email + "')";
            SQLiteCommand comando = new SQLiteCommand(comandoSQL, conexao);
            comando.ExecuteNonQuery();
        }

    }
}
