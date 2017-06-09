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
    public partial class FormRelatorioVeiculo : Form
    {
        public FormRelatorioVeiculo()
        {
            InitializeComponent();
            var list = new List<Modelos.VeiculoModelo>(new Modelos.VeiculoModelo[] { new Modelos.VeiculoModelo() { Marca = "Chevrolet" }, new Modelos.VeiculoModelo { Marca = "Fiat" } });
            // rptVeiculos1.SetDataSource(list);

            ReportDocument rpt = new ReportDocument();
            rpt.Load("Relatorio\\rptVeiculos.rpt");
            rpt.SetDataSource(list);
            crystalReportViewer1.ReportSource = rpt;
            
        }
    }
}
