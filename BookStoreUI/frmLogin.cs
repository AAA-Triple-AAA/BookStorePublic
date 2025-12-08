using System;
using System.Linq;
using System.Windows.Forms;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;

namespace BookStoreUI
{
    public partial class frmLogin : Form
    {
        private readonly BookStoreDataAccess _data = new();

        // In case we want to use it at another time
        public Employee? LoggedInEmployee { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            LoadEmployees();
        }

        // Load employees when the form opens
        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = _data.GetEmployees()
                                 .OrderBy(e => e.Lname)
                                 .ThenBy(e => e.Fname)
                                 .ToList();

            // Simple version: show only the EmpId 
            cboEmployee.DataSource = employees;
            cboEmployee.DisplayMember = "EmpId";   // what is seen in the list
            cboEmployee.ValueMember = "EmpId";     // associated value

            cboEmployee.SelectedIndex = -1; // nothing selected at the start
        }

        private bool ValidateInput()
        {
            if (cboEmployee.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select an employee.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            // We already know that SelectedItem is not null thanks to ValidateInput
            var selectedEmployee = (Employee)cboEmployee.SelectedItem!;

            var frm = new frmMainMenu(selectedEmployee);
            frm.FormClosed += (s, args) => this.Close();

            frm.Show();
            this.Hide();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
