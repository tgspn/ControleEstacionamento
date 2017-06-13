using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Modelos
{
    public class VagaModelo
    {
        public int Id { get; set; }
        public string NumeroVaga { get;  set; }
        public bool TemAcessibilidade { get;  set; }
        public decimal Preco { get; set; }
    }
}
