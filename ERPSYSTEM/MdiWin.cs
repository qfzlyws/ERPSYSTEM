using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPSYSTEM
{
    public partial class MdiWin : Form
    {
        public enum oprationStatus {Normal,New,Search,Modify };
        public MdiWin()
        {
            InitializeComponent();
        }

        private void MDIWIN_Load(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            desktop.MdiParent = this;
            desktop.WindowState = FormWindowState.Maximized;
            desktop.Show();
        }
    }
}
