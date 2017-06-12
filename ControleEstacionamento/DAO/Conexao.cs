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
        
        public Conexao()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var connectionString = "SERVER=localhost;DATABASE=controle_estacionamento;UId=root;pwd=root";

            Connection = new MySqlConnection(connectionString);
            conexao = this;
            Abrir();

        }

        public Conexao(Conexao conexao)
        {
            this.Connection = conexao.Connection;
        }
        private static IConexao conexao;
        private MySqlConnection Connection;
        private MySqlCommand command;
        private MySqlDataReader leitor;
        public static IConexao Instancia
        {
            get
            {
                if (conexao == null)
                    conexao = new Conexao();
                conexao.Abrir();
                return conexao;
            }
        }
        
        public MySqlCommand Command
        {
            get
            {
                Abrir();
                if (command == null)
                    command = Connection.CreateCommand();
                return command;
            }
        }
        public MySqlDataReader Leitor
        {
            get { return leitor; }
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
        public void FecharLeitor()
        {
            if (leitor != null)
            {
                if (!leitor.IsClosed)
                    leitor.Close();
            }
        }

        public void Ler()
        {
            try
            {
                leitor = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao fazer leitura da base de dados\r\nDados:\r\n\r\n" + ex.Message);

            }
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
