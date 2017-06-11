using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ControleEstacionamento.Interfaces;
using System.Configuration;
namespace ControleEstacionamento.DAO
{
    public class Conexao : IConexao
    {
        private MySqlConnection Connection;
        public Conexao()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            Connection = new MySqlConnection(connectionString);
            conexao = this;
            Abrir();

        }

        public Conexao(Conexao conexao)
        {
            this.Connection = conexao.Connection;
        }
        private static IConexao conexao;
        public static IConexao Instancia
        {
            get
            {
                if (conexao == null)
                    conexao = new Conexao();
                return conexao;
            }
        }
        private MySqlCommand command;
        public MySqlCommand Command
        {
            get
            {
                if (command == null)
                    command = Connection.CreateCommand();
                return command;
            }
        }

        public MySqlConnection Abrir()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();

            return Connection;
        }
        public void Fechar()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
        public void Dispose()
        {
            if (command != null)
                command.Dispose();
            command = null;
            this.Fechar();
            if (Connection != null)
            {
                Connection.Dispose();
                Connection = null;
            }
        }
    }
}
