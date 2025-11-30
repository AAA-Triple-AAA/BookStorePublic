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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerOrder));
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
            columnTitle_id = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            validatorBindingSource = new BindingSource(components);
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnAddtoCart = new Button();
            lblShoppingCart = new Label();
            dgvCart = new DataGridView();
            columnTitleID = new DataGridViewTextBoxColumn();
            columntitleS = new DataGridViewTextBoxColumn();
            columnQty = new DataGridViewTextBoxColumn();
            columnPriceS = new DataGridViewTextBoxColumn();
            columnDiscount = new DataGridViewTextBoxColumn();
            columnLineTotal = new DataGridViewTextBoxColumn();
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
            chkInitialCustomer = new CheckBox();
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
            lblStore.Location = new Point(16, 15);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(57, 25);
            lblStore.TabIndex = 0;
            lblStore.Text = "Store:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(206, 15);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(94, 25);
            lblEmployee.TabIndex = 2;
            lblEmployee.Text = "Employee:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(396, 15);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(145, 25);
            lblCustomerName.TabIndex = 4;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(589, 15);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(104, 25);
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Order Date:";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(16, 43);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(183, 33);
            cboStore.TabIndex = 1;
            // 
            // cboEmployee
            // 
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(206, 43);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(183, 33);
            cboEmployee.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(396, 43);
            txtCustomerName.MaxLength = 60;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(183, 31);
            txtCustomerName.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy/MM/dd";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(589, 43);
            dtpOrderDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(183, 31);
            dtpOrderDate.TabIndex = 7;
            dtpOrderDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(16, 125);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.PlaceholderText = "Search by Title";
            txtSearchTitle.Size = new Size(337, 31);
            txtSearchTitle.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(360, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 38);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTitles
            // 
            dgvTitles.AllowUserToAddRows = false;
            dgvTitles.AllowUserToDeleteRows = false;
            dgvTitles.AutoGenerateColumns = false;
            dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitles.Columns.AddRange(new DataGridViewColumn[] { columnTitle_id, columnPrice, columnTitle });
            dgvTitles.DataSource = validatorBindingSource;
            dgvTitles.Location = new Point(12, 170);
            dgvTitles.MultiSelect = false;
            dgvTitles.Name = "dgvTitles";
            dgvTitles.ReadOnly = true;
            dgvTitles.RowHeadersWidth = 62;
            dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitles.Size = new Size(492, 408);
            dgvTitles.TabIndex = 11;
            // 
            // columnTitle_id
            // 
            columnTitle_id.DataPropertyName = "TitleId";
            columnTitle_id.HeaderText = "Title ID";
            columnTitle_id.MinimumWidth = 8;
            columnTitle_id.Name = "columnTitle_id";
            columnTitle_id.ReadOnly = true;
            columnTitle_id.Width = 105;
            // 
            // columnPrice
            // 
            columnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0.00";
            columnPrice.DefaultCellStyle = dataGridViewCellStyle1;
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            columnPrice.Width = 70;
            // 
            // columnTitle
            // 
            columnTitle.DataPropertyName = "Title1";
            columnTitle.HeaderText = "Title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 250;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(16, 597);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(218, 25);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity of Selected Item:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(324, 593);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(180, 31);
            nudQuantity.TabIndex = 10;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.Location = new Point(360, 645);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(144, 38);
            btnAddtoCart.TabIndex = 11;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = true;
            btnAddtoCart.Click += btnAddToCart_Click;
            // 
            // lblShoppingCart
            // 
            lblShoppingCart.AutoSize = true;
            lblShoppingCart.Font = new Font("Segoe UI", 12F);
            lblShoppingCart.Location = new Point(770, 128);
            lblShoppingCart.Name = "lblShoppingCart";
            lblShoppingCart.Size = new Size(167, 32);
            lblShoppingCart.TabIndex = 15;
            lblShoppingCart.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoGenerateColumns = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { columnTitleID, columntitleS, columnQty, columnPriceS, columnDiscount, columnLineTotal });
            dgvCart.DataSource = validatorBindingSource1;
            dgvCart.Location = new Point(521, 170);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(659, 408);
            dgvCart.TabIndex = 16;
            // 
            // columnTitleID
            // 
            columnTitleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            columnTitleID.DataPropertyName = "TitleId";
            columnTitleID.FillWeight = 51.136364F;
            columnTitleID.HeaderText = "Title ID";
            columnTitleID.MinimumWidth = 8;
            columnTitleID.Name = "columnTitleID";
            columnTitleID.ReadOnly = true;
            columnTitleID.Width = 110;
            // 
            // columntitleS
            // 
            columntitleS.DataPropertyName = "Title";
            columntitleS.FillWeight = 114.987183F;
            columntitleS.HeaderText = "Title";
            columntitleS.MinimumWidth = 8;
            columntitleS.Name = "columntitleS";
            columntitleS.ReadOnly = true;
            // 
            // columnQty
            // 
            columnQty.DataPropertyName = "Quantity";
            columnQty.FillWeight = 101.850983F;
            columnQty.HeaderText = "Quantity";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            // 
            // columnPriceS
            // 
            columnPriceS.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            columnPriceS.DefaultCellStyle = dataGridViewCellStyle2;
            columnPriceS.FillWeight = 110.675179F;
            columnPriceS.HeaderText = "Price";
            columnPriceS.MinimumWidth = 8;
            columnPriceS.Name = "columnPriceS";
            columnPriceS.ReadOnly = true;
            // 
            // columnDiscount
            // 
            columnDiscount.DataPropertyName = "Discount";
            dataGridViewCellStyle3.NullValue = "P0";
            columnDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            columnDiscount.FillWeight = 110.675179F;
            columnDiscount.HeaderText = "Discount";
            columnDiscount.MinimumWidth = 8;
            columnDiscount.Name = "columnDiscount";
            columnDiscount.ReadOnly = true;
            // 
            // columnLineTotal
            // 
            columnLineTotal.DataPropertyName = "LineTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            columnLineTotal.DefaultCellStyle = dataGridViewCellStyle4;
            columnLineTotal.FillWeight = 110.675179F;
            columnLineTotal.HeaderText = "Line Total";
            columnLineTotal.MinimumWidth = 8;
            columnLineTotal.Name = "columnLineTotal";
            columnLineTotal.ReadOnly = true;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(521, 593);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 38);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(691, 593);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(144, 38);
            btnRemoveItem.TabIndex = 13;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnCommitOrder
            // 
            btnCommitOrder.Location = new Point(863, 593);
            btnCommitOrder.Name = "btnCommitOrder";
            btnCommitOrder.Size = new Size(144, 38);
            btnCommitOrder.TabIndex = 14;
            btnCommitOrder.Text = "Commit Order";
            btnCommitOrder.UseVisualStyleBackColor = true;
            btnCommitOrder.Click += btnCommitOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(1036, 593);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(144, 38);
            btnCancelOrder.TabIndex = 15;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(519, 650);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(83, 25);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(770, 650);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(40, 25);
            lblTax.TabIndex = 22;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.Location = new Point(971, 650);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(601, 645);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 24;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(814, 645);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(150, 31);
            txtTax.TabIndex = 25;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.Location = new Point(1029, 645);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 26;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // chkInitialCustomer
            // 
            chkInitialCustomer.AutoSize = true;
            chkInitialCustomer.Location = new Point(816, 43);
            chkInitialCustomer.Name = "chkInitialCustomer";
            chkInitialCustomer.Size = new Size(170, 29);
            chkInitialCustomer.TabIndex = 28;
            chkInitialCustomer.Text = "Initial Customer?";
            chkInitialCustomer.UseVisualStyleBackColor = true;
            chkInitialCustomer.CheckedChanged += chkInitialCustomer_CheckedChanged;
            // 
            // frmCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 708);
            Controls.Add(chkInitialCustomer);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnTitleID;
        private DataGridViewTextBoxColumn columntitleS;
        private DataGridViewTextBoxColumn columnQty;
        private DataGridViewTextBoxColumn columnPriceS;
        private DataGridViewTextBoxColumn columnDiscount;
        private DataGridViewTextBoxColumn columnLineTotal;
        private CheckBox chkInitialCustomer;
    }
}