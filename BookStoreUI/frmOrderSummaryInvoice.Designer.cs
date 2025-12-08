namespace BookStoreUI
{
    partial class frmOrderSummaryInvoice
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
            lblOrderNumber = new Label();
            txtOrderNumber = new TextBox();
            lblStore = new Label();
            txtStore = new TextBox();
            lblEmployee = new Label();
            txtEmployee = new TextBox();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            lblOrderDate = new Label();
            txtOrderDate = new TextBox();
            validatorBindingSource = new BindingSource(components);
            validatorBindingSource1 = new BindingSource(components);
            dgvCart = new DataGridView();
            columntitle = new DataGridViewTextBoxColumn();
            columnQty = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnDiscount = new DataGridViewTextBoxColumn();
            columnLineTotal = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            lblTotal = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(6, 23);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(132, 25);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "Order Number:";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.BorderStyle = BorderStyle.FixedSingle;
            txtOrderNumber.Location = new Point(144, 23);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.ReadOnly = true;
            txtOrderNumber.Size = new Size(252, 31);
            txtOrderNumber.TabIndex = 1;
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(77, 68);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(57, 25);
            lblStore.TabIndex = 2;
            lblStore.Text = "Store:";
            // 
            // txtStore
            // 
            txtStore.BorderStyle = BorderStyle.FixedSingle;
            txtStore.Location = new Point(144, 68);
            txtStore.Name = "txtStore";
            txtStore.ReadOnly = true;
            txtStore.Size = new Size(252, 31);
            txtStore.TabIndex = 3;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(41, 113);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(94, 25);
            lblEmployee.TabIndex = 4;
            lblEmployee.Text = "Employee:";
            // 
            // txtEmployee
            // 
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Location = new Point(144, 113);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(252, 31);
            txtEmployee.TabIndex = 5;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(41, 158);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(93, 25);
            lblCustomer.TabIndex = 6;
            lblCustomer.Text = "Customer:";
            // 
            // txtCustomer
            // 
            txtCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtCustomer.Location = new Point(144, 158);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(252, 31);
            txtCustomer.TabIndex = 7;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(34, 203);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(104, 25);
            lblOrderDate.TabIndex = 8;
            lblOrderDate.Text = "Order Date:";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = BorderStyle.FixedSingle;
            txtOrderDate.Location = new Point(144, 203);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(252, 31);
            txtOrderDate.TabIndex = 9;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoGenerateColumns = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { columntitle, columnQty, columnPrice, columnDiscount, columnLineTotal });
            dgvCart.DataSource = validatorBindingSource1;
            dgvCart.Location = new Point(16, 252);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(783, 360);
            dgvCart.TabIndex = 17;
            // 
            // columntitle
            // 
            columntitle.FillWeight = 129.305466F;
            columntitle.HeaderText = "Title";
            columntitle.MinimumWidth = 8;
            columntitle.Name = "columntitle";
            columntitle.ReadOnly = true;
            columntitle.Width = 80;
            // 
            // columnQty
            // 
            columnQty.FillWeight = 59.75903F;
            columnQty.HeaderText = "Qty";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            columnQty.Width = 77;
            // 
            // columnPrice
            // 
            columnPrice.FillWeight = 124.239647F;
            columnPrice.HeaderText = "Unit Price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            columnPrice.Width = 122;
            // 
            // columnDiscount
            // 
            columnDiscount.FillWeight = 115.509079F;
            columnDiscount.HeaderText = "Discount";
            columnDiscount.MinimumWidth = 8;
            columnDiscount.Name = "columnDiscount";
            columnDiscount.ReadOnly = true;
            columnDiscount.Width = 118;
            // 
            // columnLineTotal
            // 
            columnLineTotal.FillWeight = 108.5999F;
            columnLineTotal.HeaderText = "Line Total";
            columnLineTotal.MinimumWidth = 8;
            columnLineTotal.Name = "columnLineTotal";
            columnLineTotal.ReadOnly = true;
            columnLineTotal.Width = 121;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.Location = new Point(698, 113);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(101, 31);
            txtTotal.TabIndex = 32;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(531, 114);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(111, 31);
            txtTax.TabIndex = 31;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(531, 69);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(111, 31);
            txtSubtotal.TabIndex = 30;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.Location = new Point(746, 75);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(484, 120);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(40, 25);
            lblTax.TabIndex = 28;
            lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(441, 72);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(83, 25);
            lblSubtotal.TabIndex = 27;
            lblSubtotal.Text = "Subtotal:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(649, 168);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 52);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderSummaryInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(814, 630);
            Controls.Add(btnClose);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvCart);
            Controls.Add(txtOrderDate);
            Controls.Add(lblOrderDate);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(txtEmployee);
            Controls.Add(lblEmployee);
            Controls.Add(txtStore);
            Controls.Add(lblStore);
            Controls.Add(txtOrderNumber);
            Controls.Add(lblOrderNumber);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderSummaryInvoice";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Summary/Invoice";
            Load += frmOrderSummaryInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNumber;
        private TextBox txtOrderNumber;
        private Label lblStore;
        private TextBox txtStore;
        private Label lblEmployee;
        private TextBox txtEmployee;
        private Label lblCustomer;
        private TextBox txtCustomer;
        private Label lblOrderDate;
        private TextBox txtOrderDate;
        private BindingSource validatorBindingSource;
        private BindingSource validatorBindingSource1;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn columntitle;
        private DataGridViewTextBoxColumn columnQty;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnDiscount;
        private DataGridViewTextBoxColumn columnLineTotal;
        private TextBox txtTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label lblTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private Button btnClose;
    }
}