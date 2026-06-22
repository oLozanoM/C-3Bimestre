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
            if (cbmCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a coluna para pesquisar");
                return;
            }

            string column = cbmCombo.Text;
            string busca = cbmBuscar.Text;
            string raw = txtValor.Text ?? "";
            if (busca == "Todos")
            {
                pessoaBindingSource.Filter = null;
                return;
            }

            string escaped = raw.Replace("'", "''");
            string filtro = "";

            bool isNumeric = column == "ID";

            if (busca == "Igual")
            {
                filtro = isNumeric ? $"{column} = {escaped}" : $"{column} = '{escaped}'";
            }
            else if (busca == "Que começa com")
            {
                if (isNumeric) { MessageBox.Show("Operação inválida para coluna numérica."); return; }
                filtro = $"{column} LIKE '{escaped}%'";
            }
            else if (busca == "Que termina com")
            {
                if (isNumeric) { MessageBox.Show("Operação inválida para coluna numérica."); return; }
                filtro = $"{column} LIKE '%{escaped}'";
            }
            else if (busca == "Que contém")
            {
                if (isNumeric) { MessageBox.Show("Operação inválida para coluna numérica."); return; }
                filtro = $"{column} LIKE '%{escaped}%'";
            }
            else if (busca == "Que esteja entre")
            {
                var parts = raw.Split(';');
                if (parts.Length != 2) { MessageBox.Show("Informe intervalo no formato min;max"); return; }
                string a = parts[0].Trim();
                string b = parts[1].Trim();
                if (isNumeric)
                    filtro = $"{column} >= {a} AND {column} <= {b}";
                else
                    filtro = $"{column} >= '{a.Replace("'", "''")}' AND {column} <= '{b.Replace("'", "''")}'";
            }
            else
            {
                MessageBox.Show("Operação de busca desconhecida.");
                return;
            }

            pessoaBindingSource.Filter = filtro;
        }

        private void cbmCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
