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
    public partial class frmCustomerOrder : Form
    {
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            var errMsg = Validator.IsSelected(cboStore.SelectedIndex, "Store");
            errMsg += Validator.IsSelected(cboEmployee.SelectedIndex, "Employee");
            errMsg += Validator.IsPresent(txtCustomerName.Text, "Customer Name");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearchTitle.Text, "Title");

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
