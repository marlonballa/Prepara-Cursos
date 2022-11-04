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
    public partial class frmCadastroMedicos : Form
    {
        public frmCadastroMedicos()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleDeConsultorioMB);

        }

        private void frmCadastroMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleDeConsultorioMB.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.controleDeConsultorioMB.Medico);

        }

        private void btnFecharFrmMedicos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
