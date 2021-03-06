﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Disciplinas_Notas
{
    public partial class ControleAlterarDisciplina : UserControl
    {
        public ControleAlterarDisciplina()
        {
            InitializeComponent();
        }

        private void cmbSelecionarDisciplina_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Disciplina

            DisciplinaOp discop = new DisciplinaOp();

            cmbSelecionarDisciplina.Items.Clear();

            try
            {
                List<string> discs = discop.ProcuraDisciplina();

                foreach (string nomeDisc in discs)
                {
                    cmbSelecionarDisciplina.Items.Add(nomeDisc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void cmbSelecionarAtividade_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Atividade

            DisciplinaOp discop = new DisciplinaOp();

            cmbSelecionarAtividade.Items.Clear();

            try
            {

                string nomeDisc = cmbSelecionarDisciplina.Text.Substring(0, 7);

                List<string> atividades = discop.ProcuraAtividade(nomeDisc);

                foreach (string nomeAtividade in atividades)
                {
                    cmbSelecionarAtividade.Items.Add(nomeAtividade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnExcluirDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            try
            {
                string nomeDisc = cmbSelecionarDisciplina.Text.Substring(0, 7);

                discop.ExcluirDisciplina(nomeDisc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnExcluirAtividade_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            try
            {
                string nomeDisc = cmbSelecionarDisciplina.Text.Substring(0, 7);
                string nomeAtividade = cmbSelecionarAtividade.Text;

                discop.ExcluirAtividade(nomeDisc, nomeAtividade);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnAlterarDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            try
            {
                string nomeDisc = cmbSelecionarDisciplina.Text.Substring(0, 7);
                string nomeDiscNovo = txtNomeDisc.Text;
                string nomeProfessor = txtNomeProf.Text;

                discop.AlterarDisciplina(nomeDisc, nomeDiscNovo, nomeProfessor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnAlterarAtividade_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            try
            {
                string nomeDisc = cmbSelecionarDisciplina.Text.Substring(0, 7);
                string nomeAtividade = cmbSelecionarAtividade.Text;
                string nomeAtividadeNovo = txtNomeAtividade.Text;
                string nota = txtNota.Text;

                discop.AlterarAtividade(nomeDisc, nomeAtividade, nomeAtividadeNovo, nota);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }
    }
}
