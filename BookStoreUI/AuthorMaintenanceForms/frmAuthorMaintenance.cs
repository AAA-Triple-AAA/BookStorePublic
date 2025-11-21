using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreUI.AuthorMaintenanceForms;

namespace BookStoreUI
{
    public partial class frmAuthorMaintenance : Form
    {
        public frmAuthorMaintenance()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var frmAuthorDetail = new frmAuthorDetail { IsAdd = true }
            ;
            frmAuthorDetail.ShowDialog();
        }

        private void btbEditAuthor_Click(object sender, EventArgs e)
        {
            var frmAuthorDetail = new frmAuthorDetail { IsAdd = false };
            frmAuthorDetail.ShowDialog();
        }
    }
}
