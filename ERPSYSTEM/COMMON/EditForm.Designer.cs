namespace ERPSYSTEM.COMMON
{
    partial class EditForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFindAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(496, 25);
            this.menuStrip1.TabIndex = 4;
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
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(496, 346);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFindAll;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripMenuItem mSearch;
        private System.Windows.Forms.ToolStripMenuItem mModify;
        private System.Windows.Forms.ToolStripMenuItem mDelete;
        private System.Windows.Forms.ToolStripMenuItem mSave;
    }
}
