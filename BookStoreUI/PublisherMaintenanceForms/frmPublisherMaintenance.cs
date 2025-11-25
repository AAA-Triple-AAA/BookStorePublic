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
using BookStoreBO.DTOs;


namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherMaintenance : Form
    {
        private readonly BookStoreDataAccess _dataAccess = new BookStoreDataAccess(); 

        public bool IsAdd = false;
        public frmPublisherMaintenance()
        {
            InitializeComponent();
        }
        private void frmPublisherMaintenance_Load(object sender, EventArgs e)
        {
            LoadPublishers();  
        }

        private void LoadPublishers(string searchTerm = "")
        {
            var list = _dataAccess.GetPublishers(searchTerm);

           
            dgvPublisher.AutoGenerateColumns = false;

            dgvPublisher.DataSource = list;
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            var frm = new frmPublisherDetail { IsAdd = true };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPublishers();   
            }
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            
            if (dgvPublisher.CurrentRow == null ||
                dgvPublisher.CurrentRow.DataBoundItem is not PublisherDTO selected)
            {
                MessageBox.Show("Please select a publisher to edit.");
                return;
            }

            var frm = new frmPublisherDetail
            {
                IsAdd = false,
                PubId = selected.PubId  
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                LoadPublishers(txtSearch.Text.Trim());
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Publisher");

            if (errMsg == "")
            {
                LoadPublishers(txtSearch.Text.Trim());

            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if (dgvPublisher.CurrentRow == null ||
                dgvPublisher.CurrentRow.DataBoundItem is not PublisherDTO selected)
            {
                MessageBox.Show("Please select a publisher to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete publisher '{selected.PubName}' ({selected.PubId})?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                _dataAccess.DeletePublisher(selected.PubId);
                LoadPublishers(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting publisher: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


    }
}
