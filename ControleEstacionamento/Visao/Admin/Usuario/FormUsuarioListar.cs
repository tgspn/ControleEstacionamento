﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento.Visao.Admin.Usuario
{
    public partial class FormUsuarioListar : Form
    {
        //teste
        BindingList<Modelos.FuncionarioModelo> list = new BindingList<Modelos.FuncionarioModelo>();

        public FormUsuarioListar()
        {
            InitializeComponent();
            dgvFuncionario.DataSource = list; //teste
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormUsuarioCrud form = new FormUsuarioCrud();
            //form.MdiParent = this.MdiParent;
            form.ShowDialog();
            list.Add(form.modelo); //teste
        }

        private void btnDetalhesVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormUsuarioCrud form = new FormUsuarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var modelo = (Modelos.FuncionarioModelo)dgvFuncionario.SelectedRows[0].DataBoundItem;
            FormUsuarioCrud form = new FormUsuarioCrud(modelo);
            form.MdiParent = this.MdiParent;
            form.IsEdit = true;
            form.Show();
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir?", "Confirmação", MessageBoxButtons.YesNo);
        }

        private void btnFecharVeiculo_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
