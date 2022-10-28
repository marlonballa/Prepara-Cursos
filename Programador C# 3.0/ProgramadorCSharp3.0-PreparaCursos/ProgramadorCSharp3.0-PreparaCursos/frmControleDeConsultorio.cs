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
    public partial class frmControleDeConsultorio : Form
    {
        public frmControleDeConsultorio()
        {
            InitializeComponent();
        }

        private void cadastrarNovoMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMedicos frmCadastroMedicos = new frmCadastroMedicos();
            frmCadastroMedicos.MdiParent = this;
            frmCadastroMedicos.Show();
        }
    }
}
