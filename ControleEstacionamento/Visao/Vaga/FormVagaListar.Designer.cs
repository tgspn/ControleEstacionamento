﻿namespace ControleEstacionamento.Visao.Vaga
{
    partial class FormVagaListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVagaListar));
            this.lblBuscarVeiculo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAdicionarVeiculo = new System.Windows.Forms.Button();
            this.btnDetalhesVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFecharVeiculo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarVeiculo
            // 
            this.lblBuscarVeiculo.AutoSize = true;
            this.lblBuscarVeiculo.Location = new System.Drawing.Point(16, 24);
            this.lblBuscarVeiculo.Name = "lblBuscarVeiculo";
            this.lblBuscarVeiculo.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarVeiculo.TabIndex = 0;
            this.lblBuscarVeiculo.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(62, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(712, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnAdicionarVeiculo
            // 
            this.btnAdicionarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarVeiculo.Image")));
            this.btnAdicionarVeiculo.Location = new System.Drawing.Point(12, 3);
            this.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            this.btnAdicionarVeiculo.Size = new System.Drawing.Size(75, 42);
            this.btnAdicionarVeiculo.TabIndex = 2;
            this.btnAdicionarVeiculo.Text = "Adicionar";
            this.btnAdicionarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.btnAdicionarVeiculo.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDetalhesVeiculo
            // 
            this.btnDetalhesVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhesVeiculo.Image")));
            this.btnDetalhesVeiculo.Location = new System.Drawing.Point(93, 3);
            this.btnDetalhesVeiculo.Name = "btnDetalhesVeiculo";
            this.btnDetalhesVeiculo.Size = new System.Drawing.Size(75, 42);
            this.btnDetalhesVeiculo.TabIndex = 3;
            this.btnDetalhesVeiculo.Text = "Detalhes";
            this.btnDetalhesVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalhesVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalhesVeiculo.UseVisualStyleBackColor = true;
            this.btnDetalhesVeiculo.Click += new System.EventHandler(this.btnDetalhesVeiculo_Click);
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarVeiculo.Image")));
            this.btnEditarVeiculo.Location = new System.Drawing.Point(174, 3);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(75, 42);
            this.btnEditarVeiculo.TabIndex = 4;
            this.btnEditarVeiculo.Text = "Editar";
            this.btnEditarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarVeiculo.Click += new System.EventHandler(this.btnEditarVeiculo_Click);
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirVeiculo.Image")));
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(255, 3);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(75, 42);
            this.btnExcluirVeiculo.TabIndex = 5;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirVeiculo.UseVisualStyleBackColor = true;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(867, 384);
            this.dgvFuncionario.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFuncionario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 384);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFecharVeiculo);
            this.panel2.Controls.Add(this.btnAdicionarVeiculo);
            this.panel2.Controls.Add(this.btnDetalhesVeiculo);
            this.panel2.Controls.Add(this.btnExcluirVeiculo);
            this.panel2.Controls.Add(this.btnEditarVeiculo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 48);
            this.panel2.TabIndex = 8;
            // 
            // btnFecharVeiculo
            // 
            this.btnFecharVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharVeiculo.Location = new System.Drawing.Point(780, 22);
            this.btnFecharVeiculo.Name = "btnFecharVeiculo";
            this.btnFecharVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnFecharVeiculo.TabIndex = 6;
            this.btnFecharVeiculo.Text = "Fechar";
            this.btnFecharVeiculo.UseVisualStyleBackColor = true;
            this.btnFecharVeiculo.Click += new System.EventHandler(this.btnFecharVeiculo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.lblBuscarVeiculo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 60);
            this.panel3.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(780, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarVeiculo_Click);
            // 
            // FormVagaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVagaListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKING [Lista de Vagas]";
            this.Load += new System.EventHandler(this.FormVagaListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarVeiculo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAdicionarVeiculo;
        private System.Windows.Forms.Button btnDetalhesVeiculo;
        private System.Windows.Forms.Button btnEditarVeiculo;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFecharVeiculo;
    }
}