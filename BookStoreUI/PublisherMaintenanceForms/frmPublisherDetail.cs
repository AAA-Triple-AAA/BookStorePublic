using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreBO;

namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherDetail : Form
    {
        public bool IsAdd = false;
        public frmPublisherDetail()
        {
            InitializeComponent();
        }


        private void ClearForm()
        {
            mtbPubId.Clear();
            txtPubName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
        }

        private bool ValidateInput()
        {
            string errMsg = "";


            string pubName = txtPubName.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string country = txtCountry.Text.Trim();


            errMsg += Validator.IsMaskCompleted(mtbPubId.MaskCompleted, "Publisher ID");


            if (mtbPubId.MaskCompleted)
            {
                string pubId = mtbPubId.Text.Trim();


                var regex = new Regex(@"^(1756|1622|0877|0736|1389|99[0-9]{2})$");

                if (!regex.IsMatch(pubId))
                {
                    errMsg += "Publisher ID must be 1756, 1622, 0877, 0736, 1389, or start with 99.\n";
                }
            }


            errMsg += Validator.IsPresent(pubName, "Publisher Name");
            errMsg += Validator.IsWithinLength(pubName, "Publisher Name", 1, 40);


            errMsg += Validator.IsPresent(city, "City");
            errMsg += Validator.IsWithinLength(city, "City", 1, 20);


            errMsg += Validator.IsPresent(state, "State");
            errMsg += Validator.IsWithinLength(state, "State", 2, 2);


            errMsg += Validator.IsPresent(country, "Country");
            errMsg += Validator.IsWithinLength(country, "Country", 1, 30);


            if (errMsg == "")
                return true;

            MessageBox.Show(
                errMsg,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }


        private void frmPublisherDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Publisher" : @"Edit Publisher";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;   



            MessageBox.Show(
                "Publisher information saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }


    }
}
