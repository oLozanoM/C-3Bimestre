namespace C_3Bimestre.Formularios
{
    partial class mdiMenui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblRelatorios = new System.Windows.Forms.ToolStripLabel();
            this.lblCadastro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblConsulta = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRelatorios,
            this.lblCadastro,
            this.toolStripLabel1,
            this.lblConsulta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1478, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(90, 26);
            this.lblRelatorios.Text = "Relatórios";
            this.lblRelatorios.Click += new System.EventHandler(this.lblRelatorios_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(100, 31);
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 26);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(81, 26);
            this.lblConsulta.Text = "Consulta";
            this.lblConsulta.Click += new System.EventHandler(this.lblConsulta_Click);
            // 
            // mdiMenui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 673);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "mdiMenui";
            this.Text = "mdiMenui";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblRelatorios;
        private System.Windows.Forms.ToolStripTextBox lblCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblConsulta;
    }
}