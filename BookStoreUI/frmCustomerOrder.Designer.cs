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
            lblSearch = new Label();
            txtSearchTitle = new TextBox();
            btnSearch = new Button();
            dgvTitles = new DataGridView();
            validatorBindingSource = new BindingSource(components);
            columnTitle_id = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnAddtoCart = new Button();
            lblShoppingCart = new Label();
            dgvCart = new DataGridView();
            validatorBindingSource1 = new BindingSource(components);
            columnTitleID = new DataGridViewTextBoxColumn();
            columntitleS = new DataGridViewTextBoxColumn();
            columnQty = new DataGridViewTextBoxColumn();
            columnPriceS = new DataGridViewTextBoxColumn();
            columnDiscount = new DataGridViewTextBoxColumn();
            columnLineTotal = new DataGridViewTextBoxColumn();
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
            lblStore.Location = new Point(427, 25);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(57, 25);
            lblStore.TabIndex = 0;
            lblStore.Text = "Store:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(390, 76);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(94, 25);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Employee:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(339, 129);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(145, 25);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(380, 185);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(104, 25);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "Order Date:";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(517, 25);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(182, 33);
            cboStore.TabIndex = 4;
            // 
            // cboEmployee
            // 
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(517, 76);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(182, 33);
            cboEmployee.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(517, 126);
            txtCustomerName.MaxLength = 60;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 31);
            txtCustomerName.TabIndex = 6;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy/MM/dd";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(517, 185);
            dtpOrderDate.MaxDate = new DateTime(2025, 11, 20, 14, 42, 55, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(300, 31);
            dtpOrderDate.TabIndex = 7;
            dtpOrderDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(66, 298);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 25);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search Title:";
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(200, 298);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(150, 31);
            txtSearchTitle.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(388, 298);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 10;
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
            dgvTitles.Location = new Point(12, 354);
            dgvTitles.MultiSelect = false;
            dgvTitles.Name = "dgvTitles";
            dgvTitles.ReadOnly = true;
            dgvTitles.RowHeadersWidth = 62;
            dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitles.Size = new Size(488, 409);
            dgvTitles.TabIndex = 11;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // columnTitle_id
            // 
            columnTitle_id.HeaderText = "title_id";
            columnTitle_id.MinimumWidth = 8;
            columnTitle_id.Name = "columnTitle_id";
            columnTitle_id.ReadOnly = true;
            // 
            // columnTitle
            // 
            columnTitle.HeaderText = "title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            // 
            // columnPrice
            // 
            columnPrice.HeaderText = "price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 790);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(218, 25);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity of Selected Item:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(320, 788);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(180, 31);
            nudQuantity.TabIndex = 13;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.Location = new Point(200, 841);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(150, 34);
            btnAddtoCart.TabIndex = 14;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = true;
            // 
            // lblShoppingCart
            // 
            lblShoppingCart.AutoSize = true;
            lblShoppingCart.Font = new Font("Segoe UI", 12F);
            lblShoppingCart.Location = new Point(752, 291);
            lblShoppingCart.Name = "lblShoppingCart";
            lblShoppingCart.Size = new Size(172, 32);
            lblShoppingCart.TabIndex = 15;
            lblShoppingCart.Text = "Shopping Cart:";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoGenerateColumns = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { columnTitleID, columntitleS, columnQty, columnPriceS, columnDiscount, columnLineTotal });
            dgvCart.DataSource = validatorBindingSource1;
            dgvCart.Location = new Point(517, 354);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(649, 409);
            dgvCart.TabIndex = 16;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // columnTitleID
            // 
            columnTitleID.HeaderText = "title_id";
            columnTitleID.MinimumWidth = 8;
            columnTitleID.Name = "columnTitleID";
            columnTitleID.ReadOnly = true;
            columnTitleID.Width = 75;
            // 
            // columntitleS
            // 
            columntitleS.HeaderText = "title";
            columntitleS.MinimumWidth = 8;
            columntitleS.Name = "columntitleS";
            columntitleS.ReadOnly = true;
            columntitleS.Width = 150;
            // 
            // columnQty
            // 
            columnQty.HeaderText = "qty";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            columnQty.Width = 75;
            // 
            // columnPriceS
            // 
            columnPriceS.HeaderText = "price";
            columnPriceS.MinimumWidth = 8;
            columnPriceS.Name = "columnPriceS";
            columnPriceS.ReadOnly = true;
            // 
            // columnDiscount
            // 
            columnDiscount.HeaderText = "discount";
            columnDiscount.MinimumWidth = 8;
            columnDiscount.Name = "columnDiscount";
            columnDiscount.ReadOnly = true;
            // 
            // columnLineTotal
            // 
            columnLineTotal.HeaderText = "line total";
            columnLineTotal.MinimumWidth = 8;
            columnLineTotal.Name = "columnLineTotal";
            columnLineTotal.ReadOnly = true;
            columnLineTotal.Width = 150;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(517, 785);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(676, 785);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(127, 34);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCommitOrder
            // 
            btnCommitOrder.Location = new Point(841, 785);
            btnCommitOrder.Name = "btnCommitOrder";
            btnCommitOrder.Size = new Size(140, 34);
            btnCommitOrder.TabIndex = 19;
            btnCommitOrder.Text = "Commit Order";
            btnCommitOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(1020, 781);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(124, 34);
            btnCancelOrder.TabIndex = 20;
            btnCancelOrder.Text = "CancelOrder";
            btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(517, 841);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(83, 25);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(560, 884);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(40, 25);
            lblTax.TabIndex = 22;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(841, 862);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(606, 838);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 24;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(606, 881);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(150, 31);
            txtTax.TabIndex = 25;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.Location = new Point(917, 862);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 39);
            txtTotal.TabIndex = 26;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // frmCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 944);
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
            Controls.Add(lblSearch);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtCustomerName);
            Controls.Add(cboEmployee);
            Controls.Add(cboStore);
            Controls.Add(lblOrderDate);
            Controls.Add(lblCustomerName);
            Controls.Add(lblEmployee);
            Controls.Add(lblStore);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label lblSearch;
        private TextBox txtSearchTitle;
        private Button btnSearch;
        private DataGridView dgvTitles;
        private BindingSource validatorBindingSource;
        private DataGridViewTextBoxColumn columnTitle_id;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnPrice;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnAddtoCart;
        private Label lblShoppingCart;
        private DataGridView dgvCart;
        private BindingSource validatorBindingSource1;
        private DataGridViewTextBoxColumn columnTitleID;
        private DataGridViewTextBoxColumn columntitleS;
        private DataGridViewTextBoxColumn columnQty;
        private DataGridViewTextBoxColumn columnPriceS;
        private DataGridViewTextBoxColumn columnDiscount;
        private DataGridViewTextBoxColumn columnLineTotal;
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
    }
}