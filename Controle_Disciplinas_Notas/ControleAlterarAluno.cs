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
    public partial class ControleAlterarAluno : UserControl
    {
        public ControleAlterarAluno()
        {
            InitializeComponent();
        }

        private void cmbAluno_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Aluno

            AlunoOp aluop = new AlunoOp();

            cmbAluno.Items.Clear();

            List<string> alunos = aluop.ProcuraAluno(new Aluno());

            foreach (string nomeAlu in alunos)
            {
                cmbAluno.Items.Add(nomeAlu);
            }
        }

        private void CmbDisciplinaCadAl_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbDisciplinaCadAl.Items.Clear();

            string NomeAluno = cmbAluno.Text.Substring(0, 7);

            List<string> discs = aluop.ProcuraDiscAluno(NomeAluno);

            foreach (string nomeAtividade in discs)
            {
                cmbDisciplinaCadAl.Items.Add(nomeAtividade);
            }
        }

        private void CmbAtividade_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbAtividade.Items.Clear();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);
            string nomeDisc = cmbDisciplinaCadAl.Text.Substring(0, 7);

            List<string> atividades = aluop.ProcuraAtvAluno(nomeAluno, nomeDisc);

            foreach (string nomeAtv in atividades)
            {
                cmbAtividade.Items.Add(nomeAtv);
            }
        }

        private void BtnExcluirAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);

            aluop.ExcluirAluno(nomeAluno);
        }

        private void BtnAlterarDadosAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);
            string nomeAlunoNovo = txtNome.Text;
            string Idade = txtIdade.Text;
            string Telefone = txtTelefone.Text;
            string Ano = txtAno.Text;

            aluop.AlterarAluno(nomeAluno, nomeAlunoNovo, Idade, Telefone, Ano);
        }

        private void BtnExcluirDisciplinaAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);
            string nomeDisciplina = cmbDisciplinaCadAl.Text.Substring(0, 7);

            aluop.ExcluirDiscplinaAluno(nomeAluno, nomeDisciplina);
        }

        private void BtnExcluirAtividadeAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);
            string nomeDisciplina = cmbDisciplinaCadAl.Text.Substring(0, 7);
            string nomeAtividade = cmbAtividade.Text;

            aluop.ExcluirAtividadeAluno(nomeAluno, nomeDisciplina, nomeAtividade);
        }

        private void BtnAlterarNotaAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string nomeAluno = cmbAluno.Text.Substring(0, 7);
            string nomeDisciplina = cmbDisciplinaCadAl.Text.Substring(0, 7);
            string nomeAtividade = cmbAtividade.Text;
            string Nota = lblNotaAluno.Text;

            aluop.AlterarAtividadeNota(nomeAluno, nomeDisciplina, nomeAtividade, Nota);
        }
    }
}
