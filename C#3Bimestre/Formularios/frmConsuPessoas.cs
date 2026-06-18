using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_3Bimestre.Formularios
{
    public partial class frmConsuPessoas : Form
    {
        public frmConsuPessoas()
        {
            InitializeComponent();
        }

        private void frmConsuPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            try
            {
                this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine($"SqlException Number={ex.Number}, Server={ex.Server}, Message={ex.Message}");
                throw;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro;
            if (cbmCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a coluna para pesquisar");
                return;
            }

            filtro = cbmCombo.Text;

            string busca = cbmBuscar.Text;

            if (busca == "Igual")
            {
                filtro += "'" + txtValor.Text + "'";
            }

            else if (busca == "Que começa com")
            {
                filtro += "like " + txtValor.Text + " %";
            }

            string vCouluna 

            pessoaBindingSource.Filter = filtro;
        }

        private void cbmCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
