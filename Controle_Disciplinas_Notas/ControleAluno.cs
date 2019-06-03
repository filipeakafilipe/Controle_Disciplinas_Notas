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
    }
}
