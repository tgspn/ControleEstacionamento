using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento
{
    public partial class ucVagasItem : UserControl
    {
        public ucVagasItem()
        {
            InitializeComponent();
            label2.Text = "";
            label1.Text = "";
        }

        private string numerovaga;
        private Modelos.VeiculoModelo veiculo;
        private Color corOcupado;
        private Color corLivre;
        long ticks = 0;
        [DefaultValue("Num. Vaga")]
        public string NumeroVaga
        {
            get { return numerovaga; }
            set
            {
                if (numerovaga != value)
                {

                    numerovaga = string.IsNullOrEmpty(value) ? "Num. Vaga" : value;

                    label1.Text = numerovaga;
                    this.Invalidate();
                }
            }
        }


        private Modelos.VagaModelo vaga;

        public Modelos.VagaModelo Vaga
        {
            get { return vaga; }
            set
            {
                if (vaga != value)
                {
                    vaga = value;
                    this.BackColor = value == null ? Color.Empty : corLivre;

                }
            }
        }


        public Modelos.VeiculoModelo Veiculo
        {
            get { return veiculo; }
            set
            {
                if (veiculo != value)
                {


                    veiculo = value;
                    this.BackColor = value == null ? corLivre : corOcupado;
                    this.tmDuracao.Enabled = value != null;
                    if (value != null)
                        ticks = 0;
                    this.Invalidate();
                }

            }
        }



        public Color CorOcupado
        {
            get { return corOcupado; }
            set
            {
                if (corOcupado != value)
                {
                    corOcupado = value;
                    this.Invalidate();
                }
            }
        }



        public Color CorLivre
        {
            get { return corLivre; }
            set
            {
                if (corLivre != value)
                {
                    corLivre = value;
                    this.Invalidate();
                }
            }
        }

        public void LiberarVaga()
        {
            Veiculo = null;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        private void tmDuracao_Tick(object sender, EventArgs e)
        {
            label2.Text =$"{TimeSpan.FromSeconds(ticks).Hours.ToString("00")}:{TimeSpan.FromSeconds(ticks).Minutes.ToString("00")}";
            ticks++;
        }
    }


}
