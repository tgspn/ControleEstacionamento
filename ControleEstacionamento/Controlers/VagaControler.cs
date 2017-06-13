using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class VagaControler
    {
        private DAO.VagaDAO vagaDao = new DAO.VagaDAO();
        public List<Modelos.VagaModelo> Listar()
        {
            return vagaDao.ListarTodos();
        }
        public Modelos.VagaModelo Criar(Modelos.VagaModelo modelo)
        {
            return vagaDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.VagaModelo modelo)
        {
            vagaDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.VagaModelo modelo)
        {
            return vagaDao.Remover(modelo);
        }
        public Modelos.VagaModelo Buscar(int id)
        {
            return vagaDao.BuscarPorId(id);
        }
        internal List<Modelos.VagaModelo> BuscarPorNomeLike(string text)
        {
            return vagaDao.ListarPorNro(text);
        }
    }
}
