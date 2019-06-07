using System;
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

            List<string> discs = discop.ProcuraDisciplina(new Disciplina());

            foreach (string nomeDisc in discs)
            {
                cmbSelecionarDisciplina.Items.Add(nomeDisc);
            }
        }

        private void cmbSelecionarAtividade_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Atividade

            DisciplinaOp discop = new DisciplinaOp();

            cmbSelecionarAtividade.Items.Clear();

            string nomeDisc = cmbSelecionarDisciplina.Text;

            List<string> atividades = discop.ProcuraAtividade(new Disciplina(), nomeDisc);

            foreach (string nomeAtividade in atividades)
            {
                cmbSelecionarAtividade.Items.Add(nomeAtividade);
            }
        }

        private void BtnExcluirDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            string nomeDisc = cmbSelecionarDisciplina.Text;

            discop.ExcluirDisciplina(nomeDisc);
        }

        private void BtnExcluirAtividade_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            string nomeDisc = cmbSelecionarDisciplina.Text;
            string nomeAtividade = cmbSelecionarAtividade.Text;

            discop.ExcluirAtividade(nomeDisc, nomeAtividade);
        }

        private void BtnAlterarDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            string nomeDisc = cmbSelecionarDisciplina.Text;
            string nomeDiscNovo = txtNomeDisc.Text;
            string nomeProfessor = txtNomeProf.Text;

            discop.AlterarDisciplina(nomeDisc, nomeDiscNovo, nomeProfessor);
        }

        private void BtnAlterarAtividade_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            string nomeDisc = cmbSelecionarDisciplina.Text;
            string nomeAtividade = cmbSelecionarAtividade.Text;
            string nomeAtividadeNovo = txtNomeAtividade.Text;
            string nota = txtNota.Text;

            discop.AlterarAtividade(nomeDisc, nomeAtividade, nomeAtividadeNovo, nota);
        }
    }
}
