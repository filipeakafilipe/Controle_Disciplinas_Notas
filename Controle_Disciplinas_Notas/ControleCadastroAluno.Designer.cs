namespace Controle_Disciplinas_Notas
{
    partial class ControleCadastroAluno
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
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblNomeCadAl = new System.Windows.Forms.Label();
            this.lblDisciplinaCadAl = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.cmbAtividadeCadAl = new System.Windows.Forms.Label();
            this.cmbAtividadeAluno = new System.Windows.Forms.ComboBox();
            this.lblNotaAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionarNota = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarDisciplinaAluno = new System.Windows.Forms.Button();
            this.cmbDiscAluno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Location = new System.Drawing.Point(55, 177);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAlu.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(55, 311);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(55, 243);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(55, 377);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 4;
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAdicionarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarAluno.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarAluno.Location = new System.Drawing.Point(55, 436);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAluno.TabIndex = 5;
            this.btnAdicionarAluno.Text = "Adicionar";
            this.btnAdicionarAluno.UseVisualStyleBackColor = false;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adicionar novo aluno";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(52, 161);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(52, 227);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(52, 295);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(52, 361);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano";
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(503, 177);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbAluno.TabIndex = 11;
            this.cmbAluno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbAluno_MouseUp);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(500, 126);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(75, 13);
            this.lblNota.TabIndex = 12;
            this.lblNota.Text = "Adicionar nota";
            // 
            // lblNomeCadAl
            // 
            this.lblNomeCadAl.AutoSize = true;
            this.lblNomeCadAl.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadAl.Location = new System.Drawing.Point(500, 161);
            this.lblNomeCadAl.Name = "lblNomeCadAl";
            this.lblNomeCadAl.Size = new System.Drawing.Size(34, 13);
            this.lblNomeCadAl.TabIndex = 13;
            this.lblNomeCadAl.Text = "Aluno";
            // 
            // lblDisciplinaCadAl
            // 
            this.lblDisciplinaCadAl.AutoSize = true;
            this.lblDisciplinaCadAl.ForeColor = System.Drawing.Color.White;
            this.lblDisciplinaCadAl.Location = new System.Drawing.Point(688, 161);
            this.lblDisciplinaCadAl.Name = "lblDisciplinaCadAl";
            this.lblDisciplinaCadAl.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplinaCadAl.TabIndex = 14;
            this.lblDisciplinaCadAl.Text = "Disciplina";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(691, 177);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplina.TabIndex = 15;
            this.cmbDisciplina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbDisciplina_MouseUp);
            // 
            // cmbAtividadeCadAl
            // 
            this.cmbAtividadeCadAl.AutoSize = true;
            this.cmbAtividadeCadAl.ForeColor = System.Drawing.Color.White;
            this.cmbAtividadeCadAl.Location = new System.Drawing.Point(500, 326);
            this.cmbAtividadeCadAl.Name = "cmbAtividadeCadAl";
            this.cmbAtividadeCadAl.Size = new System.Drawing.Size(51, 13);
            this.cmbAtividadeCadAl.TabIndex = 16;
            this.cmbAtividadeCadAl.Text = "Atividade";
            // 
            // cmbAtividadeAluno
            // 
            this.cmbAtividadeAluno.FormattingEnabled = true;
            this.cmbAtividadeAluno.Location = new System.Drawing.Point(503, 342);
            this.cmbAtividadeAluno.Name = "cmbAtividadeAluno";
            this.cmbAtividadeAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbAtividadeAluno.TabIndex = 17;
            this.cmbAtividadeAluno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbAtividade_MouseUp);
            // 
            // lblNotaAluno
            // 
            this.lblNotaAluno.Location = new System.Drawing.Point(503, 408);
            this.lblNotaAluno.Name = "lblNotaAluno";
            this.lblNotaAluno.Size = new System.Drawing.Size(100, 20);
            this.lblNotaAluno.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(500, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pontuação";
            // 
            // btnAdicionarNota
            // 
            this.btnAdicionarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAdicionarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNota.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarNota.Location = new System.Drawing.Point(503, 446);
            this.btnAdicionarNota.Name = "btnAdicionarNota";
            this.btnAdicionarNota.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarNota.TabIndex = 22;
            this.btnAdicionarNota.Text = "Adicionar";
            this.btnAdicionarNota.UseVisualStyleBackColor = false;
            this.btnAdicionarNota.Click += new System.EventHandler(this.btnAdicionarNota_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(637, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trocar a pontuação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(637, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor:";
            // 
            // btnAdicionarDisciplinaAluno
            // 
            this.btnAdicionarDisciplinaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAdicionarDisciplinaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDisciplinaAluno.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarDisciplinaAluno.Location = new System.Drawing.Point(818, 177);
            this.btnAdicionarDisciplinaAluno.Name = "btnAdicionarDisciplinaAluno";
            this.btnAdicionarDisciplinaAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarDisciplinaAluno.TabIndex = 25;
            this.btnAdicionarDisciplinaAluno.Text = "Adicionar";
            this.btnAdicionarDisciplinaAluno.UseVisualStyleBackColor = false;
            this.btnAdicionarDisciplinaAluno.Click += new System.EventHandler(this.BtnAdicionarDisciplinaAluno_Click);
            // 
            // cmbDiscAluno
            // 
            this.cmbDiscAluno.FormattingEnabled = true;
            this.cmbDiscAluno.Location = new System.Drawing.Point(503, 295);
            this.cmbDiscAluno.Name = "cmbDiscAluno";
            this.cmbDiscAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscAluno.TabIndex = 26;
            this.cmbDiscAluno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmbDiscAluno_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(500, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Disciplinas do aluno";
            // 
            // ControleCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDiscAluno);
            this.Controls.Add(this.btnAdicionarDisciplinaAluno);
            this.Controls.Add(this.btnAdicionarNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNotaAluno);
            this.Controls.Add(this.cmbAtividadeAluno);
            this.Controls.Add(this.cmbAtividadeCadAl);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.lblDisciplinaCadAl);
            this.Controls.Add(this.lblNomeCadAl);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeAlu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ControleCadastroAluno";
            this.Size = new System.Drawing.Size(1082, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblNomeCadAl;
        private System.Windows.Forms.Label lblDisciplinaCadAl;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label cmbAtividadeCadAl;
        private System.Windows.Forms.ComboBox cmbAtividadeAluno;
        private System.Windows.Forms.TextBox lblNotaAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionarNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarDisciplinaAluno;
        private System.Windows.Forms.ComboBox cmbDiscAluno;
        private System.Windows.Forms.Label label6;
    }
}
