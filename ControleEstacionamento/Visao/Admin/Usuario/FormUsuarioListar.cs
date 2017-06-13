using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Admin.Usuario
{
    public partial class FormUsuarioListar : Form
    {

        BindingList<Modelos.UsuarioModelo> list;
        private Controlers.UsuarioController controler;

        public FormUsuarioListar()
        {
            InitializeComponent();
            controler = new Controlers.UsuarioController();
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormUsuarioCrud form = new FormUsuarioCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.modelo); //teste
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.UsuarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormUsuarioCrud form = new FormUsuarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.UsuarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormUsuarioCrud form = new FormUsuarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK)
                controler.Excluir((Modelos.UsuarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem);
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormUsuarioListar_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = list=new BindingList<Modelos.UsuarioModelo>(controler.Listar()); 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvFuncionario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn item in ((DataGridView)sender).Columns)
            {
                if (item.Name == "Id")
                    item.Visible = false;
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            controler.BuscarPorNomeLike(txtBuscar.Text);
        }
    }
}
