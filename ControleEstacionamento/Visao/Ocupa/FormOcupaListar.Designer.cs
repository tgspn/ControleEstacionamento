namespace ControleEstacionamento.Visao.Ocupa
{
    partial class FormOcupaListar
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.vaga11 = new ControleEstacionamento.ucVagasItem();
            this.vaga10 = new ControleEstacionamento.ucVagasItem();
            this.vaga9 = new ControleEstacionamento.ucVagasItem();
            this.vaga8 = new ControleEstacionamento.ucVagasItem();
            this.vaga7 = new ControleEstacionamento.ucVagasItem();
            this.vaga6 = new ControleEstacionamento.ucVagasItem();
            this.vaga5 = new ControleEstacionamento.ucVagasItem();
            this.vaga4 = new ControleEstacionamento.ucVagasItem();
            this.vaga3 = new ControleEstacionamento.ucVagasItem();
            this.vaga2 = new ControleEstacionamento.ucVagasItem();
            this.vaga1 = new ControleEstacionamento.ucVagasItem();
            this.ucVagas1 = new ControleEstacionamento.ucVagas();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.vaga11);
            this.panel1.Controls.Add(this.vaga10);
            this.panel1.Controls.Add(this.vaga9);
            this.panel1.Controls.Add(this.vaga8);
            this.panel1.Controls.Add(this.vaga7);
            this.panel1.Controls.Add(this.vaga6);
            this.panel1.Controls.Add(this.vaga5);
            this.panel1.Controls.Add(this.vaga4);
            this.panel1.Controls.Add(this.vaga3);
            this.panel1.Controls.Add(this.vaga2);
            this.panel1.Controls.Add(this.vaga1);
            this.panel1.Controls.Add(this.ucVagas1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 604);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleEstacionamento.Properties.Resources.num1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 604);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 48);
            this.panel2.TabIndex = 8;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(701, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // vaga11
            // 
            this.vaga11.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga11.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga11.Location = new System.Drawing.Point(63, 390);
            this.vaga11.Name = "vaga11";
            this.vaga11.NumeroVaga = null;
            this.vaga11.Size = new System.Drawing.Size(95, 140);
            this.vaga11.TabIndex = 11;
            this.vaga11.Vaga = null;
            this.vaga11.Veiculo = null;
            this.vaga11.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga10
            // 
            this.vaga10.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga10.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga10.Location = new System.Drawing.Point(183, 390);
            this.vaga10.Name = "vaga10";
            this.vaga10.NumeroVaga = null;
            this.vaga10.Size = new System.Drawing.Size(95, 140);
            this.vaga10.TabIndex = 10;
            this.vaga10.Vaga = null;
            this.vaga10.Veiculo = null;
            this.vaga10.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga9
            // 
            this.vaga9.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga9.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga9.Location = new System.Drawing.Point(303, 390);
            this.vaga9.Name = "vaga9";
            this.vaga9.NumeroVaga = null;
            this.vaga9.Size = new System.Drawing.Size(95, 140);
            this.vaga9.TabIndex = 9;
            this.vaga9.Vaga = null;
            this.vaga9.Veiculo = null;
            this.vaga9.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga8
            // 
            this.vaga8.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga8.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga8.Location = new System.Drawing.Point(423, 390);
            this.vaga8.Name = "vaga8";
            this.vaga8.NumeroVaga = null;
            this.vaga8.Size = new System.Drawing.Size(95, 140);
            this.vaga8.TabIndex = 8;
            this.vaga8.Vaga = null;
            this.vaga8.Veiculo = null;
            this.vaga8.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga7
            // 
            this.vaga7.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga7.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga7.Location = new System.Drawing.Point(543, 390);
            this.vaga7.Name = "vaga7";
            this.vaga7.NumeroVaga = null;
            this.vaga7.Size = new System.Drawing.Size(95, 140);
            this.vaga7.TabIndex = 7;
            this.vaga7.Vaga = null;
            this.vaga7.Veiculo = null;
            this.vaga7.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga6
            // 
            this.vaga6.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga6.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga6.Location = new System.Drawing.Point(639, 222);
            this.vaga6.Name = "vaga6";
            this.vaga6.NumeroVaga = null;
            this.vaga6.Size = new System.Drawing.Size(140, 95);
            this.vaga6.TabIndex = 6;
            this.vaga6.Vaga = null;
            this.vaga6.Veiculo = null;
            this.vaga6.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga5
            // 
            this.vaga5.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga5.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga5.Location = new System.Drawing.Point(542, 12);
            this.vaga5.Name = "vaga5";
            this.vaga5.NumeroVaga = null;
            this.vaga5.Size = new System.Drawing.Size(95, 140);
            this.vaga5.TabIndex = 5;
            this.vaga5.Vaga = null;
            this.vaga5.Veiculo = null;
            this.vaga5.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga4
            // 
            this.vaga4.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga4.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga4.Location = new System.Drawing.Point(423, 12);
            this.vaga4.Name = "vaga4";
            this.vaga4.NumeroVaga = null;
            this.vaga4.Size = new System.Drawing.Size(95, 140);
            this.vaga4.TabIndex = 4;
            this.vaga4.Vaga = null;
            this.vaga4.Veiculo = null;
            this.vaga4.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga3
            // 
            this.vaga3.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga3.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga3.Location = new System.Drawing.Point(303, 12);
            this.vaga3.Name = "vaga3";
            this.vaga3.NumeroVaga = null;
            this.vaga3.Size = new System.Drawing.Size(95, 140);
            this.vaga3.TabIndex = 3;
            this.vaga3.Vaga = null;
            this.vaga3.Veiculo = null;
            this.vaga3.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga2
            // 
            this.vaga2.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga2.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga2.Location = new System.Drawing.Point(183, 12);
            this.vaga2.Name = "vaga2";
            this.vaga2.NumeroVaga = null;
            this.vaga2.Size = new System.Drawing.Size(95, 140);
            this.vaga2.TabIndex = 2;
            this.vaga2.Vaga = null;
            this.vaga2.Veiculo = null;
            this.vaga2.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // vaga1
            // 
            this.vaga1.CorLivre = System.Drawing.Color.LimeGreen;
            this.vaga1.CorOcupado = System.Drawing.Color.Salmon;
            this.vaga1.Location = new System.Drawing.Point(63, 12);
            this.vaga1.Name = "vaga1";
            this.vaga1.NumeroVaga = null;
            this.vaga1.Size = new System.Drawing.Size(95, 140);
            this.vaga1.TabIndex = 1;
            this.vaga1.Vaga = null;
            this.vaga1.Veiculo = null;
            this.vaga1.Click += new System.EventHandler(this.vaga1_Click);
            // 
            // ucVagas1
            // 
            this.ucVagas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVagas1.Location = new System.Drawing.Point(0, 0);
            this.ucVagas1.Name = "ucVagas1";
            this.ucVagas1.Size = new System.Drawing.Size(788, 604);
            this.ucVagas1.TabIndex = 3;
            this.ucVagas1.Load += new System.EventHandler(this.ucVagas1_Load);
            this.ucVagas1.Click += new System.EventHandler(this.panel3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOcupaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(804, 643);
            this.MinimumSize = new System.Drawing.Size(804, 643);
            this.Name = "FormOcupaListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Vagas";
            this.Load += new System.EventHandler(this.FormOcupaListar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ucVagas ucVagas1;
        private ucVagasItem vaga6;
        private ucVagasItem vaga11;
        private ucVagasItem vaga10;
        private ucVagasItem vaga9;
        private ucVagasItem vaga8;
        private ucVagasItem vaga7;
        private ucVagasItem vaga5;
        private ucVagasItem vaga4;
        private ucVagasItem vaga3;
        private ucVagasItem vaga2;
        private ucVagasItem vaga1;
        private System.Windows.Forms.Button button1;
    }
}