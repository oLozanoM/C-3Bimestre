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
    public partial class mdiMenuu : Form
    {
        public mdiMenuu()
        {
            InitializeComponent();
        }

        private void cadastrosDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsuPessoas frmConsuPessoas = new frmConsuPessoas();
            frmConsuPessoas.MdiParent = this;
            frmConsuPessoas.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas frmCadPessoas = new frmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaPessoa frmVisualizaPessoa = new frmVisualizaPessoa();
            frmVisualizaPessoa.MdiParent = this;
            frmVisualizaPessoa.Show();
        }
    }
}
