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

        public frmTitleDetail()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            var errMsg = Validator.IsPresent(txtTitleId.Text, "Title ID");
            errMsg += Validator.IsPresent(txtTitle.Text, "Title");
            errMsg += Validator.IsSelected(cboType.SelectedIndex, "Type");
            errMsg += Validator.IsPresent(txtPubId.Text, "Publisher ID");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void ClearForm()
        {
            txtTitleId.Clear();
            txtTitle.Clear();
            cboType.SelectedIndex = -1;
            txtPubId.Clear();
            nudPrice.Value = 0.0m;
            nudAdvance.Value = 0.0m;
            nudRoyalty.Value = 0;
            nudYtdSales.Value = 0;
            txtNotes.Clear();
            dtpPubDate.Value = DateTime.Now;
        }

        private void frmTitleDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Title" : @"Edit Title";
        }
    }
}
