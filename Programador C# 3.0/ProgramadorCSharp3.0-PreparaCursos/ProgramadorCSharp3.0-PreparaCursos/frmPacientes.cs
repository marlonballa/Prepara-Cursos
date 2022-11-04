using Correios.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramadorCSharp3._0_PreparaCursos
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void PacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleDeConsultorioMB);

            

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleDeConsultorioMB.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.controleDeConsultorioMB.Paciente);
        }     

        private void btnFecharCadastroPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbCadastrarNovoPaciente.Enabled = true;

            txtEnderecoPaciente.Enabled = false;
            txtBairroPaciente.Enabled = false;
            txtNumeroEnderecoPaciente.Enabled = false;
            txtCidadePaciente.Enabled = false;
        }

        private void btnInserirDadosCEP_Click(object sender, EventArgs e)
        {
            //As informações de Rua, Bairro, Cidade, Estado e País serão inseridas por meio da consulta a API da ViaCep.
            //Verifica se o campo CEP não possui nada digitado ou se possui apenas campos em branco.

            //O Método Format em {0} vai receber o valor que está no campo txtCEPPaciente.Text
            string strURL = string.Format("https://viacep.com.br/ws/{0}/json", txtCEPPaciente.Text.Trim()); //URL de consulta ao ViaCep
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(strURL).Result;
                    //Para verificar se a consulta deu certo, devemos saber qual o status code

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        ResultadoCEP res = JsonConvert.DeserializeObject<ResultadoCEP>(result);

                        txtCidadePaciente.Enabled = true;
                        txtBairroPaciente.Enabled = true;
                        txtEnderecoPaciente.Enabled = true;
                        txtNumeroEnderecoPaciente.Enabled = true;

                        txtCidadePaciente.Text = res.PropriedadesLocalidade;
                        txtBairroPaciente.Text = res.PropriedadesBairro;
                        txtEnderecoPaciente.Text = res.PropriedadesLogradouro;
                    } else
                    {
                        MessageBox.Show("Coloque uma informação válida para o CEP. \n Utilize apenas números, sem pontos ou traços",
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            //Caso tenha algum problema na consulta, será mostrada uma mensagem para o usuário. 
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
