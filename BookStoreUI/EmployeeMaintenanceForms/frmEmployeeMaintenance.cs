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

namespace BookStoreUI.EmployeeMaintenanceForms
{
    public partial class frmEmployeeMaintenance : Form
    {
        public bool IsAdd = false;   
        public frmEmployeeMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployeeDetail { IsAdd = true };
            frm.ShowDialog();
        }

        private void btbEditEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployeeDetail { IsAdd = false };
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Employee");

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
