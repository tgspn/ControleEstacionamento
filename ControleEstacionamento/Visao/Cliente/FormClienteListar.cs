using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Cliente
{
    public partial class FormClienteListar : Form
    {
        public FormClienteListar()
        {
            InitializeComponent();

        }

        private BindingList<Modelos.ClienteModelo> list;// = new BindingList<Modelos.ClienteModelo>();
        private Controlers.ClienteController controler = new Controlers.ClienteController();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormClienteCrud form = new FormClienteCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.Cliente); //teste
            list.OrderBy(x => x.Nome);
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.ClienteModelo)dgvCliente.SelectedRows[0].DataBoundItem;
            FormClienteCrud form = new FormClienteCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.ClienteModelo)dgvCliente.SelectedRows[0].DataBoundItem;
            FormClienteCrud form = new FormClienteCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                controler.Excluir((Modelos.ClienteModelo)dgvCliente.SelectedRows[0].DataBoundItem);
        }

        private void btnFecharCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClienteListar_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = list = new BindingList<Modelos.ClienteModelo>(controler.Listar());
            list.OrderBy(x => x.Nome);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            controler.BuscarPorNomeLike(txtBuscarCliente.Text);
        }
    }
}
