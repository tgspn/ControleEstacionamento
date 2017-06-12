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

namespace ControleEstacionamento.Visao.Funcionario
{
    public partial class FormFuncionarioCrud : Form
    {
        public FormFuncionarioCrud()
        {
            InitializeComponent();
            controler = new Controlers.FuncionarioController();
        }

        public FuncionarioModelo modelo; //voltar privado depois do teste
        private Controlers.FuncionarioController controler;

        public bool IsEdit { get; set; }

        public FormFuncionarioCrud(FuncionarioModelo modelo) : this()
        {
            this.modelo = modelo;
        }

        private bool GetInfo()
        {
            if (modelo == null)
            {
                modelo = new FuncionarioModelo();
            }
            if (Validar())
            {
                modelo.Nome = txtNome.Text;
                modelo.Cpf = txtCpf.Text;
                modelo.Endereco = txtEndereco.Text;
                modelo.Telefone = txtTelefone.Text;
                modelo.Celular = txtCelular.Text;
                modelo.Salario = decimal.Parse(txtSalario.Text);
                return true;
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos!");
                return false;
            }
        }

        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
                if (!string.IsNullOrEmpty(txtCpf.Text))
                    if (!string.IsNullOrEmpty(txtCelular.Text))
                        if (!string.IsNullOrEmpty(txtSalario.Text))
                            return true;

            return false;
        }

        private void SetInfo(FuncionarioModelo modelo)
        {
            txtNome.Text = modelo.Nome;
            txtCpf.Text = modelo.Cpf.ToString();
            txtEndereco.Text = modelo.Endereco;
            txtTelefone.Text = modelo.Telefone.ToString();
            txtCelular.Text = modelo.Celular.ToString();
            txtSalario.Text = modelo.Salario.ToString();

            if(!IsEdit)
            {
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtEndereco.ReadOnly= true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;
                txtSalario.ReadOnly = true;

                btnSalvarFuncionario.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                if (IsEdit)
                    controler.Atualizar(modelo);
                else
                    controler.Criar(modelo);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                SetInfo(modelo);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
