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

namespace BookStoreUI.AuthorMaintenanceForms
{
    public partial class frmAuthorDetail : Form
    {
        public bool IsAdd = false;

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

        private bool ValidateInput()
        {
            var errMsg = Validator.IsMaskCompleted(mtbAuthorId.MaskCompleted, "Author ID");
            errMsg += Validator.IsPresent(txtLastName.Text, "Last Name");
            errMsg += Validator.IsPresent(txtFirstName.Text, "First Name");
            errMsg += Validator.IsMaskCompleted(mtbPhone.MaskCompleted, "Phone");
            errMsg += Validator.IsPresent(txtAddress.Text, "Address");
            errMsg += Validator.IsPresent(txtCity.Text, "City");
            errMsg += Validator.IsPresent(txtState.Text, "State");
            errMsg += Validator.IsMaskCompleted(mtbZip.MaskCompleted, "Zip");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void frmAuthorDetail_Load(object sender, EventArgs e)
        {
            // TODO: IMPLEMENT FUNCTION
            // Hande form load stuff
            this.Text = IsAdd ? @"Add Author" : @"Edit Author";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
