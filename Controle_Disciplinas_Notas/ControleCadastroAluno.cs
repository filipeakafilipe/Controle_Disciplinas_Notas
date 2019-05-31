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
    public partial class ControleCadastroAluno : UserControl
    {
        public ControleCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAlu.Text;
            int idade = int.Parse(txtIdade.Text);
            string telefone = txtTelefone.Text;
            int ano = int.Parse(txtAno.Text);

            AlunoOp aluno = new AlunoOp(new Aluno(), nome, idade, telefone, ano);
        }

        private void btnAtualizarAlunos_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbAluno.Items.Clear();

            List<string> alunos = aluop.ProcuraAluno(new Aluno());

            foreach(string nomeAlu in alunos)
            {
                cmbAluno.Items.Add(nomeAlu);
            }
        }

        private void btnAtualizarDisciplinas_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            cmbDisciplina.Items.Clear();

            List<string> discs = discop.ProcuraDisciplina(new Disciplina());

            foreach(string nomeDisc in discs)
            {
                cmbDisciplina.Items.Add(nomeDisc);
            }
        }

        private void btnAdicionarDisciplinaAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string NomeDisciplina = cmbDisciplina.Text;
            string NomeAluno = cmbAluno.Text;

            aluop.AdicionarDisciplina(new Disciplina(), new Aluno(), NomeDisciplina, NomeAluno);
        }

        private void btnAtualizarAtividade_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            cmbAtividade.Items.Clear();

            string nomeDisc = cmbDisciplina.Text;

            List<string> atividades = discop.ProcuraAtividade(new Disciplina(), nomeDisc);

            foreach(string nomeAtividade in atividades)
            {
                cmbAtividade.Items.Add(nomeAtividade);
            }
        }
    }
}
