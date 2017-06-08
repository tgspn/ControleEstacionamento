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

namespace ControleEstacionamento.Visao.Cliente {
    public partial class FormClienteCrud : Form {
        public FormClienteCrud() {
            InitializeComponent();
        }
        public ClienteModelo cliente;//remover o public no final do teste

        public FormClienteCrud(ClienteModelo cliente) : this()
        {
            this.cliente = cliente;
        }
        public bool IsEdit { get; set; }
        private void GetInfo() {
            if (cliente == null) {
                cliente = new ClienteModelo();
            }
            if (Validar()) {
                cliente.Nome = txtNome.Text;
                cliente.Cpf = long.Parse(txtCpf.Text);
                cliente.Telefone = long.Parse(txtTelefone.Text);
                cliente.Celular = long.Parse(txtCelular.Text);
                cliente.Endereco = txtEndereco.Text;

            } else {
                MessageBox.Show("Existem campos obrigatórios não preenchidos");
                return;
            }
        }
        private bool Validar() {
            if (!string.IsNullOrEmpty(txtNome.Text))
                if (!string.IsNullOrEmpty(txtCpf.Text))
                    if (!string.IsNullOrEmpty(txtEndereco.Text))
                        if (!string.IsNullOrEmpty(txtCelular.Text))
                            return true;

            return false;
        }

        private void SetInfo(ClienteModelo modelo) {
            txtNome.Text = modelo.Nome;
            txtCpf.Text = modelo.Cpf.ToString();
            txtEndereco.Text = modelo.Endereco;
            txtTelefone.Text = modelo.Telefone.ToString();
            txtCelular.Text = modelo.Celular.ToString();

            if (!IsEdit) {
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;

                btnSalvarCliente.Visible = false;
                btnCancelar.Text = "Fechar";
            }

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e) {
            GetInfo();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormClienteCrud_Load(object sender, EventArgs e) {
            if(cliente != null) {
                SetInfo(cliente);
            }
        }
    }
}
