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
    public partial class frmTitleDetail : Form
    {
        public bool IsAdd = false;
        private readonly BookStoreDO.DataAccessClasses.BookStoreDataAccess _data = new();
        public BookStoreDO.Models.DataLayer.Title? SelectedTitle { get; set; }
        public frmTitleDetail()
        {
            InitializeComponent();
            cboType.SelectedItem = "UNDECIDED";
        }

        private bool ValidateInput()
        {
            string errMsg = "";

            string titleId = txtTitleId.Text.Trim();
            string title = txtTitle.Text.Trim();
            string pubId = txtPubId.Text.Trim();
            string notes = txtNotes.Text.Trim();
            DateTime pubDate = dtpPubDate.Value;

            decimal price = nudPrice.Value;
            decimal advance = nudAdvance.Value;
            int royalty = (int)nudRoyalty.Value;
            int ytdSales = (int)nudYtdSales.Value;


            errMsg += Validator.IsPresent(title, "Title");
            errMsg += Validator.IsWithinLength(title, "Title", 1, 80);

            errMsg += Validator.IsSelected(cboType.SelectedIndex, "Type");

            errMsg += Validator.IsPresent(pubId, "Publisher ID");
            errMsg += Validator.IsWithinLength(pubId, "Publisher ID", 4, 4);

            if (price <= 0)
                errMsg += "Price must be greater than 0.\n";

            if (advance < 0)
                errMsg += "Advance cannot be negative.\n";

            if (royalty < 0)
                errMsg += "Royalty cannot be negative.\n";

            if (ytdSales < 0)
                errMsg += "YTD Sales cannot be negative.\n";

            if (!string.IsNullOrWhiteSpace(notes))
                errMsg += Validator.IsWithinLength(notes, "Notes", 0, 200);

            if (pubDate.Date > DateTime.Today)
                errMsg += "Publication date cannot be in the future.\n";

            if (errMsg == "")
                return true;

            MessageBox.Show(
                errMsg,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }



        private void ClearForm()
        {
            txtTitleId.Clear();
            txtTitle.Clear();

            cboType.SelectedItem = "UNDECIDED";

            txtPubId.Clear();

            nudPrice.Value = 0.0m;
            nudAdvance.Value = 0.0m;
            nudRoyalty.Value = 0;
            nudYtdSales.Value = 0;

            txtNotes.Clear();

            dtpPubDate.MaxDate = DateTime.Today;
            dtpPubDate.Value = DateTime.Today;

            txtTitleId.Focus();
        }


        private void frmTitleDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Title" : @"Edit Title";
            if (!IsAdd && SelectedTitle != null)
            {
                txtTitleId.Text = SelectedTitle.TitleId;
                txtTitle.Text = SelectedTitle.Title1;
                cboType.SelectedItem = SelectedTitle.Type;
                txtPubId.Text = SelectedTitle.PubId;
                nudPrice.Value = SelectedTitle.Price ?? 0.0m;
                nudAdvance.Value = SelectedTitle.Advance ?? 0.0m;
                nudRoyalty.Value = SelectedTitle.Royalty ?? 0;
                nudYtdSales.Value = SelectedTitle.YtdSales ?? 0;
                txtNotes.Text = SelectedTitle.Notes ?? "";
                dtpPubDate.Value = SelectedTitle.Pubdate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string titleId = txtTitleId.Text.Trim();
            string title = txtTitle.Text.Trim();
            string type = cboType.SelectedItem?.ToString() ?? "";
            string pubId = txtPubId.Text.Trim();
            decimal price = nudPrice.Value;
            decimal advance = nudAdvance.Value;
            int royalty = (int)nudRoyalty.Value;
            int ytdSales = (int)nudYtdSales.Value;
            string notes = txtNotes.Text.Trim();
            DateTime pubDate = dtpPubDate.Value;

            if (IsAdd)
            {
                var entity = new BookStoreDO.Models.DataLayer.Title
                {
                    TitleId = titleId,
                    Title1 = title,
                    Type = type,
                    PubId = pubId,
                    Price = price,
                    Advance = advance,
                    Royalty = royalty,
                    YtdSales = ytdSales,
                    Notes = string.IsNullOrWhiteSpace(notes) ? null : notes,
                    Pubdate = pubDate
                };

                _data.AddTitle(entity);
            }
            else
            {
                if (SelectedTitle == null)
                {
                    MessageBox.Show("No title selected.");
                    return;
                }

                SelectedTitle.Title1 = title;
                SelectedTitle.Type = type;
                SelectedTitle.PubId = pubId;
                SelectedTitle.Price = price;
                SelectedTitle.Advance = advance;
                SelectedTitle.Royalty = royalty;
                SelectedTitle.YtdSales = ytdSales;
                SelectedTitle.Notes = string.IsNullOrWhiteSpace(notes) ? null : notes;
                SelectedTitle.Pubdate = pubDate;

                _data.UpdateTitle(SelectedTitle);
            }

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
