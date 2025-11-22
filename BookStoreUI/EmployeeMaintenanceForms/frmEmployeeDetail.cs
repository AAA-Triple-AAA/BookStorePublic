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
    public partial class frmEmployeeDetail : Form
    {
        public bool IsAdd = false;

        public frmEmployeeDetail()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtEmpId.Clear();
            txtFirstName.Clear();
            txtMidInitial.Clear();
            txtLastName.Clear();
            nudJobId.Value = 1;
            nudJobLevel.Value = 10;
            mtbPubId.Clear();
            dtpHireDate.Value = DateTime.Now;
        }

        private bool ValidateInput()
        {
            var errMsg = Validator.IsPresent(txtEmpId.Text, "Employee ID");
            errMsg += Validator.IsPresent(txtFirstName.Text, "First Name");
            errMsg += Validator.IsPresent(txtMidInitial.Text, "Middle Initial");
            errMsg += Validator.IsWithinLength(txtMidInitial.Text, "Middle Initial", 0, 1);
            errMsg += Validator.IsPresent(txtLastName.Text, "Last Name");
            errMsg += Validator.IsPresent(nudJobId.Text, "Job ID");
            errMsg += Validator.IsPresent(nudJobLevel.Text, "Job Level");
            errMsg += Validator.IsPresent(txtLastName.Text, "Last Name");
            errMsg += Validator.IsMaskCompleted(mtbPubId.MaskCompleted, "Publisher ID");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Employee" : @"Edit Employee";
        }
    }
}
