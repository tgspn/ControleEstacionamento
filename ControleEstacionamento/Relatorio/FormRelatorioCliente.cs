using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Relatorio
{
    public partial class FormRelatorioCliente : Form
    {
        public FormRelatorioCliente()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var list = new List<Modelos.VeiculoModelo>(new Modelos.VeiculoModelo[] { new Modelos.VeiculoModelo() { Marca = "Chevrolet",Modelo="Corsa Classic",Ano="2004" }, new Modelos.VeiculoModelo { Marca = "Fiat", Modelo="Uno",Ano="2017" } });
            // rptVeiculos1.SetDataSource(list);

            ReportDocument rpt = new ReportDocument();
            rpt.Load("Relatorio\\rptVeiculosAvancado.rpt");
            rpt.SetDataSource(list);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
