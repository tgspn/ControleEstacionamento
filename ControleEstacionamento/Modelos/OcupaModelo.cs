using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Modelos
{
    public class OcupaModelo
    {
        public VeiculoModelo Veiculo { get; set; }
        public VagaModelo Vaga { get; set; }
        public FuncionarioModelo Funcionario { get; set; }

        public DateTime dhEntrada { get; set; }
        public DateTime dhSaida { get; set; }
        public int Id { get;  set; }
        public decimal ValorPago { get;  set; }
    }
}
