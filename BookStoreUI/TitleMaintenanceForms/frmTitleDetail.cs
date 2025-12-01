using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookStoreBO;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;

namespace BookStoreUI
{
    public partial class frmTitleDetail : Form
    {
        public bool IsAdd = false;
<<<<<<< Updated upstream
=======

        private readonly BookStoreDataAccess _data = new();


        private List<Publisher> _publishers = new();

        public Title? SelectedTitle { get; set; }

>>>>>>> Stashed changes
        public frmTitleDetail()
        {
            InitializeComponent();
        }

        // ================= VALIDATION =================
        private bool ValidateInput()
        {
            string errMsg = "";

            string titleId = txtTitleId.Text.Trim();
            string title = txtTitle.Text.Trim();
            string notes = txtNotes.Text.Trim();
            DateTime pubDate = dtpPubDate.Value;

            decimal price = nudPrice.Value;
            decimal advance = nudAdvance.Value;
            int royalty = (int)nudRoyalty.Value;
            int ytdSales = (int)nudYtdSales.Value;

            // Title
            errMsg += Validator.IsPresent(title, "Title");
            errMsg += Validator.IsWithinLength(title, "Title", 1, 80);

            // Type
            errMsg += Validator.IsSelected(cboType.SelectedIndex, "Type");

            // Publisher (ComboBox)
            errMsg += Validator.IsSelected(cboPubId.SelectedIndex, "Publisher");

            if (price <= 0)
                errMsg += "Price must be greater than 0.\n";

            if (advance < 0)
                errMsg += "Advance cannot be negative.\n";

            if (royalty < 0)
                errMsg += "Royalty cannot be negative.\n";

            if (ytdSales < 0)
                errMsg += "YTD Sales cannot be negative.\n";

            // Notes
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

        // ================= HELPERS =================
        private void ClearForm()
        {
            txtTitleId.Clear();
            txtTitle.Clear();

            cboType.SelectedItem = "UNDECIDED";

            cboPubId.SelectedIndex = -1;

            nudPrice.Value = 0.0m;
            nudAdvance.Value = 0.0m;
            nudRoyalty.Value = 0;
            nudYtdSales.Value = 0;

            txtNotes.Clear();

            dtpPubDate.MaxDate = DateTime.Today;
            dtpPubDate.Value = DateTime.Today;

            txtTitleId.Focus();
        }

        // ================= LOAD =================
        private void frmTitleDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Title" : @"Edit Title";
<<<<<<< Updated upstream
=======


            _publishers = _data.GetPublishers();

            cboPubId.DataSource = _publishers;
            cboPubId.DisplayMember = "PubName";
            cboPubId.ValueMember = "PubId";
            cboPubId.SelectedIndex = -1;

            if (cboType.SelectedIndex < 0)
                cboType.SelectedItem = "UNDECIDED";

            if (!IsAdd && SelectedTitle != null)
            {
                txtTitleId.Text = SelectedTitle.TitleId;
                txtTitle.Text = SelectedTitle.Title1;
                cboType.SelectedItem = SelectedTitle.Type;


                var pub = _publishers
                    .FirstOrDefault(p => p.PubId.Trim() == SelectedTitle.PubId.Trim());

                if (pub != null)
                    cboPubId.SelectedItem = pub;

                nudPrice.Value = SelectedTitle.Price ?? 0.0m;
                nudAdvance.Value = SelectedTitle.Advance ?? 0.0m;
                nudRoyalty.Value = SelectedTitle.Royalty ?? 0;
                nudYtdSales.Value = SelectedTitle.YtdSales ?? 0;

                txtNotes.Text = SelectedTitle.Notes ?? "";
                dtpPubDate.Value = SelectedTitle.Pubdate;
            }
            else
            {
                dtpPubDate.Value = DateTime.Today;
            }
>>>>>>> Stashed changes
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;   

<<<<<<< Updated upstream

            MessageBox.Show(
                "Title information saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
=======
            string titleId = txtTitleId.Text.Trim();
            string title = txtTitle.Text.Trim();
            string type = cboType.SelectedItem?.ToString() ?? "";


            var selectedPublisher = cboPubId.SelectedItem as Publisher;
            if (selectedPublisher == null)
            {
                MessageBox.Show("You must select a publisher.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pubId = selectedPublisher.PubId;

            decimal price = nudPrice.Value;
            decimal advance = nudAdvance.Value;
            int royalty = (int)nudRoyalty.Value;
            int ytdSales = (int)nudYtdSales.Value;
            string notes = txtNotes.Text.Trim();
            DateTime pubDate = dtpPubDate.Value;

            if (IsAdd)
            {
                var entity = new Title
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
>>>>>>> Stashed changes
        }
    }
}
