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
    public class ClienteDAO : IDAO<ClienteModelo>
    {
        private IConexao conexao;
        private string tableName;
        public ClienteDAO() : this(new DAO.Conexao())
        {

        }
        public ClienteDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "cliente";
        }

        public ClienteModelo Inserir(ClienteModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (nome, cpf, endereco, tel, cel, id_funcionario) VALUES (@nome, @cpf, @endereco, @tel, @cel, @id_funcionario)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@tel", model.Telefone);
            command.Parameters.AddWithValue("@cel", model.Celular);
            command.Parameters.AddWithValue("@funcionario", model.Funcionario);

            model.Id = (int)command.LastInsertedId;

            return model;
        }

        public void Atualizar(ClienteModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET nome = @nome, cpf = @cpf, endereco = @endereco, tel = @tel, cel = @cel, id_funcinario = @id_funcionario";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@tel", model.Telefone);
            command.Parameters.AddWithValue("@cel", model.Celular);
            command.Parameters.AddWithValue("@funcionario", model.Funcionario);

            command.ExecuteNonQuery();

        }

        public bool Remover(ClienteModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;
        }

        public List<ClienteModelo> ListarTodos()
        {
            var command = conexao.Command;
            command.Parameters.Clear();
            command.CommandText = $"SELECT * FROM view_cliente";

            return Ler();
        }

        public ClienteModelo BuscarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  view_cliente WHERE id =@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public List<ClienteModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM view_cliente WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        public List<ClienteModelo> Ler()
        {
            try
            {
                var reader = conexao.Command.ExecuteReader();
                List<ClienteModelo> list = new List<ClienteModelo>();
                while (reader.NextResult())
                {
                    list.Add(new ClienteModelo()
                    {
                        Nome = reader.GetString("nome"),
                        Funcionario = LerFuncionario(reader),
                        Id = reader.GetInt32("id"),
                        Cpf = reader.GetString("cpf"),
                        Endereco = reader.GetString("endereco"),
                        Telefone = reader.GetString("telefone"),
                        Celular = reader.GetString("celular")
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
                conexao.Fechar();
            }
        }

        private FuncionarioModelo LerFuncionario(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["funcionario_id"].ToString()))
                return null;
            return new FuncionarioModelo()
            {
                Id = reader.GetInt32("funcionario_id"),
                Celular = reader.GetString("funcionario_celular"),
                Cpf = reader.GetString("funcionario_cpf"),
                Endereco = reader.GetString("funcionario_endereco"),
                Nome = reader.GetString("funcionario_nome"),
                Salario = reader.GetDecimal("salario"),
                Telefone = reader.GetString("funcionario_telefone")
            };
        }

        public void Dispose()
        {
            this.conexao.Dispose();
        }

        public List<ClienteModelo> ListarPorNome(string nome)
        {
            if (nome == null)
                return null;

            var command = conexao.Command;
            command.CommandText = $"SELECT * FROM CLIENTE WHERE NOME LIKE @nome";
            command.Parameters.AddWithValue("@nome", nome);
            return Ler();
        }
        public List<ClienteModelo> ListarPorCpf(string cpf)
        {
            if (cpf == null)
                return null;

            var command = conexao.Command;
            command.CommandText = $"SELECT * FROM CLIENTE WHERE cpf LIKE @cpf";
            command.Parameters.AddWithValue("@cpf", cpf);
            return Ler();
        }
    }
}
