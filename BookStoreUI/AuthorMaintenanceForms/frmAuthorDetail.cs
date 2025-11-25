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

namespace BookStoreUI.AuthorMaintenanceForms
{
    public partial class frmAuthorDetail : Form
    {
        public bool IsAdd = false;
        public Author? Author = null;
        private BookStoreDataAccess _data = new();

        public frmAuthorDetail()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            mtbAuthorId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            mtbPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtbZip.Clear();
            chkContract.CheckState = CheckState.Unchecked;
        }

        private void DisplayAuthorInformation()
        {
            mtbAuthorId.Text = Author!.AuId;
            txtLastName.Text = Author.AuLname;
            txtFirstName.Text = Author.AuFname;
            mtbPhone.Text = Author.Phone;
            txtAddress.Text = Author.Address;
            txtCity.Text = Author.City;
            txtState.Text = Author.State;
            mtbZip.Text = Author.Zip;
            chkContract.CheckState = Author.Contract ? CheckState.Checked : CheckState.Unchecked;
        }

        private bool ValidId(string authorId)
        {
            var author = _data.GetAuthor(authorId);

            if (author == null) return true;

            MessageBox.Show(@"Author ID already taken, please enter a unique ID.");
            return false;
        }

        private bool ValidateInput()
        {
            var errMsg = "";

            // Grab trimmed values
            var lastName = txtLastName.Text.Trim();
            var firstName = txtFirstName.Text.Trim();
            var address = txtAddress.Text.Trim();
            var city = txtCity.Text.Trim();
            var state = txtState.Text.Trim();

            //We decided to write a masked box here even though the database accepts any character
            //type, because we think the masked box aligns better with the purpose of the information
            //we want to process. Although the default value, UNKNOWN, cannot be used.
            errMsg += Validator.IsMaskCompleted(mtbAuthorId.MaskCompleted, "Author ID");

         
            errMsg += Validator.IsPresent(lastName, "Last Name");
            errMsg += Validator.IsWithinLength(lastName, "Last Name", 1, 40);

            errMsg += Validator.IsPresent(firstName, "First Name");
            errMsg += Validator.IsWithinLength(firstName, "First Name", 1, 20);

            errMsg += Validator.IsMaskCompleted(mtbPhone.MaskCompleted, "Phone");

            errMsg += Validator.IsPresent(address, "Address");
            errMsg += Validator.IsWithinLength(address, "Address", 1, 40);

            errMsg += Validator.IsPresent(city, "City");
            errMsg += Validator.IsWithinLength(city, "City", 1, 20);

            errMsg += Validator.IsPresent(state, "State");
            errMsg += Validator.IsWithinLength(state, "State", 2, 2);

            errMsg += Validator.IsMaskCompleted(mtbZip.MaskCompleted, "Zip");

            if (errMsg == "") return true;

            MessageBox.Show(
                errMsg,
                @"Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }

        private void ApplyChanges()
        {
            if (IsAdd) Author = new Author();

            mtbAuthorId.TextMaskFormat = MaskFormat.IncludeLiterals;
            Author!.AuId = mtbAuthorId.Text;
            Author.AuLname = txtLastName.Text;
            Author.AuFname = txtFirstName.Text;
            Author.Phone = mtbPhone.Text;
            Author.Address = txtAddress.Text;
            Author.City = txtCity.Text;
            Author.State = txtState.Text;
            Author.Zip = mtbZip.Text;
            Author.Contract = chkContract.CheckState == CheckState.Checked;
        }

        private void frmAuthorDetail_Load(object sender, EventArgs e)
        {
            if (!IsAdd)
            {
                mtbAuthorId.Enabled = false;
                DisplayAuthorInformation();
            }

            this.Text = IsAdd ? @"Add Author" : @"Edit Author";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Stop if input is invalid
            if (!ValidateInput()) return;

            // Change or create Author
            ApplyChanges();

            // Stop if Adding author with already taken id
            if (IsAdd && !ValidId(Author!.AuId)) return;

            if (IsAdd)
            {
                _data.AddAuthor(Author!);
            }
            else
            {
                _data.UpdateAuthor(Author!);
            }

            MessageBox.Show(
                @"Author information saved successfully.",
                @"Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (!IsAdd)
            {
                txtLastName.Focus();
                return;
            }

            mtbAuthorId.Focus();
            ClearForm();
        }
    }
}
