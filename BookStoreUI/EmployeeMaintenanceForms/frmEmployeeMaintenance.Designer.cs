namespace BookStoreUI.EmployeeMaintenanceForms
{
    partial class frmEmployeeMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeMaintenance));
            btnSearch = new Button();
            txtSearch = new TextBox();
            validatorBindingSource = new BindingSource(components);
            spcDetails = new SplitContainer();
            dgvEmployee = new DataGridView();
            columnEmpId = new DataGridViewTextBoxColumn();
            columnFname = new DataGridViewTextBoxColumn();
            columnMinit = new DataGridViewTextBoxColumn();
            columnLname = new DataGridViewTextBoxColumn();
            columnJobId = new DataGridViewTextBoxColumn();
            validatorBindingSource1 = new BindingSource(components);
            rtbDetails = new RichTextBox();
            btnDeleteEmployee = new Button();
            btnAddEmployee = new Button();
            lblDetails = new Label();
            btnEditEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcDetails).BeginInit();
            spcDetails.Panel1.SuspendLayout();
            spcDetails.Panel2.SuspendLayout();
            spcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(389, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search by Employee";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(365, 31);
            txtSearch.TabIndex = 1;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 133);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvEmployee);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rtbDetails);
            spcDetails.Size = new Size(1183, 567);
            spcDetails.SplitterDistance = 815;
            spcDetails.TabIndex = 20;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToOrderColumns = true;
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { columnEmpId, columnFname, columnMinit, columnLname, columnJobId });
            dgvEmployee.DataSource = validatorBindingSource1;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(0, 0);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(815, 567);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.SelectionChanged += dgvEmployee_SelectionChanged;
            // 
            // columnEmpId
            // 
            columnEmpId.DataPropertyName = "EmpId";
            columnEmpId.HeaderText = "Employee ID";
            columnEmpId.MinimumWidth = 8;
            columnEmpId.Name = "columnEmpId";
            columnEmpId.ReadOnly = true;
            columnEmpId.Width = 150;
            // 
            // columnFname
            // 
            columnFname.DataPropertyName = "Fname";
            columnFname.HeaderText = "First Name";
            columnFname.MinimumWidth = 8;
            columnFname.Name = "columnFname";
            columnFname.ReadOnly = true;
            columnFname.Width = 150;
            // 
            // columnMinit
            // 
            columnMinit.DataPropertyName = "Minit";
            columnMinit.HeaderText = "Middle Initial";
            columnMinit.MinimumWidth = 8;
            columnMinit.Name = "columnMinit";
            columnMinit.ReadOnly = true;
            columnMinit.Width = 150;
            // 
            // columnLname
            // 
            columnLname.DataPropertyName = "Lname";
            columnLname.HeaderText = "Last Name";
            columnLname.MinimumWidth = 8;
            columnLname.Name = "columnLname";
            columnLname.ReadOnly = true;
            columnLname.Width = 150;
            // 
            // columnJobId
            // 
            columnJobId.DataPropertyName = "JobId";
            columnJobId.HeaderText = "Job ID";
            columnJobId.MinimumWidth = 8;
            columnJobId.Name = "columnJobId";
            columnJobId.ReadOnly = true;
            columnJobId.Width = 150;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // rtbDetails
            // 
            rtbDetails.Location = new Point(0, 0);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.Size = new Size(361, 567);
            rtbDetails.TabIndex = 0;
            rtbDetails.Text = "";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(464, 727);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(229, 57);
            btnDeleteEmployee.TabIndex = 5;
            btnDeleteEmployee.Text = "Delete Selected Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(16, 727);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(219, 57);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Add a New Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(960, 105);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(65, 25);
            lblDetails.TabIndex = 17;
            lblDetails.Text = "Details";
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(240, 727);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(219, 57);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "Edit Selected Employee";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btbEditEmployee_Click;
            // 
            // frmEmployeeMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 817);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(spcDetails);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lblDetails);
            Controls.Add(btnEditEmployee);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployeeMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Maintenance";
            Load += frmEmployeeMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource).EndInit();
            spcDetails.Panel1.ResumeLayout(false);
            spcDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcDetails).EndInit();
            spcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)validatorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private BindingSource validatorBindingSource;
        private SplitContainer spcDetails;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn columnau_id;
        private DataGridViewTextBoxColumn columnau_name;
        private DataGridViewTextBoxColumn columnphone;
        private DataGridViewTextBoxColumn columnAdress;
        private BindingSource validatorBindingSource1;
        private RichTextBox rtbDetails;
        private Button btnDeleteEmployee;
        private Button btnAddEmployee;
        private Label lblDetails;
        private Button btnEditEmployee;
        private DataGridViewTextBoxColumn columnEmpId;
        private DataGridViewTextBoxColumn columnFname;
        private DataGridViewTextBoxColumn columnMinit;
        private DataGridViewTextBoxColumn columnLname;
        private DataGridViewTextBoxColumn columnJobId;
    }
}