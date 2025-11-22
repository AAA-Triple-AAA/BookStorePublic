using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI
{
    public partial class frmTitleDetail : Form
    {
        public bool IsAdd = false;

        public frmTitleDetail()
        {
            InitializeComponent();
        }

        private void frmTitleDetail_Load(object sender, EventArgs e)
        {
            this.Text = IsAdd ? @"Add Title" : @"Edit Title";
        }
    }
}
