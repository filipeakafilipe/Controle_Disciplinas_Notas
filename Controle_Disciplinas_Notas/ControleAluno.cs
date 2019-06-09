using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Controle_Disciplinas_Notas
{
    public partial class ControleAluno : UserControl
    {
        public ControleAluno()
        {
            InitializeComponent();

            grfPizza.Visible = false;

            lblCodigo.Visible = false;
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

            try
            {
                List<string> alunos = aluop.ProcuraAluno();

                foreach (string nomeAlu in alunos)
                {
                    cmbAlunos.Items.Add(nomeAlu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                lblCodigo.Visible = true;
                lblNome.Visible = true;
                lblTelefone.Visible = true;
                lblIdade.Visible = true;
                lblAno.Visible = true;

                AlunoOp aluop = new AlunoOp();
                string[] Dados = new string[5];
                Dados = aluop.DadosAluno(cmbAlunos.Text.Substring(0, 7));

                lblCodigo.Text = Dados[0];
                lblNome.Text = Dados[1];
                lblTelefone.Text = Dados[2];
                lblIdade.Text = Dados[3];
                lblAno.Text = Dados[4];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void CmbDisciplinas_MouseUp(object sender, MouseEventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            cmbDisciplinas.Items.Clear();

            try
            {
                string NomeAluno = cmbAlunos.Text.Substring(0, 7);

                List<string> discs = aluop.ProcuraDiscAluno(NomeAluno);

                foreach (string nomeAtividade in discs)
                {
                    cmbDisciplinas.Items.Add(nomeAtividade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void BtnSelecionarDisciplina_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            List<Aluno> alu = new List<Aluno>();

            try
            {
                string codAluno = cmbAlunos.Text.Substring(0, 7);
                string codDisc = cmbDisciplinas.Text.Substring(0, 7);

                alu = aluop.ListarDiscAluno(codAluno, codDisc);
                dgvDiscNotas.ForeColor = Color.Black;
                dgvDiscNotas.DataSource = alu;

                dgvDiscNotas.Columns[0].Visible = false;
                dgvDiscNotas.Columns[1].Visible = false;
                dgvDiscNotas.Columns[2].Visible = false;
                dgvDiscNotas.Columns[3].Visible = false;
                dgvDiscNotas.Columns[4].Visible = false;
                dgvDiscNotas.Columns[5].Visible = false;
                dgvDiscNotas.Columns[6].Visible = false;
                dgvDiscNotas.Columns[7].Visible = false;

                dgvDiscNotas.ClearSelection();

                DisciplinaOp discop = new DisciplinaOp();
                List<double> notasMax = new List<double>();
                notasMax = discop.NotasDisc(codDisc);

                double somaMax = 0;
                foreach (double x in notasMax)
                {
                    somaMax += x;
                }

                List<Aluno> notasAluno = new List<Aluno>();
                notasAluno = aluop.NotasAluno(codAluno, codDisc);

                double somaAluno = 0;
                foreach (var x in notasAluno)
                {
                    somaAluno += double.Parse(x.NotaAluno);
                }

                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                grfPizza.Visible = true;
                grfPizza.Series = new SeriesCollection
                                  {
                                      new PieSeries
                                      {
                                          Title = "Nota Máxima",
                                          Values = new ChartValues<double> {somaMax},
                                          DataLabels = true,
                                          LabelPoint = labelPoint
                                      },
                                      new PieSeries
                                      {
                                          Title = "Nota Aluno",
                                          Values = new ChartValues<double> {somaAluno},
                                          DataLabels = true,
                                          LabelPoint = labelPoint
                                      }
                                  };

                grfPizza.LegendLocation = LegendLocation.Bottom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }
    }
}
