namespace BookStoreUI
{
    partial class frmSalesReport
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            dgvSales = new DataGridView();
            columnnord_num = new DataGridViewTextBoxColumn();
            columnord_date = new DataGridViewTextBoxColumn();
            columnTitle_id = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnQty = new DataGridViewTextBoxColumn();
            columnTotal_value = new DataGridViewTextBoxColumn();
            validatorBindingSource = new BindingSource(components);
            lblTotalValue = new Label();
            txtTotalValue = new TextBox();
            btnExport = new Button();
            btnClose = new Button();
            chkCustom = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(16, 30);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(94, 25);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(21, 75);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(88, 25);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy/MM/dd";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(113, 30);
            dtpStartDate.Margin = new Padding(2, 4, 2, 4);
            dtpStartDate.MaxDate = new DateTime(2025, 12, 7, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(140, 31);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.Value = new DateTime(1989, 1, 1, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "yyyy/MM/dd";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(113, 73);
            dtpEndDate.Margin = new Padding(2, 4, 2, 4);
            dtpEndDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(140, 31);
            dtpEndDate.TabIndex = 2;
            dtpEndDate.Value = new DateTime(2025, 12, 7, 0, 0, 0, 0);
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(483, 20);
            btnGenerateReport.Margin = new Padding(2, 4, 2, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(112, 84);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.AutoGenerateColumns = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { columnnord_num, columnord_date, columnTitle_id, columnTitle, columnQty, columnTotal_value });
            dgvSales.DataSource = validatorBindingSource;
            dgvSales.Location = new Point(16, 129);
            dgvSales.Margin = new Padding(2, 4, 2, 4);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 62;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(769, 574);
            dgvSales.TabIndex = 5;
            // 
            // columnnord_num
            // 
            columnnord_num.DataPropertyName = "OrderNum";
            columnnord_num.HeaderText = "Order Num.";
            columnnord_num.MinimumWidth = 8;
            columnnord_num.Name = "columnnord_num";
            columnnord_num.ReadOnly = true;
            columnnord_num.Width = 142;
            // 
            // columnord_date
            // 
            columnord_date.DataPropertyName = "OrderDate";
            columnord_date.HeaderText = "Order Date";
            columnord_date.MinimumWidth = 8;
            columnord_date.Name = "columnord_date";
            columnord_date.ReadOnly = true;
            columnord_date.Width = 136;
            // 
            // columnTitle_id
            // 
            columnTitle_id.DataPropertyName = "TitleId";
            columnTitle_id.HeaderText = "Title ID";
            columnTitle_id.MinimumWidth = 8;
            columnTitle_id.Name = "columnTitle_id";
            columnTitle_id.ReadOnly = true;
            columnTitle_id.Width = 103;
            // 
            // columnTitle
            // 
            columnTitle.DataPropertyName = "Title";
            columnTitle.HeaderText = "Title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 80;
            // 
            // columnQty
            // 
            columnQty.DataPropertyName = "Qty";
            columnQty.HeaderText = "Quantity";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            columnQty.Width = 116;
            // 
            // columnTotal_value
            // 
            columnTotal_value.DataPropertyName = "TotalValue";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            columnTotal_value.DefaultCellStyle = dataGridViewCellStyle2;
            columnTotal_value.HeaderText = "Total Value";
            columnTotal_value.MinimumWidth = 8;
            columnTotal_value.Name = "columnTotal_value";
            columnTotal_value.ReadOnly = true;
            columnTotal_value.Width = 132;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(21, 735);
            lblTotalValue.Margin = new Padding(2, 0, 2, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(238, 25);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "Total Value of Sold Products:";
            // 
            // txtTotalValue
            // 
            txtTotalValue.Location = new Point(251, 730);
            txtTotalValue.Margin = new Padding(2, 4, 2, 4);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(100, 31);
            txtTotalValue.TabIndex = 7;
            txtTotalValue.TextAlign = HorizontalAlignment.Right;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(576, 730);
            btnExport.Margin = new Padding(2, 4, 2, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(101, 39);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(682, 730);
            btnClose.Margin = new Padding(2, 4, 2, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 39);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // chkCustom
            // 
            chkCustom.AutoSize = true;
            chkCustom.Location = new Point(307, 49);
            chkCustom.Name = "chkCustom";
            chkCustom.Size = new Size(150, 29);
            chkCustom.TabIndex = 8;
            chkCustom.Text = "Custom Date?";
            chkCustom.UseVisualStyleBackColor = true;
            // 
            // frmSalesReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 786);
            Controls.Add(chkCustom);
            Controls.Add(btnClose);
            Controls.Add(btnExport);
            Controls.Add(txtTotalValue);
            Controls.Add(lblTotalValue);
            Controls.Add(dgvSales);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSalesReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerateReport;
        private DataGridView dgvSales;
        private BindingSource validatorBindingSource;
        private Label lblTotalValue;
        private TextBox txtTotalValue;
        private Button btnExport;
        private Button btnClose;
        private DataGridViewTextBoxColumn columnnord_num;
        private DataGridViewTextBoxColumn columnord_date;
        private DataGridViewTextBoxColumn columnTitle_id;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnQty;
        private DataGridViewTextBoxColumn columnTotal_value;
        private CheckBox chkCustom;
    }
}