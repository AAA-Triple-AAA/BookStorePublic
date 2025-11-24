namespace BookStoreUI.EmployeeMaintenanceForms
{
    partial class frmEmployeeDetail
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
            btnCancel = new Button();
            lblEmp_id = new Label();
            lblMinit = new Label();
            lblLname = new Label();
            lblFname = new Label();
            lblJob_id = new Label();
            lblJob_lvl = new Label();
            lblPub_id = new Label();
            lblHire_date = new Label();
            txtFname = new TextBox();
            txtminit = new TextBox();
            tlpEmployee = new TableLayoutPanel();
            nudJobLevel = new NumericUpDown();
            txtLname = new TextBox();
            txtEmp_id = new TextBox();
            nudJob_id = new NumericUpDown();
            mtbPubId = new MaskedTextBox();
            btnSave = new Button();
            dtpHireDate = new DateTimePicker();
            tlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJob_id).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            btnCancel.Location = new Point(494, 788);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 99);
=======
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
>>>>>>> Stashed changes
=======
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
>>>>>>> Stashed changes
=======
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
>>>>>>> Stashed changes
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEmp_id
            // 
<<<<<<< Updated upstream
            lblEmp_id.AutoSize = true;
            lblEmp_id.Location = new Point(3, 0);
            lblEmp_id.Name = "lblEmp_id";
            lblEmp_id.Size = new Size(70, 25);
            lblEmp_id.TabIndex = 0;
            lblEmp_id.Text = "emp_id";
=======
            lblEmpId.Anchor = AnchorStyles.Right;
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(15, 27);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(75, 25);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Emp. ID";
>>>>>>> Stashed changes
            // 
            // lblMinit
            // 
<<<<<<< Updated upstream
            lblMinit.AutoSize = true;
            lblMinit.Location = new Point(3, 160);
            lblMinit.Name = "lblMinit";
            lblMinit.Size = new Size(52, 25);
            lblMinit.TabIndex = 2;
            lblMinit.Text = "minit";
=======
            lblMidInitial.Anchor = AnchorStyles.Right;
            lblMidInitial.AutoSize = true;
            lblMidInitial.Location = new Point(18, 175);
            lblMidInitial.Name = "lblMidInitial";
            lblMidInitial.Size = new Size(72, 50);
            lblMidInitial.TabIndex = 4;
            lblMidInitial.Text = "Middle Initial";
>>>>>>> Stashed changes
            // 
            // lblLname
            // 
<<<<<<< Updated upstream
            lblLname.AutoSize = true;
            lblLname.Location = new Point(3, 240);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(60, 25);
            lblLname.TabIndex = 3;
            lblLname.Text = "lname";
=======
            lblLastName.Anchor = AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(31, 255);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 50);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
>>>>>>> Stashed changes
            // 
            // lblFname
            // 
<<<<<<< Updated upstream
            lblFname.AutoSize = true;
            lblFname.Location = new Point(3, 80);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(62, 25);
            lblFname.TabIndex = 1;
            lblFname.Text = "fname";
