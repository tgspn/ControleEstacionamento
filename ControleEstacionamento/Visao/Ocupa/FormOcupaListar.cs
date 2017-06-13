using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Ocupa
{
    public partial class FormOcupaListar : Form
    {

        public FormOcupaListar()
        {
            InitializeComponent();
            controler = new Controlers.OcupaController();
        }

        private Controlers.OcupaController controler;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Livre")
            {
                new FormOcupaLancamento ().ShowDialog();
                pictureBox1.Image = Properties.Resources.num1_red;
                pictureBox1.Update();
                label1.Text = "Ocupado";
            }
            else
            {
                new FormOcupaFechamento().ShowDialog();
                pictureBox1.Image = Properties.Resources.num1;
                label1.Text = "Livre";
            }
        }

        private void ucVagas1_Load(object sender, EventArgs e)
        {

        }

        private void FormOcupaListar_Load(object sender, EventArgs e)
        {
            Controlers.VagaControler vagaControler = new Controlers.VagaControler();
            var panels = panel1.Controls.Cast<Control>().Where(x => x.Name.StartsWith("vaga")).OrderBy(x=>x.TabIndex).Cast<ucVagasItem>().ToArray();
            int i = 0;
            foreach (var item in vagaControler.Listar().OrderBy(x => x.NumeroVaga))
            {
              //  panels[i].Tag = item;
                panels[i].NumeroVaga = item.NumeroVaga;
                panels[i].Vaga = item;
                i++;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void vaga1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((ucVagasItem)sender).NumeroVaga);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaga4.Veiculo = new Modelos.VeiculoModelo()
            {

            };
        }
    }
}
