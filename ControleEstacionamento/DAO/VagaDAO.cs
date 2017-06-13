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
    class VagaDAO : IDAO<VagaModelo>
    {
        private IConexao conexao;
        private string tableName;
        public VagaDAO() : this(new DAO.Conexao())
        {

        }
        public VagaDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "vaga";
        }
        public void Atualizar(VagaModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET nro=@nro, acessibilidade=@acessibilidade, valor_hora=@preco WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nro", model.NumeroVaga);
            command.Parameters.AddWithValue("@acessibilidade", model.TemAcessibilidade);
            command.Parameters.AddWithValue("@id", model.Id);
            command.Parameters.AddWithValue("@preco", model.Preco);

            command.ExecuteNonQuery();

        }

        public VagaModelo Inserir(VagaModelo model)
        {

            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (nro, acessibilidade, valor_hora) VALUES (@nro,@acessibilidade,@preco)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nro", model.NumeroVaga);
            command.Parameters.AddWithValue("@acessibilidade", model.TemAcessibilidade);
            command.Parameters.AddWithValue("@preco", model.Preco);


            command.ExecuteNonQuery();

            model.Id = (int)command.LastInsertedId;

            return model;
        }

        public bool Remover(VagaModelo model)
        {


            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;

        }
        public List<VagaModelo> ListarTodos()
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName}";

            return Ler();

        }

        public VagaModelo BuscarPorId(int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }
        public List<VagaModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }

        
        public List<VagaModelo> Ler()
        {
            try
            {
                conexao.Ler();
                var reader = conexao.Leitor;
                List<VagaModelo> list = new List<VagaModelo>();
                while (reader.Read())
                {
                    list.Add(new VagaModelo()
                    {
                        NumeroVaga = reader.GetString("nro"),
                        Id = reader.GetInt32("id"),
                        TemAcessibilidade = reader.GetBoolean("acessibilidade"),
                        Preco = reader.GetDecimal("valor_hora"),
                        
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
        public void Dispose()
        {
            this.conexao.Dispose();
        }
    }
}
