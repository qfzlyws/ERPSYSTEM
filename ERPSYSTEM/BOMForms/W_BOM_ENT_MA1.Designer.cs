using ERPSYSTEM.DataSets;

namespace ERPSYSTEM.BOMForms
{
    partial class W_BOM_ENT_MA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_BOM_ENT_MA1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borNm = new System.Windows.Forms.TextBox();
            this.borNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFindAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNo = new System.Windows.Forms.TextBox();
            this.modifyDt = new System.Windows.Forms.TextBox();
            this.cBORMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOM = new BOM();
            this.cBORMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBORMTableAdapter = new DataSets.BOMTableAdapters.CBORMTableAdapter();
            this.bORNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFY_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBORMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBORMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.modifyDt);
            this.splitContainer1.Panel2.Controls.Add(this.userNo);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.borNm);
            this.splitContainer1.Panel2.Controls.Add(this.borNo);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(591, 340);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bORNODataGridViewTextBoxColumn,
            this.bORNMDataGridViewTextBoxColumn,
            this.USER_NO,
            this.MODIFY_DT});
            this.dataGridView1.DataSource = this.cBORMBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // borNm
            // 
            this.borNm.Location = new System.Drawing.Point(84, 49);
            this.borNm.MaxLength = 20;
            this.borNm.Name = "borNm";
            this.borNm.Size = new System.Drawing.Size(100, 21);
            this.borNm.TabIndex = 3;
            // 
            // borNo
            // 
            this.borNo.Location = new System.Drawing.Point(84, 22);
            this.borNo.MaxLength = 2;
            this.borNo.Name = "borNo";
            this.borNo.Size = new System.Drawing.Size(33, 21);
            this.borNo.TabIndex = 2;
            this.borNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "制程名稱:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "制程編號:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFindAll,
            this.mNew,
            this.mSearch,
            this.mModify,
            this.mDelete,
            this.mSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFindAll
            // 
            this.mFindAll.Name = "mFindAll";
            this.mFindAll.Size = new System.Drawing.Size(44, 21);
            this.mFindAll.Text = "讀取";
            this.mFindAll.Click += new System.EventHandler(this.mFindAll_Click);
            // 
            // mNew
            // 
            this.mNew.Name = "mNew";
            this.mNew.Size = new System.Drawing.Size(44, 21);
            this.mNew.Text = "新增";
            this.mNew.Click += new System.EventHandler(this.mNew_Click);
            // 
            // mSearch
            // 
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(44, 21);
            this.mSearch.Text = "查詢";
            this.mSearch.Click += new System.EventHandler(this.mSearch_Click);
            // 
            // mModify
            // 
            this.mModify.Name = "mModify";
            this.mModify.Size = new System.Drawing.Size(44, 21);
            this.mModify.Text = "修改";
            this.mModify.Click += new System.EventHandler(this.mModify_Click);
            // 
            // mDelete
            // 
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(44, 21);
            this.mDelete.Text = "刪除";
            this.mDelete.Click += new System.EventHandler(this.mDelete_Click);
            // 
            // mSave
            // 
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(44, 21);
            this.mSave.Text = "保存";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "異動人:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "異動時間:";
            // 
            // userNo
            // 
            this.userNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userNo.Enabled = false;
            this.userNo.Location = new System.Drawing.Point(84, 76);
            this.userNo.Name = "userNo";
            this.userNo.Size = new System.Drawing.Size(100, 21);
            this.userNo.TabIndex = 6;
            // 
            // modifyDt
            // 
            this.modifyDt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyDt.Enabled = false;
            this.modifyDt.Location = new System.Drawing.Point(84, 103);
            this.modifyDt.Name = "modifyDt";
            this.modifyDt.Size = new System.Drawing.Size(135, 21);
            this.modifyDt.TabIndex = 7;
            // 
            // cBORMBindingSource1
            // 
            this.cBORMBindingSource1.DataMember = "CBORM";
            this.cBORMBindingSource1.DataSource = this.bOM;
            // 
            // bOM
            // 
            this.bOM.DataSetName = "BOM";
            this.bOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBORMBindingSource
            // 
            this.cBORMBindingSource.DataMember = "CBORM";
            this.cBORMBindingSource.DataSource = this.bOM;
            // 
            // cBORMTableAdapter
            // 
            this.cBORMTableAdapter.ClearBeforeFill = true;
            // 
            // bORNODataGridViewTextBoxColumn
            // 
            this.bORNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bORNODataGridViewTextBoxColumn.DataPropertyName = "BOR_NO";
            this.bORNODataGridViewTextBoxColumn.HeaderText = "制程編號";
            this.bORNODataGridViewTextBoxColumn.Name = "bORNODataGridViewTextBoxColumn";
            this.bORNODataGridViewTextBoxColumn.ReadOnly = true;
            this.bORNODataGridViewTextBoxColumn.Width = 78;
            // 
            // bORNMDataGridViewTextBoxColumn
            // 
            this.bORNMDataGridViewTextBoxColumn.DataPropertyName = "BOR_NM";
            this.bORNMDataGridViewTextBoxColumn.HeaderText = "制程名稱";
            this.bORNMDataGridViewTextBoxColumn.Name = "bORNMDataGridViewTextBoxColumn";
            this.bORNMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // USER_NO
            // 
            this.USER_NO.DataPropertyName = "USER_NO";
            this.USER_NO.HeaderText = "USER_NO";
            this.USER_NO.Name = "USER_NO";
            this.USER_NO.ReadOnly = true;
            this.USER_NO.Visible = false;
            // 
            // MODIFY_DT
            // 
            this.MODIFY_DT.DataPropertyName = "MODIFY_DT";
            this.MODIFY_DT.HeaderText = "MODIFY_DT";
            this.MODIFY_DT.Name = "MODIFY_DT";
            this.MODIFY_DT.ReadOnly = true;
            this.MODIFY_DT.Visible = false;
            // 
            // W_BOM_ENT_MA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 365);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "W_BOM_ENT_MA1";
            this.Text = "制程基本資料";
            this.Load += new System.EventHandler(this.BorWin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBORMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBORMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BOM bOM;
        private System.Windows.Forms.BindingSource cBORMBindingSource;
        private DataSets.BOMTableAdapters.CBORMTableAdapter cBORMTableAdapter;
        private System.Windows.Forms.BindingSource cBORMBindingSource1;
        private System.Windows.Forms.TextBox borNm;
        private System.Windows.Forms.TextBox borNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFindAll;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripMenuItem mSearch;
        private System.Windows.Forms.ToolStripMenuItem mModify;
        private System.Windows.Forms.ToolStripMenuItem mDelete;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modifyDt;
        private System.Windows.Forms.TextBox userNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bORNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bORNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFY_DT;
    }
}