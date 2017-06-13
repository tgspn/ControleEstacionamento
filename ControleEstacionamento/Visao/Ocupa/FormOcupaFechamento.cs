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

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool GetInfo() {
            if (ocupa == null) {
                ocupa = new OcupaModelo();

                try {
                    ocupa.dhSaida = System.DateTime.Now;
                    
                    label1.Text = ocupaControler.TempoTotal(ocupa).ToString();
                    int valor = Convert.ToInt32(ocupaControler.TempoTotal(ocupa));

                    decimal valor_total = valor * ocupa.Vaga.Preco;
                    label2.Text = valor_total.ToString();
                    return true;
                }
                catch {
                   
                }
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
    }
}
