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
        }

        private void btnAtualizarAlunos_Click(object sender, EventArgs e)
        {
            AlunoOp aluop = new AlunoOp();

            List<Aluno> alus = new List<Aluno>();

            alus = aluop.ListarAlunos();

            dgvListarAlunos.ForeColor = Color.Black;
            dgvListarAlunos.DataSource = alus;
            dgvListarAlunos.Columns[5].Visible = false;

            dgvListarAlunos.ClearSelection();
        }
    }
}
