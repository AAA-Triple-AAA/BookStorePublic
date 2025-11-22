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
            lblPrintExport = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(4, 14);
            lblOrderNumber.Margin = new Padding(2, 0, 2, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(87, 15);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "Order Number:";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.BorderStyle = BorderStyle.FixedSingle;
            txtOrderNumber.Location = new Point(95, 6);
            txtOrderNumber.Margin = new Padding(2, 2, 2, 2);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.ReadOnly = true;
            txtOrderNumber.Size = new Size(106, 23);
            txtOrderNumber.TabIndex = 1;
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(54, 41);
            lblStore.Margin = new Padding(2, 0, 2, 0);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(37, 15);
            lblStore.TabIndex = 2;
            lblStore.Text = "Store:";
            // 
            // txtStore
            // 
            txtStore.BorderStyle = BorderStyle.FixedSingle;
            txtStore.Location = new Point(95, 33);
            txtStore.Margin = new Padding(2, 2, 2, 2);
            txtStore.Name = "txtStore";
            txtStore.ReadOnly = true;
            txtStore.Size = new Size(106, 23);
            txtStore.TabIndex = 3;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(29, 68);
            lblEmployee.Margin = new Padding(2, 0, 2, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(62, 15);
            lblEmployee.TabIndex = 4;
            lblEmployee.Text = "Employee:";
            // 
            // txtEmployee
            // 
            txtEmployee.BorderStyle = BorderStyle.FixedSingle;
            txtEmployee.Location = new Point(95, 60);
            txtEmployee.Margin = new Padding(2, 2, 2, 2);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(106, 23);
            txtEmployee.TabIndex = 5;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(29, 95);
            lblCustomer.Margin = new Padding(2, 0, 2, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(62, 15);
            lblCustomer.TabIndex = 6;
            lblCustomer.Text = "Customer:";
            // 
            // txtCustomer
            // 
            txtCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtCustomer.Location = new Point(95, 87);
            txtCustomer.Margin = new Padding(2, 2, 2, 2);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(106, 23);
            txtCustomer.TabIndex = 7;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(24, 122);
            lblOrderDate.Margin = new Padding(2, 0, 2, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(67, 15);
            lblOrderDate.TabIndex = 8;
            lblOrderDate.Text = "Order Date:";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = BorderStyle.FixedSingle;
            txtOrderDate.Location = new Point(95, 114);
            txtOrderDate.Margin = new Padding(2, 2, 2, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(106, 23);
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
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { columntitle, columnQty, columnPrice, columnDiscount, columnLineTotal });
            dgvCart.DataSource = validatorBindingSource1;
            dgvCart.Location = new Point(11, 151);
            dgvCart.Margin = new Padding(2, 2, 2, 2);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(548, 216);
            dgvCart.TabIndex = 17;
            // 
            // columntitle
            // 
            columntitle.FillWeight = 129.305466F;
            columntitle.HeaderText = "Title";
            columntitle.MinimumWidth = 8;
            columntitle.Name = "columntitle";
            columntitle.ReadOnly = true;
            // 
            // columnQty
            // 
            columnQty.FillWeight = 59.75903F;
            columnQty.HeaderText = "Qty";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            // 
            // columnPrice
            // 
            columnPrice.FillWeight = 124.239647F;
            columnPrice.HeaderText = "Unit Price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            // 
            // columnDiscount
            // 
            columnDiscount.FillWeight = 115.509079F;
            columnDiscount.HeaderText = "Discount";
            columnDiscount.MinimumWidth = 8;
            columnDiscount.Name = "columnDiscount";
            columnDiscount.ReadOnly = true;
            // 
            // columnLineTotal
            // 
            columnLineTotal.FillWeight = 108.5999F;
            columnLineTotal.HeaderText = "Line Total";
            columnLineTotal.MinimumWidth = 8;
            columnLineTotal.Name = "columnLineTotal";
            columnLineTotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.Location = new Point(439, 73);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(106, 23);
            txtTotal.TabIndex = 32;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(316, 73);
            txtTax.Margin = new Padding(2, 2, 2, 2);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(106, 23);
            txtTax.TabIndex = 31;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(316, 46);
            txtSubtotal.Margin = new Padding(2, 2, 2, 2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(106, 23);
            txtSubtotal.TabIndex = 30;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.Location = new Point(439, 54);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(280, 76);
            lblTax.Margin = new Padding(2, 0, 2, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 15);
            lblTax.TabIndex = 28;
            lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(253, 49);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 27;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblPrintExport
            // 
            lblPrintExport.Location = new Point(316, 106);
            lblPrintExport.Margin = new Padding(2, 2, 2, 2);
            lblPrintExport.Name = "lblPrintExport";
            lblPrintExport.Size = new Size(106, 31);
            lblPrintExport.TabIndex = 33;
            lblPrintExport.Text = "Print/Export";
            lblPrintExport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(439, 106);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 31);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOrderSummaryInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(570, 378);
            Controls.Add(btnClose);
            Controls.Add(lblPrintExport);
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
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderSummaryInvoice";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Summary/Invoice";
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
        private Button lblPrintExport;
        private Button btnClose;
    }
}