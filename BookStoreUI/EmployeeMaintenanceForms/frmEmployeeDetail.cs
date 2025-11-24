using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using BookStoreBO;
using System.Text.RegularExpressions;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

namespace BookStoreUI.EmployeeMaintenanceForms
{
    public partial class frmEmployeeDetail : Form
    {
        public frmEmployeeDetail()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

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
            string errMsg = "";


            string empId = txtEmpId.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleInit = txtMidInitial.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            int jobId = (int)nudJobId.Value;
            int jobLevel = (int)nudJobLevel.Value;

            DateTime hireDate = dtpHireDate.Value;


            errMsg += Validator.IsPresent(empId, "Employee ID");
            if (empId != "")
            {

                var regex = new Regex(
                    @"^[A-Z]{3}[1-9][0-9]{4}[FM]$|^[A-Z]-[A-Z][1-9][0-9]{4}[FM]$");

                if (!regex.IsMatch(empId))
                {
                    errMsg += "Employee ID format is invalid. Examples: ABC10000F or A-B10000M.\n";
                }
            }


            errMsg += Validator.IsPresent(firstName, "First Name");
            errMsg += Validator.IsWithinLength(firstName, "First Name", 1, 20);


            errMsg += Validator.IsWithinLength(middleInit, "Middle Initial", 0, 1);


            errMsg += Validator.IsPresent(lastName, "Last Name");
            errMsg += Validator.IsWithinLength(lastName, "Last Name", 1, 30);


            if (jobId <= 0)
            {
                errMsg += "Job ID must be greater than 0.\n";
            }


            if (jobLevel < 0 || jobLevel > 255)
            {
                errMsg += "Job Level must be between 0 and 255.\n";
            }


            errMsg += Validator.IsMaskCompleted(mtbPubId.MaskCompleted, "Publisher ID");


            if (hireDate.Date > DateTime.Today)
            {
                errMsg += "Hire Date cannot be in the future.\n";
            }


            if (errMsg == "")
                return true;

            MessageBox.Show(
                errMsg,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }


        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Employee" : @"Edit Employee";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;   // Stop if there are validation errors

            // TODO: save to the database (insert/update employee)

            MessageBox.Show(
                "Employee information saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            txtEmpId.Focus();
        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
