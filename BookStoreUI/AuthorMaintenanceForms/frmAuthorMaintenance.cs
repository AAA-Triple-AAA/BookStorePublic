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
using BookStoreUI.AuthorMaintenanceForms;

namespace BookStoreUI
{
    public partial class frmAuthorMaintenance : Form
    {
        private readonly BookStoreDataAccess _data = new();

        private Author? _author;

        public frmAuthorMaintenance()
        {
            InitializeComponent();
        }

        private void SetRichTextBox(Author author)
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID: {author.AuId}");
            sb.AppendLine($"Last Name: {author.AuLname}");
            sb.AppendLine($"First Name: {author.AuFname}");
            sb.AppendLine($"Phone: {author.Phone}");
            sb.AppendLine($"Address: {author.Address}");
            sb.AppendLine($"City: {author.City}");
            sb.AppendLine($"State: {author.State}");
            sb.AppendLine($"Zip: {author.Zip}");
            sb.AppendLine($"HasContract: {author.Contract}");

            rtbDetails.Text = sb.ToString();
        }

        private void LoadData()
        {
            var authors = _data.GetAuthors();
            dgvAuthor.DataSource = null;
            dgvAuthor.DataSource = authors;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var frmAuthorDetail = new frmAuthorDetail { IsAdd = true };
            frmAuthorDetail.ShowDialog();
        }

        private void btbEditAuthor_Click(object sender, EventArgs e)
        {
            if (_author == null)
            {
                MessageBox.Show(@"Must select an author");
                return;
            }

            var frmAuthorDetail = new frmAuthorDetail { IsAdd = false, Author = _author };
            frmAuthorDetail.ShowDialog();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearch.Text, "Author");

            if (errMsg == "")
            {
                // TODO: SEARCH LOGIC
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void frmAuthorMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAuthor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAuthor.SelectedRows.Count == 0) return;

            var row = dgvAuthor.SelectedRows[0];
            var possibleAuthor = row.DataBoundItem;

            if (possibleAuthor is not Author author) return;

            _author = author;

            SetRichTextBox(author);
        }
    }
}
