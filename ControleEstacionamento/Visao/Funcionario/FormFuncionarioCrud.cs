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
        public FormFuncionarioCrud(FuncionarioModelo modelo) : this()
        {
            this.Funcionario = modelo;
        }
        private Controlers.FuncionarioController controler;
        public FuncionarioModelo Funcionario { get;private set; }

        public bool IsEdit { get; set; }

        

        private bool GetInfo()
        {
            if (Funcionario == null)
            {
                Funcionario = new FuncionarioModelo();
            }
            if (Validar())
            {
                Funcionario.Nome = txtNome.Text;
                Funcionario.Cpf = txtCpf.Text;
                Funcionario.Endereco = txtEndereco.Text;
                Funcionario.Telefone = txtTelefone.Text;
                Funcionario.Celular = txtCelular.Text;
                Funcionario.Salario = decimal.Parse(txtSalario.Text);

                if (IsEdit)
                    controler.Atualizar(Funcionario);
                else
                    controler.Criar(Funcionario);

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
            if(GetInfo())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {
            if (Funcionario != null)
            {
                SetInfo(Funcionario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
