using ERPSYSTEM.DataSets;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERPSYSTEM.DataSets.BOMTableAdapters;

namespace ERPSYSTEM.BOMForms
{
    public partial class W_BOM_ENT_MA1 : Form
    {
        private MdiWin.oprationStatus status;
        private BorDAO borDAO = null;
        private BOM.CBORMDataTable cborm = null;
        private CBORMTableAdapter bormTableAdapter = null;
        private int currentRowIndex = -1;

        public W_BOM_ENT_MA1()
        {
            InitializeComponent();
        }

        private void BorWin_Load(object sender, EventArgs e)
        {
            this.oprarionStatusControll(MdiWin.oprationStatus.Normal);
            cborm = new BOM.CBORMDataTable();
            bormTableAdapter = new DataSets.BOMTableAdapters.CBORMTableAdapter();
            borDAO = new BorDAO(cborm,bormTableAdapter);
            this.dataGridView1.DataSource = cborm;
        }

        private void mSearch_Click(object sender, EventArgs e)
        {
            this.oprarionStatusControll(MdiWin.oprationStatus.Search);
        }

        protected void oprarionStatusControll(MdiWin.oprationStatus status) {
            switch (status) {
                case MdiWin.oprationStatus.Normal:
                    this.borNo.Enabled = false;
                    this.borNm.Enabled = false;
                    this.status = status;
                    break;
                case MdiWin.oprationStatus.New:
                    this.borNm.Text = "";
                    this.borNo.Text = "";
                    this.borNo.Enabled = true;
                    this.borNm.Enabled = true;
                    this.borNo.Focus();
                    this.status = status;
                    break;
                case MdiWin.oprationStatus.Modify:
                    this.borNo.Enabled = false;
                    this.borNm.Enabled = true;
                    this.borNm.Focus();
                    this.status = status;
                    break;
                case MdiWin.oprationStatus.Search:
                    this.borNo.Enabled = true;
                    this.borNm.Enabled = false;
                    this.borNo.Focus();
                    this.status = status;
                    break;
            }
        }

        private void mNew_Click(object sender, EventArgs e)
        {
            this.oprarionStatusControll(MdiWin.oprationStatus.New);
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            string borNo = this.borNo.Text;
            string borNm = this.borNm.Text;

            switch (status)
            {
                case MdiWin.oprationStatus.New:
                    borDAO.Add(borNo, borNm);
                    break;

                case MdiWin.oprationStatus.Modify:
                    borDAO.Modify(borNo, borNm);
                    break;
            }

            this.oprarionStatusControll(MdiWin.oprationStatus.Normal);

        }

        private void mModify_Click(object sender, EventArgs e)
        {
            this.oprarionStatusControll(MdiWin.oprationStatus.Modify);
        }

        private void mFindAll_Click(object sender, EventArgs e)
        {
            borDAO.findAll();
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }

        private void borNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                if (status == MdiWin.oprationStatus.Search)
                {
                    int findRow = borDAO.Search(this.borNo.Text);

                    if (findRow == -1)
                        MessageBox.Show("無符合條件的資料!");
                    else
                    {
                        dataGridView1.CurrentCell = dataGridView1[1, findRow];
                    }

                    this.oprarionStatusControll(MdiWin.oprationStatus.Normal);
                }
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell.RowIndex != currentRowIndex)
            {
                this.borNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.borNm.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.userNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.modifyDt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                currentRowIndex = dataGridView1.CurrentRow.Index;
            }
        }

        private void mDelete_Click(object sender, EventArgs e)
        {
            //啟用事務控制的刪除功能
            //默認情況下，TableAdapter會自動提交或回滾事務
            bormTableAdapter.Connection.Open();
            OracleTransaction trans = bormTableAdapter.Connection.BeginTransaction();
            try
            {
                borDAO.Delete(this.borNo.Text);

                trans.Commit();
            }
            catch(Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            bormTableAdapter.Connection.Close();
        }
    }
}
