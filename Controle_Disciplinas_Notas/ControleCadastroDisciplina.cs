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
        public ControleCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                DisciplinaOp Disc = new DisciplinaOp(txtNomeDisc.Text, txtProfessor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void btnAdicionarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeDisciplina = cmbDisciplinaCadAt.Text.Substring(0, 7);
                string NomeAtividade = txtNomeAtividade.Text;
                double NotaMax = double.Parse(txtNotaMax.Text);

                DisciplinaOp Disc = new DisciplinaOp();

                Disc.AdicionarAtividade(new Disciplina(), NomeDisciplina, NomeAtividade, NotaMax);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }

        private void cmbDisciplinaCadAt_MouseUp(object sender, MouseEventArgs e)
        {
            // Atualiza Combobox Disciplina

            DisciplinaOp discop = new DisciplinaOp();

            cmbDisciplinaCadAt.Items.Clear();

            try
            {
                List<string> discs = discop.ProcuraDisciplina(new Disciplina());

                foreach (string nomeDisc in discs)
                {
                    cmbDisciplinaCadAt.Items.Add(nomeDisc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu.\nMensagem: {ex.Message}", "Atenção");
            }
        }
    }
}
