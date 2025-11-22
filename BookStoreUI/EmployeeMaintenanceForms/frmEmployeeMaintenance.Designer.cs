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
            columnemp_id = new DataGridViewTextBoxColumn();
            columnFname = new DataGridViewTextBoxColumn();
            columnMinit = new DataGridViewTextBoxColumn();
            columnAu_lname = new DataGridViewTextBoxColumn();
            columnJob_id = new DataGridViewTextBoxColumn();
            validatorBindingSource1 = new BindingSource(components);
            rbtDetails = new RichTextBox();
            btbDeleteEmployee = new Button();
            btnAddEmployee = new Button();
            lblDetails = new Label();
            btbEditEmployee = new Button();
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
            btnSearch.Location = new Point(272, 23);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search by Employee";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 23);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 1;
            // 
            // validatorBindingSource
            // 
            validatorBindingSource.DataSource = typeof(BookStoreBO.Validator);
            // 
            // spcDetails
            // 
            spcDetails.Location = new Point(-1, 80);
            spcDetails.Margin = new Padding(2);
            spcDetails.Name = "spcDetails";
            // 
            // spcDetails.Panel1
            // 
            spcDetails.Panel1.Controls.Add(dgvEmployee);
            // 
            // spcDetails.Panel2
            // 
            spcDetails.Panel2.Controls.Add(rbtDetails);
            spcDetails.Size = new Size(828, 340);
            spcDetails.SplitterDistance = 571;
            spcDetails.SplitterWidth = 3;
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
            dgvEmployee.Margin = new Padding(2);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(571, 340);
            dgvEmployee.TabIndex = 0;
            // 
            // columnemp_id
            // 
            columnemp_id.HeaderText = "Employee ID";
            columnemp_id.MinimumWidth = 8;
            columnemp_id.Name = "columnemp_id";
            columnemp_id.ReadOnly = true;
            columnemp_id.Width = 150;
            // 
            // columnFname
            // 
            columnFname.HeaderText = "First Name";
            columnFname.MinimumWidth = 8;
            columnFname.Name = "columnFname";
            columnFname.ReadOnly = true;
            columnFname.Width = 150;
            // 
            // columnMinit
            // 
            columnMinit.HeaderText = "Middle Initial";
            columnMinit.MinimumWidth = 8;
            columnMinit.Name = "columnMinit";
            columnMinit.ReadOnly = true;
            columnMinit.Width = 150;
            // 
            // columnAu_lname
            // 
            columnAu_lname.HeaderText = "Last Name";
            columnAu_lname.MinimumWidth = 8;
            columnAu_lname.Name = "columnAu_lname";
            columnAu_lname.ReadOnly = true;
            columnAu_lname.Width = 150;
            // 
            // columnJob_id
            // 
            columnJob_id.HeaderText = "Job ID";
            columnJob_id.MinimumWidth = 8;
            columnJob_id.Name = "columnJob_id";
            columnJob_id.ReadOnly = true;
            columnJob_id.Width = 150;
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // rbtDetails
            // 
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Margin = new Padding(2);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(254, 342);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            // 
            // btbDeleteEmployee
            // 
            btbDeleteEmployee.Location = new Point(325, 436);
            btbDeleteEmployee.Margin = new Padding(2);
            btbDeleteEmployee.Name = "btbDeleteEmployee";
            btbDeleteEmployee.Size = new Size(153, 34);
            btbDeleteEmployee.TabIndex = 5;
            btbDeleteEmployee.Text = "Delete Selected Employee";
            btbDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(11, 436);
            btnAddEmployee.Margin = new Padding(2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(153, 34);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Add a New Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(672, 63);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(42, 15);
            lblDetails.TabIndex = 17;
            lblDetails.Text = "Details";
            // 
            // btbEditEmployee
            // 
            btbEditEmployee.Location = new Point(168, 436);
            btbEditEmployee.Margin = new Padding(2);
            btbEditEmployee.Name = "btbEditEmployee";
            btbEditEmployee.Size = new Size(153, 34);
            btbEditEmployee.TabIndex = 4;
            btbEditEmployee.Text = "Edit Selected Employee";
            btbEditEmployee.UseVisualStyleBackColor = true;
            btbEditEmployee.Click += btbEditEmployee_Click;
            // 
            // frmEmployeeMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 490);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(spcDetails);
            Controls.Add(btbDeleteEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lblDetails);
            Controls.Add(btbEditEmployee);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private Button btbDeleteEmployee;
        private Button btnAddEmployee;
        private Label lblDetails;
        private Button btbEditEmployee;
        private DataGridViewTextBoxColumn columnemp_id;
        private DataGridViewTextBoxColumn columnFname;
        private DataGridViewTextBoxColumn columnMinit;
        private DataGridViewTextBoxColumn columnAu_lname;
        private DataGridViewTextBoxColumn columnJob_id;
    }
}