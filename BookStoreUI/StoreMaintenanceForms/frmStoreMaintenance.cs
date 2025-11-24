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

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreMaintenance : Form
    {
        public frmStoreMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var frm = new frmStoreDetail { IsAdd = true };
            frm.ShowDialog();
        }

        private void btbEditStore_Click(object sender, EventArgs e)
        {
            var frm = new frmStoreDetail { IsAdd = true };
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Store");

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
