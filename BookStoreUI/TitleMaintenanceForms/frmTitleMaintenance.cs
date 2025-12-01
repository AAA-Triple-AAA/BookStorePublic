using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BookStoreBO;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;

namespace BookStoreUI
{
    public partial class frmTitleMaintenance : Form
    {
        public bool IsAdd = false;

        private readonly BookStoreDataAccess _data = new();

        public frmTitleMaintenance()
        {
            InitializeComponent();

            this.Load += frmTitleMaintenance_Load;
            dgvTitle.SelectionChanged += dgvTitle_SelectionChanged;
        }

        // ================== LOAD LIST ==================
        private void LoadTitles()
        {
            dgvTitle.DataSource = _data.GetTitles();
            UpdateDetails();
        }

        private void frmTitleMaintenance_Load(object? sender, EventArgs e)
        {
            LoadTitles();
        }

        // ================== DETAILS PANEL ==================
        private void dgvTitle_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            if (dgvTitle.CurrentRow == null)
            {
                rtbDetails.Clear();
                return;
            }

            var selected = dgvTitle.CurrentRow.DataBoundItem as Title;
            if (selected == null)
            {
                rtbDetails.Clear();
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Title ID : {selected.TitleId}");
            sb.AppendLine($"Title    : {selected.Title1}");
            sb.AppendLine($"Type     : {selected.Type}");
            sb.AppendLine($"Pub. ID  : {selected.PubId}");
            sb.AppendLine($"Price    : {selected.Price?.ToString("C") ?? "N/A"}");
            sb.AppendLine($"Advance  : {selected.Advance?.ToString("C") ?? "N/A"}");
            sb.AppendLine($"Royalty  : {selected.Royalty?.ToString() ?? "N/A"}");
            sb.AppendLine($"YTD Sales: {selected.YtdSales?.ToString() ?? "N/A"}");
            sb.AppendLine($"Pub. Date: {selected.Pubdate:d}");

            if (!string.IsNullOrWhiteSpace(selected.Notes))
            {
                sb.AppendLine();
                sb.AppendLine("Notes:");
                sb.AppendLine(selected.Notes);
            }

            rtbDetails.Text = sb.ToString();
        }

        // ================== ADD / EDIT ==================
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

            var selected = (Title)dgvTitle.CurrentRow.DataBoundItem;

            var frm = new frmTitleDetail
            {
                IsAdd = false,
                SelectedTitle = selected
            };

            if (frm.ShowDialog() == DialogResult.OK)
                LoadTitles();
        }

        // ================== SEARCH ==================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Title");

            if (errMsg == "")
            {
                dgvTitle.DataSource = _data.SearchTitles(txtSearch.Text);
                UpdateDetails();
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        // ================== DELETE ==================
        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (dgvTitle.CurrentRow == null)
            {
                MessageBox.Show("Please select a title first.");
                return;
            }

            var selected = (Title)dgvTitle.CurrentRow.DataBoundItem;

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

