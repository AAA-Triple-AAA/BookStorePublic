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
            txtSearch = new TextBox();
            rbtDetails = new RichTextBox();
            validatorBindingSource1 = new BindingSource(components);
            lblSearch = new Label();
            spcDetails = new SplitContainer();
            this.dgvPublisher = new DataGridView();
            validatorBindingSource = new BindingSource(components);
            btnAddPublisher = new Button();
            lblDetails = new Label();
            btbEditPublisher = new Button();
            btnSearch = new Button();
            btbDeletePublisher = new Button();
            columnPub_id = new DataGridViewTextBoxColumn();
            columnPub_name = new DataGridViewTextBoxColumn();
            columnCity = new DataGridViewTextBoxColumn();
            columnState = new DataGridViewTextBoxColumn();
            columnCountry = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvPublisher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 31);
            txtSearch.TabIndex = 26;
            // 
            // rbtDetails
            // 
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(361, 567);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 24;
            lblSearch.Text = "Search:";
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-2, 133);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(this.dgvPublisher);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rbtDetails);
            spcDetails.Size = new Size(1183, 567);
            spcDetails.SplitterDistance = 817;
            spcDetails.TabIndex = 28;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.AllowUserToAddRows = false;
            this.dgvPublisher.AllowUserToOrderColumns = true;
            this.dgvPublisher.AutoGenerateColumns = false;
            this.dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Columns.AddRange(new DataGridViewColumn[] { columnPub_id, columnPub_name, columnCity, columnState, columnCountry });
            this.dgvPublisher.DataSource = validatorBindingSource1;
            this.dgvPublisher.Dock = DockStyle.Fill;
            this.dgvPublisher.Location = new Point(0, 0);
            this.dgvPublisher.MultiSelect = false;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.RowHeadersWidth = 62;
            this.dgvPublisher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublisher.Size = new Size(817, 567);
            this.dgvPublisher.TabIndex = 0;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // btnAddPublisher
            // 
            btnAddPublisher.Location = new Point(70, 772);
            btnAddPublisher.Name = "btnAddPublisher";
            btnAddPublisher.Size = new Size(231, 95);
            btnAddPublisher.TabIndex = 29;
            btnAddPublisher.Text = "Add a New Publisher";
            btnAddPublisher.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(960, 105);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(65, 25);
            lblDetails.TabIndex = 25;
            lblDetails.Text = "Details";
            // 
            // btbEditPublisher
            // 
            btbEditPublisher.Location = new Point(488, 772);
            btbEditPublisher.Name = "btbEditPublisher";
            btbEditPublisher.Size = new Size(231, 95);
            btbEditPublisher.TabIndex = 30;
            btbEditPublisher.Text = "Edit Selected Publisher";
            btbEditPublisher.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(530, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 33);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search by Publisher";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btbDeletePublisher
            // 
            btbDeletePublisher.Location = new Point(872, 772);
            btbDeletePublisher.Name = "btbDeletePublisher";
            btbDeletePublisher.Size = new Size(231, 95);
            btbDeletePublisher.TabIndex = 31;
            btbDeletePublisher.Text = "Delete Selected Publisher";
            btbDeletePublisher.UseVisualStyleBackColor = true;
            // 
            // columnPub_id
            // 
            columnPub_id.HeaderText = "pub_id";
            columnPub_id.MinimumWidth = 8;
            columnPub_id.Name = "columnPub_id";
            columnPub_id.ReadOnly = true;
            columnPub_id.Width = 150;
            // 
            // columnPub_name
            // 
            columnPub_name.HeaderText = "pub_name";
            columnPub_name.MinimumWidth = 8;
            columnPub_name.Name = "columnPub_name";
            columnPub_name.ReadOnly = true;
            columnPub_name.Width = 150;
            // 
            // columnCity
            // 
            columnCity.HeaderText = "city";
            columnCity.MinimumWidth = 8;
            columnCity.Name = "columnCity";
            columnCity.ReadOnly = true;
            columnCity.Width = 150;
            // 
            // columnState
            // 
            columnState.HeaderText = "state";
            columnState.MinimumWidth = 8;
            columnState.Name = "columnState";
            columnState.ReadOnly = true;
            columnState.Width = 150;
            // 
            // columnCountry
            // 
            columnCountry.HeaderText = "country";
            columnCountry.MinimumWidth = 8;
            columnCountry.Name = "columnCountry";
            columnCountry.ReadOnly = true;
            columnCountry.Width = 150;
            // 
            // frmPublisherMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 944);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(spcDetails);
            Controls.Add(btnAddPublisher);
            Controls.Add(lblDetails);
            Controls.Add(btbEditPublisher);
            Controls.Add(btnSearch);
            Controls.Add(btbDeletePublisher);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)this.dgvPublisher).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private RichTextBox rbtDetails;
        private BindingSource validatorBindingSource1;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnTitle;
        private Label lblSearch;
        private DataGridViewTextBoxColumn columnTitle_id;
        private SplitContainer spcDetails;
        private DataGridView dgvTitle;
        private BindingSource validatorBindingSource;
        private Button btnAddPublisher;
        private Label lblDetails;
        private Button btbEditPublisher;
        private Button btnSearch;
        private Button btbDeletePublisher;
        private DataGridViewTextBoxColumn columnPub_id;
        private DataGridViewTextBoxColumn columnPub_name;
        private DataGridViewTextBoxColumn columnCity;
        private DataGridViewTextBoxColumn columnState;
        private DataGridViewTextBoxColumn columnCountry;
    }
}