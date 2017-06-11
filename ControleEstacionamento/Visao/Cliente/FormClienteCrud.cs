using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstacionamento.Modelos;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Cliente
{
    public partial class FormClienteCrud : Form
    {
        public FormClienteCrud()
        {
            InitializeComponent();
            controler = new Controlers.ClienteController();
        }

        public ClienteModelo Cliente { get; private set; }
        private Controlers.ClienteController controler;

        public FormClienteCrud(ClienteModelo cliente) : this()
        {
            this.Cliente = cliente;
        }
        public bool IsEdit { get; set; }
        private bool GetInfo()
        {
            if (Cliente == null)
            {
                Cliente = new ClienteModelo();
            }
            if (Validar())
            {
                Cliente.Nome = txtNome.Text;
                Cliente.Cpf = txtCpf.Text;
                Cliente.Telefone = txtTelefone.Text;
                Cliente.Celular = txtCelular.Text;
                Cliente.Endereco = txtEndereco.Text;
                Cliente.Funcionario = Configuracao.CurrentFuncionario;
                return true;


            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos");
                return false;
            }
        }
        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
                if (!string.IsNullOrEmpty(txtCpf.Text))
                    if (!string.IsNullOrEmpty(txtEndereco.Text))
                        if (!string.IsNullOrEmpty(txtCelular.Text))
                            return true;

            return false;
        }

        private void SetInfo(ClienteModelo modelo)
        {
            txtNome.Text = modelo.Nome;
            txtCpf.Text = modelo.Cpf.ToString();
            txtEndereco.Text = modelo.Endereco;
            txtTelefone.Text = modelo.Telefone.ToString();
            txtCelular.Text = modelo.Celular.ToString();

            if (!IsEdit)
            {
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;

                btnSalvarCliente.Visible = false;
                btnCancelar.Text = "Fechar";
            }

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                if (IsEdit)
                    controler.Atualizar(Cliente);
                else
                    controler.Criar(Cliente);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClienteCrud_Load(object sender, EventArgs e)
        {
            if (Cliente != null)
            {
                SetInfo(Cliente);
            }
        }
    }
}
