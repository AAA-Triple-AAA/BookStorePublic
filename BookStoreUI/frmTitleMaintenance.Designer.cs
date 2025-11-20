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
            btbDeleteTitle = new Button();
            btnAddTitle = new Button();
            lblDetails = new Label();
            btbEditTitle = new Button();
            btnSearch = new Button();
            validatorBindingSource = new BindingSource(components);
            spcDetails = new SplitContainer();
            dgvTitle = new DataGridView();
            columnTitle_id = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnType = new DataGridViewTextBoxColumn();
            columnPub_id = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            validatorBindingSource1 = new BindingSource(components);
            rbtDetails = new RichTextBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btbDeleteTitle
            // 
            btbDeleteTitle.Location = new Point(611, 463);
            btbDeleteTitle.Margin = new Padding(2, 2, 2, 2);
            btbDeleteTitle.Name = "btbDeleteTitle";
            btbDeleteTitle.Size = new Size(162, 57);
            btbDeleteTitle.TabIndex = 23;
            btbDeleteTitle.Text = "Delete Selected Title";
            btbDeleteTitle.UseVisualStyleBackColor = true;
            // 
            // btnAddTitle
            // 
            btnAddTitle.Location = new Point(50, 463);
            btnAddTitle.Margin = new Padding(2, 2, 2, 2);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(162, 57);
            btnAddTitle.TabIndex = 21;
            btnAddTitle.Text = "Add a New Title";
            btnAddTitle.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(673, 63);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(42, 15);
            lblDetails.TabIndex = 17;
            lblDetails.Text = "Details";
            // 
            // btbEditTitle
            // 
            btbEditTitle.Location = new Point(342, 463);
            btbEditTitle.Margin = new Padding(2, 2, 2, 2);
            btbEditTitle.Name = "btbEditTitle";
            btbEditTitle.Size = new Size(162, 57);
            btbEditTitle.TabIndex = 22;
            btbEditTitle.Text = "Edit Selected Title";
            btbEditTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(372, 47);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 20);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search by Title";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 80);
            spcDetails.Margin = new Padding(2, 2, 2, 2);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvTitle);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rbtDetails);
            spcDetails.Size = new Size(828, 340);
            spcDetails.SplitterDistance = 572;
            spcDetails.SplitterWidth = 3;
            spcDetails.TabIndex = 20;
            // 
            // dgvTitle
            // 
            dgvTitle.AllowUserToAddRows = false;
            dgvTitle.AllowUserToOrderColumns = true;
            dgvTitle.AutoGenerateColumns = false;
            dgvTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitle.Columns.AddRange(new DataGridViewColumn[] { columnTitle_id, columnTitle, columnType, columnPub_id, columnPrice });
            dgvTitle.DataSource = validatorBindingSource1;
            dgvTitle.Dock = DockStyle.Fill;
            dgvTitle.Location = new Point(0, 0);
            dgvTitle.Margin = new Padding(2, 2, 2, 2);
            dgvTitle.MultiSelect = false;
            dgvTitle.Name = "dgvTitle";
            dgvTitle.ReadOnly = true;
            dgvTitle.RowHeadersWidth = 62;
            dgvTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitle.Size = new Size(572, 340);
            dgvTitle.TabIndex = 0;
            // 
            // columnTitle_id
            // 
            columnTitle_id.HeaderText = "title_id";
            columnTitle_id.MinimumWidth = 8;
            columnTitle_id.Name = "columnTitle_id";
            columnTitle_id.ReadOnly = true;
            columnTitle_id.Width = 150;
            // 
            // columnTitle
            // 
            columnTitle.HeaderText = "title";
            columnTitle.MinimumWidth = 8;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 150;
            // 
            // columnType
            // 
            columnType.HeaderText = "type";
            columnType.MinimumWidth = 8;
            columnType.Name = "columnType";
            columnType.ReadOnly = true;
            columnType.Width = 150;
            // 
            // columnPub_id
            // 
            columnPub_id.HeaderText = "pub_id";
            columnPub_id.MinimumWidth = 8;
            columnPub_id.Name = "columnPub_id";
            columnPub_id.ReadOnly = true;
            columnPub_id.Width = 150;
            // 
            // columnPrice
            // 
            columnPrice.HeaderText = "price";
            columnPrice.MinimumWidth = 8;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            columnPrice.Width = 150;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // rbtDetails
            // 
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Margin = new Padding(2, 2, 2, 2);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(254, 342);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 48);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(71, 48);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 18;
            // 
            // frmTitleMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 566);
            Controls.Add(btbDeleteTitle);
            Controls.Add(btnAddTitle);
            Controls.Add(lblDetails);
            Controls.Add(btbEditTitle);
            Controls.Add(btnSearch);
            Controls.Add(spcDetails);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTitleMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Title Maintenance";
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

        private Button btbDeleteTitle;
        private Button btnAddTitle;
        private Label lblDetails;
        private Button btbEditTitle;
        private Button btnSearch;
        private BindingSource validatorBindingSource;
        private SplitContainer spcDetails;
        private DataGridView dgvTitle;
        private BindingSource validatorBindingSource1;
        private RichTextBox rbtDetails;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn columnTitle_id;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnPub_id;
        private DataGridViewTextBoxColumn columnPrice;
    }
}