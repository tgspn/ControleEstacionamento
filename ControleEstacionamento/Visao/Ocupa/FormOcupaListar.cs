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
        BindingList<Modelos.FuncionarioModelo> list = new BindingList<Modelos.FuncionarioModelo>();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Livre")
            {
                new FormOcupaFechamento ().ShowDialog();
                pictureBox1.Image = Properties.Resources.num1_red;
                pictureBox1.Update();
                label1.Text = "Ocupado";
            }
            else
            {
                new FormOcupaCrud().ShowDialog();
                pictureBox1.Image = Properties.Resources.num1;
                label1.Text = "Livre";
            }
        }
    }
}
