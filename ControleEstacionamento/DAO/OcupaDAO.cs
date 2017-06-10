using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstacionamento.Modelos;
using ControleEstacionamento.Interfaces;
using MySql.Data.MySqlClient;

namespace ControleEstacionamento.DAO
{
    class OcupaDAO : IDAO<OcupaModelo>
    {
        private IConexao conexao;
        private string tableName;
        public OcupaDAO() : this(new DAO.Conexao())
        {

        }
        public OcupaDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "ocupa";
        }
        public void Atualizar(OcupaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET id_funcionario=@id_func, id_veiculo=@id_veiculo, id_vaga=@id_vaga, dh_entrada=@dh_entrada, dh_saida=@dh_saida";

            command.Parameters.AddWithValue("@id_func", model.Funcionario);
            command.Parameters.AddWithValue("@id_veiculo", model.Veiculo);
            command.Parameters.AddWithValue("@id_vaga", model.Vaga);
            command.Parameters.AddWithValue("@dh_entrada", model.dhEntrada);
            command.Parameters.AddWithValue("@dh_saida", model.dhSaida);

            command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.conexao.Dispose();
        }

        public OcupaModelo Inserir(OcupaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (id_funcionario, id_veiculo, id_vaga, dh_entrada, dh_saida) VALUES (@id_func, @id_veiculo, @id_vaga, @dh_entrada, @dh_saida)";

            command.Parameters.AddWithValue("@id_func", model.Funcionario);
            command.Parameters.AddWithValue("@id_veiculo", model.Veiculo);
            command.Parameters.AddWithValue("@id_vaga", model.Vaga);
            command.Parameters.AddWithValue("@dh_entrada", model.dhEntrada);
            command.Parameters.AddWithValue("@dh_saida", model.dhSaida);

            return model;
        }

        public List<OcupaModelo> Ler()
        {
            var reader = conexao.Command.ExecuteReader();
            List<OcupaModelo> list = new List<OcupaModelo>();
            while (reader.NextResult())
            {
                list.Add(new OcupaModelo()
                {
                    Funcionario = new FuncionarioModelo
                    {
                        Id = reader.GetInt32("id_funcionario")
                    },
                    Veiculo = new VeiculoModelo
                    {
                        Id = reader.GetInt32("id_veiculo")
                    },
                    Vaga = new VagaModelo
                    {
                        Id = reader.GetInt32("id_vaga")
                    },
                    dhEntrada = reader.GetDateTime("dh_entrada"),
                    dhSaida = reader.GetDateTime("dh_saida")
                });
            }
            foreach (var item in list)
            {

            }
            return list;
        }

        public List<OcupaModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        public List<OcupaModelo> ListarTodos()
        {
            var command = conexao.Command;
            command.CommandText = $"SELECT * FROM {tableName}";

            return Ler();
        }

        public OcupaModelo ProcurarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {tableName} WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public bool Remover(OcupaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id_funcionario=@id_funcionario and id_veiculo=@id_veiculo and vaga=@id_vaga";

            command.Parameters.AddWithValue("@id_funcionario", model.Funcionario);
            command.Parameters.AddWithValue("@id_veiculo", model.Veiculo);
            command.Parameters.AddWithValue("@id_vaga", model.Vaga);

            return command.ExecuteNonQuery() > 0;

        }
    }
}
