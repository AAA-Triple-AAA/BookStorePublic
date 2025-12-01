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

namespace BookStoreUI
{
    public partial class frmTitleMaintenance : Form
    {
        public bool IsAdd = false;
        private readonly BookStoreDO.DataAccessClasses.BookStoreDataAccess _data = new();

        public frmTitleMaintenance()
        {
            InitializeComponent();
        }
        private void LoadTitles()
        {
            dgvTitle.DataSource = _data.GetTitles();
        }
        private void frmTitleMaintenance_Load(object sender, EventArgs e)
        {
            LoadTitles();
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {


            var frm = new frmTitleDetail { IsAdd = true };
            if (frm.ShowDialog() == DialogResult.OK)
                LoadTitles();
        }

        private void btbEditTitle_Click(object sender, EventArgs e)
        {
            if (dgvTitle.CurrentRow == null)
            {
                MessageBox.Show("Please select a title first.");
                return;
            }

            var selected = (BookStoreDO.Models.DataLayer.Title)dgvTitle.CurrentRow.DataBoundItem;

            var frm = new frmTitleDetail
            {
                IsAdd = false,
                SelectedTitle = selected
            };

            if (frm.ShowDialog() == DialogResult.OK)
                LoadTitles();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Title");

            if (errMsg == "")
            {
                dgvTitle.DataSource = _data.SearchTitles(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (dgvTitle.CurrentRow == null)
            {
                MessageBox.Show("Please select a title first.");
                return;
            }

            var selected = (BookStoreDO.Models.DataLayer.Title)dgvTitle.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"Delete '{selected.Title1}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _data.DeleteTitle(selected.TitleId);
                LoadTitles();
            }
        }
    }
}
