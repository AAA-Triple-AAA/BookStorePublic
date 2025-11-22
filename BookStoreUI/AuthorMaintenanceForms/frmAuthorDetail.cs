using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI.AuthorMaintenanceForms
{
    public partial class frmAuthorDetail : Form
    {
        public bool IsAdd = false;

        public frmAuthorDetail()
        {
            InitializeComponent();
        }

        private void frmAuthorDetail_Load(object sender, EventArgs e)
        {
            // TODO: IMPLEMENT FUNCTION
            // Hande form load stuff
            this.Text = IsAdd ? @"Add Author" : @"Edit Author";
        }
    }
}
