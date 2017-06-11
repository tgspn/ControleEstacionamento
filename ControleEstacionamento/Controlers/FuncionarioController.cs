using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class FuncionarioController
    {
        private DAO.FuncionarioDAO dao = new DAO.FuncionarioDAO();
        public List<Modelos.FuncionarioModelo> Listar()
        {
            return dao.ListarTodos();
        }
        public Modelos.FuncionarioModelo Criar(Modelos.FuncionarioModelo modelo)
        {
            return dao.Inserir(modelo);
        }
        public void Atualizar(Modelos.FuncionarioModelo modelo)
        {
            dao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.FuncionarioModelo modelo)
        {
            return dao.Remover(modelo);
        }
        public Modelos.FuncionarioModelo Buscar(int id)
        {
            return dao.ProcurarPorId(id);
        }
        public Modelos.FuncionarioModelo BuscarPorUsuarioId(int id)
        {
            return dao.BuscarPorUsuarioId(id);
        }
    }
}
