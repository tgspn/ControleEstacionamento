using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Controlers
{
    class UsuarioController
    {
        private DAO.UsuarioDAO dao = new DAO.UsuarioDAO();
        private DAO.FuncionarioDAO funcionariDao = new DAO.FuncionarioDAO();

        public List<Modelos.UsuarioModelo> Listar()
        {
            return dao.ListarTodos();

        }
        public Modelos.UsuarioModelo Criar(Modelos.UsuarioModelo modelo)
        {

            var usuario = dao.Inserir(modelo);
            if (modelo.Funcionario != null)
            {
                modelo.Funcionario.Usuario = modelo;
                funcionariDao.Atualizar(modelo.Funcionario);
            }
            return usuario;
        }
        public void Atualizar(Modelos.UsuarioModelo modelo)
        {
            
            dao.Atualizar(modelo);
            if (modelo.Funcionario != null)
            {
                modelo.Funcionario.Usuario = modelo;
                funcionariDao.Atualizar(modelo.Funcionario);
            }
        }
        public bool Excluir(Modelos.UsuarioModelo modelo)
        {
           

            bool removido = dao.Remover(modelo);
            if (removido)
            {
                if (modelo.Funcionario != null)
                {
                    modelo.Funcionario.Usuario = null;
                    funcionariDao.Atualizar(modelo.Funcionario);
                }
            }
                

            return removido;
        }
        public Modelos.UsuarioModelo Buscar(int id)
        {
            return dao.BuscarPorId(id);
        }
        public Modelos.UsuarioModelo Logar(Modelos.UsuarioModelo modelo)
        {
            return dao.Logar(modelo);

        }
    }
}
