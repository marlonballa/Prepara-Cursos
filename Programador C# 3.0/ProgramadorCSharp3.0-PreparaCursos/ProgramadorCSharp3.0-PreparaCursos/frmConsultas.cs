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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultas02BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultas02BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleDeConsultorioMB);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleDeConsultorioMB.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.controleDeConsultorioMB.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'controleDeConsultorioMB.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.controleDeConsultorioMB.Medico);
            // TODO: esta linha de código carrega dados na tabela 'controleDeConsultorioMB.Consultas02'. Você pode movê-la ou removê-la conforme necessário.
            this.consultas02TableAdapter.Fill(this.controleDeConsultorioMB.Consultas02);

        }
    }
}
