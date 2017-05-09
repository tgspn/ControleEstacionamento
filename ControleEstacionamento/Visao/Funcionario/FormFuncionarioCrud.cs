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

namespace ControleEstacionamento.Visao.Funcionario
{
    public partial class FormFuncionarioCrud : Form
    {
        public FormFuncionarioCrud()
        {
            InitializeComponent();
        }

        public FuncionarioModelo funcionario;//remover o public no final do teste

        public FormFuncionarioCrud (FuncionarioModelo funcionario):this()
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
