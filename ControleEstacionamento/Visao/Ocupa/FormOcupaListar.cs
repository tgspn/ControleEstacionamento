using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Ocupa
{
    public partial class FormOcupaListar : Form
    {
        //teste
        BindingList<Modelos.VagaModelo> list = new BindingList<Modelos.VagaModelo>();

        public FormOcupaListar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
        }
    }
}
