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
            btnSearch = new Button();
            txtSearch = new TextBox();
            validatorBindingSource = new BindingSource(components);
            spcDetails = new SplitContainer();
            dgvEmployee = new DataGridView();
            validatorBindingSource1 = new BindingSource(components);
            rbtDetails = new RichTextBox();
            lblSearch = new Label();
            this.btbDeleteEmployee = new Button();
            this.btnAddEmployee = new Button();
            lblDetails = new Label();
            btbEditEmployee = new Button();
            columnemp_id = new DataGridViewTextBoxColumn();
            columnFname = new DataGridViewTextBoxColumn();
            columnMinit = new DataGridViewTextBoxColumn();
            columnAu_lname = new DataGridViewTextBoxColumn();
            columnJob_id = new DataGridViewTextBoxColumn();
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
            btnSearch.Location = new Point(530, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(189, 33);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search by Employee";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 31);
            txtSearch.TabIndex = 18;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-2, 133);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvEmployee);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rbtDetails);
            spcDetails.Size = new Size(1183, 567);
            spcDetails.SplitterDistance = 817;
            spcDetails.TabIndex = 20;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToOrderColumns = true;
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { columnemp_id, columnFname, columnMinit, columnAu_lname, columnJob_id });
            dgvEmployee.DataSource = validatorBindingSource1;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(0, 0);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(817, 567);
            dgvEmployee.TabIndex = 0;
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search:";
            // 
            // btbDeleteEmployee
            // 
            this.btbDeleteEmployee.Location = new Point(872, 772);
            this.btbDeleteEmployee.Name = "btbDeleteEmployee";
            this.btbDeleteEmployee.Size = new Size(231, 95);
            this.btbDeleteEmployee.TabIndex = 23;
            this.btbDeleteEmployee.Text = "Delete Selected Employee";
            this.btbDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new Point(70, 772);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new Size(231, 95);
            this.btnAddEmployee.TabIndex = 21;
            this.btnAddEmployee.Text = "Add a New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
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
            // btbEditEmployee
            // 
            btbEditEmployee.Location = new Point(488, 772);
            btbEditEmployee.Name = "btbEditEmployee";
            btbEditEmployee.Size = new Size(231, 95);
            btbEditEmployee.TabIndex = 22;
            btbEditEmployee.Text = "Edit Selected Employee";
            btbEditEmployee.UseVisualStyleBackColor = true;
            // 
            // columnemp_id
            // 
            columnemp_id.HeaderText = "emp_id";
            columnemp_id.MinimumWidth = 8;
            columnemp_id.Name = "columnemp_id";
            columnemp_id.ReadOnly = true;
            columnemp_id.Width = 150;
            // 
            // columnFname
            // 
            columnFname.HeaderText = "fname";
            columnFname.MinimumWidth = 8;
            columnFname.Name = "columnFname";
            columnFname.ReadOnly = true;
            columnFname.Width = 150;
            // 
            // columnMinit
            // 
            columnMinit.HeaderText = "minit";
            columnMinit.MinimumWidth = 8;
            columnMinit.Name = "columnMinit";
            columnMinit.ReadOnly = true;
            columnMinit.Width = 150;
            // 
            // columnAu_lname
            // 
            columnAu_lname.HeaderText = "au_lname";
            columnAu_lname.MinimumWidth = 8;
            columnAu_lname.Name = "columnAu_lname";
            columnAu_lname.ReadOnly = true;
            columnAu_lname.Width = 150;
            // 
            // columnJob_id
            // 
            columnJob_id.HeaderText = "job_id";
            columnJob_id.MinimumWidth = 8;
            columnJob_id.Name = "columnJob_id";
            columnJob_id.ReadOnly = true;
            columnJob_id.Width = 150;
            // 
            // frmEmployeeMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 944);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(spcDetails);
            Controls.Add(lblSearch);
            Controls.Add(this.btbDeleteEmployee);
            Controls.Add(this.btnAddEmployee);
            Controls.Add(lblDetails);
            Controls.Add(btbEditEmployee);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployeeMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Maintenance";
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
        private RichTextBox rbtDetails;
        private Label lblSearch;
        private Button btbDeleteAuthor;
        private Button btnAddAuthor;
        private Label lblDetails;
        private Button btbEditEmployee;
        private DataGridViewTextBoxColumn columnemp_id;
        private DataGridViewTextBoxColumn columnFname;
        private DataGridViewTextBoxColumn columnMinit;
        private DataGridViewTextBoxColumn columnAu_lname;
        private DataGridViewTextBoxColumn columnJob_id;
    }
}