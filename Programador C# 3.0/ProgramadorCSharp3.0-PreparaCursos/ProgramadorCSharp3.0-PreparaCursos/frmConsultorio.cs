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
    public partial class frmConsultorio : Form
    {
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Consultorio_2_0DataSet);

        }

        private void consultasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Consultorio_2_0DataSet);

        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_Consultorio_2_0DataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this._Consultorio_2_0DataSet.Consultas);

        }
    }
}
