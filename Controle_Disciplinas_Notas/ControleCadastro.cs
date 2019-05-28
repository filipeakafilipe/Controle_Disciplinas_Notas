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
    public partial class ControleCadastro : UserControl
    {
        public ControleCadastro()
        {
            InitializeComponent();
            controleCadastroInicio1.BringToFront();
        }

        private void BtnCadastroAluno_Click(object sender, EventArgs e)
        {
            controleCadastroAluno1.BringToFront();
        }

        private void BtnCadastroDisciplina_Click(object sender, EventArgs e)
        {

            controleCadastroDisciplina1.BringToFront();
        }
    }
}
