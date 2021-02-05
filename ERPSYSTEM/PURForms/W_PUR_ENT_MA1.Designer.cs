namespace ERPSYSTEM.PURForms
{
    partial class W_PUR_ENT_MA1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDKINDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vendKindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDFNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDINVNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAFACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pUR = new ERPSYSTEM.DataSets.PUR();
            this.cVENDORMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendKindBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVENDORMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(725, 400);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factNo,
            this.vENDNODataGridViewTextBoxColumn,
            this.vENDKINDDataGridViewTextBoxColumn,
            this.vENDFNMDataGridViewTextBoxColumn,
            this.vENDINVNODataGridViewTextBoxColumn,
            this.tRAFACTDataGridViewTextBoxColumn,
            this.userNo,
            this.modifyDt});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(725, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // factNo
            // 
            this.factNo.DataPropertyName = "FACT_NO";
            this.factNo.HeaderText = "FACT_NO";
            this.factNo.Name = "factNo";
            this.factNo.Visible = false;
            // 
            // vENDNODataGridViewTextBoxColumn
            // 
            this.vENDNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vENDNODataGridViewTextBoxColumn.DataPropertyName = "VEND_NO";
            this.vENDNODataGridViewTextBoxColumn.HeaderText = "供應商編號";
            this.vENDNODataGridViewTextBoxColumn.MaxInputLength = 5;
            this.vENDNODataGridViewTextBoxColumn.Name = "vENDNODataGridViewTextBoxColumn";
            this.vENDNODataGridViewTextBoxColumn.Width = 90;
            // 
            // vENDKINDDataGridViewTextBoxColumn
            // 
            this.vENDKINDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vENDKINDDataGridViewTextBoxColumn.DataPropertyName = "VEND_KIND";
            this.vENDKINDDataGridViewTextBoxColumn.DataSource = this.vendKindBindingSource;
            this.vENDKINDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.vENDKINDDataGridViewTextBoxColumn.HeaderText = "國內外注記";
            this.vENDKINDDataGridViewTextBoxColumn.Name = "vENDKINDDataGridViewTextBoxColumn";
            this.vENDKINDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vENDKINDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vENDKINDDataGridViewTextBoxColumn.ValueMember = "Kind";
            this.vENDKINDDataGridViewTextBoxColumn.Width = 90;
            // 
            // vendKindBindingSource
            // 
            this.vendKindBindingSource.DataSource = typeof(ERPSYSTEM.DataSets.VendKind);
            // 
            // vENDFNMDataGridViewTextBoxColumn
            // 
            this.vENDFNMDataGridViewTextBoxColumn.DataPropertyName = "VEND_FNM";
            this.vENDFNMDataGridViewTextBoxColumn.HeaderText = "供應商簡稱";
            this.vENDFNMDataGridViewTextBoxColumn.Name = "vENDFNMDataGridViewTextBoxColumn";
            // 
            // vENDINVNODataGridViewTextBoxColumn
            // 
            this.vENDINVNODataGridViewTextBoxColumn.DataPropertyName = "VEND_INVNO";
            this.vENDINVNODataGridViewTextBoxColumn.HeaderText = "供應商統編";
            this.vENDINVNODataGridViewTextBoxColumn.Name = "vENDINVNODataGridViewTextBoxColumn";
            // 
            // tRAFACTDataGridViewTextBoxColumn
            // 
            this.tRAFACTDataGridViewTextBoxColumn.DataPropertyName = "TRA_FACT";
            this.tRAFACTDataGridViewTextBoxColumn.HeaderText = "轉廠注記";
            this.tRAFACTDataGridViewTextBoxColumn.Name = "tRAFACTDataGridViewTextBoxColumn";
            // 
            // userNo
            // 
            this.userNo.DataPropertyName = "USER_NO";
            this.userNo.HeaderText = "異動人";
            this.userNo.Name = "userNo";
            // 
            // modifyDt
            // 
            this.modifyDt.DataPropertyName = "MODIFY_DT";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.modifyDt.DefaultCellStyle = dataGridViewCellStyle2;
            this.modifyDt.HeaderText = "異動時間";
            this.modifyDt.Name = "modifyDt";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCancel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // mCancel
            // 
            this.mCancel.Name = "mCancel";
            this.mCancel.Size = new System.Drawing.Size(100, 22);
            this.mCancel.Text = "取消";
            this.mCancel.Click += new System.EventHandler(this.mCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供應商編號：";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(96, 22);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 21);
            this.textBox1.TabIndex = 1;
            // 
            // pUR
            // 
            this.pUR.DataSetName = "PUR";
            this.pUR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cVENDORMBindingSource
            // 
            this.cVENDORMBindingSource.DataMember = "CVENDORM";
            this.cVENDORMBindingSource.DataSource = this.pUR;
            // 
            // W_PUR_ENT_MA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Name = "W_PUR_ENT_MA1";
            this.Text = "供應商維護";
            this.Load += new System.EventHandler(this.W_PUR_ENT_MA1_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendKindBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVENDORMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendKindBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn factNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vENDKINDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDFNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDINVNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAFACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDt;
        private DataSets.PUR pUR;
        private System.Windows.Forms.BindingSource cVENDORMBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCancel;
    }
}
