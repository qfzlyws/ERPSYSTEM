using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYSTEM.BLL;
using ERPSYSTEM.DataSets;

namespace ERPSYSTEM.PURForms
{
    public partial class W_PUR_ENT_MA1 : ERPSYSTEM.COMMON.EditSingleForm
    {
        private VendorBLL vendorBll;

        public W_PUR_ENT_MA1()
        {
            InitializeComponent();

            vendorBll = new VendorBLL();
            this.cVENDORMBindingSource.DataSource = new PUR.CVENDORMDataTable();
            this.dataGridView1.DataSource = this.cVENDORMBindingSource;
        }

        private void W_PUR_ENT_MA1_Load(object sender, EventArgs e)
        {
            VendKind vend = new VendKind("1", "國內");
            this.vendKindBindingSource.Add(vend);

            vend = new VendKind("2", "國外");
            this.vendKindBindingSource.Add(vend);
        }

        protected override void mFindAll_Click(object sender, EventArgs e)
        {
            this.cVENDORMBindingSource.DataSource = vendorBll.GetVendors();
        }

        protected override void mSearch_Click(object sender, EventArgs e)
        {
            string vendNo = this.textBox1.Text;

            if(vendNo.Trim().Equals("")||vendNo == null)
            {
                MessageBox.Show("請輸入供應商編號!");
                this.textBox1.Focus();
                return;
            }

            this.cVENDORMBindingSource.DataSource = vendorBll.GetVendorById(vendNo);
        }

        protected override void mSave_Click(object sender, EventArgs e)
        {
            this.cVENDORMBindingSource.EndEdit();
            vendorBll.UpdateVendors((PUR.CVENDORMDataTable)this.cVENDORMBindingSource.DataSource);
        }

        protected override void mDelete_Click(object sender, EventArgs e)
        {
            this.cVENDORMBindingSource.RemoveCurrent();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["factNo"].Value = "0721";
            e.Row.Cells["userNo"].Value = "CR007975";
            e.Row.Cells["modifyDt"].Value = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }

        private void mCancel_Click(object sender, EventArgs e)
        {
            this.cVENDORMBindingSource.CancelEdit();
        }
    }
}
