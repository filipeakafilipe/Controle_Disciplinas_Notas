using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//using System.Xml;
//using System.Xml.Linq;

namespace Controle_Disciplinas_Notas
{
    public partial class ControleCadastroDisciplina : UserControl
    {
        //Disciplina disc = new Disciplina();

        public ControleCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            //Disciplina MinhaDisciplina = new Disciplina();

            //MinhaDisciplina.NomeDisc = txtNomeDisc.Text;
            //MinhaDisciplina.Professor = txtProfessor.Text;

            DisciplinaOp Disc = new DisciplinaOp(new Disciplina(), txtNomeDisc.Text, txtProfessor.Text);
        }

        private void BtnSelecionarDisciplina_Click(object sender, EventArgs e)
        {
            //DisciplinaOp Disc = new DisciplinaOp();

            ///*var Consulta = */Disc.SelecionaDisciplina(cmbDisciplinaCadDi.Text);

            ////Disc.RetornaConsulta(Consulta);
        }

        private void btnAdicionarAtividade_Click(object sender, EventArgs e)
        {
            string NomeAtividade = txtNomeAtividade.Text;
            double NotaMax = double.Parse(txtNotaMax.Text);

            //DisciplinaOp Disc = new DisciplinaOp();

            //Disc.AdicionarAtividade(new Disciplina(), NomeAtividade, NotaMax/*, Consulta*/);
        }

        private void btnAtualizarDisciplinas_Click(object sender, EventArgs e)
        {
            DisciplinaOp discop = new DisciplinaOp();

            List<string> discs = discop.ProcuraDisciplina(new Disciplina());

            foreach (string nomeDisc in discs)
            {
                cmbDisciplinaCadDi.Items.Add(nomeDisc);
            }
        }
    }
}
