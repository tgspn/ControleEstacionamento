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
            //form.WindowState = FormWindowState.Maximized;

            if (Application.OpenForms.OfType<Visao.Funcionario.FormFuncionarioListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Funcionario.FormFuncionarioListar>().First().Focus();
            }
            else
            { 
                form.Show();
            }

        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            Visao.Cliente.FormClienteListar form = new Visao.Cliente.FormClienteListar();
            form.MdiParent = this;
            // form.WindowState = FormWindowState.Maximized;

            if (Application.OpenForms.OfType<Visao.Cliente.FormClienteListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Cliente.FormClienteListar>().First().Focus();
            }
            else
            {
                form.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Visao.Vaga.FormVagaListar form = new Visao.Vaga.FormVagaListar();
            form.MdiParent = this;

            if (Application.OpenForms.OfType<Visao.Vaga.FormVagaListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Vaga.FormVagaListar>().First().Focus();
            }
            else
            {
                form.Show();
            }
        }

        private void tsbVeiculo_Click(object sender, EventArgs e)
        {
            Visao.Veiculo.FormVeiculoListar form = new Visao.Veiculo.FormVeiculoListar();
            form.MdiParent = this;
            //form.WindowState = FormWindowState.Maximized;

            if (Application.OpenForms.OfType<Visao.Veiculo.FormVeiculoListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Veiculo.FormVeiculoListar>().First().Focus();
            }
            else
            {
                form.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Visao.Ocupa.FormOcupaListar form = new Visao.Ocupa.FormOcupaListar();
            form.MdiParent = this;
            //form.WindowState = FormWindowState.Maximized;

            if (Application.OpenForms.OfType<Visao.Ocupa.FormOcupaListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Ocupa.FormOcupaListar>().First().Focus();
            }
            else
            {
                form.Show();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            new ControleEstacionamento.Visao.Ocupa.FormOcupaListar() { MdiParent = this }.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio.FormRelatorioVeiculoAvancado().ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visao.Admin.Usuario.FormUsuarioListar form = new Visao.Admin.Usuario.FormUsuarioListar();
            form.MdiParent = this;
            //form.WindowState = FormWindowState.Maximized;

            if (Application.OpenForms.OfType<Visao.Admin.Usuario.FormUsuarioListar>().Count() > 0)
            {
                Application.OpenForms.OfType<Visao.Admin.Usuario.FormUsuarioListar>().First().Focus();
            }
            else
            {
                form.Show();
            }
        }
    }
}
