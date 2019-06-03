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

        private void cmbDisciplina_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Disciplina

            DisciplinaOp discop = new DisciplinaOp();

            cmbDisciplina.Items.Clear();

            List<string> discs = discop.ProcuraDisciplina(new Disciplina());

            foreach (string nomeDisc in discs)
            {
                cmbDisciplina.Items.Add(nomeDisc);
            }
        }

        private void BtnAdicionarDisciplinaAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string NomeDisciplina = cmbDisciplina.Text;
            string NomeAluno = cmbAluno.Text;

            aluop.AdicionarDisciplina(new Disciplina(), new Aluno(), NomeDisciplina, NomeAluno);
        }

        private void CmbDiscAluno_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbDiscAluno.Items.Clear();

            //string NomeDisciplina = cmbDisciplina.Text;
            string NomeAluno = cmbAluno.Text;

            List<string> discs = aluop.ProcuraDiscAluno(/*NomeDisciplina, */NomeAluno);

            foreach(string nomeAtividade in discs)
            {
                cmbDiscAluno.Items.Add(nomeAtividade);
            }
        }

        private void cmbAtividade_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Atividade

            DisciplinaOp discop = new DisciplinaOp();

            cmbAtividadeAluno.Items.Clear();

            string nomeDisc = cmbDiscAluno.Text;

            List<string> atividades = discop.ProcuraAtividade(new Disciplina(), nomeDisc);

            foreach (string nomeAtividade in atividades)
            {
                cmbAtividadeAluno.Items.Add(nomeAtividade);
            }
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            string NomeAluno = cmbAluno.Text;
            string NomeDisciplina = cmbDiscAluno.Text;
            string NomeAtividade = cmbAtividadeAluno.Text;
            double Nota = double.Parse(lblNotaAluno.Text);

            aluop.AdicionarNota(NomeDisciplina, NomeAluno, NomeAtividade, Nota);
        }     
    }
}
