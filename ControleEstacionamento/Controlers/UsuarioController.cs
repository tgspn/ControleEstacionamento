using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class UsuarioController
    {
        private DAO.UsuarioDAO clienteDao = new DAO.UsuarioDAO();
        public List<Modelos.UsuarioModelo> Listar()
        {
            return clienteDao.ListarTodos();
        }
        public Modelos.UsuarioModelo Criar(Modelos.UsuarioModelo modelo)
        {
            return clienteDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.UsuarioModelo modelo)
        {
            clienteDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.UsuarioModelo modelo)
        {
            return clienteDao.Remover(modelo);
        }
        public Modelos.UsuarioModelo Buscar(int id)
        {
            return clienteDao.ProcurarPorId(id);
        }
        public Modelos.UsuarioModelo Logar(Modelos.UsuarioModelo modelo)
        {
            return clienteDao.Logar(modelo);
            
        }
    }
}
