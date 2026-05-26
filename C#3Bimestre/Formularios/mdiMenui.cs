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
    public partial class mdiMenui : Form
    {
        public mdiMenui()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas frmCadPessoas = new frmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsuPessoas ConsultaPessoas = new frmConsuPessoas();
            ConsultaPessoas.MdiParent = this;
            ConsultaPessoas.Show();
        }
    }
}
