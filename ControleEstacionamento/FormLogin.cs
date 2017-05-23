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

        private bool Validar()
        {
            if (txtUser.Text == "admin")
                if (txtPasswd.Text == "admin")
                    return true;

            return false;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                txtUser.Text = "";
                txtPasswd.Text = "";
            }
        }
    }
}
