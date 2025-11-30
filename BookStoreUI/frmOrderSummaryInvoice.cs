using System;
using System.Windows.Forms;
using BookStoreBO;

namespace BookStoreUI
{
    public partial class frmOrderSummaryInvoice : Form
    {
        private readonly OrderSummary _summary;

        public frmOrderSummaryInvoice(OrderSummary summary)
        {
            InitializeComponent();
            _summary = summary;
        }

        private void frmOrderSummaryInvoice_Load(object sender, EventArgs e)
        {
            // Ajusta los nombres de tus labels/textboxes
            lblOrderNumber.Text = _summary.OrderNumber;
            lblStore.Text = $"{_summary.StoreName} ({_summary.StoreId})";
            lblEmployee.Text = _summary.EmployeeName;
            lblCustomer.Text = _summary.CustomerName;
            lblOrderDate.Text = _summary.OrderDate.ToShortDateString();

            txtSubtotal.Text = _summary.Subtotal.ToString("0.00");
            txtTax.Text = _summary.Tax.ToString("0.00");
            txtTotal.Text = _summary.Total.ToString("0.00");

            dgvCart.AutoGenerateColumns = false;
            dgvCart.DataSource = _summary.Items;
        }
    }
}
