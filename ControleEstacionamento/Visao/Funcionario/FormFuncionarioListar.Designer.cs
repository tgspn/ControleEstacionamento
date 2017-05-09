namespace ControleEstacionamento.Visao.Funcionario
{
    partial class FormFuncionarioListar
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
            this.lblBuscarFuncionario = new System.Windows.Forms.Label();
            this.txtBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.btnAdicionarFuncionario = new System.Windows.Forms.Button();
            this.btnDetalhesFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarFuncionario
            // 
            this.lblBuscarFuncionario.AutoSize = true;
            this.lblBuscarFuncionario.Location = new System.Drawing.Point(13, 13);
            this.lblBuscarFuncionario.Name = "lblBuscarFuncionario";
            this.lblBuscarFuncionario.Size = new System.Drawing.Size(40, 13);
            this.lblBuscarFuncionario.TabIndex = 0;
            this.lblBuscarFuncionario.Text = "Buscar";
            // 
            // txtBuscarFuncionario
            // 
            this.txtBuscarFuncionario.Location = new System.Drawing.Point(59, 10);
            this.txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            this.txtBuscarFuncionario.Size = new System.Drawing.Size(466, 20);
            this.txtBuscarFuncionario.TabIndex = 1;
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(59, 36);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarFuncionario.TabIndex = 2;
            this.btnAdicionarFuncionario.Text = "Adicionar";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            this.btnAdicionarFuncionario.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDetalhesFuncionario
            // 
            this.btnDetalhesFuncionario.Location = new System.Drawing.Point(140, 36);
            this.btnDetalhesFuncionario.Name = "btnDetalhesFuncionario";
            this.btnDetalhesFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhesFuncionario.TabIndex = 3;
            this.btnDetalhesFuncionario.Text = "Detalhes";
            this.btnDetalhesFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Location = new System.Drawing.Point(221, 36);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFuncionario.TabIndex = 4;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(302, 36);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 5;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(16, 65);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(509, 287);
            this.dgvFuncionario.TabIndex = 6;
            // 
            // FormFuncionarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 364);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Controls.Add(this.btnDetalhesFuncionario);
            this.Controls.Add(this.btnAdicionarFuncionario);
            this.Controls.Add(this.txtBuscarFuncionario);
            this.Controls.Add(this.lblBuscarFuncionario);
            this.Name = "FormFuncionarioListar";
            this.Text = "FormFuncionarioListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarFuncionario;
        private System.Windows.Forms.TextBox txtBuscarFuncionario;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
        private System.Windows.Forms.Button btnDetalhesFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
    }
}