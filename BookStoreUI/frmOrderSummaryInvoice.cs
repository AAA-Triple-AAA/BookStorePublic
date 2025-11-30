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
            _summary = summary ?? throw new ArgumentNullException(nameof(summary));
            InitializeComponent();
        }

        private void frmOrderSummaryInvoice_Load(object sender, EventArgs e)
        {
            // Header data in TEXTBOXES
            txtOrderNumber.Text = _summary.OrderNumber;
            txtStore.Text = $"{_summary.StoreName} ({_summary.StoreId})";
            txtEmployee.Text = $"{_summary.EmployeeName} ({_summary.EmployeeId})";
            txtCustomer.Text = _summary.CustomerName;
            txtOrderDate.Text = _summary.OrderDate.ToShortDateString();

            txtSubtotal.Text = _summary.Subtotal.ToString("0.00");
            txtTax.Text = _summary.Tax.ToString("0.00");
            txtTotal.Text = _summary.Total.ToString("0.00");

            // Grid
            dgvCart.AutoGenerateColumns = false;
            dgvCart.DataSource = _summary.Items;

            dgvCart.Columns["columntitle"].DataPropertyName = "Title";
            dgvCart.Columns["columnQty"].DataPropertyName = "Quantity";
            dgvCart.Columns["columnPrice"].DataPropertyName = "Price";
            dgvCart.Columns["columnDiscount"].DataPropertyName = "Discount";
            dgvCart.Columns["columnLineTotal"].DataPropertyName = "LineTotal";

            dgvCart.Columns["columnPrice"].DefaultCellStyle.Format = "0.00";
            dgvCart.Columns["columnLineTotal"].DefaultCellStyle.Format = "0.00";
            dgvCart.Columns["columnDiscount"].DefaultCellStyle.Format = "0.00";
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
