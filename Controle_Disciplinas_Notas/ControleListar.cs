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
    public partial class ControleListar : UserControl
    {
        public ControleListar()
        {
            InitializeComponent();
            controleListarInicio1.BringToFront();
        }

        private void BtnListarAlunos_Click(object sender, EventArgs e)
        {
            controleListarAlunos1.BringToFront();
        }

        private void BtnListarDisciplinas_Click(object sender, EventArgs e)
        {
            controleListarDisciplinas1.BringToFront();
        }
    }
}
