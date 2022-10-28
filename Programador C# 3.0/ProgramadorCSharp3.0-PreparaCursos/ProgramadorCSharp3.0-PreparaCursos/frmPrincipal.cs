using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramadorCSharp3._0_PreparaCursos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultorio frmConsultorio = new frmConsultorio();
            frmConsultorio.ShowDialog();
        }

        private void controleDeDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleDespesas frmControleDespesas = new frmControleDespesas();
            frmControleDespesas.ShowDialog();   
        }

        private void controleDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleDeAluno frmControleDeAluno = new frmControleDeAluno();
            frmControleDeAluno.ShowDialog();
        }

        private void meusContatosAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusContatos frmMeusContatos = new frmMeusContatos();
            frmMeusContatos.ShowDialog();
        }
    }
}
