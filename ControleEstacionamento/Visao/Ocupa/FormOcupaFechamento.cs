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
        public FormOcupaFechamento()
        {
            InitializeComponent();
        }
        OcupaModelo ocupa = new OcupaModelo();
        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool GetInfo() {
            if(ocupa == null) {
                ocupa = new OcupaModelo();
            }
            try {
                ocupa.dhSaida = System.DateTime.Now;
                return true;
            }
            catch (Exception erro) {
                MessageBox.Show("Erro - " + erro);
                return false;
            }
            
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
