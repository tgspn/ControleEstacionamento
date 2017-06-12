using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstacionamento.Interfaces;
using ControleEstacionamento.Modelos;
using MySql.Data.MySqlClient;

namespace ControleEstacionamento.DAO
{
    class FuncionarioDAO : IDAO<FuncionarioModelo>
    {
        private IConexao conexao;
        private string tableName;
        public FuncionarioDAO() : this(new DAO.Conexao())
        {

        }
        public FuncionarioDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "funcionario";
        }
        public void Atualizar(FuncionarioModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET nome=@nome, endereco=@endereco, cpf=@cpf, telefone=@telefone, celular=@celular, salario=@salario, usuario_id=@usuario_id WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@telefone", model.Telefone);
            command.Parameters.AddWithValue("@celular", model.Celular);
            command.Parameters.AddWithValue("@salario", model.Salario);
            command.Parameters.AddWithValue("@id", model.Id);
            if (model.Usuario != null)
                command.Parameters.AddWithValue("@usuario_id", model.Usuario.Id);
            else
                command.Parameters.AddWithValue("@usuario_id", null);
            command.ExecuteNonQuery();

        }


        public FuncionarioModelo Inserir(FuncionarioModelo model)
        {

            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (nome,endereco,cpf,telefone,celular,salario,usuario_id) VALUES (@nome,@endereco,@cpf,@telefone,@celular,@salario,@usuario_id)";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@telefone", model.Telefone);
            command.Parameters.AddWithValue("@celular", model.Celular);
            command.Parameters.AddWithValue("@salario", model.Salario);
            command.Parameters.AddWithValue("@id", model.Id);
            if (model.Usuario != null)
                command.Parameters.AddWithValue("@usuario_id", model.Usuario.Id);
            else
                command.Parameters.AddWithValue("@usuario_id", null);

            model.Id = (int)command.LastInsertedId;

            return model;
        }

        public bool Remover(FuncionarioModelo model)
        {


            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;

        }
        public List<FuncionarioModelo> ListarTodos()
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName}";

            return Ler();
        }

      
        public FuncionarioModelo BuscarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }
        public List<FuncionarioModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }
        internal FuncionarioModelo BuscarPorUsuarioId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE usuario_id =@id";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }
        public List<FuncionarioModelo> Ler()
        {
            try
            {
                conexao.Ler();
                var reader = conexao.Leitor;
                List<FuncionarioModelo> list = new List<FuncionarioModelo>();
                while (reader.Read())
                {
                    list.Add(new FuncionarioModelo()
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Endereco = reader.GetString("endereco"),
                        Cpf = reader.GetString("cpf"),
                        Telefone = reader.GetString("telefone"),
                        Celular = reader.GetString("celular"),
                        Salario = reader.GetDecimal("salario")
                    });
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
        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
