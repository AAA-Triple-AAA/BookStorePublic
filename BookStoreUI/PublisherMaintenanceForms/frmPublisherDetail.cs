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

namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherDetail : Form
    {
        public bool IsAdd = false;

        public frmPublisherDetail()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            var errMsg = Validator.IsMaskCompleted(mtbPub_id.MaskCompleted, "Publisher ID");
            errMsg += Validator.IsPresent(txtPub_name.Text, "Publisher Name");
            errMsg += Validator.IsPresent(txtCity.Text, "City");
            errMsg += Validator.IsPresent(txtState.Text, "State");
            errMsg += Validator.IsPresent(txtCountry.Text, "Country");

            if (errMsg == "") return true;

            MessageBox.Show(errMsg);
            return false;
        }

        private void frmPublisherDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Publisher" : @"Edit Publisher";
        }
    }
}
