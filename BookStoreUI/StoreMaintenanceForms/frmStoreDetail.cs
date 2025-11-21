using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI.StoreMaintenanceForms
{
    public partial class frmStoreDetail : Form
    {
        public bool IsAdd = false;

        public frmStoreDetail()
        {
            InitializeComponent();
        }

        private void frnStoreDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Store" : @"Edit Store";
        }
    }
}
