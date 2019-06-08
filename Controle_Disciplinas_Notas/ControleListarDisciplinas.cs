using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Controle_Disciplinas_Notas
{
    public partial class ControleListarDisciplinas : UserControl
    {
        //DataTable dt = new DataTable();

        public ControleListarDisciplinas()
        {
            InitializeComponent();

            DisciplinaOp discop = new DisciplinaOp();

            List<Disciplina> Discs = new List<Disciplina>();

            Discs = discop.ListarDisciplinas();

            dgvListarDisciplinas.ForeColor = Color.Black;
            dgvListarDisciplinas.DataSource = Discs;
            dgvListarDisciplinas.Columns[0].Width = 84;
            dgvListarDisciplinas.Columns[1].Width = 84;
            dgvListarDisciplinas.Columns[2].Width = 84;
            dgvListarDisciplinas.Columns[3].Width = 84;
            dgvListarDisciplinas.Columns[4].Width = 84;
            dgvListarDisciplinas.Columns[5].Visible = false;

            dgvListarDisciplinas.ClearSelection();
        }

        private void btnAtualizarDisciplinas_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            List<Disciplina> Discs = new List<Disciplina>();

            Discs = discop.ListarDisciplinas();

            dgvListarDisciplinas.ForeColor = Color.Black;
            dgvListarDisciplinas.DataSource = Discs;
            dgvListarDisciplinas.Columns[0].Width = 84;
            dgvListarDisciplinas.Columns[1].Width = 84;
            dgvListarDisciplinas.Columns[2].Width = 84;
            dgvListarDisciplinas.Columns[3].Width = 84;
            dgvListarDisciplinas.Columns[4].Width = 84;
            dgvListarDisciplinas.Columns[5].Visible = false;

            dgvListarDisciplinas.ClearSelection();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string codDisc = txtPesquisar.Text.ToUpper();

            dgvListarDisciplinas.ClearSelection();

            for(int i = 0; i < dgvListarDisciplinas.RowCount; i++)
            {
                if(dgvListarDisciplinas.Rows[i].Cells[0].Value.ToString() == codDisc)
                {
                    dgvListarDisciplinas.CurrentCell = dgvListarDisciplinas.Rows[i].Cells[0];
                    break;
                }
            }
        }
    }
}
