using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Modelos
{
    public class FuncionarioModelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public long Cpf { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public decimal Salario { get; set; }
    }
}
