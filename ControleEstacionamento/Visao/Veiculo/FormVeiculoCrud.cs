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

        VeiculoModelo veiculo;//remover o public no final do teste

        public FormVeiculoCrud(VeiculoModelo veiculo) : this()
        {
            this.veiculo = veiculo;
        }

        public void GetInfo()
        {
            if (veiculo == null)
            {
                veiculo = new VeiculoModelo();
            }
            if (!string.IsNullOrEmpty(txtNomeFuncionario.Text))
            {
            }
            else
            {
                MessageBox.Show("Test");
                return;
            }

            //funcionario.Cpf = long.Parse()

        }
        public void SetInfo(VeiculoModelo modelo)
        {

        }
        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
