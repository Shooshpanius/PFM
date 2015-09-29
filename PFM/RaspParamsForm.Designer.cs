namespace PFM
{
    partial class RaspParamsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputlengthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pfmDataSet = new PFM.pfmDataSet();
            this.input_lengthTableAdapter = new PFM.pfmDataSetTableAdapters.input_lengthTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltxtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKoutputlenghtinputlength1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.output_lenghtTableAdapter = new PFM.pfmDataSetTableAdapters.output_lenghtTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizesTableAdapter = new PFM.pfmDataSetTableAdapters.sizesTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortTableAdapter = new PFM.pfmDataSetTableAdapters.sortTableAdapter();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputlengthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKoutputlenghtinputlength1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(703, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lenghtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inputlengthBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(124, 433);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "lenght";
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            this.lenghtDataGridViewTextBoxColumn.Width = 50;
            // 
            // inputlengthBindingSource
            // 
            this.inputlengthBindingSource.DataMember = "input_length";
            this.inputlengthBindingSource.DataSource = this.pfmDataSet;
            // 
            // pfmDataSet
            // 
            this.pfmDataSet.DataSetName = "pfmDataSet";
            this.pfmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // input_lengthTableAdapter
            // 
            this.input_lengthTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idinputDataGridViewTextBoxColumn,
            this.l1DataGridViewTextBoxColumn,
            this.l2DataGridViewTextBoxColumn,
            this.l3DataGridViewTextBoxColumn,
            this.ltxtDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKoutputlenghtinputlength1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(142, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(354, 433);
            this.dataGridView2.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // idinputDataGridViewTextBoxColumn
            // 
            this.idinputDataGridViewTextBoxColumn.DataPropertyName = "id_input";
            this.idinputDataGridViewTextBoxColumn.HeaderText = "id_input";
            this.idinputDataGridViewTextBoxColumn.Name = "idinputDataGridViewTextBoxColumn";
            this.idinputDataGridViewTextBoxColumn.Width = 30;
            // 
            // l1DataGridViewTextBoxColumn
            // 
            this.l1DataGridViewTextBoxColumn.DataPropertyName = "l1";
            this.l1DataGridViewTextBoxColumn.HeaderText = "l1";
            this.l1DataGridViewTextBoxColumn.Name = "l1DataGridViewTextBoxColumn";
            this.l1DataGridViewTextBoxColumn.Width = 50;
            // 
            // l2DataGridViewTextBoxColumn
            // 
            this.l2DataGridViewTextBoxColumn.DataPropertyName = "l2";
            this.l2DataGridViewTextBoxColumn.HeaderText = "l2";
            this.l2DataGridViewTextBoxColumn.Name = "l2DataGridViewTextBoxColumn";
            this.l2DataGridViewTextBoxColumn.Width = 50;
            // 
            // l3DataGridViewTextBoxColumn
            // 
            this.l3DataGridViewTextBoxColumn.DataPropertyName = "l3";
            this.l3DataGridViewTextBoxColumn.HeaderText = "l3";
            this.l3DataGridViewTextBoxColumn.Name = "l3DataGridViewTextBoxColumn";
            this.l3DataGridViewTextBoxColumn.Width = 50;
            // 
            // ltxtDataGridViewTextBoxColumn
            // 
            this.ltxtDataGridViewTextBoxColumn.DataPropertyName = "l_txt";
            this.ltxtDataGridViewTextBoxColumn.HeaderText = "l_txt";
            this.ltxtDataGridViewTextBoxColumn.Name = "ltxtDataGridViewTextBoxColumn";
            // 
            // fKoutputlenghtinputlength1BindingSource
            // 
            this.fKoutputlenghtinputlength1BindingSource.DataMember = "FK_output_lenght_input_length1";
            this.fKoutputlenghtinputlength1BindingSource.DataSource = this.inputlengthBindingSource;
            // 
            // output_lenghtTableAdapter
            // 
            this.output_lenghtTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.wDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.txtDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sizesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(502, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(276, 211);
            this.dataGridView3.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 30;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "w";
            this.wDataGridViewTextBoxColumn.HeaderText = "w";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.Width = 50;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "h";
            this.hDataGridViewTextBoxColumn.HeaderText = "h";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.Width = 50;
            // 
            // txtDataGridViewTextBoxColumn
            // 
            this.txtDataGridViewTextBoxColumn.DataPropertyName = "txt";
            this.txtDataGridViewTextBoxColumn.HeaderText = "txt";
            this.txtDataGridViewTextBoxColumn.Name = "txtDataGridViewTextBoxColumn";
            // 
            // sizesBindingSource
            // 
            this.sizesBindingSource.DataMember = "sizes";
            this.sizesBindingSource.DataSource = this.pfmDataSet;
            // 
            // sizesTableAdapter
            // 
            this.sizesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.sDataGridViewTextBoxColumn,
            this.txtDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.sortBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(503, 230);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(275, 215);
            this.dataGridView4.TabIndex = 6;
            // 
            // sortBindingSource
            // 
            this.sortBindingSource.DataMember = "sort";
            this.sortBindingSource.DataSource = this.pfmDataSet;
            // 
            // sortTableAdapter
            // 
            this.sortTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 30;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "s";
            this.sDataGridViewTextBoxColumn.HeaderText = "s";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 50;
            // 
            // txtDataGridViewTextBoxColumn1
            // 
            this.txtDataGridViewTextBoxColumn1.DataPropertyName = "txt";
            this.txtDataGridViewTextBoxColumn1.HeaderText = "txt";
            this.txtDataGridViewTextBoxColumn1.Name = "txtDataGridViewTextBoxColumn1";
            // 
            // RaspParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 478);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Name = "RaspParamsForm";
            this.Text = "RaspParamsForm";
            this.Load += new System.EventHandler(this.RaspParamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputlengthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKoutputlenghtinputlength1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pfmDataSet pfmDataSet;
        private System.Windows.Forms.BindingSource inputlengthBindingSource;
        private pfmDataSetTableAdapters.input_lengthTableAdapter input_lengthTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKoutputlenghtinputlength1BindingSource;
        private pfmDataSetTableAdapters.output_lenghtTableAdapter output_lenghtTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource sizesBindingSource;
        private pfmDataSetTableAdapters.sizesTableAdapter sizesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltxtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource sortBindingSource;
        private pfmDataSetTableAdapters.sortTableAdapter sortTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDataGridViewTextBoxColumn1;
    }
}