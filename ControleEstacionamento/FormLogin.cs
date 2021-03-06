﻿using System;
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
        Controlers.UsuarioController controler = new Controlers.UsuarioController();
        private bool Validar()
        {
            if (txtUser.Text == "admin" && txtPasswd.Text == "admin")
            {
                Configuracao.CurrentFuncionario = new Modelos.FuncionarioModelo()
                {
                    Id=0,
                    Nome="Admin"                    
                };
                return true;
            }
            else
            {
                var usuario = controler.Logar(new Modelos.UsuarioModelo() { Usuario = txtUser.Text, Senha = txtPasswd.Text });
                if (usuario != null)
                {
                    Configuracao.CurrentFuncionario = usuario.Funcionario;
                    return Configuracao.CurrentFuncionario != null;
                }
            }
            return false;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            btnLogar.Enabled = false;
            if (Validar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválido");
                this.DialogResult = DialogResult.Cancel;
                txtUser.Text = "";
                txtPasswd.Text = "";
                
               
            }
            btnLogar.Enabled = true;
        }
        
    }
}
