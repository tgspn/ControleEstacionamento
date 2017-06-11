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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Controlers.UsuarioController controler=new Controlers.UsuarioController();
        Controlers.FuncionarioController FuncionarioControler = new Controlers.FuncionarioController();
        private bool Validar()
        {
            if (txtUser.Text == "admin" && txtPasswd.Text == "admin")
                return true;
            else
            {
                var usuario = controler.Logar(new Modelos.UsuarioModelo() { Usuario = txtUser.Text, Senha = txtPasswd.Text });
                if(usuario!=null)
                {
                    Configuracao.CurrentFuncionario = FuncionarioControler.BuscarPorUsuarioId(usuario.Id);
                    return Configuracao.CurrentFuncionario != null;
                }
            }
            return false;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            btnLogar.Enabled = false;
            if (Validar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválido");
                this.DialogResult = DialogResult.Cancel;
                txtUser.Text = "";
                txtPasswd.Text = "";
            }
            btnLogar.Enabled = true;
        }

        private void txtPasswd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogar.PerformClick();
        }
    }
}
