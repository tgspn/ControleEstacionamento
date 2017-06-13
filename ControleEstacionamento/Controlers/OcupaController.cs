using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class OcupaController
    {
        private DAO.OcupaDAO ocupaDao = new DAO.OcupaDAO();
        public List<Modelos.OcupaModelo> Listar()
        {
            return ocupaDao.ListarTodos();
        }
        public Modelos.OcupaModelo Criar(Modelos.OcupaModelo modelo)
        {
            return ocupaDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.OcupaModelo modelo)
        {
            ocupaDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.OcupaModelo modelo)
        {
            return ocupaDao.Remover(modelo);
        }
        public Modelos.OcupaModelo Buscar(int id)
        {
            return ocupaDao.BuscarPorId(id);
        }
        public DateTime TempoTotal(Modelos.OcupaModelo modelo) {
            return ocupaDao.PegarHoraEntrada(modelo);
        }
    }
}
