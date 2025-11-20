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
            btbDeleteAuthor = new Button();
            btnAddAuthor = new Button();
            lblDetails = new Label();
            rbtDetails = new RichTextBox();
            validatorBindingSource1 = new BindingSource(components);
            columnAdress = new DataGridViewTextBoxColumn();
            columnphone = new DataGridViewTextBoxColumn();
            btbEditAuthor = new Button();
            columnau_name = new DataGridViewTextBoxColumn();
            columnau_id = new DataGridViewTextBoxColumn();
            dgvAuthor = new DataGridView();
            columnAu_lname = new DataGridViewTextBoxColumn();
            spcDetails = new SplitContainer();
            validatorBindingSource = new BindingSource(components);
            btnSearch = new Button();
            lblSearch = new Label();
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
            // btbDeleteAuthor
            // 
            btbDeleteAuthor.Location = new Point(611, 463);
            btbDeleteAuthor.Margin = new Padding(2);
            btbDeleteAuthor.Name = "btbDeleteAuthor";
            btbDeleteAuthor.Size = new Size(162, 57);
            btbDeleteAuthor.TabIndex = 15;
            btbDeleteAuthor.Text = "Delete Selected Author";
            btbDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(50, 463);
            btnAddAuthor.Margin = new Padding(2);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(162, 57);
            btnAddAuthor.TabIndex = 13;
            btnAddAuthor.Text = "Add a New Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
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
            // rbtDetails
            // 
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Margin = new Padding(2);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(254, 342);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            // 
            // validatorBindingSource1
            // 
            validatorBindingSource1.DataSource = typeof(BookStoreBO.Validator);
            // 
            // columnAdress
            // 
            columnAdress.HeaderText = "address";
            columnAdress.MinimumWidth = 8;
            columnAdress.Name = "columnAdress";
            columnAdress.ReadOnly = true;
            columnAdress.Width = 150;
            // 
            // columnphone
            // 
            columnphone.HeaderText = "phone";
            columnphone.MinimumWidth = 8;
            columnphone.Name = "columnphone";
            columnphone.ReadOnly = true;
            columnphone.Width = 150;
            // 
            // btbEditAuthor
            // 
            btbEditAuthor.Location = new Point(342, 463);
            btbEditAuthor.Margin = new Padding(2);
            btbEditAuthor.Name = "btbEditAuthor";
            btbEditAuthor.Size = new Size(162, 57);
            btbEditAuthor.TabIndex = 14;
            btbEditAuthor.Text = "Edit Selected Author";
            btbEditAuthor.UseVisualStyleBackColor = true;
            // 
            // columnau_name
            // 
            columnau_name.HeaderText = "au_fname";
            columnau_name.MinimumWidth = 8;
            columnau_name.Name = "columnau_name";
            columnau_name.ReadOnly = true;
            columnau_name.Width = 150;
            // 
            // columnau_id
            // 
            columnau_id.HeaderText = "au_id";
            columnau_id.MinimumWidth = 8;
            columnau_id.Name = "columnau_id";
            columnau_id.ReadOnly = true;
            columnau_id.Width = 150;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToAddRows = false;
            dgvAuthor.AllowUserToOrderColumns = true;
            dgvAuthor.AutoGenerateColumns = false;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { columnau_id, columnAu_lname, columnau_name, columnphone, columnAdress });
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
            // 
            // columnAu_lname
            // 
            columnAu_lname.HeaderText = "au_lname";
            columnAu_lname.MinimumWidth = 8;
            columnAu_lname.Name = "columnAu_lname";
            columnAu_lname.ReadOnly = true;
            columnAu_lname.Width = 150;
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
            spcDetails.Panel2.Controls.Add(rbtDetails);
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
            btnSearch.Location = new Point(372, 47);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 20);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search by Author";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 48);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(71, 48);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 10;
            // 
            // frmAuthorMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 566);
            Controls.Add(spcDetails);
            Controls.Add(btbDeleteAuthor);
            Controls.Add(btnAddAuthor);
            Controls.Add(lblDetails);
            Controls.Add(btbEditAuthor);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAuthorMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author Maintenance";
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

        private Button btbDeleteAuthor;
        private Button btnAddAuthor;
        private Label lblDetails;
        private RichTextBox rbtDetails;
        private BindingSource validatorBindingSource1;
        private DataGridViewTextBoxColumn columnAdress;
        private DataGridViewTextBoxColumn columnphone;
        private Button btbEditAuthor;
        private DataGridViewTextBoxColumn columnau_name;
        private DataGridViewTextBoxColumn columnau_id;
        private DataGridView dgvAuthor;
        private DataGridViewTextBoxColumn columnAu_lname;
        private SplitContainer spcDetails;
        private BindingSource validatorBindingSource;
        private Button btnSearch;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}