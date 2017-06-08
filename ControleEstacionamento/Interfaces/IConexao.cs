using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Interfaces
{
    public interface IConexao:IDisposable
    {
        MySqlConnection Abrir();
        void Fechar();
        MySqlCommand Command { get; }
    }
}
