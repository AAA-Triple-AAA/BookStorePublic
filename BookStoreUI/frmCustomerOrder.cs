using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BookStoreBO;
using BookStoreDO.DataAccessClasses;
using BookStoreDO.Models.DataLayer;
// To avoid conflict with System.Windows.Forms.VisualStyles.VisualStyleElement.Header.Title
using TitleEntity = BookStoreDO.Models.DataLayer.Title;

namespace BookStoreUI
{
    public partial class frmCustomerOrder : Form
    {
        private readonly BookStoreDataAccess _data = new();

        //   Internal model of cart
        private class CartItem
        {
            public string TitleId { get; set; } = "";
            public string Title { get; set; } = "";
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Discount { get; set; }   // ex: 0.07m, 0.10m

            public decimal LineTotal => Quantity * Price * (1 - Discount);
        }

        private readonly BindingList<CartItem> _cart = new();

        // Fixed tax (if the teacher changes, adjust here)
        private const decimal TaxRate = 0.07m;

        public frmCustomerOrder()
        {
            InitializeComponent();

            InitializeCartGrid();
            LoadHeaderData();
            LoadTitles();
        }


        //  Initializations
        private void InitializeCartGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.DataSource = _cart;
        }

        private void LoadHeaderData()
        {
            // STORES
            var stores = _data.GetStores()
                              .OrderBy(s => s.StorName)
                              .ToList();

            cboStore.DataSource = stores;
            cboStore.DisplayMember = "StorName";
            cboStore.ValueMember = "StorId";
            cboStore.SelectedIndex = -1;

            // EMPLOYEES
            var employees = _data.GetEmployees()
                                 .OrderBy(e => e.Lname)
                                 .ThenBy(e => e.Fname)
                                 .Select(e => new
                                 {
                                     Display = $"{e.Lname}, {e.Fname}",
                                     Value = e.EmpId,
                                     Employee = e
                                 })
                                 .ToList();

            cboEmployee.DataSource = employees;
            cboEmployee.DisplayMember = "Display";
            cboEmployee.ValueMember = "Value";
            cboEmployee.SelectedIndex = -1;

            // ORDER DATE
            dtpOrderDate.Value = DateTime.Today;
        }

        private void LoadTitles(string searchText = "")
        {
            var titles = string.IsNullOrWhiteSpace(searchText)
                ? _data.GetTitles()
                : _data.SearchTitles(searchText);

            dgvTitles.AutoGenerateColumns = false;
            dgvTitles.DataSource = titles;
        }

        // Header validation
        private bool ValidateInput()
        {
            var errMsg = "";

            errMsg += Validator.IsSelected(cboStore.SelectedIndex, "Store");
            errMsg += Validator.IsSelected(cboEmployee.SelectedIndex, "Employee");
            errMsg += Validator.IsPresent(txtCustomerName.Text, "Customer Name");

            if (dtpOrderDate.Value.Date > DateTime.Today)
            {
                errMsg += "Order Date cannot be in the future.\n";
            }

            if (errMsg == "") return true;

            MessageBox.Show(
                errMsg,
                @"Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }

        //   Search events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var errMsg = Validator.IsSearchEntryPresent(txtSearchTitle.Text, "Title");

            if (errMsg == "")
            {
                var searchText = txtSearchTitle.Text.Trim();
                LoadTitles(searchText);
            }
            else
            {
                MessageBox.Show(errMsg, @"Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //  Cart: Add / Update / Remove
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvTitles.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Please select a title from the list.",
                    @"Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvTitles.SelectedRows[0];
            if (row.DataBoundItem is not TitleEntity title)
            {
                MessageBox.Show(@"Could not determine selected title.",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int qty = (int)nudQuantity.Value;
            if (qty <= 0)
            {
                MessageBox.Show(@"Quantity must be at least 1.",
                    @"Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboStore.SelectedValue == null)
            {
                MessageBox.Show(@"Please select a store before adding items to the cart.",
                    @"Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string storId = cboStore.SelectedValue.ToString()!;
            bool isInitialCustomer = chkInitialCustomer.Checked;

            decimal discountPercent = _data.GetDiscountFor(storId, qty, isInitialCustomer);
            decimal price = title.Price ?? 0m;

            var existing = _cart.FirstOrDefault(c => c.TitleId == title.TitleId);
            if (existing != null)
            {
                existing.Quantity += qty;
                existing.Discount = _data.GetDiscountFor(storId, existing.Quantity, isInitialCustomer);
                dgvCart.Refresh();
            }
            else
            {
                _cart.Add(new CartItem
                {
                    TitleId = title.TitleId,
                    Title = title.Title1,
                    Quantity = qty,
                    Price = price,
                    Discount = discountPercent
                });
            }

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal subtotal = _cart.Sum(c => c.LineTotal);
            decimal tax = subtotal * TaxRate;
            decimal total = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("0.00");
            txtTax.Text = tax.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If you allow editing Quantity directly in the grid, only recalc here.
            UpdateTotals();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Please select an item in the shopping cart to remove.",
                    @"Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvCart.SelectedRows[0];
            if (row.DataBoundItem is not CartItem item) return;

            _cart.Remove(item);
            UpdateTotals();
        }


        //   Commit / Cancel

        private void btnCommitOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (_cart.Count == 0)
            {
                MessageBox.Show(@"The shopping cart is empty.",
                    @"Commit Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Header data
            string storId = cboStore.SelectedValue!.ToString()!;
            DateTime orderDate = dtpOrderDate.Value.Date;

            // Prepare items to store in SALES
            var itemsForDb = _cart
                .Select(ci => (TitleId: ci.TitleId, Quantity: ci.Quantity))
                .ToList();

            // Save order in DB -> SALES table
            string ordNum = _data.CreateOrder(storId, orderDate, itemsForDb);

            // Recalcular totales
            decimal subtotal = _cart.Sum(c => c.LineTotal);
            decimal tax = subtotal * TaxRate;
            decimal total = subtotal + tax;

            // Create summary object for the invoice
            var store = (Store)cboStore.SelectedItem!;
            dynamic emp = cboEmployee.SelectedItem!; // { Display, Value, Employee }

            var summary = new OrderSummary
            {
                OrderNumber = ordNum,
                StoreName = store.StorName,
                StoreId = store.StorId,
                EmployeeName = emp.Display,
                EmployeeId = emp.Value,
                CustomerName = txtCustomerName.Text.Trim(),
                OrderDate = orderDate,
                Subtotal = subtotal,
                Tax = tax,
                Total = total,
                Items = _cart.Select(ci => new OrderItemSummary
                {
                    TitleId = ci.TitleId,
                    Title = ci.Title,
                    Quantity = ci.Quantity,
                    Price = ci.Price,
                    Discount = ci.Discount,
                    LineTotal = ci.LineTotal
                }).ToList()
            };

            // Show summary/invoice screen
            using (var frm = new frmOrderSummaryInvoice(summary))
            {
                frm.ShowDialog();
            }
            // After confirming, we close this screen
            this.Close();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkInitialCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            if (cboStore.SelectedValue == null) return;

            string storId = cboStore.SelectedValue.ToString()!;
            bool isInitialCustomer = chkInitialCustomer.Checked;

            foreach (var item in _cart)
            {

                item.Discount = _data.GetDiscountFor(storId, item.Quantity, isInitialCustomer);

            }

            dgvCart.Refresh();
            UpdateTotals();
        }
    }
}
