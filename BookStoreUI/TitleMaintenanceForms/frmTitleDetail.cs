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

        private readonly BookStoreDataAccess _data = new();

        // List of publishers used to populate the combo box
        private List<Publisher> _publishers = new();

        // The title being edited (only used to know what the original title was)
        public Title? SelectedTitle { get; set; }

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

            // For ADD, validate that the ID is present.
            if (IsAdd)
            {
                errMsg += Validator.IsPresent(titleId, "Title ID");
                errMsg += Validator.IsWithinLength(titleId, "Title ID", 1, 6);
            }

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
        private void frmTitleDetail_Load(object? sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Title" : @"Edit Title";

            // Load publishers
            _publishers = _data.GetPublishers();

            cboPubId.DataSource = _publishers;
            cboPubId.DisplayMember = "PubName";
            cboPubId.ValueMember = "PubId";
            cboPubId.SelectedIndex = -1;

            if (cboType.SelectedIndex < 0)
                cboType.SelectedItem = "UNDECIDED";

            if (!IsAdd && SelectedTitle != null)
            {
                // We don't want them to change the ID when editing (PK)
                txtTitleId.Text = SelectedTitle.TitleId;
                txtTitleId.Enabled = false;

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
                // ADD
                txtTitleId.Enabled = true;
                dtpPubDate.Value = DateTime.Today;
            }
        }

        // ================= SAVE =================
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            // For ADD operations, we use what's in the box.
            // For EDIT operations, we always use the original ID to avoid changing the primary key.
            string titleId = IsAdd
                ? txtTitleId.Text.Trim()
                : SelectedTitle!.TitleId;

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

            // We ALWAYS create a new entity with the current values.
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

            try
            {
                if (IsAdd)
                {
                    _data.AddTitle(entity);
                }
                else
                {
                    _data.UpdateTitle(entity);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while saving the title:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
