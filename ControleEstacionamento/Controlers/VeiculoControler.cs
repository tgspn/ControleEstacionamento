using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    public class VeiculoControler
    {
        private DAO.VeiculoDAO veiculoDao = new DAO.VeiculoDAO();
        public List<Modelos.VeiculoModelo> Listar()
        {
            return veiculoDao.ListarTodos();
        }
        public Modelos.VeiculoModelo Criar(Modelos.VeiculoModelo modelo)
        {
            return veiculoDao.Inserir(modelo);
        }
        public void Atualizar(Modelos.VeiculoModelo modelo)
        {
            veiculoDao.Atualizar(modelo);
        }
        public bool Excluir(Modelos.VeiculoModelo modelo)
        {          
            return veiculoDao.Remover(modelo);
        }
        public Modelos.VeiculoModelo Buscar(int id)
        {

            return veiculoDao.ProcurarPorId(id);
        }
    }
}
