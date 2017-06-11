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
            command.CommandText = $"UPDATE {tableName} SET nome=@nome, endereco=@endereco, cpf=@cpf, telefone=@telefone, celular=@celular, salario=@salario WHERE id=@id";

            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@telefone", model.Telefone);
            command.Parameters.AddWithValue("@celular", model.Celular);
            command.Parameters.AddWithValue("@salario", model.Salario);
            command.Parameters.AddWithValue("@id", model.Id);

            command.ExecuteNonQuery();

        }

       
        public FuncionarioModelo Inserir(FuncionarioModelo model)
        {

            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (nome,endereco,cpf,telefone,celular,salario) VALUES (@nome,@endereco,@cpf,@telefone,@celular,@salario)";

            command.Parameters.AddWithValue("@nome", model.Nome);
            command.Parameters.AddWithValue("@endereco", model.Endereco);
            command.Parameters.AddWithValue("@cpf", model.Cpf);
            command.Parameters.AddWithValue("@telefone", model.Telefone);
            command.Parameters.AddWithValue("@celular", model.Celular);
            command.Parameters.AddWithValue("@salario", model.Salario);
            command.Parameters.AddWithValue("@id", model.Id);

            model.Id = int.Parse(command.ExecuteScalar().ToString());

            return model;
        }

        public bool Remover(FuncionarioModelo model)
        {


            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";

            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;

        }
        public List<FuncionarioModelo> ListarTodos()
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName}";

            return Ler();
        }

        public List<FuncionarioModelo> Ler()
        {
            var reader = conexao.Command.ExecuteReader();
            List<FuncionarioModelo> list = new List<FuncionarioModelo>();
            while (reader.NextResult())
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
            foreach (var item in list)
            {
                //Preencher a propriedade cliente
            }
            return list;
        }
        public FuncionarioModelo ProcurarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";
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
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
