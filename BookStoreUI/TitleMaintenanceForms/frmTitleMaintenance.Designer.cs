namespace BookStoreUI
{
    partial class frmTitleMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitleMaintenance));
            btnDeleteTitle = new Button();
            btnAddTitle = new Button();
            lblDetails = new Label();
            btnEditTitle = new Button();
            btnSearch = new Button();
            validatorBindingSource = new BindingSource(components);
            spcDetails = new SplitContainer();
            dgvTitle = new DataGridView();
            validatorBindingSource1 = new BindingSource(components);
            rtbDetails = new RichTextBox();
            txtSearch = new TextBox();
            columnTitleId = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnType = new DataGridViewTextBoxColumn();
            columnPub_id = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteTitle
            // 
            btnDeleteTitle.Location = new Point(463, 723);
            btnDeleteTitle.Name = "btnDeleteTitle";
            btnDeleteTitle.Size = new Size(219, 57);
            btnDeleteTitle.TabIndex = 5;
            btnDeleteTitle.Text = "Delete Selected Title";
            btnDeleteTitle.UseVisualStyleBackColor = true;
            btnDeleteTitle.Click += btnDeleteTitle_Click;
            // 
            // btnAddTitle
            // 
            btnAddTitle.Location = new Point(14, 723);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(219, 57);
            btnAddTitle.TabIndex = 3;
            btnAddTitle.Text = "Add a New Title";
            btnAddTitle.UseVisualStyleBackColor = true;
            btnAddTitle.Click += btnAddTitle_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(961, 105);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(65, 25);
            lblDetails.TabIndex = 17;
            lblDetails.Text = "Details";
            // 
            // btnEditTitle
            // 
            btnEditTitle.Location = new Point(239, 723);
            btnEditTitle.Name = "btnEditTitle";
            btnEditTitle.Size = new Size(219, 57);
            btnEditTitle.TabIndex = 4;
            btnEditTitle.Text = "Edit Selected Title";
            btnEditTitle.UseVisualStyleBackColor = true;
            btnEditTitle.Click += btbEditTitle_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(389, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search by Title";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 133);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvTitle);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rtbDetails);
            spcDetails.Size = new Size(1183, 567);
            spcDetails.SplitterDistance = 817;
            spcDetails.TabIndex = 20;
            // 
            // dgvTitle
            // 
            dgvTitle.AllowUserToAddRows = false;
            dgvTitle.AllowUserToOrderColumns = true;
            dgvTitle.AutoGenerateColumns = false;
            dgvTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitle.Columns.AddRange(new DataGridViewColumn[] { columnTitleId, columnTitle, columnType, columnPub_id, columnPrice });
            dgvTitle.DataSource = validatorBindingSource1;
            dgvTitle.Dock = DockStyle.Fill;
            dgvTitle.Location = new Point(0, 0);
            dgvTitle.MultiSelect = false;
            dgvTitle.Name = "dgvTitle";
            dgvTitle.ReadOnly = true;
            dgvTitle.RowHeadersWidth = 62;
            dgvTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitle.Size = new Size(817, 567);
            dgvTitle.TabIndex = 0;
            // 
            // rtbDetails
            // 
            rtbDetails.Location = new Point(0, 0);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.Size = new Size(361, 567);
            rtbDetails.TabIndex = 0;
            rtbDetails.Text = "";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(365, 31);
            txtSearch.TabIndex = 1;
            // 
            // columnTitleId
            // 
            columnTitleId.DataPropertyName = "TitleId";
            columnTitleId.HeaderText = "Title ID";
            columnTitleId.MinimumWidth = 8;
            columnTitleId.Name = "columnTitleId";
            columnTitleId.ReadOnly = true;
            columnTitleId.Width = 150;
            // 
            // columnTitle
            // 
            columnTitle.DataPropertyName = "Title1";
            columnTitle.HeaderText = "Title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 150;
            // 
            // columnType
            // 
            columnType.DataPropertyName = "Type";
            columnType.HeaderText = "Type";
            columnType.MinimumWidth = 8;
            columnType.Name = "columnType";
            columnType.ReadOnly = true;
            columnType.Width = 150;
            // 
            // columnPub_id
            // 
            columnPub_id.DataPropertyName = "PubId";
            columnPub_id.HeaderText = "Pub. ID";
            columnPub_id.MinimumWidth = 8;
            columnPub_id.Name = "columnPub_id";
            columnPub_id.ReadOnly = true;
            columnPub_id.Width = 150;
            // 
            // columnPrice
            // 
            columnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            columnPrice.DefaultCellStyle = dataGridViewCellStyle1;
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            columnPrice.Width = 150;
            // 
            // frmTitleMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 817);
            Controls.Add(btnDeleteTitle);
            Controls.Add(btnAddTitle);
            Controls.Add(lblDetails);
            Controls.Add(btnEditTitle);
            Controls.Add(btnSearch);
            Controls.Add(spcDetails);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTitleMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Title Maintenance";
            Load += frmTitleMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            spcDetails.Panel1.ResumeLayout(false);
            spcDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcDetails).EndInit();
            spcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteTitle;
        private Button btnAddTitle;
        private Label lblDetails;
        private Button btnEditTitle;
        private Button btnSearch;
        private BindingSource validatorBindingSource;
        private SplitContainer spcDetails;
        private DataGridView dgvTitle;
        private BindingSource validatorBindingSource1;
        private RichTextBox rtbDetails;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn columnTitleId;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnPub_id;
        private DataGridViewTextBoxColumn columnPrice;
    }
}