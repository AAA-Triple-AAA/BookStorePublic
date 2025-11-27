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
using System.Text.RegularExpressions;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;


namespace BookStoreUI.EmployeeMaintenanceForms
{
    public partial class frmEmployeeDetail : Form
    {
        public bool IsAdd = false;
        public Employee? Employee { get; set; }

        private readonly BookStoreDataAccess _data = new();

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

            //JOB VALIDATION
            if (jobLevel < 0 || jobLevel > 255)
            {
                errMsg += "Job Level must be between 0 and 255.\n";
            }

            var job = _data.GetJob((short)jobId);

            if (job == null)
            {
                errMsg += $"Job ID {jobId} does not exist in Jobs table.\n";
            }
            else
            {
                // Special rule: job_id = 1 → level = 10
                if (job.JobId == 1 && jobLevel != 10)
                {
                    errMsg += "Job ID 1 expects the job level to be exactly 10.\n";
                }
                // For everyone else: level between min and max of that row in JOBS
                else if (job.JobId != 1 &&
                         (jobLevel < job.MinLvl || jobLevel > job.MaxLvl))
                {
                    errMsg += $"Job Level for Job ID {jobId} must be between {job.MinLvl} and {job.MaxLvl}.\n";
                }
            }

            //----------------------------------------------------------------------------------------------------------

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

            if (!IsAdd && Employee != null)
            {
                // Do not allow changing the PK while editing
                txtEmpId.Enabled = false;

                // Show existing employee data
                txtEmpId.Text = Employee.EmpId;
                txtFirstName.Text = Employee.Fname;
                txtMidInitial.Text = Employee.Minit;
                txtLastName.Text = Employee.Lname;
                nudJobId.Value = Employee.JobId;
                nudJobLevel.Value = Employee.JobLvl ?? 10;
                mtbPubId.Text = Employee.PubId;
                dtpHireDate.Value = Employee.HireDate;
            }

            //  Adjust the Job Level range according to the current Job ID
            UpdateJobLevelRange();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            ApplyChanges();

            try
            {
                if (IsAdd)
                {
                    // Verificar que el ID no exista
                    if (_data.GetEmployee(Employee!.EmpId) != null)
                    {
                        MessageBox.Show(@"Employee ID already taken, please enter a unique ID.");
                        return;
                    }

                    _data.AddEmployee(Employee!);
                }
                else
                {
                    _data.UpdateEmployee(Employee!);
                }

                MessageBox.Show(
                    "Employee information saved successfully.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while saving the employee:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApplyChanges()
        {
            // Si estamos agregando, o si por alguna razón Employee es null, creamos uno nuevo
            if (IsAdd || Employee == null)
            {
                Employee = new Employee();
            }

            Employee.EmpId = txtEmpId.Text.Trim();
            Employee.Fname = txtFirstName.Text.Trim();
            Employee.Minit = txtMidInitial.Text.Trim();
            Employee.Lname = txtLastName.Text.Trim();
            Employee.JobId = (short)nudJobId.Value;      // SMALLINT
            Employee.JobLvl = (byte)nudJobLevel.Value;    // TINYINT
            Employee.PubId = mtbPubId.Text;
            Employee.HireDate = dtpHireDate.Value;
        }

        private void UpdateJobLevelRange()
        {
            // We take the current Job ID from NumericUpDown
            short jobId = (short)nudJobId.Value;

            // We look for that job in the JOBS table
            var job = _data.GetJob(jobId);

            if (job == null)
            {
                // If the Job does not exist, we leave a generic range.
                nudJobLevel.Minimum = 0;
                nudJobLevel.Maximum = 255;
                return;
            }

            // We assume that in Job.cs you have something like:
            // public byte MinLvl { get; set; }
            // public byte MaxLvl { get; set; }
            // public short JobId { get; set; }

            var min = job.MinLvl;
            var max = job.MaxLvl;

            nudJobLevel.Minimum = min;
            nudJobLevel.Maximum = max;

            // Special rule: Job 1 → level 10 required
            if (job.JobId == 1)
            {
                nudJobLevel.Value = 10;
            }
            else
            {
                // For other jobs, if the current level is out of range, we move it to the minimum.
                if (nudJobLevel.Value < min || nudJobLevel.Value > max)
                {
                    nudJobLevel.Value = min;
                }
            }
        }

        private void nudJobId_ValueChanged(object sender, EventArgs e)
        {
            UpdateJobLevelRange();
        }


    }
}
