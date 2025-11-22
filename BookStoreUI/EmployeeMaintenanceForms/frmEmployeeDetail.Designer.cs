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
            btnCancel.Location = new Point(219, 393);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 28);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEmpId
            // 
            lblEmpId.Anchor = AnchorStyles.Right;
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(15, 16);
            lblEmpId.Margin = new Padding(2, 0, 2, 0);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(48, 15);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Emp. ID";
            // 
            // lblMidInitial
            // 
            lblMidInitial.Anchor = AnchorStyles.Right;
            lblMidInitial.AutoSize = true;
            lblMidInitial.Location = new Point(16, 105);
            lblMidInitial.Margin = new Padding(2, 0, 2, 0);
            lblMidInitial.Name = "lblMidInitial";
            lblMidInitial.Size = new Size(47, 30);
            lblMidInitial.TabIndex = 4;
            lblMidInitial.Text = "Middle Initial";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 153);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(39, 30);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 57);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(39, 30);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblJobId
            // 
            lblJobId.Anchor = AnchorStyles.Right;
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(24, 208);
            lblJobId.Margin = new Padding(2, 0, 2, 0);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(39, 15);
            lblJobId.TabIndex = 8;
            lblJobId.Text = "Job ID";
            // 
            // lblJobLevel
            // 
            lblJobLevel.Anchor = AnchorStyles.Right;
            lblJobLevel.AutoSize = true;
            lblJobLevel.Location = new Point(8, 256);
            lblJobLevel.Margin = new Padding(2, 0, 2, 0);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new Size(55, 15);
            lblJobLevel.TabIndex = 10;
            lblJobLevel.Text = "Job Level";
            // 
            // lblPubId
            // 
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(18, 304);
            lblPubId.Margin = new Padding(2, 0, 2, 0);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(45, 15);
            lblPubId.TabIndex = 12;
            lblPubId.Text = "Pub. ID";
            // 
            // lblHireDate
            // 
            lblHireDate.Anchor = AnchorStyles.Right;
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(7, 353);
            lblHireDate.Margin = new Padding(2, 0, 2, 0);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(56, 15);
            lblHireDate.TabIndex = 14;
            lblHireDate.Text = "Hire Date";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(67, 60);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtMidInitial
            // 
            txtMidInitial.Anchor = AnchorStyles.Left;
            txtMidInitial.CharacterCasing = CharacterCasing.Upper;
            txtMidInitial.Location = new Point(67, 108);
            txtMidInitial.Margin = new Padding(2);
            txtMidInitial.MaxLength = 1;
            txtMidInitial.Name = "txtMidInitial";
            txtMidInitial.Size = new Size(36, 23);
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
            tlpEmployee.Margin = new Padding(2);
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
            tlpEmployee.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpEmployee.Size = new Size(328, 385);
            tlpEmployee.TabIndex = 19;
            // 
            // nudJobLevel
            // 
            nudJobLevel.Anchor = AnchorStyles.Left;
            nudJobLevel.Location = new Point(67, 252);
            nudJobLevel.Margin = new Padding(2);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(56, 23);
            nudJobLevel.TabIndex = 11;
            nudJobLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.CharacterCasing = CharacterCasing.Upper;
            txtLastName.Location = new Point(67, 156);
            txtLastName.Margin = new Padding(2);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtEmpId
            // 
            txtEmpId.Anchor = AnchorStyles.Left;
            txtEmpId.CharacterCasing = CharacterCasing.Upper;
            txtEmpId.Location = new Point(67, 12);
            txtEmpId.Margin = new Padding(2);
            txtEmpId.MaxLength = 9;
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(106, 23);
            txtEmpId.TabIndex = 1;
            // 
            // nudJobId
            // 
            nudJobId.Anchor = AnchorStyles.Left;
            nudJobId.Location = new Point(67, 204);
            nudJobId.Margin = new Padding(2);
            nudJobId.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJobId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJobId.Name = "nudJobId";
            nudJobId.Size = new Size(88, 23);
            nudJobId.TabIndex = 9;
            nudJobId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // mtbPubId
            // 
            mtbPubId.Anchor = AnchorStyles.Left;
            mtbPubId.HidePromptOnLeave = true;
            mtbPubId.Location = new Point(67, 300);
            mtbPubId.Margin = new Padding(2);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.Size = new Size(57, 23);
            mtbPubId.TabIndex = 13;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Anchor = AnchorStyles.Left;
            dtpHireDate.CustomFormat = "yyyy/MM/dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(67, 349);
            dtpHireDate.Margin = new Padding(2);
            dtpHireDate.MaxDate = new DateTime(2025, 11, 20, 14, 20, 7, 0);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(115, 23);
            dtpHireDate.TabIndex = 15;
            dtpHireDate.Value = new DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(11, 393);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(328, 432);
            Controls.Add(btnCancel);
            Controls.Add(tlpEmployee);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
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
        private Label lblContract;
        private TextBox txtFirstName;
        private TextBox txtMidInitial;
        private TableLayoutPanel tlpEmployee;
        private CheckBox chkContract;
        private Button btnSave;
        private TextBox txtEmpId;
        private TextBox txtLastName;
        private NumericUpDown nudJobLevel;
        private NumericUpDown nudJobId;
        private MaskedTextBox mtbPubId;
        private DateTimePicker dtpHireDate;
    }
}