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

        

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
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
