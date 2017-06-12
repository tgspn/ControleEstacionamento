using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Funcionario
{
    public partial class FormFuncionarioListar : Form
    {
        //teste
        BindingList<Modelos.FuncionarioModelo> list;
        Controlers.FuncionarioController controler;

        public FormFuncionarioListar()
        {
            InitializeComponent();
            controler = new Controlers.FuncionarioController();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormFuncionarioCrud form = new FormFuncionarioCrud();            
            if (form.ShowDialog() == DialogResult.OK)
            {
                list.Add(form.Funcionario); 
            }
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormFuncionarioCrud form = new FormFuncionarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormFuncionarioCrud form = new FormFuncionarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                var item= (Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
                if (controler.Excluir(item))
                {
                    list.Remove(item);
                }   
            }
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormFuncionarioListar_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = list = new BindingList<Modelos.FuncionarioModelo>(controler.Listar());
        }
    }
}
