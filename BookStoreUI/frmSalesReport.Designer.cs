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
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(11, 18);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(61, 15);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(15, 45);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(57, 15);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy/MM/dd";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(76, 12);
            dtpStartDate.Margin = new Padding(2);
            dtpStartDate.MaxDate = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(99, 23);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(76, 39);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.MaxDate = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(191, 12);
            btnGenerateReport.Margin = new Padding(2);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(79, 50);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.AutoGenerateColumns = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { columnnord_num, columnord_date, columnTitle_id, columnTitle, columnQty, columnTotal_value });
            dgvSales.DataSource = validatorBindingSource;
            dgvSales.Location = new Point(11, 77);
            dgvSales.Margin = new Padding(2);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 62;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(538, 344);
            dgvSales.TabIndex = 5;
            // 
            // columnnord_num
            // 
            columnnord_num.HeaderText = "Order Num.";
            columnnord_num.MinimumWidth = 8;
            columnnord_num.Name = "columnnord_num";
            columnnord_num.ReadOnly = true;
            // 
            // columnord_date
            // 
            columnord_date.HeaderText = "Order Date";
            columnord_date.MinimumWidth = 8;
            columnord_date.Name = "columnord_date";
            columnord_date.ReadOnly = true;
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
            // columnQty
            // 
            columnQty.HeaderText = "Quantity";
            columnQty.MinimumWidth = 8;
            columnQty.Name = "columnQty";
            columnQty.ReadOnly = true;
            // 
            // columnTotal_value
            // 
            columnTotal_value.HeaderText = "Total Value";
            columnTotal_value.MinimumWidth = 8;
            columnTotal_value.Name = "columnTotal_value";
            columnTotal_value.ReadOnly = true;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(15, 441);
            lblTotalValue.Margin = new Padding(2, 0, 2, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(157, 15);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "Total Value of Sold Products:";
            // 
            // txtTotalValue
            // 
            txtTotalValue.Location = new Point(176, 438);
            txtTotalValue.Margin = new Padding(2);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(71, 23);
            txtTotalValue.TabIndex = 7;
            txtTotalValue.TextAlign = HorizontalAlignment.Right;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(403, 438);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(71, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export File";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(478, 438);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmSalesReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(560, 472);
            Controls.Add(btnClose);
            Controls.Add(btnExport);
            Controls.Add(txtTotalValue);
            Controls.Add(lblTotalValue);
            Controls.Add(dgvSales);
            Controls.Add(btnGenerateReport);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtpStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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
        private DateTimePicker dateTimePicker1;
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
    }
}