=======
            lblFirstName.Anchor = AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(31, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(59, 50);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
>>>>>>> Stashed changes
            // 
            // lblJob_id
            // 
<<<<<<< Updated upstream
            lblJob_id.AutoSize = true;
            lblJob_id.Location = new Point(3, 320);
            lblJob_id.Name = "lblJob_id";
            lblJob_id.Size = new Size(60, 25);
            lblJob_id.TabIndex = 4;
            lblJob_id.Text = "job_id";
=======
            lblJobId.Anchor = AnchorStyles.Right;
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(27, 347);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(63, 25);
            lblJobId.TabIndex = 8;
            lblJobId.Text = "Job ID";
>>>>>>> Stashed changes
            // 
            // lblJob_lvl
            // 
<<<<<<< Updated upstream
            lblJob_lvl.AutoSize = true;
            lblJob_lvl.Location = new Point(3, 400);
            lblJob_lvl.Name = "lblJob_lvl";
            lblJob_lvl.Size = new Size(62, 25);
            lblJob_lvl.TabIndex = 5;
            lblJob_lvl.Text = "job_lvl";
=======
            lblJobLevel.Anchor = AnchorStyles.Right;
            lblJobLevel.AutoSize = true;
            lblJobLevel.Location = new Point(6, 427);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new Size(84, 25);
            lblJobLevel.TabIndex = 10;
            lblJobLevel.Text = "Job Level";
>>>>>>> Stashed changes
            // 
            // lblPub_id
            // 
<<<<<<< Updated upstream
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(3, 480);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(66, 25);
            lblPub_id.TabIndex = 6;
            lblPub_id.Text = "pub_id";
=======
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(20, 507);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(70, 25);
            lblPubId.TabIndex = 12;
            lblPubId.Text = "Pub. ID";
>>>>>>> Stashed changes
            // 
            // lblHire_date
            // 
<<<<<<< Updated upstream
            lblHire_date.AutoSize = true;
            lblHire_date.Location = new Point(3, 560);
            lblHire_date.Name = "lblHire_date";
            lblHire_date.Size = new Size(83, 25);
            lblHire_date.TabIndex = 7;
            lblHire_date.Text = "hire_date";
=======
            lblHireDate.Anchor = AnchorStyles.Right;
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(4, 588);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(86, 25);
            lblHireDate.TabIndex = 14;
            lblHireDate.Text = "Hire Date";
>>>>>>> Stashed changes
            // 
            // txtFname
            // 
<<<<<<< Updated upstream
            txtFname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(163, 104);
            txtFname.MaxLength = 20;
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(634, 31);
            txtFname.TabIndex = 10;
=======
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(96, 104);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(370, 31);
            txtFirstName.TabIndex = 3;
>>>>>>> Stashed changes
            // 
            // txtminit
            // 
<<<<<<< Updated upstream
            txtminit.Anchor = AnchorStyles.Left;
            txtminit.CharacterCasing = CharacterCasing.Upper;
            txtminit.Location = new Point(163, 184);
            txtminit.MaxLength = 1;
            txtminit.Name = "txtminit";
            txtminit.Size = new Size(50, 31);
            txtminit.TabIndex = 11;
=======
            txtMidInitial.Anchor = AnchorStyles.Left;
            txtMidInitial.CharacterCasing = CharacterCasing.Upper;
            txtMidInitial.Location = new Point(96, 184);
            txtMidInitial.MaxLength = 1;
            txtMidInitial.Name = "txtMidInitial";
            txtMidInitial.Size = new Size(50, 31);
            txtMidInitial.TabIndex = 5;
>>>>>>> Stashed changes
            // 
            // tlpEmployee
            // 
            tlpEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpEmployee.ColumnCount = 2;
            tlpEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpEmployee.Controls.Add(nudJobLevel, 1, 5);
            tlpEmployee.Controls.Add(txtLname, 1, 3);
            tlpEmployee.Controls.Add(lblEmp_id, 0, 0);
            tlpEmployee.Controls.Add(lblMinit, 0, 2);
            tlpEmployee.Controls.Add(lblLname, 0, 3);
            tlpEmployee.Controls.Add(lblFname, 0, 1);
            tlpEmployee.Controls.Add(lblJob_id, 0, 4);
            tlpEmployee.Controls.Add(lblJob_lvl, 0, 5);
            tlpEmployee.Controls.Add(lblPub_id, 0, 6);
            tlpEmployee.Controls.Add(lblHire_date, 0, 7);
            tlpEmployee.Controls.Add(txtFname, 1, 1);
            tlpEmployee.Controls.Add(txtminit, 1, 2);
            tlpEmployee.Controls.Add(txtEmp_id, 1, 0);
            tlpEmployee.Controls.Add(nudJob_id, 1, 4);
            tlpEmployee.Controls.Add(mtbPubId, 1, 6);
            tlpEmployee.Controls.Add(dtpHireDate, 1, 7);
            tlpEmployee.Dock = DockStyle.Top;
            tlpEmployee.Location = new Point(0, 0);
            tlpEmployee.Name = "tlpEmployee";
            tlpEmployee.RowCount = 8;
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            tlpEmployee.Size = new Size(800, 641);
=======
            tlpEmployee.Size = new Size(469, 642);
>>>>>>> Stashed changes
=======
            tlpEmployee.Size = new Size(469, 642);
>>>>>>> Stashed changes
=======
            tlpEmployee.Size = new Size(469, 642);
>>>>>>> Stashed changes
            tlpEmployee.TabIndex = 19;
            // 
            // nudJobLevel
            // 
            nudJobLevel.Anchor = AnchorStyles.Left;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            nudJobLevel.Location = new Point(163, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
            nudJobLevel.TabIndex = 21;
=======
            nudJobLevel.Location = new Point(96, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
=======
            nudJobLevel.Location = new Point(96, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
>>>>>>> Stashed changes
=======
            nudJobLevel.Location = new Point(96, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
>>>>>>> Stashed changes
            nudJobLevel.TabIndex = 11;
>>>>>>> Stashed changes
            nudJobLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtLname
            // 
<<<<<<< Updated upstream
            txtLname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLname.CharacterCasing = CharacterCasing.Upper;
            txtLname.Location = new Point(163, 264);
            txtLname.MaxLength = 30;
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(634, 31);
            txtLname.TabIndex = 19;
=======
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.CharacterCasing = CharacterCasing.Upper;
            txtLastName.Location = new Point(96, 264);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 31);
            txtLastName.TabIndex = 7;
>>>>>>> Stashed changes
            // 
            // txtEmp_id
            // 
<<<<<<< Updated upstream
            txtEmp_id.Anchor = AnchorStyles.Left;
            txtEmp_id.CharacterCasing = CharacterCasing.Upper;
            txtEmp_id.Location = new Point(163, 24);
            txtEmp_id.MaxLength = 9;
            txtEmp_id.Name = "txtEmp_id";
            txtEmp_id.Size = new Size(150, 31);
            txtEmp_id.TabIndex = 18;
=======
            txtEmpId.Anchor = AnchorStyles.Left;
            txtEmpId.CharacterCasing = CharacterCasing.Upper;
            txtEmpId.Location = new Point(96, 24);
            txtEmpId.MaxLength = 9;
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(150, 31);
            txtEmpId.TabIndex = 1;
>>>>>>> Stashed changes
            // 
            // nudJob_id
            // 
<<<<<<< Updated upstream
            nudJob_id.Anchor = AnchorStyles.Left;
            nudJob_id.Location = new Point(163, 344);
            nudJob_id.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJob_id.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJob_id.Name = "nudJob_id";
            nudJob_id.Size = new Size(125, 31);
            nudJob_id.TabIndex = 20;
            nudJob_id.Value = new decimal(new int[] { 1, 0, 0, 0 });
=======
            nudJobId.Anchor = AnchorStyles.Left;
            nudJobId.Location = new Point(96, 344);
            nudJobId.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJobId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJobId.Name = "nudJobId";
            nudJobId.Size = new Size(126, 31);
            nudJobId.TabIndex = 9;
            nudJobId.Value = new decimal(new int[] { 1, 0, 0, 0 });
>>>>>>> Stashed changes
            // 
            // mtbPubId
            // 
            mtbPubId.Anchor = AnchorStyles.Left;
            mtbPubId.HidePromptOnLeave = true;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            mtbPubId.Location = new Point(163, 504);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(80, 31);
            mtbPubId.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(80, 788);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 99);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
=======
            mtbPubId.Location = new Point(96, 504);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(80, 31);
            mtbPubId.TabIndex = 13;
            mtbPubId.Text = "9952";
>>>>>>> Stashed changes
=======
            mtbPubId.Location = new Point(96, 504);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(80, 31);
            mtbPubId.TabIndex = 13;
            mtbPubId.Text = "9952";
>>>>>>> Stashed changes
=======
            mtbPubId.Location = new Point(96, 504);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(80, 31);
            mtbPubId.TabIndex = 13;
            mtbPubId.Text = "9952";
>>>>>>> Stashed changes
            // 
            // dtpHireDate
            // 
            dtpHireDate.Anchor = AnchorStyles.Left;
            dtpHireDate.CustomFormat = "yyyy/MM/dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            dtpHireDate.Location = new Point(163, 577);
            dtpHireDate.MaxDate = new DateTime(2025, 11, 20, 14, 20, 7, 0);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(162, 31);
            dtpHireDate.TabIndex = 23;
            dtpHireDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // frmEmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 944);
=======
            dtpHireDate.Location = new Point(96, 585);
            dtpHireDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpHireDate.Name = "dtpHireDate";
=======
            dtpHireDate.Location = new Point(96, 585);
            dtpHireDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpHireDate.Name = "dtpHireDate";
>>>>>>> Stashed changes
=======
            dtpHireDate.Location = new Point(96, 585);
            dtpHireDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpHireDate.Name = "dtpHireDate";
>>>>>>> Stashed changes
            dtpHireDate.Size = new Size(163, 31);
            dtpHireDate.TabIndex = 15;
            dtpHireDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(16, 655);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 47);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEmployeeDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(469, 720);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            Controls.Add(btnCancel);
            Controls.Add(tlpEmployee);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployeeDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Employee";
            tlpEmployee.ResumeLayout(false);
            tlpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJob_id).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Label lblEmp_id;
        private Label lblMinit;
        private Label lblLname;
        private Label lblFname;
        private Label lblJob_id;
        private Label lblJob_lvl;
        private Label lblPub_id;
        private Label lblHire_date;
        private Label lblContract;
        private TextBox txtFname;
        private TextBox txtminit;
        private TableLayoutPanel tlpEmployee;
        private CheckBox chkContract;
        private Button btnSave;
        private TextBox txtEmp_id;
        private TextBox txtLname;
        private NumericUpDown nudJobLevel;
        private NumericUpDown nudJob_id;
        private MaskedTextBox mtbPubId;
        private DateTimePicker dtpHireDate;
    }
}