using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI.PublisherMaintenanceForms
{
    public partial class frmPublisherDetail : Form
    {
        public bool IsAdd = false;

        public frmPublisherDetail()
        {
            InitializeComponent();
        }

        private void frmPublisherDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Publisher" : @"Edit Publisher";
        }
    }
}
