using BookStoreBO;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreDO.Models.DataLayer; 
using System.Windows.Forms;

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreMaintenance : Form
    {
        private readonly StoreManager _storeManager = new StoreManager();

        public frmStoreMaintenance()
        {
            InitializeComponent();
        }

        private void frmStoreMaintenance_Load(object sender, EventArgs e)
        {
            var stores = _storeManager.GetAllStores();
            dgvStore.AutoGenerateColumns = false;
            dgvStore.DataSource = stores;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var frm = new frmStoreDetail { IsAdd = true };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var stores = _storeManager.GetAllStores();
                dgvStore.AutoGenerateColumns = false;
                dgvStore.DataSource = stores;
            }
        }

        private void btbEditStore_Click(object sender, EventArgs e)
        {
            if (dgvStore.CurrentRow?.DataBoundItem is not Store selectedStore)
            {
                MessageBox.Show("Please select a store to edit.");
                return;
            }
            var frm = new frmStoreDetail
            {
                IsAdd = false,
                CurrentStore = selectedStore
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var stores = _storeManager.GetAllStores();
                dgvStore.AutoGenerateColumns = false;
                dgvStore.DataSource = stores;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Store");

            if (errMsg == "")
            {
                string term = txtSearch.Text.Trim();
                var stores = _storeManager.SearchStores(term);
                dgvStore.DataSource = stores;
                UpdateDetails();
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {

            if (dgvStore.CurrentRow?.DataBoundItem is not Store selectedStore)
            {
                MessageBox.Show("Please select a store to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete store '{selectedStore.StorName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _storeManager.DeleteStore(selectedStore.StorId);
                var stores = _storeManager.GetAllStores();
                dgvStore.AutoGenerateColumns = false;
                dgvStore.DataSource = stores;
            }

        }

        private void dgvStore_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            if (dgvStore.CurrentRow == null)
            {
                rtbDetails.Clear();
                return;
            }

            var selected = dgvStore.CurrentRow.DataBoundItem as Store;
            if (selected == null)
            {
                rtbDetails.Clear();
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Store ID: {selected.StorId}");
            sb.AppendLine($"Name: {selected.StorName}");
            sb.AppendLine($"City: {selected.City}");
            sb.AppendLine($"State: {selected.State}");
            sb.AppendLine($"Zip: {selected.Zip}");

            rtbDetails.Text = sb.ToString();
        }
    }
}
