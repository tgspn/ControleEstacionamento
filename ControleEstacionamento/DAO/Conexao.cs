using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ControleEstacionamento.DAO
{
    internal class Conexao
    {
        private static Conexao current;
        MySqlConnection Connection;
        private Conexao()
        {

            Connection = new MySqlConnection();
        }
        public static Conexao Current
        {
            get
            {
                if (current == null)
                    current = new Conexao();
                return current;
            }
        }


    }
}
