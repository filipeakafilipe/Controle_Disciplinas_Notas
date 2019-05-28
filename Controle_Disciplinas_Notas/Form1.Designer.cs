namespace Controle_Disciplinas_Notas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.controleInicio1 = new Controle_Disciplinas_Notas.ControleInicio();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAluno);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar Expandir Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 46);
            this.panel2.TabIndex = 2;
            // 
            // btnAluno
            // 
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAluno.Image")));
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(15, 184);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(131, 46);
            this.btnAluno.TabIndex = 5;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.BtnAluno_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(15, 138);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(131, 46);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(15, 92);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(131, 46);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(15, 46);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(131, 46);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(146, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 21);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // controleInicio1
            // 
            this.controleInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.controleInicio1.Location = new System.Drawing.Point(146, 12);
            this.controleInicio1.Name = "controleInicio1";
            this.controleInicio1.Size = new System.Drawing.Size(654, 438);
            this.controleInicio1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controleInicio1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private ControleInicio controleInicio1;
    }
}

