namespace Controle_Disciplinas_Notas
{
    partial class ControleCadastro
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
            this.btnCadastroAluno = new System.Windows.Forms.Button();
            this.btnCadastroDisciplina = new System.Windows.Forms.Button();
            this.controleCadastroDisciplina1 = new Controle_Disciplinas_Notas.ControleCadastroDisciplina();
            this.controleCadastroAluno1 = new Controle_Disciplinas_Notas.ControleCadastroAluno();
            this.controleCadastroInicio1 = new Controle_Disciplinas_Notas.ControleCadastroInicio();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ControleCadastro";
            // 
            // btnCadastroAluno
            // 
            this.btnCadastroAluno.Location = new System.Drawing.Point(526, 66);
            this.btnCadastroAluno.Name = "btnCadastroAluno";
            this.btnCadastroAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroAluno.TabIndex = 3;
            this.btnCadastroAluno.Text = "Aluno";
            this.btnCadastroAluno.UseVisualStyleBackColor = true;
            this.btnCadastroAluno.Click += new System.EventHandler(this.BtnCadastroAluno_Click);
            // 
            // btnCadastroDisciplina
            // 
            this.btnCadastroDisciplina.Location = new System.Drawing.Point(670, 66);
            this.btnCadastroDisciplina.Name = "btnCadastroDisciplina";
            this.btnCadastroDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroDisciplina.TabIndex = 4;
            this.btnCadastroDisciplina.Text = "Disciplina";
            this.btnCadastroDisciplina.UseVisualStyleBackColor = true;
            this.btnCadastroDisciplina.Click += new System.EventHandler(this.BtnCadastroDisciplina_Click);
            // 
            // controleCadastroDisciplina1
            // 
            this.controleCadastroDisciplina1.BackColor = System.Drawing.Color.Coral;
            this.controleCadastroDisciplina1.Location = new System.Drawing.Point(0, 114);
            this.controleCadastroDisciplina1.Name = "controleCadastroDisciplina1";
            this.controleCadastroDisciplina1.Size = new System.Drawing.Size(1082, 500);
            this.controleCadastroDisciplina1.TabIndex = 2;
            // 
            // controleCadastroAluno1
            // 
            this.controleCadastroAluno1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.controleCadastroAluno1.Location = new System.Drawing.Point(0, 114);
            this.controleCadastroAluno1.Name = "controleCadastroAluno1";
            this.controleCadastroAluno1.Size = new System.Drawing.Size(1082, 500);
            this.controleCadastroAluno1.TabIndex = 1;
            // 
            // controleCadastroInicio1
            // 
            this.controleCadastroInicio1.BackColor = System.Drawing.Color.Olive;
            this.controleCadastroInicio1.Location = new System.Drawing.Point(-3, 114);
            this.controleCadastroInicio1.Name = "controleCadastroInicio1";
            this.controleCadastroInicio1.Size = new System.Drawing.Size(1082, 500);
            this.controleCadastroInicio1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro/Alteração";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControleCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controleCadastroInicio1);
            this.Controls.Add(this.btnCadastroDisciplina);
            this.Controls.Add(this.btnCadastroAluno);
            this.Controls.Add(this.controleCadastroDisciplina1);
            this.Controls.Add(this.controleCadastroAluno1);
            this.Controls.Add(this.label1);
            this.Name = "ControleCadastro";
            this.Size = new System.Drawing.Size(1079, 614);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ControleCadastroAluno controleCadastroAluno1;
        private ControleCadastroDisciplina controleCadastroDisciplina1;
        private System.Windows.Forms.Button btnCadastroAluno;
        private System.Windows.Forms.Button btnCadastroDisciplina;
        private ControleCadastroInicio controleCadastroInicio1;
        private System.Windows.Forms.Label label2;
    }
}
