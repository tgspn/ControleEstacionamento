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
    public partial class FormOcupaLancamento : Form
    {
        public FormOcupaLancamento()
        {
            InitializeComponent();
            controler = new Controlers.OcupaController();
        }

        public OcupaModelo ocupa = new OcupaModelo();
        private Controlers.OcupaController controler;

        private bool Validar() {
            if (!string.IsNullOrEmpty(ocupa.Veiculo.Modelo))
                if (!string.IsNullOrEmpty(ocupa.dhEntrada.ToString()))
                    return true;

            return false;
        }
        private bool GetInfo() {
            if (ocupa == null)
                ocupa = new OcupaModelo();
            if (Validar()) {
                ocupa.dhEntrada = System.DateTime.Now;
                return true;

            }
            else {
                MessageBox.Show("Existem campos obrigatórios não preenchidos");
                return false;
            }
        }
        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (GetInfo()) {
                controler.Criar(ocupa);
            }
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmHoraEntrada_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
