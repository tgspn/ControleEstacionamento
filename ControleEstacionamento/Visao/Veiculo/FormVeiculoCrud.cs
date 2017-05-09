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

namespace ControleEstacionamento.Visao.Veiculo
{
    public partial class FormVeiculoCrud : Form
    {
        public FormVeiculoCrud()
        {
            InitializeComponent();
        }

        public FuncionarioModelo funcionario;//remover o public no final do teste

        public FormVeiculoCrud (FuncionarioModelo funcionario):this()
        {
            this.funcionario = funcionario;
        }

        public void GetInfo()
        {
            if(funcionario == null)
            {
                funcionario = new FuncionarioModelo();
            }
            if (!string.IsNullOrEmpty(txtNomeFuncionario.Text))
                funcionario.Celular = long.Parse(txtNomeFuncionario.Text);
            else
            {
                MessageBox.Show("Test");
                return;
            }

            //funcionario.Cpf = long.Parse()

        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
