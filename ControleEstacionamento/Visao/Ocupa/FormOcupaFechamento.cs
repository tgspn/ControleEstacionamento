using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstacionamento.Modelos;

namespace ControleEstacionamento.Visao.Ocupa
{
    public partial class FormOcupaFechamento : Form
    {
        public FormOcupaFechamento(VagaModelo vaga)
        {
            InitializeComponent();
            ocupaControler = new Controlers.OcupaController();
            this.vaga = vaga;
        }
        OcupaModelo ocupa = new OcupaModelo();
        Controlers.OcupaController ocupaControler;
        private VagaModelo vaga;
        private DateTime entrada;

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {                
                this.Close();
            }
        }
        private void SetInfo()
        {
            this.entrada = ocupaControler.HoraEntrada(ocupa);
            var tempoTotal = DateTime.Now- entrada ;
            label1.Text = $"{tempoTotal.Hours}:{tempoTotal.Minutes}";

            decimal valor_total =(decimal) tempoTotal.TotalHours * ocupa.Vaga.Preco;
            label2.Text = valor_total.ToString();

        }
        private bool GetInfo()
        {


            try
            {
                ocupa.dhSaida = System.DateTime.Now;

                var tempoTotal = DateTime.Now - entrada;
                decimal valor_total =(decimal) tempoTotal.TotalHours * ocupa.Vaga.Preco;
                ocupa.ValorPago = valor_total;
                return true;
            }
            catch
            {

            }

            return false;

        }
        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmFechamento_Tick(object sender, EventArgs e)
        {
            var tempoTotal = DateTime.Now - entrada;
            label1.Text = $"{tempoTotal.Hours}:{tempoTotal.Minutes}";
        }
    }
}
