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
    public partial class ControleListarAlunos : UserControl
    {
        public ControleListarAlunos()
        {
            InitializeComponent();

            AlunoOp aluop = new AlunoOp();

            List<Aluno> alus = new List<Aluno>();

            try
            {
                alus = aluop.ListarAlunos();

                dgvListarAlunos.ForeColor = Color.Black;
                dgvListarAlunos.DataSource = alus;
                dgvListarAlunos.Columns[5].Visible = false;

                dgvListarAlunos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void btnAtualizarAlunos_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            List<Aluno> alus = new List<Aluno>();

            try
            {
                alus = aluop.ListarAlunos();

                dgvListarAlunos.ForeColor = Color.Black;
                dgvListarAlunos.DataSource = alus;
                dgvListarAlunos.Columns[5].Visible = false;

                dgvListarAlunos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string codAluno = txtPesquisar.Text.ToUpper();

            dgvListarAlunos.ClearSelection();

            try
            {
                for (int i = 0; i < dgvListarAlunos.RowCount; i++)
                {
                    if (dgvListarAlunos.Rows[i].Cells[0].Value.ToString() == codAluno)
                    {
                        dgvListarAlunos.CurrentCell = dgvListarAlunos.Rows[i].Cells[0];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }
    }
}
