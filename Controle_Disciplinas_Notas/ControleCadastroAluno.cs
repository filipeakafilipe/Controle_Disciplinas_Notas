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
            try
            {
                string nome = txtNomeAlu.Text;
                int idade = int.Parse(txtIdade.Text);
                string telefone = txtTelefone.Text;
                int ano = int.Parse(txtAno.Text);

                AlunoOp aluno = new AlunoOp(new Aluno(), nome, idade, telefone, ano);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void cmbAluno_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Aluno

            AlunoOp aluop = new AlunoOp();

            cmbAluno.Items.Clear();

            try
            {
                List<string> alunos = aluop.ProcuraAluno();

                foreach (string nomeAlu in alunos)
                {
                    cmbAluno.Items.Add(nomeAlu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void cmbDisciplina_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Disciplina

            DisciplinaOp discop = new DisciplinaOp();

            cmbDisciplina.Items.Clear();

            try
            {
                List<string> discs = discop.ProcuraDisciplina();

                foreach (string nomeDisc in discs)
                {
                    cmbDisciplina.Items.Add(nomeDisc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnAdicionarDisciplinaAluno_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            try
            {
                string NomeDisciplina = cmbDisciplina.Text.Substring(0, 7);
                string NomeAluno = cmbAluno.Text.Substring(0, 7);

                aluop.AdicionarDisciplina(NomeDisciplina, NomeAluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void CmbDiscAluno_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbDiscAluno.Items.Clear();

            try
            {
                string NomeAluno = cmbAluno.Text.Substring(0, 7);

                List<string> discs = aluop.ProcuraDiscAluno(NomeAluno);

                foreach (string nomeAtividade in discs)
                {
                    cmbDiscAluno.Items.Add(nomeAtividade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void cmbAtividade_MouseUp(object sender, MouseEventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            cmbAtividadeAluno.Items.Clear();

            try
            {
                string nomeDisc = cmbDiscAluno.Text.Substring(0, 7);

                List<string> atividades = discop.ProcuraAtividade(nomeDisc);

                foreach (string nomeAtividade in atividades)
                {
                    cmbAtividadeAluno.Items.Add(nomeAtividade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            try
            {
            string NomeAluno = cmbAluno.Text.Substring(0, 7);
            string NomeDisciplina = cmbDiscAluno.Text.Substring(0, 7);
            string NomeAtividade = cmbAtividadeAluno.Text;
            double Nota = double.Parse(lblNotaAluno.Text);

            aluop.AdicionarNota(NomeDisciplina, NomeAluno, NomeAtividade, Nota);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }
    }
}
