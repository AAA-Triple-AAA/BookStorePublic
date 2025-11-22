namespace BookStoreUI
{
    partial class frmCustomerOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblStore = new Label();
            lblEmployee = new Label();
            lblCustomerName = new Label();
            lblOrderDate = new Label();
            cboStore = new ComboBox();
            cboEmployee = new ComboBox();
            txtCustomerName = new TextBox();
            dtpOrderDate = new DateTimePicker();
            txtSearchTitle = new TextBox();
            btnSearch = new Button();
            dgvTitles = new DataGridView();
            validatorBindingSource = new BindingSource(components);
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnAddtoCart = new Button();
            lblShoppingCart = new Label();
            dgvCart = new DataGridView();
            validatorBindingSource1 = new BindingSource(components);
            btnUpdate = new Button();
            btnRemoveItem = new Button();
            btnCommitOrder = new Button();
            btnCancelOrder = new Button();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            columnTitle_id = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnTitleID = new DataGridViewTextBoxColumn();
            columntitleS = new DataGridViewTextBoxColumn();
            columnQty = new DataGridViewTextBoxColumn();
            columnPriceS = new DataGridViewTextBoxColumn();
            columnDiscount = new DataGridViewTextBoxColumn();
            columnLineTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTitles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(11, 9);
            lblStore.Margin = new Padding(2, 0, 2, 0);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(37, 15);
            lblStore.TabIndex = 0;
            lblStore.Text = "Store:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(144, 9);
            lblEmployee.Margin = new Padding(2, 0, 2, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(62, 15);
            lblEmployee.TabIndex = 2;
            lblEmployee.Text = "Employee:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(277, 9);
            lblCustomerName.Margin = new Padding(2, 0, 2, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(97, 15);
            lblCustomerName.TabIndex = 4;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(412, 9);
            lblOrderDate.Margin = new Padding(2, 0, 2, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(67, 15);
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Order Date:";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(11, 26);
            cboStore.Margin = new Padding(2, 2, 2, 2);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(129, 23);
            cboStore.TabIndex = 1;
            // 
            // cboEmployee
            // 
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(144, 26);
            cboEmployee.Margin = new Padding(2, 2, 2, 2);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(129, 23);
            cboEmployee.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(277, 26);
            txtCustomerName.Margin = new Padding(2, 2, 2, 2);
            txtCustomerName.MaxLength = 60;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(129, 23);
            txtCustomerName.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy/MM/dd";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(412, 26);
            dtpOrderDate.Margin = new Padding(2, 2, 2, 2);
            dtpOrderDate.MaxDate = new DateTime(2025, 11, 20, 14, 42, 55, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(129, 23);
            dtpOrderDate.TabIndex = 7;
            dtpOrderDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(11, 75);
            txtSearchTitle.Margin = new Padding(2, 2, 2, 2);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.PlaceholderText = "Search by Title";
            txtSearchTitle.Size = new Size(237, 23);
            txtSearchTitle.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(252, 75);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvTitles
            // 
            dgvTitles.AllowUserToAddRows = false;
            dgvTitles.AllowUserToDeleteRows = false;
            dgvTitles.AutoGenerateColumns = false;
            dgvTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitles.Columns.AddRange(new DataGridViewColumn[] { columnTitle_id, columnTitle, columnPrice });
            dgvTitles.DataSource = validatorBindingSource;
            dgvTitles.Location = new Point(11, 102);
            dgvTitles.Margin = new Padding(2, 2, 2, 2);
            dgvTitles.MultiSelect = false;
            dgvTitles.Name = "dgvTitles";
            dgvTitles.ReadOnly = true;
            dgvTitles.RowHeadersWidth = 62;
            dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitles.Size = new Size(342, 245);
            dgvTitles.TabIndex = 11;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(11, 358);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(144, 15);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity of Selected Item:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(227, 356);
            nudQuantity.Margin = new Padding(2, 2, 2, 2);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(126, 23);
            nudQuantity.TabIndex = 10;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.Location = new Point(252, 387);
            btnAddtoCart.Margin = new Padding(2, 2, 2, 2);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(101, 23);
            btnAddtoCart.TabIndex = 11;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = true;
            // 
            // lblShoppingCart
            // 
            lblShoppingCart.AutoSize = true;
            lblShoppingCart.Font = new Font("Segoe UI", 12F);
            lblShoppingCart.Location = new Point(539, 77);
            lblShoppingCart.Margin = new Padding(2, 0, 2, 0);
            lblShoppingCart.Name = "lblShoppingCart";
            lblShoppingCart.Size = new Size(110, 21);
            lblShoppingCart.TabIndex = 15;
            lblShoppingCart.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoGenerateColumns = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { columnTitleID, columntitleS, columnQty, columnPriceS, columnDiscount, columnLineTotal });
            dgvCart.DataSource = validatorBindingSource1;
            dgvCart.Location = new Point(365, 102);
            dgvCart.Margin = new Padding(2, 2, 2, 2);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(461, 245);
            dgvCart.TabIndex = 16;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(365, 356);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(484, 356);
            btnRemoveItem.Margin = new Padding(2, 2, 2, 2);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(101, 23);
            btnRemoveItem.TabIndex = 13;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCommitOrder
            // 
            btnCommitOrder.Location = new Point(604, 356);
            btnCommitOrder.Margin = new Padding(2, 2, 2, 2);
            btnCommitOrder.Name = "btnCommitOrder";
            btnCommitOrder.Size = new Size(101, 23);
            btnCommitOrder.TabIndex = 14;
            btnCommitOrder.Text = "Commit Order";
            btnCommitOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(725, 356);
            btnCancelOrder.Margin = new Padding(2, 2, 2, 2);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(101, 23);
            btnCancelOrder.TabIndex = 15;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(363, 390);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(539, 390);
            lblTax.Margin = new Padding(2, 0, 2, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 22;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.Location = new Point(680, 390);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(421, 387);
            txtSubtotal.Margin = new Padding(2, 2, 2, 2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(106, 23);
            txtSubtotal.TabIndex = 24;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(570, 387);
            txtTax.Margin = new Padding(2, 2, 2, 2);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(106, 23);
            txtTax.TabIndex = 25;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.Location = new Point(720, 387);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(106, 23);
            txtTotal.TabIndex = 26;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // columnTitle_id
            // 
            columnTitle_id.HeaderText = "Title ID";
            columnTitle_id.MinimumWidth = 8;
            columnTitle_id.Name = "columnTitle_id";
            columnTitle_id.ReadOnly = true;
            // 
            // columnTitle
            // 
            columnTitle.HeaderText = "Title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            // 
            // columnPrice
            // 
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            // 
            // columnTitleID
            // 
            columnTitleID.HeaderText = "Title ID";
            columnTitleID.MinimumWidth = 8;
            columnTitleID.Name = "columnTitleID";
            columnTitleID.ReadOnly = true;
            columnTitleID.Width = 75;
            // 
            // columntitleS
            // 
            columntitleS.HeaderText = "Title";
            columntitleS.MinimumWidth = 8;
            columntitleS.Name = "columntitleS";
            columntitleS.ReadOnly = true;
            columntitleS.Width = 150;
            // 
            // columnQty
            // 
            columnQty.HeaderText = "Quantity";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            columnQty.Width = 75;
            // 
            // columnPriceS
            // 
            columnPriceS.HeaderText = "Price";
            columnPriceS.MinimumWidth = 8;
            columnPriceS.Name = "columnPriceS";
            columnPriceS.ReadOnly = true;
            // 
            // columnDiscount
            // 
            columnDiscount.HeaderText = "Discount";
            columnDiscount.MinimumWidth = 8;
            columnDiscount.Name = "columnDiscount";
            columnDiscount.ReadOnly = true;
            // 
            // columnLineTotal
            // 
            columnLineTotal.HeaderText = "Line Total";
            columnLineTotal.MinimumWidth = 8;
            columnLineTotal.Name = "columnLineTotal";
            columnLineTotal.ReadOnly = true;
            columnLineTotal.Width = 150;
            // 
            // frmCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 425);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnCommitOrder);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCart);
            Controls.Add(lblShoppingCart);
            Controls.Add(btnAddtoCart);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(dgvTitles);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTitle);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtCustomerName);
            Controls.Add(cboEmployee);
            Controls.Add(cboStore);
            Controls.Add(lblOrderDate);
            Controls.Add(lblCustomerName);
            Controls.Add(lblEmployee);
            Controls.Add(lblStore);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "frmCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Order - Shopping Cart";
            ((System.ComponentModel.ISupportInitialize)dgvTitles).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStore;
        private Label lblEmployee;
        private Label lblCustomerName;
        private Label lblOrderDate;
        private ComboBox cboStore;
        private ComboBox cboEmployee;
        private TextBox txtCustomerName;
        private DateTimePicker dtpOrderDate;
        private TextBox txtSearchTitle;
        private Button btnSearch;
        private DataGridView dgvTitles;
        private BindingSource validatorBindingSource;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnAddtoCart;
        private Label lblShoppingCart;
        private DataGridView dgvCart;
        private BindingSource validatorBindingSource1;
        private Button btnUpdate;
        private Button btnRemoveItem;
        private Button btnCommitOrder;
        private Button btnCancelOrder;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn columnTitle_id;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnTitleID;
        private DataGridViewTextBoxColumn columntitleS;
        private DataGridViewTextBoxColumn columnQty;
        private DataGridViewTextBoxColumn columnPriceS;
        private DataGridViewTextBoxColumn columnDiscount;
        private DataGridViewTextBoxColumn columnLineTotal;
    }
}