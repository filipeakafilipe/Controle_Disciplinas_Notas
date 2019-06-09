namespace Controle_Disciplinas_Notas
{
    partial class ControleAluno
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAlunos = new System.Windows.Forms.ComboBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.btnSelecionarDisciplina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDiscNotas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.grfPizza = new LiveCharts.WinForms.PieChart();
            this.lblCodigoAluno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAlunos
            // 
            this.cmbAlunos.FormattingEnabled = true;
            this.cmbAlunos.Location = new System.Drawing.Point(28, 55);
            this.cmbAlunos.Name = "cmbAlunos";
            this.cmbAlunos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlunos.TabIndex = 3;
            this.cmbAlunos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbAlunos_MouseUp);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(164, 55);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(256, 55);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplinas.TabIndex = 6;
            this.cmbDisciplinas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmbDisciplinas_MouseUp);
            // 
            // btnSelecionarDisciplina
            // 
            this.btnSelecionarDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelecionarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarDisciplina.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarDisciplina.Location = new System.Drawing.Point(383, 53);
            this.btnSelecionarDisciplina.Name = "btnSelecionarDisciplina";
            this.btnSelecionarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarDisciplina.TabIndex = 7;
            this.btnSelecionarDisciplina.Text = "Selecionar";
            this.btnSelecionarDisciplina.UseVisualStyleBackColor = false;
            this.btnSelecionarDisciplina.Click += new System.EventHandler(this.BtnSelecionarDisciplina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de alunos (ID-Nome)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Disciplina";
            // 
            // dgvDiscNotas
            // 
            this.dgvDiscNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscNotas.Location = new System.Drawing.Point(256, 108);
            this.dgvDiscNotas.Name = "dgvDiscNotas";
            this.dgvDiscNotas.Size = new System.Drawing.Size(445, 405);
            this.dgvDiscNotas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(28, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(28, 212);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 16;
            this.lblIdade.Text = "Idade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefone:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(28, 258);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ano (série):";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(28, 303);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 21;
            this.lblAno.Text = "Ano";
            // 
            // grfPizza
            // 
            this.grfPizza.Location = new System.Drawing.Point(761, 189);
            this.grfPizza.Name = "grfPizza";
            this.grfPizza.Size = new System.Drawing.Size(292, 238);
            this.grfPizza.TabIndex = 23;
            this.grfPizza.Text = "pieChart1";
            // 
            // lblCodigoAluno
            // 
            this.lblCodigoAluno.AutoSize = true;
            this.lblCodigoAluno.ForeColor = System.Drawing.Color.White;
            this.lblCodigoAluno.Location = new System.Drawing.Point(28, 117);
            this.lblCodigoAluno.Name = "lblCodigoAluno";
            this.lblCodigoAluno.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoAluno.TabIndex = 24;
            this.lblCodigoAluno.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(28, 130);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // ControleAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCodigoAluno);
            this.Controls.Add(this.grfPizza);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDiscNotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarDisciplina);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.cmbAlunos);
            this.Name = "ControleAluno";
            this.Size = new System.Drawing.Size(1079, 614);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbAlunos;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button btnSelecionarDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDiscNotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAno;
        private LiveCharts.WinForms.PieChart grfPizza;
        private System.Windows.Forms.Label lblCodigoAluno;
        private System.Windows.Forms.Label lblCodigo;
    }
}
