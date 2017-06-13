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

namespace ControleEstacionamento.Visao.Ocupa
{
    public partial class FormOcupaLancamento : Form
    {
        public FormOcupaLancamento(VagaModelo vaga)
        {
            InitializeComponent();
            ocupaControler = new OcupaController();
            funcionarioControler = new FuncionarioController();
            veiculoControler = new VeiculoControler();
            vagaControler = new VagaControler();
            this.vaga = vaga;
        }

        public OcupaModelo ocupa = new OcupaModelo();
        private OcupaController ocupaControler;
        private FuncionarioController funcionarioControler;
        private VeiculoControler veiculoControler;
        private VagaControler vagaControler;
        private VagaModelo vaga;
        public VeiculoModelo Veiculo { get; internal set; }

        private bool Validar()
        {
            if (comboBox1.SelectedValue != null)
                return true;

            return false;
        }
        private bool GetInfo()
        {
            if (ocupa == null)
                ocupa = new OcupaModelo();
            if (Validar())
            {
                ocupa.dhEntrada = System.DateTime.Now;
                ocupa.Veiculo = comboBox1.SelectedValue as VeiculoModelo;
                ocupa.Funcionario = Configuracao.CurrentFuncionario;
                ocupa.Vaga = vaga;

                return true;

            }
            else {
                MessageBox.Show("Existem campos obrigatórios não preenchidos");
                return false;
            }
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                ocupaControler.Criar(ocupa);
                this.Veiculo = ocupa.Veiculo;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void FormFuncionarioCrud_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            comboBox1.DataSource = new BindingSource(veiculoControler.Listar().ToDictionary(k => k.Placa, v => v), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tmHoraEntrada_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculoControler.Listar();
        }

        private void tmFechamento_Tick(object sender, EventArgs e)
        {

        }
    }
}
