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
            clienteControler = new Controlers.ClienteController();
        }

        VeiculoModelo veiculo;//remover o public no final do teste
        private Controlers.VeiculoControler controler;
        private Controlers.ClienteController clienteControler;

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
                veiculo.Cliente = comboBox1.SelectedValue as Modelos.ClienteModelo;

                if (IsEdit)
                    controler.Atualizar(veiculo);
                else
                    controler.Criar(veiculo);

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
                            if (comboBox1.SelectedValue != null)
                                return true;

            return false;
        }
        public void SetInfo(VeiculoModelo modelo)
        {
            txtModelo.Text = modelo.Modelo;
            txtAno.Text = modelo.Ano.ToString();
            txtMarca.Text = modelo.Marca;
            txtPlaca.Text = modelo.Placa.ToString();
            comboBox1.SelectedValue = veiculo.Cliente;

            if (!IsEdit)
            {
                txtMarca.Enabled = false;
                txtModelo.Enabled = false;
                txtAno.Enabled = false;
                txtPlaca.Enabled = false;
                comboBox1.Enabled = false;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void FormVeiculoCrud_Load(object sender, EventArgs e)
        {
            var dic = clienteControler.Listar().ToDictionary(x => x.Nome, v => v);
            if (dic.Count > 0)
            {
                comboBox1.DataSource = new BindingSource(dic, null);
                comboBox1.DisplayMember = "Key";
                comboBox1.ValueMember = "Value";
            }
            
                
        }
    }
}
