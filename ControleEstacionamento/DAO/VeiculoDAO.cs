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
    public class VeiculoDAO : IDAO<VeiculoModelo>
    {
        private IConexao conexao;
        private string tableName;
        public VeiculoDAO() : this(new DAO.Conexao())
        {

        }
        public VeiculoDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "C";
        }
        public void Atualizar(VeiculoModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET marca=@marca, modelo=@modelo , ano=@ano , placa=@placa , cliente_id=@cliente WHERE id=@id";

            command.Parameters.AddWithValue("@marca", model.Marca);
            command.Parameters.AddWithValue("@modelo", model.Modelo);
            command.Parameters.AddWithValue("@ano", model.Ano);
            command.Parameters.AddWithValue("@placa", model.Placa);
            command.Parameters.AddWithValue("@cliente", model.Cliente.Id);
            command.Parameters.AddWithValue("@id", model.Id);

            command.ExecuteNonQuery();

        }

        public VeiculoModelo Inserir(VeiculoModelo model)
        {

            var command = conexao.Command;
            command.CommandText = $"INSERT INTO {tableName} (marca,modelo,ano,placa,cliente_id) VALUES (@marca,@modelo,@ano,@placa,@cliente)";

            command.Parameters.AddWithValue("@marca", model.Marca);
            command.Parameters.AddWithValue("@modelo", model.Modelo);
            command.Parameters.AddWithValue("@ano", model.Ano);
            command.Parameters.AddWithValue("@placa", model.Placa);
            command.Parameters.AddWithValue("@cliente", model.Cliente.Id);

            model.Id = (int)command.LastInsertedId;

            return model;
        }

        public bool Remover(VeiculoModelo model)
        {


            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";

            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;

        }
        public List<VeiculoModelo> ListarTodos()
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName}";

            return Ler();

        }

        public List<VeiculoModelo> Ler()
        {
            try
            {
                var reader = conexao.Command.ExecuteReader();
                List<VeiculoModelo> list = new List<VeiculoModelo>();
                while (reader.NextResult())
                {
                    list.Add(new VeiculoModelo()
                    {
                        Ano = reader.GetString("ano"),
                        Cliente = new ClienteModelo()
                        {
                            Id = reader.GetInt32("cliente_id")
                        },
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        Modelo = reader.GetString("modelo"),
                        Placa = reader.GetString("placa")
                    });
                }

                return list;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Fechar();
            }
        }
        public VeiculoModelo BuscarPorId( int id)
        {
            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id =@id";
            command.Parameters.AddWithValue("@id", id);

            return Ler().FirstOrDefault();
        }
        public List<VeiculoModelo> ListarPorId(params int[] id)
        {
            if (id == null || id.Length == 0)
                return null;

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName} WHERE id IN ({string.Join(",", id)})";

            return Ler();
        }
        public void Dispose()
        {
            this.conexao.Dispose();
        }
        
    }
}
