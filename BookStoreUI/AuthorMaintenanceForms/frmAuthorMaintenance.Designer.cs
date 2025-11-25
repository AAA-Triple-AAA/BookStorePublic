namespace BookStoreUI
{
    partial class frmAuthorMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthorMaintenance));
            btnDeleteAuthor = new Button();
            btnAddAuthor = new Button();
            lblDetails = new Label();
            rtbDetails = new RichTextBox();
            validatorBindingSource1 = new BindingSource(components);
            btnEditAuthor = new Button();
            dgvAuthor = new DataGridView();
            columnAuId = new DataGridViewTextBoxColumn();
            columnAuLName = new DataGridViewTextBoxColumn();
            columnAuFname = new DataGridViewTextBoxColumn();
            columnphone = new DataGridViewTextBoxColumn();
            columnAddress = new DataGridViewTextBoxColumn();
            spcDetails = new SplitContainer();
            validatorBindingSource = new BindingSource(components);
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(295, 435);
            btnDeleteAuthor.Margin = new Padding(2);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(138, 34);
            btnDeleteAuthor.TabIndex = 15;
            btnDeleteAuthor.Text = "Delete Selected Author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(11, 435);
            btnAddAuthor.Margin = new Padding(2);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(138, 34);
            btnAddAuthor.TabIndex = 13;
            btnAddAuthor.Text = "Add a New Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(673, 63);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(42, 15);
            lblDetails.TabIndex = 9;
            lblDetails.Text = "Details";
            // 
            // rtbDetails
            // 
            rtbDetails.Location = new Point(0, 0);
            rtbDetails.Margin = new Padding(2);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.Size = new Size(254, 342);
            rtbDetails.TabIndex = 0;
            rtbDetails.Text = "";
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.Location = new Point(153, 435);
            btnEditAuthor.Margin = new Padding(2);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(138, 34);
            btnEditAuthor.TabIndex = 14;
            btnEditAuthor.Text = "Edit Selected Author";
            btnEditAuthor.UseVisualStyleBackColor = true;
            btnEditAuthor.Click += btbEditAuthor_Click;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToAddRows = false;
            dgvAuthor.AllowUserToOrderColumns = true;
            dgvAuthor.AutoGenerateColumns = false;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { columnAuId, columnAuLName, columnAuFname, columnphone, columnAddress });
            dgvAuthor.DataSource = validatorBindingSource1;
            dgvAuthor.Dock = DockStyle.Fill;
            dgvAuthor.Location = new Point(0, 0);
            dgvAuthor.Margin = new Padding(2);
            dgvAuthor.MultiSelect = false;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.ReadOnly = true;
            dgvAuthor.RowHeadersWidth = 62;
            dgvAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthor.Size = new Size(572, 340);
            dgvAuthor.TabIndex = 0;
            dgvAuthor.SelectionChanged += dgvAuthor_SelectionChanged;
            // 
            // columnAuId
            // 
            columnAuId.DataPropertyName = "AuId";
            columnAuId.HeaderText = "Author ID";
            columnAuId.MinimumWidth = 8;
            columnAuId.Name = "columnAuId";
            columnAuId.ReadOnly = true;
            columnAuId.Width = 150;
            // 
            // columnAuLName
            // 
            columnAuLName.DataPropertyName = "AuLname";
            columnAuLName.HeaderText = "Last Name";
            columnAuLName.MinimumWidth = 8;
            columnAuLName.Name = "columnAuLName";
            columnAuLName.ReadOnly = true;
            columnAuLName.Width = 150;
            // 
            // columnAuFname
            // 
            columnAuFname.DataPropertyName = "AuFname";
            columnAuFname.HeaderText = "First Name";
            columnAuFname.MinimumWidth = 8;
            columnAuFname.Name = "columnAuFname";
            columnAuFname.ReadOnly = true;
            columnAuFname.Width = 150;
            // 
            // columnphone
            // 
            columnphone.DataPropertyName = "Phone";
            columnphone.HeaderText = "Phone";
            columnphone.MinimumWidth = 8;
            columnphone.Name = "columnphone";
            columnphone.ReadOnly = true;
            columnphone.Width = 150;
            // 
            // columnAddress
            // 
            columnAddress.DataPropertyName = "Address";
            columnAddress.HeaderText = "Address";
            columnAddress.MinimumWidth = 8;
            columnAddress.Name = "columnAddress";
            columnAddress.ReadOnly = true;
            columnAddress.Width = 150;
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 80);
            spcDetails.Margin = new Padding(2);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvAuthor);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rtbDetails);
            spcDetails.Size = new Size(828, 340);
            spcDetails.SplitterDistance = 572;
            spcDetails.SplitterWidth = 3;
            spcDetails.TabIndex = 12;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 29);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search by Author";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 30);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 10;
            // 
            // frmAuthorMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 490);
            Controls.Add(spcDetails);
            Controls.Add(btnDeleteAuthor);
            Controls.Add(btnAddAuthor);
            Controls.Add(lblDetails);
            Controls.Add(btnEditAuthor);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAuthorMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author Maintenance";
            Load += frmAuthorMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            spcDetails.Panel1.ResumeLayout(false);
            spcDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcDetails).EndInit();
            spcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAuthor;
        private Button btnAddAuthor;
        private Label lblDetails;
        private RichTextBox rtbDetails;
        private BindingSource validatorBindingSource1;
        private Button btnEditAuthor;
        private DataGridView dgvAuthor;
        private SplitContainer spcDetails;
        private BindingSource validatorBindingSource;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn columnAuId;
        private DataGridViewTextBoxColumn columnAuLName;
        private DataGridViewTextBoxColumn columnAuFname;
        private DataGridViewTextBoxColumn columnphone;
        private DataGridViewTextBoxColumn columnAddress;
    }
}