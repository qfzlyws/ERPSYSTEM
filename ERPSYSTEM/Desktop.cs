using ERPSYSTEM.DataSets;
using ERPSYSTEM.DataSets.SYSPROGTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ERPSYSTEM
{
    public partial class Desktop : Form
    {
        private TreeNode node = null;
        private SYSPROG.SYSPROGDataTable sysprog = null;
        private SYSPROGTableAdapter sysprogTableAdapter = null;

        public Desktop()
        {
            InitializeComponent();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            sysprog = new SYSPROG.SYSPROGDataTable();
            sysprogTableAdapter = new SYSPROGTableAdapter();

            sysprogTableAdapter.Fill(sysprog);

            node = new TreeNode();
            node.Text = "系統目錄";
            treeView1.Nodes.Add(node);
            SetChildNodes(node);
            node.ExpandAll();
        }

        private void SetChildNodes(TreeNode parentNode)
        {
            if (parentNode.Level == 0) //為根節點添加子系統明細
            {
                var sysname = (from sys in sysprog orderby sys.MIS_NO select new { sys.MIS_NO, sys.MIS_NM }).Distinct();

                foreach (var tmp in sysname)
                {
                    node = new TreeNode();
                    node.Text = tmp.MIS_NM;
                    node.Tag = tmp.MIS_NO;
                    parentNode.Nodes.Add(node);

                    SetChildNodes(node);
                }
            }
            else if (parentNode.Level == 1) //為子系統節點添加模塊明細
            {
                string misNo = parentNode.Tag.ToString();

                var sysmodule = (from module in sysprog where module.MIS_NO == misNo orderby module.MOD_ID select new { module.MOD_ID, module.MOD_NM }).Distinct();

                foreach (var tmp in sysmodule)
                {
                    node = new TreeNode();
                    node.Text = tmp.MOD_NM;
                    node.Tag = tmp.MOD_ID;
                    parentNode.Nodes.Add(node);

                    SetChildNodes(node);
                }
            }
            else if (parentNode.Level == 2) //為模塊節點添加程式明細
            {
                string misNo = parentNode.Parent.Tag.ToString();
                string modId = parentNode.Tag.ToString();

                var progs = (from prog in sysprog
                            where prog.MIS_NO == misNo && prog.MOD_ID == modId
                            orderby prog.PROG_SEQ
                            select new { prog.PROG_SEQ,prog.PROG_NO, prog.PROG_NM });

                foreach(var tmp in progs)
                {
                    node = new TreeNode();
                    node.Text = tmp.PROG_SEQ + "." + tmp.PROG_NM;
                    node.Tag = tmp.PROG_NO.Trim();
                    parentNode.Nodes.Add(node);
                }
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            node = treeView1.SelectedNode;

            if(node != null && node.Level == 3)
            {
                try
                {
                    string misNo = node.Parent.Parent.Tag.ToString();

                    Type t = Type.GetType("ERPSYSTEM." + misNo + "Forms." + node.Tag.ToString());
                    Form win = (Form)Activator.CreateInstance(t);
                    win.MdiParent = this.MdiParent;
                    win.WindowState = FormWindowState.Maximized;
                    win.Show();
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
