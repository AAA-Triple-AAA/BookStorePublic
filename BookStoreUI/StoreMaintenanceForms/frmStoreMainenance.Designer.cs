namespace BookStoreUI.StoreMaintenanceForms
{
    partial class frmStoreMainenance
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
            validatorBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            lblSearch = new Label();
            spcDetails = new SplitContainer();
            dgvStore = new DataGridView();
            validatorBindingSource1 = new BindingSource(components);
            rbtDetails = new RichTextBox();
            btnAddStore = new Button();
            btbEditStore = new Button();
            btnSearch = new Button();
            btbDeleteStore = new Button();
            lblDetails = new Label();
            columnStore_id = new DataGridViewTextBoxColumn();
            columnStore_name = new DataGridViewTextBoxColumn();
            columnStoreAddress = new DataGridViewTextBoxColumn();
            columnCity = new DataGridViewTextBoxColumn();
            columnState = new DataGridViewTextBoxColumn();
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
            txtSearch.Location = new Point(100, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 31);
            txtSearch.TabIndex = 34;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 32;
            lblSearch.Text = "Search:";
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-2, 133);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvStore);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rbtDetails);
            spcDetails.Size = new Size(1183, 567);
            spcDetails.SplitterDistance = 817;
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
            dgvStore.MultiSelect = false;
            dgvStore.Name = "dgvStore";
            dgvStore.ReadOnly = true;
            dgvStore.RowHeadersWidth = 62;
            dgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStore.Size = new Size(817, 567);
            dgvStore.TabIndex = 0;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // rbtDetails
            // 
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(361, 567);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            // 
            // btnAddStore
            // 
            btnAddStore.Location = new Point(70, 772);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(231, 95);
            btnAddStore.TabIndex = 37;
            btnAddStore.Text = "Add a New Store";
            btnAddStore.UseVisualStyleBackColor = true;
            // 
            // btbEditStore
            // 
            btbEditStore.Location = new Point(488, 772);
            btbEditStore.Name = "btbEditStore";
            btbEditStore.Size = new Size(231, 95);
            btbEditStore.TabIndex = 38;
            btbEditStore.Text = "Edit Selected Store";
            btbEditStore.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(530, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 33);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search by Store";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btbDeleteStore
            // 
            btbDeleteStore.Location = new Point(872, 772);
            btbDeleteStore.Name = "btbDeleteStore";
            btbDeleteStore.Size = new Size(231, 95);
            btbDeleteStore.TabIndex = 39;
            btbDeleteStore.Text = "Delete Selected Store";
            btbDeleteStore.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(960, 105);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(65, 25);
            lblDetails.TabIndex = 33;
            lblDetails.Text = "Details";
            // 
            // columnStore_id
            // 
            columnStore_id.HeaderText = "stor_id";
            columnStore_id.MinimumWidth = 8;
            columnStore_id.Name = "columnStore_id";
            columnStore_id.ReadOnly = true;
            columnStore_id.Width = 150;
            // 
            // columnStore_name
            // 
            columnStore_name.HeaderText = "store_name";
            columnStore_name.MinimumWidth = 8;
            columnStore_name.Name = "columnStore_name";
            columnStore_name.ReadOnly = true;
            columnStore_name.Width = 150;
            // 
            // columnStoreAddress
            // 
            columnStoreAddress.HeaderText = "store_address";
            columnStoreAddress.MinimumWidth = 8;
            columnStoreAddress.Name = "columnStoreAddress";
            columnStoreAddress.ReadOnly = true;
            columnStoreAddress.Width = 150;
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
            // frmStoreMainenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 944);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(spcDetails);
            Controls.Add(btnAddStore);
            Controls.Add(btbEditStore);
            Controls.Add(btnSearch);
            Controls.Add(btbDeleteStore);
            Controls.Add(lblDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStoreMainenance";
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
        private Label lblSearch;
        private SplitContainer spcDetails;
        private DataGridView dgvStore;
        private DataGridViewTextBoxColumn columnStore_id;
        private DataGridViewTextBoxColumn columnStore_name;
        private DataGridViewTextBoxColumn columnStoreAddress;
        private DataGridViewTextBoxColumn columnCity;
        private DataGridViewTextBoxColumn columnState;
        private BindingSource validatorBindingSource1;
        private RichTextBox rbtDetails;
        private Button btnAddStore;
        private Button btbEditStore;
        private Button btnSearch;
        private Button btbDeleteStore;
        private Label lblDetails;
    }
}