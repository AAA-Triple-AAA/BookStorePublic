using BookStoreUI.EmployeeMaintenanceForms;
using BookStoreUI.PublisherMaintenanceForms;
using BookStoreUI.StoreMaintenanceForms;
using System;
using System.Windows.Forms;
using BookStoreDO.Models.DataLayer;   //  for Employee

namespace BookStoreUI
{
    public partial class frmMainMenu : Form
    {
        //  We save the employee who logged in
        private readonly Employee _loggedInEmployee;

        //  The main menu NOW receives the employee in the constructor
        public frmMainMenu(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee ?? throw new ArgumentNullException(nameof(loggedInEmployee));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTitleMaintenance_Click(object sender, EventArgs e)
        {
            frmTitleMaintenance frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAuthorMaintenance_Click(object sender, EventArgs e)
        {
            frmAuthorMaintenance frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEmployeeMaintenance_Click(object sender, EventArgs e)
        {
            frmEmployeeMaintenance frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPublisherMaintenance_Click(object sender, EventArgs e)
        {
            frmPublisherMaintenance frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnStoreMaintenance_Click(object sender, EventArgs e)
        {
            frmStoreMaintenance frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmSalesReport frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            //  THIS is where we use the employee who logged in
            using (var frm = new frmCustomerOrder(_loggedInEmployee))
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
