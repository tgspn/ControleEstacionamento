using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Interfaces
{
    public interface IDAO<T>:IDisposable
    {
        T Inserir(T model);
        void Atualizar(T model);
        bool Remover(T model);
        List<T> ListarTodos();
        T BuscarPorId(int id);
        List<T> ListarPorId(params int[] id);

        List<T> Ler();

    }
}
