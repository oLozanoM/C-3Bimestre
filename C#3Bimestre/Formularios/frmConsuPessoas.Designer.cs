namespace C_3Bimestre.Formularios
{
    partial class frmConsuPessoas
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
            this.components = new System.ComponentModel.Container();
            this.cmbColuna = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Agenda = new C_3Bimestre.Dados.DataSet_Agenda();
            this.pessoaTableAdapter = new C_3Bimestre.Dados.DataSet_AgendaTableAdapters.PessoaTableAdapter();
            this.lblPessoas = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmCombo = new System.Windows.Forms.ComboBox();
            this.cbmBuscar = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColuna
            // 
            this.cmbColuna.AutoGenerateColumns = false;
            this.cmbColuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmbColuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dATANASCIMENTODataGridViewTextBoxColumn});
            this.cmbColuna.DataSource = this.pessoaBindingSource;
            this.cmbColuna.Location = new System.Drawing.Point(48, 115);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.RowHeadersWidth = 62;
            this.cmbColuna.RowTemplate.Height = 28;
            this.cmbColuna.Size = new System.Drawing.Size(1255, 465);
            this.cmbColuna.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            this.eNDERECODataGridViewTextBoxColumn.Width = 150;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // dATANASCIMENTODataGridViewTextBoxColumn
            // 
            this.dATANASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dATANASCIMENTODataGridViewTextBoxColumn.Name = "dATANASCIMENTODataGridViewTextBoxColumn";
            this.dATANASCIMENTODataGridViewTextBoxColumn.Width = 150;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Location = new System.Drawing.Point(44, 28);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(101, 20);
            this.lblPessoas.TabIndex = 1;
            this.lblPessoas.Text = "Pessoas por:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(270, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 20);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // cbmCombo
            // 
            this.cbmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmCombo.FormattingEnabled = true;
            this.cbmCombo.Items.AddRange(new object[] {
            "ID",
            "NOME",
            "ENDERECO",
            "CIDADE",
            "EMAIL",
            "DATA_NASCIMENTO"});
            this.cbmCombo.Location = new System.Drawing.Point(48, 66);
            this.cbmCombo.Name = "cbmCombo";
            this.cbmCombo.Size = new System.Drawing.Size(121, 28);
            this.cbmCombo.TabIndex = 4;
            this.cbmCombo.SelectedIndexChanged += new System.EventHandler(this.cbmCombo_SelectedIndexChanged);
            // 
            // cbmBuscar
            // 
            this.cbmBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBuscar.FormattingEnabled = true;
            this.cbmBuscar.Items.AddRange(new object[] {
            "Todos",
            "Igual",
            "Que começa com",
            "Que termina com",
            "Que contém",
            "Que esteja entre"});
            this.cbmBuscar.Location = new System.Drawing.Point(274, 66);
            this.cbmBuscar.Name = "cbmBuscar";
            this.cbmBuscar.Size = new System.Drawing.Size(121, 28);
            this.cbmBuscar.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(512, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(152, 26);
            this.txtValor.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(716, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 40);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmConsuPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 645);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbmBuscar);
            this.Controls.Add(this.cbmCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblPessoas);
            this.Controls.Add(this.cmbColuna);
            this.Name = "frmConsuPessoas";
            this.Text = "ConsultaPessoas";
            this.Load += new System.EventHandler(this.frmConsuPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbColuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cmbColuna;
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPessoas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmCombo;
        private System.Windows.Forms.ComboBox cbmBuscar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFiltrar;
    }
}