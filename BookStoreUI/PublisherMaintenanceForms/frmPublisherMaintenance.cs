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



namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherMaintenance : Form
    {
        public bool IsAdd = false;

        private readonly BookStoreDataAccess _data = new();
        public frmPublisherMaintenance()
        {
            InitializeComponent();
        }
        private void LoadPublishers(string? searchTerm = null)
        {
            var publishers = _data.GetPublishers();  

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string term = searchTerm.Trim().ToLower();

                publishers = publishers
                    .Where(p =>
                        p.PubId.ToLower().Contains(term) ||
                        p.PubName.ToLower().Contains(term))
                    .ToList();
            }
         
            dgvPublisher.AutoGenerateColumns = false;
            dgvPublisher.DataSource = publishers;
        }

   
        private void frmPublisherMaintenance_Load(object sender, EventArgs e)
        {
            LoadPublishers();
        }


        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPublisherDetail())
            {
                frm.IsAdd = true;
                frm.Publisher = null;

                var result = frm.ShowDialog();

             
                if (result == DialogResult.OK)
                {
                    LoadPublishers();
                }
            }
        }

        private void btbEditPublisher_Click(object sender, EventArgs e)
        {
            if (dgvPublisher.CurrentRow?.DataBoundItem is not Publisher selected)
            {
                MessageBox.Show("Please select a publisher to edit.");
                return;
            }

            var publisherFromDb = _data.GetPublisher(selected.PubId);
            if (publisherFromDb == null)
            {
                MessageBox.Show("Selected publisher could not be found.");
                return;
            }

            using (var frm = new frmPublisherDetail())
            {
                frm.IsAdd = false;
                frm.Publisher = publisherFromDb;

                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadPublishers();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Publisher");

            if (errMsg == "")
            {
                LoadPublishers(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if (dgvPublisher.CurrentRow?.DataBoundItem is not Publisher selected)
            {
                MessageBox.Show("Please select a publisher to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete publisher '{selected.PubName}' ({selected.PubId})?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            _data.DeletePublisher(selected);
            LoadPublishers();
        }

    }
}
