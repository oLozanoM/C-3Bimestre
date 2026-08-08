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
    public partial class frmAniversarianteMes : Form
    {
        public frmAniversarianteMes()
        {
            InitializeComponent();
        }

        private void frmAniversarianteMes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int mesSelecionado;

            if(int.TryParse(numericUpDown1.Value.ToString(), out mesSelecionado))
            {
                //var adapter = new sp_AniversarianteDoMes2TableAdpater();
                //var tabela = adapter.GetTabela(mesSelecionado);
                //dataGridView1.DataSource = tabela;
            } 
            else
            {
                MessageBox.Show("Selecione um mês válido.");
            }
        }
    }
}
