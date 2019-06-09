namespace Controle_Disciplinas_Notas
{
    partial class ControleAlterarAluno
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
            this.btnAlterarNotaAluno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotaAluno = new System.Windows.Forms.TextBox();
            this.cmbAtividade = new System.Windows.Forms.ComboBox();
            this.cmbAtividadeCadAl = new System.Windows.Forms.Label();
            this.cmbDisciplinaCadAl = new System.Windows.Forms.ComboBox();
            this.lblDisciplinaCadAl = new System.Windows.Forms.Label();
            this.lblNomeCadAl = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarDadosAluno = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnExcluirDisciplinaAluno = new System.Windows.Forms.Button();
            this.btnExcluirAtividadeAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterarNotaAluno
            // 
            this.btnAlterarNotaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlterarNotaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarNotaAluno.Location = new System.Drawing.Point(472, 335);
            this.btnAlterarNotaAluno.Name = "btnAlterarNotaAluno";
            this.btnAlterarNotaAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarNotaAluno.TabIndex = 44;
            this.btnAlterarNotaAluno.Text = "Alterar";
            this.btnAlterarNotaAluno.UseVisualStyleBackColor = false;
            this.btnAlterarNotaAluno.Click += new System.EventHandler(this.BtnAlterarNotaAluno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pontuação";
            // 
            // lblNotaAluno
            // 
            this.lblNotaAluno.Location = new System.Drawing.Point(472, 276);
            this.lblNotaAluno.Name = "lblNotaAluno";
            this.lblNotaAluno.Size = new System.Drawing.Size(100, 20);
            this.lblNotaAluno.TabIndex = 40;
            // 
            // cmbAtividade
            // 
            this.cmbAtividade.FormattingEnabled = true;
            this.cmbAtividade.Location = new System.Drawing.Point(472, 210);
            this.cmbAtividade.Name = "cmbAtividade";
            this.cmbAtividade.Size = new System.Drawing.Size(121, 21);
            this.cmbAtividade.TabIndex = 39;
            this.cmbAtividade.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmbAtividade_MouseUp);
            // 
            // cmbAtividadeCadAl
            // 
            this.cmbAtividadeCadAl.AutoSize = true;
            this.cmbAtividadeCadAl.ForeColor = System.Drawing.Color.White;
            this.cmbAtividadeCadAl.Location = new System.Drawing.Point(469, 194);
            this.cmbAtividadeCadAl.Name = "cmbAtividadeCadAl";
            this.cmbAtividadeCadAl.Size = new System.Drawing.Size(51, 13);
            this.cmbAtividadeCadAl.TabIndex = 38;
            this.cmbAtividadeCadAl.Text = "Atividade";
            // 
            // cmbDisciplinaCadAl
            // 
            this.cmbDisciplinaCadAl.FormattingEnabled = true;
            this.cmbDisciplinaCadAl.Location = new System.Drawing.Point(472, 141);
            this.cmbDisciplinaCadAl.Name = "cmbDisciplinaCadAl";
            this.cmbDisciplinaCadAl.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplinaCadAl.TabIndex = 37;
            this.cmbDisciplinaCadAl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmbDisciplinaCadAl_MouseUp);
            // 
            // lblDisciplinaCadAl
            // 
            this.lblDisciplinaCadAl.AutoSize = true;
            this.lblDisciplinaCadAl.ForeColor = System.Drawing.Color.White;
            this.lblDisciplinaCadAl.Location = new System.Drawing.Point(469, 126);
            this.lblDisciplinaCadAl.Name = "lblDisciplinaCadAl";
            this.lblDisciplinaCadAl.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplinaCadAl.TabIndex = 36;
            this.lblDisciplinaCadAl.Text = "Disciplina";
            // 
            // lblNomeCadAl
            // 
            this.lblNomeCadAl.AutoSize = true;
            this.lblNomeCadAl.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadAl.Location = new System.Drawing.Point(40, 115);
            this.lblNomeCadAl.Name = "lblNomeCadAl";
            this.lblNomeCadAl.Size = new System.Drawing.Size(34, 13);
            this.lblNomeCadAl.TabIndex = 35;
            this.lblNomeCadAl.Text = "Aluno";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(469, 90);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(35, 13);
            this.lblNota.TabIndex = 34;
            this.lblNota.Text = "Notas";
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(43, 131);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbAluno.TabIndex = 33;
            this.cmbAluno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbAluno_MouseUp);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(40, 366);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 32;
            this.lblAno.Text = "Ano";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(40, 300);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 31;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(40, 232);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 30;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(40, 166);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dados";
            // 
            // btnAlterarDadosAluno
            // 
            this.btnAlterarDadosAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlterarDadosAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDadosAluno.Location = new System.Drawing.Point(43, 441);
            this.btnAlterarDadosAluno.Name = "btnAlterarDadosAluno";
            this.btnAlterarDadosAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDadosAluno.TabIndex = 27;
            this.btnAlterarDadosAluno.Text = "Alterar";
            this.btnAlterarDadosAluno.UseVisualStyleBackColor = false;
            this.btnAlterarDadosAluno.Click += new System.EventHandler(this.BtnAlterarDadosAluno_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(43, 382);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 26;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(43, 248);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 25;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(43, 316);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 182);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Aluno";
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAluno.Location = new System.Drawing.Point(170, 129);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 51;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.BtnExcluirAluno_Click);
            // 
            // btnExcluirDisciplinaAluno
            // 
            this.btnExcluirDisciplinaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExcluirDisciplinaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDisciplinaAluno.ForeColor = System.Drawing.Color.White;
            this.btnExcluirDisciplinaAluno.Location = new System.Drawing.Point(599, 141);
            this.btnExcluirDisciplinaAluno.Name = "btnExcluirDisciplinaAluno";
            this.btnExcluirDisciplinaAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDisciplinaAluno.TabIndex = 54;
            this.btnExcluirDisciplinaAluno.Text = "Excluir";
            this.btnExcluirDisciplinaAluno.UseVisualStyleBackColor = false;
            this.btnExcluirDisciplinaAluno.Click += new System.EventHandler(this.BtnExcluirDisciplinaAluno_Click);
            // 
            // btnExcluirAtividadeAluno
            // 
            this.btnExcluirAtividadeAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExcluirAtividadeAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAtividadeAluno.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAtividadeAluno.Location = new System.Drawing.Point(599, 210);
            this.btnExcluirAtividadeAluno.Name = "btnExcluirAtividadeAluno";
            this.btnExcluirAtividadeAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAtividadeAluno.TabIndex = 55;
            this.btnExcluirAtividadeAluno.Text = "Excluir";
            this.btnExcluirAtividadeAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAtividadeAluno.Click += new System.EventHandler(this.BtnExcluirAtividadeAluno_Click);
            // 
            // ControleAlterarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnExcluirAtividadeAluno);
            this.Controls.Add(this.btnExcluirDisciplinaAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarNotaAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNotaAluno);
            this.Controls.Add(this.cmbAtividade);
            this.Controls.Add(this.cmbAtividadeCadAl);
            this.Controls.Add(this.cmbDisciplinaCadAl);
            this.Controls.Add(this.lblDisciplinaCadAl);
            this.Controls.Add(this.lblNomeCadAl);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterarDadosAluno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ControleAlterarAluno";
            this.Size = new System.Drawing.Size(1082, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarNotaAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblNotaAluno;
        private System.Windows.Forms.ComboBox cmbAtividade;
        private System.Windows.Forms.Label cmbAtividadeCadAl;
        private System.Windows.Forms.ComboBox cmbDisciplinaCadAl;
        private System.Windows.Forms.Label lblDisciplinaCadAl;
        private System.Windows.Forms.Label lblNomeCadAl;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterarDadosAluno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnExcluirDisciplinaAluno;
        private System.Windows.Forms.Button btnExcluirAtividadeAluno;
    }
}
