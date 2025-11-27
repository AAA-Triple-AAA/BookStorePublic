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
            lblEmpId = new Label();
            lblMidInitial = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblJobId = new Label();
            lblJobLevel = new Label();
            lblPubId = new Label();
            lblHireDate = new Label();
            txtFirstName = new TextBox();
            txtMidInitial = new TextBox();
            tlpEmployee = new TableLayoutPanel();
            nudJobLevel = new NumericUpDown();
            txtLastName = new TextBox();
            txtEmpId = new TextBox();
            nudJobId = new NumericUpDown();
            mtbPubId = new MaskedTextBox();
            dtpHireDate = new DateTimePicker();
            btnSave = new Button();
            tlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJobId).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEmpId
            // 
            lblEmpId.Anchor = AnchorStyles.Right;
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(15, 27);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(75, 25);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Emp. ID";
            // 
            // lblMidInitial
            // 
            lblMidInitial.Anchor = AnchorStyles.Right;
            lblMidInitial.AutoSize = true;
            lblMidInitial.Location = new Point(18, 175);
            lblMidInitial.Name = "lblMidInitial";
            lblMidInitial.Size = new Size(72, 50);
            lblMidInitial.TabIndex = 4;
            lblMidInitial.Text = "Middle Initial";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(31, 255);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 50);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(31, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(59, 50);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblJobId
            // 
            lblJobId.Anchor = AnchorStyles.Right;
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(27, 347);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(63, 25);
            lblJobId.TabIndex = 8;
            lblJobId.Text = "Job ID";
            // 
            // lblJobLevel
            // 
            lblJobLevel.Anchor = AnchorStyles.Right;
            lblJobLevel.AutoSize = true;
            lblJobLevel.Location = new Point(6, 427);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new Size(84, 25);
            lblJobLevel.TabIndex = 10;
            lblJobLevel.Text = "Job Level";
            // 
            // lblPubId
            // 
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(20, 507);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(70, 25);
            lblPubId.TabIndex = 12;
            lblPubId.Text = "Pub. ID";
            // 
            // lblHireDate
            // 
            lblHireDate.Anchor = AnchorStyles.Right;
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(4, 588);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(86, 25);
            lblHireDate.TabIndex = 14;
            lblHireDate.Text = "Hire Date";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(96, 104);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(370, 31);
            txtFirstName.TabIndex = 3;
            // 
            // txtMidInitial
            // 
            txtMidInitial.Anchor = AnchorStyles.Left;
            txtMidInitial.CharacterCasing = CharacterCasing.Upper;
            txtMidInitial.Location = new Point(96, 184);
            txtMidInitial.MaxLength = 1;
            txtMidInitial.Name = "txtMidInitial";
            txtMidInitial.Size = new Size(50, 31);
            txtMidInitial.TabIndex = 5;
            // 
            // tlpEmployee
            // 
            tlpEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpEmployee.ColumnCount = 2;
            tlpEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpEmployee.Controls.Add(nudJobLevel, 1, 5);
            tlpEmployee.Controls.Add(txtLastName, 1, 3);
            tlpEmployee.Controls.Add(lblEmpId, 0, 0);
            tlpEmployee.Controls.Add(lblMidInitial, 0, 2);
            tlpEmployee.Controls.Add(lblLastName, 0, 3);
            tlpEmployee.Controls.Add(lblFirstName, 0, 1);
            tlpEmployee.Controls.Add(lblJobId, 0, 4);
            tlpEmployee.Controls.Add(lblJobLevel, 0, 5);
            tlpEmployee.Controls.Add(lblPubId, 0, 6);
            tlpEmployee.Controls.Add(lblHireDate, 0, 7);
            tlpEmployee.Controls.Add(txtFirstName, 1, 1);
            tlpEmployee.Controls.Add(txtMidInitial, 1, 2);
            tlpEmployee.Controls.Add(txtEmpId, 1, 0);
            tlpEmployee.Controls.Add(nudJobId, 1, 4);
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
            tlpEmployee.Size = new Size(469, 642);
            tlpEmployee.TabIndex = 19;
            // 
            // nudJobLevel
            // 
            nudJobLevel.Anchor = AnchorStyles.Left;
            nudJobLevel.Location = new Point(96, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
            nudJobLevel.TabIndex = 11;
            nudJobLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.CharacterCasing = CharacterCasing.Upper;
            txtLastName.Location = new Point(96, 264);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtEmpId
            // 
            txtEmpId.Anchor = AnchorStyles.Left;
            txtEmpId.CharacterCasing = CharacterCasing.Upper;
            txtEmpId.Location = new Point(96, 24);
            txtEmpId.MaxLength = 9;
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(150, 31);
            txtEmpId.TabIndex = 1;
            // 
            // nudJobId
            // 
            nudJobId.Anchor = AnchorStyles.Left;
            nudJobId.Location = new Point(96, 344);
            nudJobId.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJobId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJobId.Name = "nudJobId";
            nudJobId.Size = new Size(126, 31);
            nudJobId.TabIndex = 9;
            nudJobId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudJobId.ValueChanged += nudJobId_ValueChanged;
            // 
            // mtbPubId
            // 
            mtbPubId.Anchor = AnchorStyles.Left;
            mtbPubId.HidePromptOnLeave = true;
            mtbPubId.Location = new Point(96, 504);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(80, 31);
            mtbPubId.TabIndex = 13;
            mtbPubId.Text = "9952";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Anchor = AnchorStyles.Left;
            dtpHireDate.CustomFormat = "yyyy/MM/dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(96, 585);
            dtpHireDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpHireDate.Name = "dtpHireDate";
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
            Load += frmEmployeeDetail_Load;
            tlpEmployee.ResumeLayout(false);
            tlpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJobId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Label lblEmpId;
        private Label lblMidInitial;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblJobId;
        private Label lblJobLevel;
        private Label lblPubId;
        private Label lblHireDate;
        private TextBox txtFirstName;
        private TextBox txtMidInitial;
        private TableLayoutPanel tlpEmployee;
        private Button btnSave;
        private TextBox txtEmpId;
        private TextBox txtLastName;
        private NumericUpDown nudJobLevel;
        private NumericUpDown nudJobId;
        private MaskedTextBox mtbPubId;
        private DateTimePicker dtpHireDate;
    }
}
