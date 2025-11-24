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
            string errMsg = "";

            // Grab trimmed values
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();

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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            // Final check
>>>>>>> Stashed changes
=======
            // Final check
>>>>>>> Stashed changes
=======
            // Final check
>>>>>>> Stashed changes
            if (errMsg != "")
            {
                MessageBox.Show(
                    errMsg,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }


        private void frmAuthorDetail_Load(object sender, EventArgs e)
        {
            // TODO: IMPLEMENT FUNCTION
            // Hande form load stuff
            this.Text = IsAdd ? @"Add Author" : @"Edit Author";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            if (!ValidateInput())
                return;  // stop if there are validation errors
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            
            if (!ValidateInput())
                return;    // if there are errors, the message box is already shown

            MessageBox.Show(
                "Author information saved successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

           
            ClearForm();
            mtbAuthorId.Focus();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }


    }
}
