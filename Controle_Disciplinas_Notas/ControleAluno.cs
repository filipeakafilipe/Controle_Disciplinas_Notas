using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LiveCharts;

namespace Controle_Disciplinas_Notas
{
    public partial class ControleAluno : UserControl
    {
        public ControleAluno()
        {
            InitializeComponent();

            grfCartesiano.Visible = false;
            grfPizza.Visible = false;

            lblNome.Visible = false;
            lblTelefone.Visible = false;
            lblIdade.Visible = false;
            lblAno.Visible = false;
        }

        private void cmbAlunos_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Aluno

            AlunoOp aluop = new AlunoOp();

            cmbAlunos.Items.Clear();

            List<string> alunos = aluop.ProcuraAluno(new Aluno());

            foreach (string nomeAlu in alunos)
            {
                cmbAlunos.Items.Add(nomeAlu);
            }
        }

        private void LblSelecionar_Click(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            lblTelefone.Visible = true;
            lblIdade.Visible = true;
            lblAno.Visible = true;

            AlunoOp aluop = new AlunoOp();
            string[] Dados = new string[4];
            Dados = aluop.DadosAluno(cmbAlunos.Text);

            lblNome.Text = Dados[0];
            lblTelefone.Text = Dados[1];
            lblIdade.Text = Dados[2];
            lblAno.Text = Dados[3];
        }

        private void CmbDisciplinas_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbDisciplinas.Items.Clear();

            //string NomeDisciplina = cmbDisciplina.Text;
            string NomeAluno = cmbAlunos.Text;

            List<string> discs = aluop.ProcuraDiscAluno(/*NomeDisciplina, */NomeAluno);

            foreach (string nomeAtividade in discs)
            {
                cmbDisciplinas.Items.Add(nomeAtividade);
            }
        }

        private void BtnSelecionarDisciplina_Click(object sender, EventArgs e)
        {

        }
    }
}
