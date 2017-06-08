using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbFuncionarios_Click(object sender, EventArgs e)
        {
            //TODO:Inserir o código para iniciar a visão de listagem de todos os funcionários cadastrados.

            Visao.Funcionario.FormFuncionarioListar form = new Visao.Funcionario.FormFuncionarioListar();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();


        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            Visao.Cliente.FormClienteListar form = new Visao.Cliente.FormClienteListar();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new Visao.Vaga.FormVagaListar()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
        }.Show();
        }

        private void tsbVeiculo_Click(object sender, EventArgs e) {
            Visao.Veiculo.FormVeiculoListar form = new Visao.Veiculo.FormVeiculoListar();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            new ControleEstacionamento.Visao.Ocupa.FormOcupaListar() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            new ControleEstacionamento.Visao.Ocupa.FormOcupaListar() { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio.FormRelatorio().ShowDialog();
        }
    }
}
