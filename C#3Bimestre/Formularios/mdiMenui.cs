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

        private void lblRelatorios_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsuPessoas frmConsuPessoas = new frmConsuPessoas();
            frmConsuPessoas.MdiParent = this;
            frmConsuPessoas.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas frmCadPessoas = new frmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
