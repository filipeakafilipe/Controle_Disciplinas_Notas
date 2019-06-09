namespace Controle_Disciplinas_Notas
{
    partial class ControleListar
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
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.btnListarDisciplinas = new System.Windows.Forms.Button();
            this.controleListarDisciplinas1 = new Controle_Disciplinas_Notas.ControleListarDisciplinas();
            this.controleListarInicio1 = new Controle_Disciplinas_Notas.ControleListarInicio();
            this.controleListarAlunos1 = new Controle_Disciplinas_Notas.ControleListarAlunos();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar";
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAlunos.ForeColor = System.Drawing.Color.White;
            this.btnListarAlunos.Location = new System.Drawing.Point(14, 66);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnListarAlunos.TabIndex = 1;
            this.btnListarAlunos.Text = "Alunos";
            this.btnListarAlunos.UseVisualStyleBackColor = false;
            this.btnListarAlunos.Click += new System.EventHandler(this.BtnListarAlunos_Click);
            // 
            // btnListarDisciplinas
            // 
            this.btnListarDisciplinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListarDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarDisciplinas.ForeColor = System.Drawing.Color.White;
            this.btnListarDisciplinas.Location = new System.Drawing.Point(95, 66);
            this.btnListarDisciplinas.Name = "btnListarDisciplinas";
            this.btnListarDisciplinas.Size = new System.Drawing.Size(75, 23);
            this.btnListarDisciplinas.TabIndex = 2;
            this.btnListarDisciplinas.Text = "Disciplinas";
            this.btnListarDisciplinas.UseVisualStyleBackColor = false;
            this.btnListarDisciplinas.Click += new System.EventHandler(this.BtnListarDisciplinas_Click);
            // 
            // controleListarDisciplinas1
            // 
            this.controleListarDisciplinas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleListarDisciplinas1.ForeColor = System.Drawing.Color.White;
            this.controleListarDisciplinas1.Location = new System.Drawing.Point(0, 114);
            this.controleListarDisciplinas1.Name = "controleListarDisciplinas1";
            this.controleListarDisciplinas1.Size = new System.Drawing.Size(1082, 500);
            this.controleListarDisciplinas1.TabIndex = 4;
            // 
            // controleListarInicio1
            // 
            this.controleListarInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleListarInicio1.Location = new System.Drawing.Point(0, 114);
            this.controleListarInicio1.Name = "controleListarInicio1";
            this.controleListarInicio1.Size = new System.Drawing.Size(1082, 500);
            this.controleListarInicio1.TabIndex = 5;
            // 
            // controleListarAlunos1
            // 
            this.controleListarAlunos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controleListarAlunos1.Location = new System.Drawing.Point(0, 114);
            this.controleListarAlunos1.Name = "controleListarAlunos1";
            this.controleListarAlunos1.Size = new System.Drawing.Size(1082, 500);
            this.controleListarAlunos1.TabIndex = 6;
            // 
            // ControleListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.controleListarAlunos1);
            this.Controls.Add(this.controleListarInicio1);
            this.Controls.Add(this.controleListarDisciplinas1);
            this.Controls.Add(this.btnListarDisciplinas);
            this.Controls.Add(this.btnListarAlunos);
            this.Controls.Add(this.label1);
            this.Name = "ControleListar";
            this.Size = new System.Drawing.Size(1079, 614);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.Button btnListarDisciplinas;
        private ControleListarDisciplinas controleListarDisciplinas1;
        private ControleListarInicio controleListarInicio1;
        private ControleListarAlunos controleListarAlunos1;
    }
}
