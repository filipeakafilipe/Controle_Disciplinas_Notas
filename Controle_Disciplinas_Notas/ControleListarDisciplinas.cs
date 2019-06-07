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
        }

        private void btnAtualizarDisciplinas_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();

            //dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Disciplina", typeof(string)),
            //                                        new DataColumn("Professor", typeof(string)),
            //                                        new DataColumn("Atividade", typeof(string)),
            //                                        new DataColumn("Valor", typeof(string))});



            //dt.Rows.Add("1", "2", "3", "4");
            //dt.Rows.Add("1", "2", "3", "4");
            //dgvListarDisciplinas.DataSource = dt;
            //dgvListarDisciplinas.ClearSelection();
            //dgvListarDisciplinas.Columns[0].Width = 105;
            //dgvListarDisciplinas.Columns[1].Width = 105;
            //dgvListarDisciplinas.Columns[2].Width = 105;
            //dgvListarDisciplinas.Columns[3].Width = 105;

            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(@"C:\Users\Filipe\Desktop\Prog\PUC\Controle_Disciplinas_Notas\disciplinas.xml");
            //dgvListarDisciplinas.DataSource = dataSet.Tables[0];

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
    }
}
