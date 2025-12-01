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

namespace BookStoreUI
{
    public partial class frmTitleMaintenance : Form
    {
        public bool IsAdd = false;
<<<<<<< Updated upstream
=======

        private readonly BookStoreDataAccess _data = new();

>>>>>>> Stashed changes
        public frmTitleMaintenance()
        {
            InitializeComponent();

            // Asegurar que se enganchen los eventos
            this.Load += frmTitleMaintenance_Load;
            dgvTitle.SelectionChanged += dgvTitle_SelectionChanged;
        }
<<<<<<< Updated upstream
=======

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
>>>>>>> Stashed changes

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
            sb.AppendLine($"Title ID: {selected.TitleId}");
            sb.AppendLine($"Title   : {selected.Title1}");
            sb.AppendLine($"Type    : {selected.Type}");
            sb.AppendLine($"Pub. ID : {selected.PubId}");
            sb.AppendLine($"Price   : {selected.Price?.ToString("C") ?? "N/A"}");
            sb.AppendLine($"Advance : {selected.Advance?.ToString("C") ?? "N/A"}");
            sb.AppendLine($"Royalty : {selected.Royalty?.ToString() ?? "N/A"}");
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
            frm.ShowDialog();
        }

        private void btbEditTitle_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            var frm = new frmTitleDetail { IsAdd = false };
            frm.ShowDialog();
        }

=======
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
>>>>>>> Stashed changes
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Title");

            if (errMsg == "")
            {
<<<<<<< Updated upstream
                // TODO: SEARCH LOGIC
=======
                dgvTitle.DataSource = _data.SearchTitles(txtSearch.Text);
                UpdateDetails();
>>>>>>> Stashed changes
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
<<<<<<< Updated upstream
=======

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
>>>>>>> Stashed changes
    }
}
