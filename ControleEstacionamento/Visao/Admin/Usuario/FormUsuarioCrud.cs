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
using ControleEstacionamento.Controlers;

namespace ControleEstacionamento.Visao.Admin.Usuario
{
    public partial class FormUsuarioCrud : Form
    {
        public FormUsuarioCrud()
        {
            InitializeComponent();
            funcionarioControler = new FuncionarioController();
            usuarioControler = new UsuarioController();
        }

        public UsuarioModelo modelo; //voltar privado depois do teste
        private FuncionarioController funcionarioControler;
        private UsuarioController usuarioControler;

        public bool IsEdit { get; set; }

        public FormUsuarioCrud(UsuarioModelo modelo) : this()
        {
            this.modelo = modelo;
        }

        private bool GetInfo()
        {
            if (modelo == null)
            {
                modelo = new UsuarioModelo();
            }
            if (Validar())
            {
                modelo.Usuario = txtNome.Text;
                modelo.Senha = txtCpf.Text;
                modelo.Funcionario = cmbFuncionario.SelectedValue as FuncionarioModelo;

                usuarioControler.Criar(modelo);

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
                    return true;

            return false;
        }

        private void SetInfo(UsuarioModelo modelo)
        {
            txtNome.Text = modelo.Usuario;
            txtCpf.Text = modelo.Usuario;
            cmbFuncionario.SelectedValue = modelo.Funcionario;

            if (!IsEdit)
            {
                txtNome.Enabled = false;
                txtCpf.Enabled = false;
                cmbFuncionario.Enabled = false;

                btnSalvarFuncionario.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {
            var dic = funcionarioControler.Listar().OrderBy(x => x.Nome).ToDictionary(k => k.Nome, v => v);
            if (dic.Count > 0)
            {
                cmbFuncionario.DataSource = new BindingSource(dic, null);
                cmbFuncionario.DisplayMember = "Key";
                cmbFuncionario.ValueMember = "Value";
            }
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
