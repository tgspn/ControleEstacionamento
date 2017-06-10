using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class FuncionarioControler
    {
        private DAO.FuncionarioDAO funcionarioDao = new DAO.FuncionarioDAO();
        public List<Modelos.FuncionarioModelo> Listar()
        {
            return funcionarioDao.ListarTodos();
        }
        public Modelos.FuncionarioModelo Criar(Modelos.FuncionarioModelo modelo)
        {
            return funcionarioDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.FuncionarioModelo modelo)
        {
            funcionarioDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.FuncionarioModelo modelo)
        {
            return funcionarioDao.Remover(modelo);
        }
        public Modelos.FuncionarioModelo Buscar(int id)
        {
            return funcionarioDao.ProcurarPorId(id);
        }
    }
}
