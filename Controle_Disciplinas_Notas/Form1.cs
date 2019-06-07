using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Disciplinas_Notas
{
    public partial class PainelConteudo : Form
    {
        public PainelConteudo()
        {
            InitializeComponent();
            PainelLadoVerde.Height = btnInicio.Height;
            controleInicio1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PainelLadoVerde.Height = btnInicio.Height;
            PainelLadoVerde.Top = btnInicio.Top;
            controleInicio1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(50, 50, 50);
            btnCadastro.BackColor = Color.FromArgb(40, 40, 40);
            btnAlterar.BackColor = Color.FromArgb(40, 40, 40);
            btnListar.BackColor = Color.FromArgb(40, 40, 40);
            btnAluno.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            PainelLadoVerde.Height = btnCadastro.Height;
            PainelLadoVerde.Top = btnCadastro.Top;
            controleCadastro1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(40, 40, 40);
            btnCadastro.BackColor = Color.FromArgb(50, 50, 50);
            btnAlterar.BackColor = Color.FromArgb(40, 40, 40);
            btnListar.BackColor = Color.FromArgb(40, 40, 40);
            btnAluno.BackColor = Color.FromArgb(40, 40, 40);
            //InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PainelLadoVerde.Height = btnAlterar.Height;
            PainelLadoVerde.Top = btnAlterar.Top;
            controleAlterar1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(40, 40, 40);
            btnCadastro.BackColor = Color.FromArgb(40, 40, 40);
            btnAlterar.BackColor = Color.FromArgb(50, 50, 50);
            btnListar.BackColor = Color.FromArgb(40, 40, 40);
            btnAluno.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            PainelLadoVerde.Height = btnListar.Height;
            PainelLadoVerde.Top = btnListar.Top;
            controleListar1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(40, 40, 40);
            btnCadastro.BackColor = Color.FromArgb(40, 40, 40);
            btnAlterar.BackColor = Color.FromArgb(40, 40, 40);
            btnListar.BackColor = Color.FromArgb(50, 50, 50);
            btnAluno.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            PainelLadoVerde.Height = btnAluno.Height;
            PainelLadoVerde.Top = btnAluno.Top;
            controleAluno1.BringToFront();
            btnInicio.BackColor = Color.FromArgb(40, 40, 40);
            btnCadastro.BackColor = Color.FromArgb(40, 40, 40);
            btnAlterar.BackColor = Color.FromArgb(40, 40, 40);
            btnListar.BackColor = Color.FromArgb(40, 40, 40);
            btnAluno.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
