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
    public partial class FormVeiculoListar : Form
    {
        public FormVeiculoListar()
        {
            InitializeComponent();
            controler = new Controlers.VeiculoControler();
        }
        private Controlers.VeiculoControler controler;
        private BindingList<VeiculoModelo> list;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var form = new Veiculo.FormVeiculoCrud();
            if (form.ShowDialog() == DialogResult.OK)
                LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvFuncionario.DataSource = new BindingList<Modelos.VeiculoModelo>(controler.Listar());
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.VeiculoModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            if (new Veiculo.FormVeiculoCrud(modelo) { IsEdit = true }.ShowDialog() == DialogResult.OK)
                LoadDataGrid();
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVeiculoListar_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.VeiculoModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            if (new Veiculo.FormVeiculoCrud(modelo).ShowDialog() == DialogResult.OK)
                LoadDataGrid();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
            {
                var item = (Modelos.VeiculoModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
                controler.Excluir(item);

            }
        }
    }
}
