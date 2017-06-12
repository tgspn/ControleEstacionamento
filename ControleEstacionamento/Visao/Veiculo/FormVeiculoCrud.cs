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

namespace ControleEstacionamento.Visao.Veiculo
{
    public partial class FormVeiculoCrud : Form
    {
        public FormVeiculoCrud()
        {
            InitializeComponent();
            controler = new Controlers.VeiculoControler();
        }

        VeiculoModelo veiculo;//remover o public no final do teste
        private Controlers.VeiculoControler controler;

        public bool IsEdit { get; set; }

        public bool IsEdit { get; internal set; }

        public FormVeiculoCrud(VeiculoModelo veiculo) : this()
        {
            this.veiculo = veiculo;
        }

        public bool GetInfo()
        {
            if (veiculo == null)
            {
                veiculo = new VeiculoModelo();
            }
            if (Validar())
            {
                veiculo.Marca = txtMarca.Text;
                veiculo.Modelo = txtModelo.Text;
                veiculo.Ano = txtAno.Text;
                veiculo.Placa = txtPlaca.Text;
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
            if (!string.IsNullOrEmpty(txtMarca.Text))
                if (!string.IsNullOrEmpty(txtModelo.Text))
                    if (!string.IsNullOrEmpty(txtAno.Text))
                        if (!string.IsNullOrEmpty(txtPlaca.Text))
                            return true;

            return false;
        }
        public void SetInfo(VeiculoModelo modelo)
        {
            txtModelo.Text = modelo.Modelo;
            txtAno.Text = modelo.Ano.ToString();
            txtMarca.Text = modelo.Marca;
            txtPlaca.Text = modelo.Placa.ToString();


            if (!IsEdit)
            {
                txtMarca.ReadOnly = true;
                txtModelo.ReadOnly = true;
                txtAno.ReadOnly = true;
                txtPlaca.ReadOnly = true;


                btnSalvarFuncionario.Visible = false;
                btnCancelar.Text = "Fechar";
            }
        }
        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
