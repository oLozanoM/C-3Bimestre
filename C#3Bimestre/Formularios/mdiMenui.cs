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

        private void btn_relatiorios_mb_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cadastro_mb_Click(object sender, EventArgs e)
        {
            frmCadPessoas frmCadPessoas = new frmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void btn_Consulta_mb_Click(object sender, EventArgs e)
        {
            frmConsuPessoas frmConsuPessoas = new frmConsuPessoas();
            frmConsuPessoas.MdiParent = this;
            frmConsuPessoas.Show();
        }
    }
}
