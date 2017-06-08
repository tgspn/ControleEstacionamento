using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Vaga
{
    public partial class FormVagaListar : Form
    {
        //teste
        BindingList<Modelos.VagaModelo> list = new BindingList<Modelos.VagaModelo>();

        public FormVagaListar()
        {
            InitializeComponent();
            dgvFuncionario.DataSource = list; //teste
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormVagaCrud form = new FormVagaCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.modelo); //teste
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.VagaModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormVagaCrud form = new FormVagaCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.VagaModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormVagaCrud form = new FormVagaCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
