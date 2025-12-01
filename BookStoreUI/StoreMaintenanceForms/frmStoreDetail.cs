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

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreDetail : Form
    {
        public bool IsAdd = false;
        public Store Store = null;
        private BookStoreDataAccess _data = new();

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

            mtbStoreId.Focus();
        }

        private bool ValidId(string storeId)
        {
            var store = _data.GetStore(storeId);

            if (store == null) return true;

            MessageBox.Show(@"Store ID already taken, please enter a unique ID.");
            return false;
        }

        private bool ValidateInput()
        {
            string errMsg = "";


            string storeName = txtStoreName.Text.Trim();
            string storeAddress = txtStoreAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();


            errMsg += Validator.IsMaskCompleted(mtbStoreId.MaskCompleted, "Store ID");


            errMsg += Validator.IsPresent(storeName, "Store Name");
            errMsg += Validator.IsWithinLength(storeName, "Store Name", 1, 40);


            errMsg += Validator.IsPresent(storeAddress, "Store Address");
            errMsg += Validator.IsWithinLength(storeAddress, "Store Address", 1, 40);


            errMsg += Validator.IsPresent(city, "City");
            errMsg += Validator.IsWithinLength(city, "City", 1, 20);


            errMsg += Validator.IsPresent(state, "State");
            errMsg += Validator.IsWithinLength(state, "State", 2, 2);


            errMsg += Validator.IsMaskCompleted(mtbZip.MaskCompleted, "Zip");


            if (errMsg == "")
                return true;

            MessageBox.Show(
                errMsg,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }

        private void DisplayStoreInformation()
        {
            mtbStoreId.Text = Store!.StorId;
            txtStoreName.Text = Store.StorName;
            txtStoreAddress.Text = Store.StorAddress;
            txtCity.Text = Store.City;
            txtState.Text = Store.State;
            mtbZip.Text = Store.Zip;
        }

        private void ApplyChanges()
        {
            if (IsAdd) Store = new Store();

            Store!.StorId = mtbStoreId.Text;
            Store.StorName = txtStoreName.Text;
            Store.StorAddress = txtStoreAddress.Text;
            Store.City = txtCity.Text;
            Store.State = txtState.Text;
            Store.Zip = mtbZip.Text;
        }

        private void frnStoreDetail_Load(object sender, EventArgs e)
        {
            if (!IsAdd)
            {
                mtbStoreId.Enabled = false;
                DisplayStoreInformation();
            }

            this.Text = IsAdd ? @"Add Store" : @"Edit Store";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;   

            ApplyChanges();

            if (IsAdd && !ValidId(Store!.StorId)) return;

            if (IsAdd) _data.AddStore(Store);
            else _data.UpdateStore(Store);

            MessageBox.Show(
                @"Store information saved successfully.",
                @"Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (!IsAdd)
            {
                txtStoreName.Focus();
                return;
            }

            mtbStoreId.Focus();
            ClearForm();
        }
    }
}
