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

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreDetail : Form
    {
        public bool IsAdd = false;

        public frmStoreDetail()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            mtbStoreId.Clear();
            txtStoreName.Clear();
            txtStoreAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            mtbZip.Clear();
        }

        private bool ValidateInput()
        {
            var errMsg = Validator.IsMaskCompleted(mtbStoreId.MaskCompleted, "Store ID");
            errMsg += Validator.IsPresent(txtStoreName.Text, "Store Name");
            errMsg += Validator.IsPresent(txtStoreAddress.Text, "Store Address");
            errMsg += Validator.IsPresent(txtCity.Text, "City");
            errMsg += Validator.IsPresent(txtState.Text, "State");
            errMsg += Validator.IsWithinLength(txtState.Text, "State", 2, 2);
            errMsg += Validator.IsMaskCompleted(mtbZip.MaskCompleted, "Zip");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void frnStoreDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Store" : @"Edit Store";
        }
    }
}
