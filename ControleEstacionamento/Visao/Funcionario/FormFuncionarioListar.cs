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
        BindingList<Modelos.FuncionarioModelo> list = new BindingList<Modelos.FuncionarioModelo>();
        private Controlers.FuncionarioController controler = new Controlers.FuncionarioController();

        public FormFuncionarioListar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormFuncionarioCrud form = new FormFuncionarioCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.modelo); //teste
            list.OrderBy(x => x.Nome);
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
            if (result == DialogResult.Yes)
                controler.Excluir((Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem);
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormFuncionarioListar_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = list = new BindingList<Modelos.FuncionarioModelo>(controler.Listar());
            list.OrderBy(x => x.Nome);
        }
    }
}
