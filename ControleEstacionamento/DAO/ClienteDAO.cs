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
            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@tel", model.Telefone);
            command.Parameters.AddWithValue("@cel", model.Celular);
            command.Parameters.AddWithValue("@funcionario", model.Funcionario);

            model.Id = int.Parse(command.ExecuteScalar().ToString());

            return model;
        }

        public void Atualizar(ClienteModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET nome = @nome, cpf = @cpf, endereco = @endereco, tel = @tel, cel = @cel, id_funcinario = @id_funcionario";

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

            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;
        }

        public List<ClienteModelo> ListarTodos()
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {tableName}";

            return Ler();
        }

        public ClienteModelo ProcurarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public List<ClienteModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        public List<ClienteModelo> Ler()
        {
            var reader = conexao.Command.ExecuteReader();
            List<ClienteModelo> list = new List<ClienteModelo>();
            while (reader.NextResult())
            {
                list.Add(new ClienteModelo()
                {
                    Nome = reader.GetString("nome"),
                    Funcionario = new FuncionarioModelo()
                    {
                        Id = reader.GetInt32("id_funcionario")
                    },
                    Id = reader.GetInt32("id"),
                    Cpf = reader.GetString("cpf"),
                    Endereco = reader.GetString("endereco"),
                    Telefone = reader.GetString("telefone"),
                    Celular = reader.GetString("celular")
                });
            }
            foreach (var item in list)
            {

            }
            return list;
        }

        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
