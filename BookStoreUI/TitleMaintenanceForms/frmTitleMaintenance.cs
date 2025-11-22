using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreBO;

namespace BookStoreUI
{
    public partial class frmTitleMaintenance : Form
    {
        public frmTitleMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            var frm = new frmTitleDetail { IsAdd = true };
            frm.ShowDialog();
        }

        private void btbEditTitle_Click(object sender, EventArgs e)
        {
            var frm = new frmTitleDetail { IsAdd = false };
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Title");

            if (errMsg == "")
            {
                // TODO: SEARCH LOGIC
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
    }
}
