namespace ControleEstacionamento.Visao.Veiculo
{
    partial class FormVeiculoListar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarFuncionario
            // 
            this.lblBuscarFuncionario.AutoSize = true;
            this.lblBuscarFuncionario.Location = new System.Drawing.Point(16, 24);
            this.lblBuscarFuncionario.Name = "lblBuscarFuncionario";
            this.lblBuscarFuncionario.Size = new System.Drawing.Size(40, 13);
            this.lblBuscarFuncionario.TabIndex = 0;
            this.lblBuscarFuncionario.Text = "Buscar";
            // 
            // txtBuscarFuncionario
            // 
            this.txtBuscarFuncionario.Location = new System.Drawing.Point(62, 21);
            this.txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            this.txtBuscarFuncionario.Size = new System.Drawing.Size(466, 20);
            this.txtBuscarFuncionario.TabIndex = 1;
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarFuncionario.TabIndex = 2;
            this.btnAdicionarFuncionario.Text = "Adicionar";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            this.btnAdicionarFuncionario.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDetalhesFuncionario
            // 
            this.btnDetalhesFuncionario.Location = new System.Drawing.Point(93, 12);
            this.btnDetalhesFuncionario.Name = "btnDetalhesFuncionario";
            this.btnDetalhesFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhesFuncionario.TabIndex = 3;
            this.btnDetalhesFuncionario.Text = "Detalhes";
            this.btnDetalhesFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Location = new System.Drawing.Point(174, 12);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFuncionario.TabIndex = 4;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(255, 12);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 5;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(867, 432);
            this.dgvFuncionario.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFuncionario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 432);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdicionarFuncionario);
            this.panel2.Controls.Add(this.btnDetalhesFuncionario);
            this.panel2.Controls.Add(this.btnExcluirFuncionario);
            this.panel2.Controls.Add(this.btnEditarFuncionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 48);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtBuscarFuncionario);
            this.panel3.Controls.Add(this.lblBuscarFuncionario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 60);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormVeiculoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormVeiculoListar";
            this.Text = "Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarFuncionario;
        private System.Windows.Forms.TextBox txtBuscarFuncionario;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
        private System.Windows.Forms.Button btnDetalhesFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}