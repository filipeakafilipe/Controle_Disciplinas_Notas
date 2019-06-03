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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlunos = new System.Windows.Forms.ComboBox();
            this.lblSelecionar = new System.Windows.Forms.Button();
            this.cmbSelecionarGrafico = new System.Windows.Forms.ComboBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.btnSelecionarDisciplina = new System.Windows.Forms.Button();
            this.btnSelecionarGrafico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelecionarGrafico = new System.Windows.Forms.Label();
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
            this.grfCartesiano = new LiveCharts.WinForms.CartesianChart();
            this.grfPizza = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ControleAluno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(28, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adicionar foto do aluno em baixo";
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
            // lblSelecionar
            // 
            this.lblSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelecionar.ForeColor = System.Drawing.Color.White;
            this.lblSelecionar.Location = new System.Drawing.Point(164, 55);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(75, 23);
            this.lblSelecionar.TabIndex = 4;
            this.lblSelecionar.Text = "Selecionar";
            this.lblSelecionar.UseVisualStyleBackColor = false;
            this.lblSelecionar.Click += new System.EventHandler(this.LblSelecionar_Click);
            // 
            // cmbSelecionarGrafico
            // 
            this.cmbSelecionarGrafico.FormattingEnabled = true;
            this.cmbSelecionarGrafico.Location = new System.Drawing.Point(791, 57);
            this.cmbSelecionarGrafico.Name = "cmbSelecionarGrafico";
            this.cmbSelecionarGrafico.Size = new System.Drawing.Size(121, 21);
            this.cmbSelecionarGrafico.TabIndex = 5;
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
            // btnSelecionarGrafico
            // 
            this.btnSelecionarGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelecionarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarGrafico.Location = new System.Drawing.Point(918, 55);
            this.btnSelecionarGrafico.Name = "btnSelecionarGrafico";
            this.btnSelecionarGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarGrafico.TabIndex = 8;
            this.btnSelecionarGrafico.Text = "Selecionar";
            this.btnSelecionarGrafico.UseVisualStyleBackColor = false;
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
            // lblSelecionarGrafico
            // 
            this.lblSelecionarGrafico.AutoSize = true;
            this.lblSelecionarGrafico.ForeColor = System.Drawing.Color.White;
            this.lblSelecionarGrafico.Location = new System.Drawing.Point(788, 41);
            this.lblSelecionarGrafico.Name = "lblSelecionarGrafico";
            this.lblSelecionarGrafico.Size = new System.Drawing.Size(78, 13);
            this.lblSelecionarGrafico.TabIndex = 10;
            this.lblSelecionarGrafico.Text = "Tipo de gráfico";
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
            this.label4.Location = new System.Drawing.Point(28, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(28, 317);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Trocar pro nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Idade";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(28, 354);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(85, 13);
            this.lblIdade.TabIndex = 16;
            this.lblIdade.Text = "Trocar pra idade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefone";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(28, 400);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(97, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Trocar pro telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ano (série):";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(28, 445);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(38, 13);
            this.lblAno.TabIndex = 21;
            this.lblAno.Text = "Nome:";
            // 
            // grfCartesiano
            // 
            this.grfCartesiano.Location = new System.Drawing.Point(744, 108);
            this.grfCartesiano.Name = "grfCartesiano";
            this.grfCartesiano.Size = new System.Drawing.Size(308, 213);
            this.grfCartesiano.TabIndex = 22;
            this.grfCartesiano.Text = "cartesianChart1";
            // 
            // grfPizza
            // 
            this.grfPizza.Location = new System.Drawing.Point(791, 327);
            this.grfPizza.Name = "grfPizza";
            this.grfPizza.Size = new System.Drawing.Size(227, 173);
            this.grfPizza.TabIndex = 23;
            this.grfPizza.Text = "pieChart1";
            // 
            // ControleAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grfPizza);
            this.Controls.Add(this.grfCartesiano);
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
            this.Controls.Add(this.lblSelecionarGrafico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarGrafico);
            this.Controls.Add(this.btnSelecionarDisciplina);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.cmbSelecionarGrafico);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.cmbAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ControleAluno";
            this.Size = new System.Drawing.Size(1079, 614);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlunos;
        private System.Windows.Forms.Button lblSelecionar;
        private System.Windows.Forms.ComboBox cmbSelecionarGrafico;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button btnSelecionarDisciplina;
        private System.Windows.Forms.Button btnSelecionarGrafico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelecionarGrafico;
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
        private LiveCharts.WinForms.CartesianChart grfCartesiano;
        private LiveCharts.WinForms.PieChart grfPizza;
    }
}
