namespace Controle_Disciplinas_Notas
{
    partial class ControleAlterar
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
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnAlterarDisciplina = new System.Windows.Forms.Button();
            this.controleAlterarAluno1 = new Controle_Disciplinas_Notas.ControleAlterarAluno();
            this.controleAlterarDisciplina1 = new Controle_Disciplinas_Notas.ControleAlterarDisciplina();
            this.controleAlterarInicio1 = new Controle_Disciplinas_Notas.ControleAlterarInicio();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar";
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlterarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarAluno.ForeColor = System.Drawing.Color.White;
            this.btnAlterarAluno.Location = new System.Drawing.Point(14, 66);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 4;
            this.btnAlterarAluno.Text = "Aluno";
            this.btnAlterarAluno.UseVisualStyleBackColor = false;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnAlterarDisciplina
            // 
            this.btnAlterarDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlterarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDisciplina.ForeColor = System.Drawing.Color.White;
            this.btnAlterarDisciplina.Location = new System.Drawing.Point(95, 66);
            this.btnAlterarDisciplina.Name = "btnAlterarDisciplina";
            this.btnAlterarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDisciplina.TabIndex = 5;
            this.btnAlterarDisciplina.Text = "Disciplina";
            this.btnAlterarDisciplina.UseVisualStyleBackColor = false;
            this.btnAlterarDisciplina.Click += new System.EventHandler(this.btnAlterarDisciplina_Click);
            // 
            // controleAlterarAluno1
            // 
            this.controleAlterarAluno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleAlterarAluno1.ForeColor = System.Drawing.Color.White;
            this.controleAlterarAluno1.Location = new System.Drawing.Point(0, 114);
            this.controleAlterarAluno1.Name = "controleAlterarAluno1";
            this.controleAlterarAluno1.Size = new System.Drawing.Size(1082, 500);
            this.controleAlterarAluno1.TabIndex = 6;
            // 
            // controleAlterarDisciplina1
            // 
            this.controleAlterarDisciplina1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleAlterarDisciplina1.Location = new System.Drawing.Point(0, 114);
            this.controleAlterarDisciplina1.Name = "controleAlterarDisciplina1";
            this.controleAlterarDisciplina1.Size = new System.Drawing.Size(1082, 500);
            this.controleAlterarDisciplina1.TabIndex = 7;
            // 
            // controleAlterarInicio1
            // 
            this.controleAlterarInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleAlterarInicio1.Location = new System.Drawing.Point(0, 114);
            this.controleAlterarInicio1.Name = "controleAlterarInicio1";
            this.controleAlterarInicio1.Size = new System.Drawing.Size(1082, 500);
            this.controleAlterarInicio1.TabIndex = 8;
            // 
            // ControleAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.controleAlterarInicio1);
            this.Controls.Add(this.controleAlterarDisciplina1);
            this.Controls.Add(this.controleAlterarAluno1);
            this.Controls.Add(this.btnAlterarDisciplina);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.label1);
            this.Name = "ControleAlterar";
            this.Size = new System.Drawing.Size(1079, 614);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnAlterarDisciplina;
        private ControleAlterarAluno controleAlterarAluno1;
        private ControleAlterarDisciplina controleAlterarDisciplina1;
        private ControleAlterarInicio controleAlterarInicio1;
    }
}
