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
    public partial class ControleAlterar : UserControl
    {
        public ControleAlterar()
        {
            InitializeComponent();
            controleAlterarInicio1.BringToFront();
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            controleAlterarAluno1.BringToFront();
        }

        private void btnAlterarDisciplina_Click(object sender, EventArgs e)
        {
            controleAlterarDisciplina1.BringToFront();
        }
    }
}
