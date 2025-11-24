namespace BookStoreUI.StoreMaintenanceForms
{
    partial class frmStoreMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreMaintenance));
            validatorBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            spcDetails = new SplitContainer();
            dgvStore = new DataGridView();
            columnStore_id = new DataGridViewTextBoxColumn();
            columnStore_name = new DataGridViewTextBoxColumn();
            columnStoreAddress = new DataGridViewTextBoxColumn();
            columnCity = new DataGridViewTextBoxColumn();
            columnState = new DataGridViewTextBoxColumn();
            validatorBindingSource1 = new BindingSource(components);
            rtbDetails = new RichTextBox();
            btnAddStore = new Button();
            btnEditStore = new Button();
            btnSearch = new Button();
            btnDeleteStore = new Button();
            lblDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 25);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 1;
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 80);
            spcDetails.Margin = new Padding(2);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvStore);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rtbDetails);
            spcDetails.Size = new Size(828, 340);
            spcDetails.SplitterDistance = 571;
            spcDetails.SplitterWidth = 3;
            spcDetails.TabIndex = 36;
            // 
            // dgvStore
            // 
            dgvStore.AllowUserToAddRows = false;
            dgvStore.AllowUserToOrderColumns = true;
            dgvStore.AutoGenerateColumns = false;
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Columns.AddRange(new DataGridViewColumn[] { columnStore_id, columnStore_name, columnStoreAddress, columnCity, columnState });
            dgvStore.DataSource = validatorBindingSource1;
            dgvStore.Dock = DockStyle.Fill;
            dgvStore.Location = new Point(0, 0);
            dgvStore.Margin = new Padding(2);
            dgvStore.MultiSelect = false;
            dgvStore.Name = "dgvStore";
            dgvStore.ReadOnly = true;
            dgvStore.RowHeadersWidth = 62;
            dgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStore.Size = new Size(571, 340);
            dgvStore.TabIndex = 0;
            // 
            // columnStore_id
            // 
            columnStore_id.HeaderText = "Store ID";
            columnStore_id.MinimumWidth = 8;
            columnStore_id.Name = "columnStore_id";
            columnStore_id.ReadOnly = true;
            columnStore_id.Width = 150;
            // 
            // columnStore_name
            // 
            columnStore_name.HeaderText = "Name";
            columnStore_name.MinimumWidth = 8;
            columnStore_name.Name = "columnStore_name";
            columnStore_name.ReadOnly = true;
            columnStore_name.Width = 150;
            // 
            // columnStoreAddress
            // 
            columnStoreAddress.HeaderText = "Address";
            columnStoreAddress.MinimumWidth = 8;
            columnStoreAddress.Name = "columnStoreAddress";
            columnStoreAddress.ReadOnly = true;
            columnStoreAddress.Width = 150;
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
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
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
            // btnAddStore
            // 
            btnAddStore.Location = new Point(11, 435);
            btnAddStore.Margin = new Padding(2);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(153, 34);
            btnAddStore.TabIndex = 3;
            btnAddStore.Text = "Add a New Store";
            btnAddStore.UseVisualStyleBackColor = true;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // btnEditStore
            // 
            btnEditStore.Location = new Point(168, 435);
            btnEditStore.Margin = new Padding(2);
            btnEditStore.Name = "btnEditStore";
            btnEditStore.Size = new Size(153, 34);
            btnEditStore.TabIndex = 4;
            btnEditStore.Text = "Edit Selected Store";
            btnEditStore.UseVisualStyleBackColor = true;
            btnEditStore.Click += btbEditStore_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 25);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search by Store";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteStore
            // 
            btnDeleteStore.Location = new Point(325, 435);
            btnDeleteStore.Margin = new Padding(2);
            btnDeleteStore.Name = "btnDeleteStore";
            btnDeleteStore.Size = new Size(153, 34);
            btnDeleteStore.TabIndex = 5;
            btnDeleteStore.Text = "Delete Selected Store";
            btnDeleteStore.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(672, 63);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(42, 15);
            lblDetails.TabIndex = 33;
            lblDetails.Text = "Details";
            // 
            // frmStoreMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 490);
            Controls.Add(txtSearch);
            Controls.Add(spcDetails);
            Controls.Add(btnAddStore);
            Controls.Add(btnEditStore);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteStore);
            Controls.Add(lblDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStoreMaintenance";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Store Mainenance";
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            spcDetails.Panel1.ResumeLayout(false);
            spcDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcDetails).EndInit();
            spcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource validatorBindingSource;
        private TextBox txtSearch;
        private SplitContainer spcDetails;
        private DataGridView dgvStore;
        private BindingSource validatorBindingSource1;
        private RichTextBox rtbDetails;
        private Button btnAddStore;
        private Button btnEditStore;
        private Button btnSearch;
        private Button btnDeleteStore;
        private Label lblDetails;
        private DataGridViewTextBoxColumn columnStore_id;
        private DataGridViewTextBoxColumn columnStore_name;
        private DataGridViewTextBoxColumn columnStoreAddress;
        private DataGridViewTextBoxColumn columnCity;
        private DataGridViewTextBoxColumn columnState;
    }
}