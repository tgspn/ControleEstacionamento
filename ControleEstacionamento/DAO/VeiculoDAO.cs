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
        private string viewName;
        public VeiculoDAO() : this(new DAO.Conexao())
        {

        }
        public VeiculoDAO(Interfaces.IConexao conexao)
        {
            this.conexao = conexao;
            this.tableName = "veiculo";
            this.viewName = "view_veiculo";
        }
        public void Atualizar(VeiculoModelo model)
        {
            var command = conexao.Command;
            command.CommandText = $"UPDATE {tableName} SET marca=@marca, modelo=@modelo , ano=@ano , placa=@placa , cliente_id=@cliente WHERE id=@id";
            command.Parameters.Clear();
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
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@marca", model.Marca);
            command.Parameters.AddWithValue("@modelo", model.Modelo);
            command.Parameters.AddWithValue("@ano", model.Ano);
            command.Parameters.AddWithValue("@placa", model.Placa);
            command.Parameters.AddWithValue("@cliente", model.Cliente.Id);

            command.ExecuteNonQuery();

            model.Id = (int)command.LastInsertedId;

            return model;
        }

        public bool Remover(VeiculoModelo model)
        {


            var command = conexao.Command;
            command.CommandText = $"DELETE FROM {tableName} WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", model.Id);

            return command.ExecuteNonQuery() > 0;

        }
        public List<VeiculoModelo> ListarTodos()
        {

            var command = conexao.Command;

            command.CommandText = $"SELECT * FROM  {tableName}";

            return Ler();

        }

        public VeiculoModelo BuscarPorId(int id)
        {
            var command = conexao.Command;
            command.Parameters.Clear();
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
                        Cliente = LerCliente(reader),
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        Modelo = reader.GetString("modelo"),
                        Placa = reader.GetString("placa")
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
        public void Dispose()
        {
            this.conexao.Dispose();
        }

        // por nome
        public List<VeiculoModelo> ListarPorNome(string nome)
        {
            if (nome == null)
            {
                return null;
            }

            var command = conexao.Command;

            command.CommandText = $"select * from {tableName} v where nome like" + nome;
            return Ler();
        }
        public List<VeiculoModelo> ListarPorModelo(VeiculoModelo modelo)
        {
            if (modelo == null)
                return null;

            var command = conexao.Command;

            command.CommandText = $"select * from {tableName} v where modelo like @modelo";
            command.Parameters.AddWithValue("@modelo", modelo.Modelo);
            return Ler();
        }
        public List<VeiculoModelo> ListarPorAno(string ano)
        {
            if (ano == null)
                return null;

            var command = conexao.Command;
            command.CommandText = $"select * from {tableName} v where ano like @ano";
            command.Parameters.AddWithValue("@ano", ano);
            return Ler();
        }
        public List<VeiculoModelo> ListarPorCor(string cor)
        {
            if (cor == null)
                return null;

            var command = conexao.Command;
            command.CommandText = $"select * from {tableName} v where cor like @cor";
            command.Parameters.AddWithValue("@cor", cor);
            return Ler();
        }

        public List<VeiculoModelo> ListarPorCliente(int id_cliente) {

            var command = conexao.Command;
            command.CommandText = $"select c.id as ID, c.nome as Cliente, v.marca as Fabricante, v.modelo as Modelo, v.placa as Placa, v.cor as Cor from {tableName} v join cliente c on v.id_cliente = c.id where id_cliente = " + id_cliente;
            return Ler();
        }
    }
}
