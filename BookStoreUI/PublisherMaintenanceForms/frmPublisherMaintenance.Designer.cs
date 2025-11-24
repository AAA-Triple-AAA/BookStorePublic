namespace BookStoreUI.PublisherMaintenanceForms
{
    partial class frmPublisherMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublisherMaintenance));
            txtSearch = new TextBox();
            rtbDetails = new RichTextBox();
            validatorBindingSource1 = new BindingSource(components);
            spcDetails = new SplitContainer();
            dgvPublisher = new DataGridView();
            columnPub_id = new DataGridViewTextBoxColumn();
            columnPub_name = new DataGridViewTextBoxColumn();
            columnCity = new DataGridViewTextBoxColumn();
            columnState = new DataGridViewTextBoxColumn();
            columnCountry = new DataGridViewTextBoxColumn();
            validatorBindingSource = new BindingSource(components);
            btnAddPublisher = new Button();
            lblDetails = new Label();
            btnEditPublisher = new Button();
            btnSearch = new Button();
            btnDeletePublisher = new Button();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 24);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 1;
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
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 80);
            spcDetails.Margin = new Padding(2);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvPublisher);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rtbDetails);
            spcDetails.Size = new Size(828, 340);
            spcDetails.SplitterDistance = 571;
            spcDetails.SplitterWidth = 3;
            spcDetails.TabIndex = 28;
            // 
            // dgvPublisher
            // 
            dgvPublisher.AllowUserToAddRows = false;
            dgvPublisher.AllowUserToOrderColumns = true;
            dgvPublisher.AutoGenerateColumns = false;
            dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisher.Columns.AddRange(new DataGridViewColumn[] { columnPub_id, columnPub_name, columnCity, columnState, columnCountry });
            dgvPublisher.DataSource = validatorBindingSource1;
            dgvPublisher.Dock = DockStyle.Fill;
            dgvPublisher.Location = new Point(0, 0);
            dgvPublisher.Margin = new Padding(2);
            dgvPublisher.MultiSelect = false;
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.ReadOnly = true;
            dgvPublisher.RowHeadersWidth = 62;
            dgvPublisher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublisher.Size = new Size(571, 340);
            dgvPublisher.TabIndex = 0;
            // 
            // columnPub_id
            // 
            columnPub_id.HeaderText = "Pub. ID";
            columnPub_id.MinimumWidth = 8;
            columnPub_id.Name = "columnPub_id";
            columnPub_id.ReadOnly = true;
            columnPub_id.Width = 150;
            // 
            // columnPub_name
            // 
            columnPub_name.HeaderText = "Name";
            columnPub_name.MinimumWidth = 8;
            columnPub_name.Name = "columnPub_name";
            columnPub_name.ReadOnly = true;
            columnPub_name.Width = 150;
            // 
            // columnCity
            // 
            columnCity.HeaderText = "City";
            columnCity.MinimumWidth = 8;
            columnCity.Name = "columnCity";
            columnCity.ReadOnly = true;
            columnCity.Width = 150;
            // 
            // columnState
            // 
            columnState.HeaderText = "State";
            columnState.MinimumWidth = 8;
            columnState.Name = "columnState";
            columnState.ReadOnly = true;
            columnState.Width = 150;
            // 
            // columnCountry
            // 
            columnCountry.HeaderText = "Country";
            columnCountry.MinimumWidth = 8;
            columnCountry.Name = "columnCountry";
            columnCountry.ReadOnly = true;
            columnCountry.Width = 150;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnAddPublisher
            // 
            btnAddPublisher.Location = new Point(11, 437);
            btnAddPublisher.Margin = new Padding(2);
            btnAddPublisher.Name = "btnAddPublisher";
            btnAddPublisher.Size = new Size(153, 34);
            btnAddPublisher.TabIndex = 3;
            btnAddPublisher.Text = "Add a New Publisher";
            btnAddPublisher.UseVisualStyleBackColor = true;
            btnAddPublisher.Click += btnAddPublisher_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(672, 63);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(42, 15);
            lblDetails.TabIndex = 25;
            lblDetails.Text = "Details";
            // 
            // btnEditPublisher
            // 
            btnEditPublisher.Location = new Point(168, 437);
            btnEditPublisher.Margin = new Padding(2);
            btnEditPublisher.Name = "btnEditPublisher";
            btnEditPublisher.Size = new Size(153, 34);
            btnEditPublisher.TabIndex = 4;
            btnEditPublisher.Text = "Edit Selected Publisher";
            btnEditPublisher.UseVisualStyleBackColor = true;
            btnEditPublisher.Click += btbEditPublisher_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 24);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search by Publisher";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeletePublisher
            // 
            btnDeletePublisher.Location = new Point(325, 437);
            btnDeletePublisher.Margin = new Padding(2);
            btnDeletePublisher.Name = "btnDeletePublisher";
            btnDeletePublisher.Size = new Size(153, 34);
            btnDeletePublisher.TabIndex = 5;
            btnDeletePublisher.Text = "Delete Selected Publisher";
            btnDeletePublisher.UseVisualStyleBackColor = true;
            // 
            // frmPublisherMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 490);
            Controls.Add(txtSearch);
            Controls.Add(spcDetails);
            Controls.Add(btnAddPublisher);
            Controls.Add(lblDetails);
            Controls.Add(btnEditPublisher);
            Controls.Add(btnSearch);
            Controls.Add(btnDeletePublisher);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPublisherMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publisher Maintenance";
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            spcDetails.Panel1.ResumeLayout(false);
            spcDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcDetails).EndInit();
            spcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private RichTextBox rtbDetails;
        private BindingSource validatorBindingSource1;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnTitle_id;
        private SplitContainer spcDetails;
        private DataGridView dgvPublisher;
        private BindingSource validatorBindingSource;
        private Button btnAddPublisher;
        private Label lblDetails;
        private Button btnEditPublisher;
        private Button btnSearch;
        private Button btnDeletePublisher;
        private DataGridViewTextBoxColumn columnPub_id;
        private DataGridViewTextBoxColumn columnPub_name;
        private DataGridViewTextBoxColumn columnCity;
        private DataGridViewTextBoxColumn columnState;
        private DataGridViewTextBoxColumn columnCountry;
    }
}