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

        public FormVagaListar()
        {
            InitializeComponent();
            controler = new Controlers.VagaControler();
        }
        private Controlers.VagaControler controler;


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormVagaCrud form = new FormVagaCrud();
            //form.MdiParent = this.MdiParent;
            if (form.ShowDialog() == DialogResult.OK)
                CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            dgvFuncionario.DataSource = new BindingList<Modelos.VagaModelo>(controler.Listar());
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
          var result=  MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                controler.Excluir((Modelos.VagaModelo)dgvFuncionario.SelectedRows[0].DataBoundItem);
                CarregarDataGrid();
            }

        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVagaListar_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnBuscarVeiculo_Click(object sender, EventArgs e)
        {
            controler.BuscarPorNomeLike(txtBuscar.Text);
        }
    }
}
