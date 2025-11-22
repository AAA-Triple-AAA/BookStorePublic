using BookStoreUI.EmployeeMaintenanceForms;
using BookStoreUI.PublisherMaintenanceForms;
using BookStoreUI.StoreMaintenanceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
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
            frmCustomerOrder frm = new();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
