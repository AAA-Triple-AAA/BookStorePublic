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

        private Author? _author = null;

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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var frmAuthorDetail = new frmAuthorDetail { IsAdd = true };
            frmAuthorDetail.ShowDialog();
        }

        private void btbEditAuthor_Click(object sender, EventArgs e)
        {
            var frmAuthorDetail = new frmAuthorDetail { IsAdd = false };
            frmAuthorDetail.ShowDialog();
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
            dgvAuthor.DataSource = _data.GetAuthors();
        }

        private void dgvAuthor_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvAuthor.SelectedRows[0];
            var possibleAuthor = row.DataBoundItem;

            if (possibleAuthor is not Author author) return;

            _author = author;

            SetRichTextBox(author);
        }
    }
}
