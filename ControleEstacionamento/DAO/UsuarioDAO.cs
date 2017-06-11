using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstacionamento.Interfaces;
using ControleEstacionamento.Modelos;
using MySql.Data.MySqlClient;
using ControleEstacionamento.DAO;

namespace ControleEstacionamento.DAO
{
    public class UsuarioDAO : IDAO<UsuarioModelo>
    {
        private IConexao conexao;
        private string tableName;
        public UsuarioDAO() : this(Conexao.Instancia)
        {

        }
        public UsuarioDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "usuario";
        }

        public UsuarioModelo Inserir(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (usuario, senha) VALUES (@usuario,md5( @senha))";
            command.Parameters.AddWithValue("@usuario", model.Usuario);
            command.Parameters.AddWithValue("@senha", model.Senha);

            model.Id = int.Parse(command.ExecuteScalar().ToString());

            return model;
        }

        public void Atualizar(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET usuario = @usuario, senha = @senha WHERE id=@id";

            command.Parameters.AddWithValue("@usuario", model.Usuario);
            command.Parameters.AddWithValue("@senha", model.Senha);
            command.Parameters.AddWithValue("@id", model.Id);

            command.ExecuteNonQuery();

        }

        public bool Remover(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";

            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;
        }

        public List<UsuarioModelo> ListarTodos()
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {tableName}";

            return Ler();
        }

        public UsuarioModelo ProcurarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public List<UsuarioModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        public List<UsuarioModelo> Ler()
        {
            var reader = conexao.Command.ExecuteReader();
            List<UsuarioModelo> list = new List<UsuarioModelo>();
            while (reader.NextResult())
            {
                list.Add(new UsuarioModelo()
                {
                    Usuario = reader.GetString("usuario"),

                    Id = reader.GetInt32("id"),
                    Senha = reader.GetString("senha"),
                });
            }

            return list;
        }
        public UsuarioModelo Logar(UsuarioModelo modelo)
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE usuario=@usuario AND senha=md5(@senha)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", modelo.Usuario);
            command.Parameters.AddWithValue("@senha", modelo.Senha);
            var list = Ler();
            if (list.Count == 1)
                return list.First();

            return null;

                    
        }
        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
