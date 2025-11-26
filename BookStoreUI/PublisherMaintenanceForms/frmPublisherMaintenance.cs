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


namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherMaintenance : Form
    {
        public bool IsAdd = false;
        public frmPublisherMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            var frm = new frmPublisherDetail { IsAdd = true };
            frm.ShowDialog();
        }

        private void btbEditPublisher_Click(object sender, EventArgs e)
        {
            var frm = new frmPublisherDetail { IsAdd = false };
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Publisher");

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
