using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookStoreBO;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;

namespace BookStoreUI.EmployeeMaintenanceForms
{
    public partial class frmEmployeeMaintenance : Form
    {
        private readonly BookStoreDataAccess _data = new();

        private Employee? _employee;

        public frmEmployeeMaintenance()
        {
            InitializeComponent();
        }

        private void SetRichTextBox(Employee emp)
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID: {emp.EmpId}");
            sb.AppendLine($"First Name: {emp.Fname}");
            sb.AppendLine($"Middle Initial: {emp.Minit}");
            sb.AppendLine($"Last Name: {emp.Lname}");
            sb.AppendLine($"Job ID: {emp.JobId}");
            sb.AppendLine($"Job Level: {emp.JobLvl}");
            sb.AppendLine($"Pub ID: {emp.PubId}");
            sb.AppendLine($"Hire Date: {emp.HireDate:d}");

            rtbDetails.Text = sb.ToString();
        }

        private void LoadData()
        {
            var employees = _data.GetEmployees();
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = employees;

            /*
            // Optional: Adjust headers if the designer didn't create them
            dgvEmployee.Columns[nameof(Employee.EmpId)].HeaderText = "Employee ID";
            dgvEmployee.Columns[nameof(Employee.Fname)].HeaderText = "First Name";
            dgvEmployee.Columns[nameof(Employee.Minit)].HeaderText = "Middle Initial";
            dgvEmployee.Columns[nameof(Employee.Lname)].HeaderText = "Last Name";
            dgvEmployee.Columns[nameof(Employee.JobId)].HeaderText = "Job ID";
*/
        }

        private void frmEmployeeMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0) return;

            var row = dgvEmployee.SelectedRows[0];
            var possibleEmp = row.DataBoundItem;

            if (possibleEmp is not Employee emp) return;

            _employee = emp;
            SetRichTextBox(emp);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployeeDetail { IsAdd = true };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else
            {
                // Incluso si devuelve Cancel, puede haber insertado antes de cerrar;
                // para estar seguros, se puede recargar
                LoadData();
            }
        }

        private void btbEditEmployee_Click(object sender, EventArgs e)
        {
            if (_employee == null)
            {
                MessageBox.Show(@"Must select an employee");
                return;
            }

            var frm = new frmEmployeeDetail
            {
                IsAdd = false,
                Employee = _employee   // // <-- Here we pass on the selected employee
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();   // Reload the grid after editing
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (_employee == null)
            {
                MessageBox.Show(@"Must select an employee");
                return;
            }

            var result = MessageBox.Show(
                $@"Are you sure you want to delete {_employee.Lname}, {_employee.Fname}?",
                @"Delete Employee",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                _data.DeleteEmployee(_employee);
                _employee = null;
                rtbDetails.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while deleting the employee:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Employee");

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            var searchText = txtSearch.Text.Trim().ToLower();

            var allEmps = _data.GetEmployees();

            var match = false;

            var filtered = allEmps
                .OrderByDescending(emp =>
                {
                    var fullName = $"{emp.Fname.ToLower()} {emp.Lname.ToLower()}";
                    var fullNameLastFirst = $"{emp.Lname.ToLower()} {emp.Fname.ToLower()}";

                    var result =
                        emp.EmpId.ToLower().Contains(searchText) ||
                        emp.Fname.ToLower().Contains(searchText) ||
                        emp.Lname.ToLower().Contains(searchText) ||
                        fullName.Contains(searchText) ||
                        fullNameLastFirst.Contains(searchText);

                    if (!match) match = result;

                    return result;
                })
                .ThenBy(emp => emp.EmpId)
                .ToList();

            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = filtered;

            if (match && dgvEmployee.Rows.Count > 0)
            {
                dgvEmployee.Rows[0].Selected = true;
            }
            else
            {
                rtbDetails.Clear();
                _employee = null;
                MessageBox.Show(
                    @"No employees found matching your criteria.",
                    @"Employee not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                LoadData();
            }
        }
    }
}
