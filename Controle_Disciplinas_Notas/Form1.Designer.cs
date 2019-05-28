﻿namespace Controle_Disciplinas_Notas
{
    partial class PainelConteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelConteudo));
            this.PainelLado = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PainelLadoVerde = new System.Windows.Forms.Panel();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PainelCima = new System.Windows.Forms.FlowLayoutPanel();
            this.controleAluno1 = new Controle_Disciplinas_Notas.ControleAluno();
            this.controleListar1 = new Controle_Disciplinas_Notas.ControleListar();
            this.controleCadastro1 = new Controle_Disciplinas_Notas.ControleCadastro();
            this.controleInicio1 = new Controle_Disciplinas_Notas.ControleInicio();
            this.PainelLado.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelLado
            // 
            this.PainelLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PainelLado.Controls.Add(this.button1);
            this.PainelLado.Controls.Add(this.PainelLadoVerde);
            this.PainelLado.Controls.Add(this.btnAluno);
            this.PainelLado.Controls.Add(this.btnListar);
            this.PainelLado.Controls.Add(this.btnCadastro);
            this.PainelLado.Controls.Add(this.btnInicio);
            this.PainelLado.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelLado.Location = new System.Drawing.Point(0, 0);
            this.PainelLado.Name = "PainelLado";
            this.PainelLado.Size = new System.Drawing.Size(146, 626);
            this.PainelLado.TabIndex = 0;
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
            // PainelLadoVerde
            // 
            this.PainelLadoVerde.BackColor = System.Drawing.Color.Teal;
            this.PainelLadoVerde.Location = new System.Drawing.Point(0, 46);
            this.PainelLadoVerde.Name = "PainelLadoVerde";
            this.PainelLadoVerde.Size = new System.Drawing.Size(15, 46);
            this.PainelLadoVerde.TabIndex = 2;
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
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
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
            // PainelCima
            // 
            this.PainelCima.BackColor = System.Drawing.Color.Teal;
            this.PainelCima.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelCima.Location = new System.Drawing.Point(146, 0);
            this.PainelCima.Name = "PainelCima";
            this.PainelCima.Size = new System.Drawing.Size(1079, 21);
            this.PainelCima.TabIndex = 1;
            // 
            // controleAluno1
            // 
            this.controleAluno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.controleAluno1.Location = new System.Drawing.Point(146, 12);
            this.controleAluno1.Name = "controleAluno1";
            this.controleAluno1.Size = new System.Drawing.Size(1079, 614);
            this.controleAluno1.TabIndex = 5;
            // 
            // controleListar1
            // 
            this.controleListar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.controleListar1.Location = new System.Drawing.Point(146, 12);
            this.controleListar1.Name = "controleListar1";
            this.controleListar1.Size = new System.Drawing.Size(1079, 614);
            this.controleListar1.TabIndex = 4;
            // 
            // controleCadastro1
            // 
            this.controleCadastro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.controleCadastro1.Location = new System.Drawing.Point(146, 12);
            this.controleCadastro1.Name = "controleCadastro1";
            this.controleCadastro1.Size = new System.Drawing.Size(1079, 614);
            this.controleCadastro1.TabIndex = 3;
            // 
            // controleInicio1
            // 
            this.controleInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.controleInicio1.Location = new System.Drawing.Point(146, 12);
            this.controleInicio1.Name = "controleInicio1";
            this.controleInicio1.Size = new System.Drawing.Size(1079, 614);
            this.controleInicio1.TabIndex = 2;
            // 
            // PainelConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1225, 626);
            this.Controls.Add(this.controleAluno1);
            this.Controls.Add(this.controleListar1);
            this.Controls.Add(this.controleCadastro1);
            this.Controls.Add(this.controleInicio1);
            this.Controls.Add(this.PainelCima);
            this.Controls.Add(this.PainelLado);
            this.Name = "PainelConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PainelLado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelLado;
        private System.Windows.Forms.FlowLayoutPanel PainelCima;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel PainelLadoVerde;
        private System.Windows.Forms.Button button1;
        private ControleInicio controleInicio1;
        private ControleCadastro controleCadastro1;
        private ControleListar controleListar1;
        private ControleAluno controleAluno1;
    }
}

