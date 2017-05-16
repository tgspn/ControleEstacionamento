using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Cliente {
    public partial class FormClienteListar : Form {
        public FormClienteListar() {
            InitializeComponent();
            dgvCliente.DataSource = list;
        }

        BindingList<Modelos.ClienteModelo> list = new BindingList<Modelos.ClienteModelo>();

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormClienteCrud form = new FormClienteCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.cliente); //teste
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e) {
            var modelo = (Modelos.ClienteModelo)dgvCliente.SelectedRows[0].DataBoundItem;
            FormClienteCrud form = new FormClienteCrud(modelo); 
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e) {
            var modelo = (Modelos.ClienteModelo)dgvCliente.SelectedRows[0].DataBoundItem;
            FormClienteCrud form = new FormClienteCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e) {
            MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
        }
    }
}
