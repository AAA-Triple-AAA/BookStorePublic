using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreDO.Models.DataLayer;
using BookStoreBO;

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreDetail : Form
    {
        public bool IsAdd = false;
        public Store? CurrentStore { get; set; }
        private readonly StoreManager _storeManager = new StoreManager();
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


        private void frnStoreDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Store" : @"Edit Store";

            if (!IsAdd && CurrentStore != null)
            {
                
                mtbStoreId.Text = CurrentStore.StorId;
                mtbStoreId.ReadOnly = true; 

                txtStoreName.Text = CurrentStore.StorName;
                txtStoreAddress.Text = CurrentStore.StorAddress;
                txtCity.Text = CurrentStore.City;
                txtState.Text = CurrentStore.State;
                mtbZip.Text = CurrentStore.Zip;

            }
            else
            {
                // Adding new store
                ClearForm();
                mtbStoreId.ReadOnly = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            string storeId = mtbStoreId.Text;
            string storeName = txtStoreName.Text.Trim();
            string storeAddress = txtStoreAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string zip = mtbZip.Text;

            if (IsAdd)
            {
                // Create a new Store entity
                var newStore = new Store
                {
                    StorId = storeId,
                    StorName = storeName,
                    StorAddress = storeAddress,
                    City = city,
                    State = state,
                    Zip = zip
                };

                _storeManager.AddStore(newStore);
            }
            else
            {
                if (CurrentStore == null)
                {
                    MessageBox.Show("No store loaded to update.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the existing Store entity
                CurrentStore.StorName = storeName;
                CurrentStore.StorAddress = storeAddress;
                CurrentStore.City = city;
                CurrentStore.State = state;
                CurrentStore.Zip = zip;

                _storeManager.UpdateStore(CurrentStore);
            }


            MessageBox.Show(
                "Store information saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
