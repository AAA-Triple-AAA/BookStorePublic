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
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreMaintenance : Form
    {
        private BookStoreDataAccess _data = new();
        private Store? _store;

        public frmStoreMaintenance()
        {
            InitializeComponent();
        }

        private void SetRichTextBox(Store store)
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID: {_store.StorId}");
            sb.AppendLine($"Name: {_store.StorName}");
            sb.AppendLine($"Address: {_store.StorAddress}");
            sb.AppendLine($"City: {_store.City}");
            sb.AppendLine($"State: {_store.State}");
            sb.AppendLine($"Zip: {_store.Zip}");

            rtbDetails.Text = sb.ToString();
        }

        private void LoadData()
        {
            var stores = _data.GetStores();
            dgvStore.DataSource = null;
            dgvStore.DataSource = stores;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            var frm = new frmStoreDetail { IsAdd = true };
            frm.ShowDialog();
            LoadData();
        }

        private void btbEditStore_Click(object sender, EventArgs e)
        {
            if (_store == null)
            {
                MessageBox.Show(@"Must select a stores");
                return;
            }

            var frm = new frmStoreDetail { IsAdd = false, Store = _store };
            frm.ShowDialog();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Store");

            if (errMsg == "")
            { 
                var searchText = txtSearch.Text.Trim().ToLower();

                var allStores = _data.GetStores();

                var match = false;

                var sortedStores = allStores.OrderByDescending(s =>
                    {
                        var result = s.StorName.ToLower().Contains(searchText) ||
                                     s.StorId.ToString().Contains(searchText);

                        if (!match) match = result;

                        return result;
                    })
                    .ThenBy(s => s.StorId)
                    .ToList();

                dgvStore.DataSource = null;
                dgvStore.DataSource = sortedStores;

                if (match)
                {
                    dgvStore.Rows[0].Selected = true;
                }
                else
                {
                    rtbDetails.Clear();
                    _store = null;
                    MessageBox.Show(@"No stores found matching your criteria.", @"Store not found",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void dgvStore_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStore.SelectedRows.Count == 0) return;

            var row = dgvStore.SelectedRows[0];
            var possibleStore = row.DataBoundItem;

            if (possibleStore is not Store store) return;

            _store = store;

            SetRichTextBox(store);
        }

        private void frmStoreMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            if (_store == null)
            {
                MessageBox.Show(@"Must select a store");
                return;
            }

            var result = MessageBox.Show($@"Are you sure you want to delete {_store.StorName} ({_store.StorId})",
                @"Delete Store",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            _data.DeleteStore(_store);
            LoadData();
        }
    }
}
