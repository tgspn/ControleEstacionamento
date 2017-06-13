using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class ClienteController
    {
        private DAO.ClienteDAO clienteDao = new DAO.ClienteDAO();
        public List<Modelos.ClienteModelo> Listar()
        {
            return clienteDao.ListarTodos();
        }
        public Modelos.ClienteModelo Criar(Modelos.ClienteModelo modelo)
        {
            return clienteDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.ClienteModelo modelo)
        {
            clienteDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.ClienteModelo modelo)
        {
            return clienteDao.Remover(modelo);
        }
        public Modelos.ClienteModelo Buscar(int id)
        {
            return clienteDao.BuscarPorId(id);
        }

        internal List<Modelos.ClienteModelo> BuscarPorNomeLike(string text)
        {
            return clienteDao.ListarPorNome(text);
        }
    }
}
