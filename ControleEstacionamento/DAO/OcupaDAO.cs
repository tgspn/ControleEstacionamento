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
        private string viewName;
        public OcupaDAO() : this(new DAO.Conexao())
        {

        }
        public OcupaDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "ocupa";
            this.viewName = "view_ocupa";
        }
        public void Atualizar(OcupaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET id_funcionario=@id_func, id_veiculo=@id_veiculo, id_vaga=@id_vaga, dh_entrada=@dh_entrada, dh_saida=@dh_saida";
            command.Parameters.Clear();
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
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_func", 1);
            command.Parameters.AddWithValue("@id_veiculo", model.Veiculo);
            command.Parameters.AddWithValue("@id_vaga", model.Vaga);
            command.Parameters.AddWithValue("@dh_entrada", model.dhEntrada);
            command.Parameters.AddWithValue("@dh_saida", model.dhSaida);

            command.ExecuteNonQuery();
            model.Id = (int)command.LastInsertedId;

            return model;
        }


        public List<OcupaModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {viewName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        public List<OcupaModelo> ListarTodos()
        {
            var command = conexao.Command;
            command.CommandText = $"SELECT * FROM {viewName}";

            return Ler();
        }

        public OcupaModelo BuscarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM {viewName} WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }

        public bool Remover(OcupaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id_funcionario=@id_funcionario and id_veiculo=@id_veiculo and vaga=@id_vaga";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id_funcionario", model.Funcionario);
            command.Parameters.AddWithValue("@id_veiculo", model.Veiculo);
            command.Parameters.AddWithValue("@id_vaga", model.Vaga);

            return command.ExecuteNonQuery() > 0;

        }

        public List<OcupaModelo> Ler()
        {
            try
            {
                var reader = conexao.Command.ExecuteReader();
                List<OcupaModelo> list = new List<OcupaModelo>();
                while (reader.NextResult())
                {
                    list.Add(new OcupaModelo()
                    {
                        Funcionario = LerFuncionario(reader),
                        Veiculo = LerVeiculo(reader),
                        Vaga = LerVaga(reader),
                        dhEntrada = reader.GetDateTime("dh_entrada"),
                        dhSaida = reader.GetDateTime("dh_saida")
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

        private VagaModelo LerVaga(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["vaga_id"].ToString()))
                return null;
            return new VagaModelo()
            {
                Id=reader.GetInt32("vaga_id"),
                NumeroVaga= reader.GetString("nro"),
                TemAcessibilidade= reader.GetBoolean("acessibilidade"),
            };
        }

        private VeiculoModelo LerVeiculo(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["veiculo_id"].ToString()))
                return null;
            return new VeiculoModelo()
            {
                Id = reader.GetInt32("veiculo_id"),
                Ano = reader.GetString("ano"),
                Cliente = LerCliente(reader),
                Marca = reader.GetString("marca"),
                Modelo = reader.GetString("modelo"),
                Placa = reader.GetString("placa"),
            };
        }

        private ClienteModelo LerCliente(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["cliente_id"].ToString()))
                return null;
            return new ClienteModelo()
            {

                Nome = reader.GetString("cliente_nome"),
                Funcionario = LerFuncionario(reader),
                Id = reader.GetInt32("cliente_id"),
                Cpf = reader.GetString("cliente_cpf"),
                Endereco = reader.GetString("cliente_endereco"),
                Telefone = reader.GetString("cliente_telefone"),
                Celular = reader.GetString("cliente_celular")
            };
        }


        private FuncionarioModelo LerFuncionario(MySqlDataReader reader)
        {
            if (string.IsNullOrEmpty(reader["funcionario_id"].ToString()))
                return null;
            return new FuncionarioModelo
            {
                Celular = reader.GetString("funcionario_celular"),
                Cpf = reader.GetString("funcionario_cpf"),
                Endereco = reader.GetString("funcionario_endereco"),
                Id = reader.GetInt32("funcionario_id"),
                Nome = reader.GetString("funcionario_nome"),
                Telefone = reader.GetString("funcionario_telefone")
            };
        }
    }
}
