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
        private string viewName;
        public UsuarioDAO() : this(Conexao.Instancia)
        {

        }
        public UsuarioDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "usuario";
            this.viewName = "view_usuario";
        }

        public UsuarioModelo Inserir(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (usuario, senha) VALUES (@usuario,md5( @senha))";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", model.Usuario);
            command.Parameters.AddWithValue("@senha", model.Senha);
            command.ExecuteNonQuery();
            model.Id = (int)command.LastInsertedId;


            return model;
        }

        public void Atualizar(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET usuario = @usuario, senha =md5( @senha) WHERE id=@id";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", model.Usuario);
            command.Parameters.AddWithValue("@senha", model.Senha);
            command.Parameters.AddWithValue("@id", model.Id);

            command.ExecuteNonQuery();

        }

        public bool Remover(UsuarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;
        }

        public List<UsuarioModelo> ListarTodos()
        {
            var command = conexao.Command;

            command.Parameters.Clear();
            command.CommandText = $"SELECT * FROM { viewName}  ";

            return Ler();
        }

        public UsuarioModelo BuscarPorId(int id)
        {
            var command = conexao.Command;

            command.Parameters.Clear();
            command.CommandText = $"SELECT * FROM { viewName} WHERE usuario.id = @id";

            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public List<UsuarioModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;
            command.Parameters.Clear();
            command.CommandText = $"SELECT * FROM { viewName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

       

        public UsuarioModelo Logar(UsuarioModelo modelo)
        {

            var command = conexao.Command;
            command.Parameters.Clear();
            command.CommandText = $"SELECT * FROM { viewName} WHERE usuario=@usuario AND senha=md5(@senha)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", modelo.Usuario);
            command.Parameters.AddWithValue("@senha", modelo.Senha);
            var list = Ler();
            if (list.Count == 1)
                return list.First();

            return null;


        }

        public List<UsuarioModelo> Ler()
        {
            try
            {
                conexao.Ler();
                var leitor = conexao.Leitor;
                List<UsuarioModelo> list = new List<UsuarioModelo>();
                while (leitor.Read())
                {
                    var usuario = new UsuarioModelo()
                    {
                        Usuario = leitor.GetString("usuario"),
                        Id = leitor.GetInt32("id"),
                        Senha = leitor.GetString("senha"),
                        Funcionario = LerFuncionario(leitor)
                    };
                    if (usuario.Funcionario != null)
                        usuario.Funcionario.Usuario = usuario;
                    list.Add(usuario);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharLeitor();

            }

        }

        private FuncionarioModelo LerFuncionario(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["funcionario_id"].ToString()))
                return null;
            else
                return new FuncionarioModelo()
                {
                    Celular = reader.GetString("cel"),
                    Cpf = reader.GetString("cpf"),
                    Endereco = reader.GetString("endereco"),
                    Id = reader.GetInt32("funcionario_id"),
                    Nome = reader.GetString("nome"),
                    Salario = reader.GetDecimal("salario"),
                    Telefone = reader.GetString("tel")
                };

        }
        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
