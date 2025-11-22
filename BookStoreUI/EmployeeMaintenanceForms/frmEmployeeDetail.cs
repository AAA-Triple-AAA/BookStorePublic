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

        private bool ValidateInput()
        {
            var errMsg = Validator.IsPresent(txtEmp_id.Text, "Employee ID");
            errMsg += Validator.IsPresent(txtFname.Text, "First Name");
            errMsg += Validator.IsPresent(txtminit.Text, "Middle Initial");
            errMsg += Validator.IsWithinLength(txtminit.Text, "Middle Initial", 0, 1);
            errMsg += Validator.IsPresent(txtLname.Text, "Last Name");
            errMsg += Validator.IsPresent(nudJob_id.Text, "Job ID");
            errMsg += Validator.IsPresent(nudJobLevel.Text, "Job Level");
            errMsg += Validator.IsPresent(txtLname.Text, "Last Name");
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
