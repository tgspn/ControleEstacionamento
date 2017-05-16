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

namespace ControleEstacionamento.Visao.Vaga
{
    public partial class FormVagaCrud : Form
    {
        public FormVagaCrud()
        {
            InitializeComponent();
        }

        public VagaModelo modelo; //voltar privado depois do teste

        public bool IsEdit { get; set; }

        public FormVagaCrud(VagaModelo modelo) : this()
        {
            this.modelo = modelo;
        }

        private void GetInfo()
        {
            if (modelo == null)
            {
                modelo = new VagaModelo();
            }
            if (Validar())
            {
                modelo.NumeroVaga = txtNr.Text;
                modelo.TemAcessibilidade =cbxAcessibilidade.Checked;
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos!");
                return;
            }
        }

        private bool Validar()
        {
            if (!string.IsNullOrEmpty(txtNr.Text))
                return true;

            return false;
        }

        private void SetInfo(VagaModelo modelo)
        {
            txtNr.Text = modelo.NumeroVaga.ToString();
            cbxAcessibilidade.Checked = modelo.TemAcessibilidade;

            if (!IsEdit)
            {
                txtNr.ReadOnly = true;
                cbxAcessibilidade.Enabled = false;

                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetInfo();
            this.Close();
        }

        private void FormVagaCrud_Load(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
