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
            dtpHireDate = new DateTimePicker();
            btnSave = new Button();
            tlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJob_id).BeginInit();
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
            // lblEmp_id
            // 
            lblEmp_id.Anchor = AnchorStyles.Right;
            lblEmp_id.AutoSize = true;
            lblEmp_id.Location = new Point(15, 16);
            lblEmp_id.Margin = new Padding(2, 0, 2, 0);
            lblEmp_id.Name = "lblEmp_id";
            lblEmp_id.Size = new Size(48, 15);
            lblEmp_id.TabIndex = 0;
            lblEmp_id.Text = "Emp. ID";
            // 
            // lblMinit
            // 
            lblMinit.Anchor = AnchorStyles.Right;
            lblMinit.AutoSize = true;
            lblMinit.Location = new Point(16, 105);
            lblMinit.Margin = new Padding(2, 0, 2, 0);
            lblMinit.Name = "lblMinit";
            lblMinit.Size = new Size(47, 30);
            lblMinit.TabIndex = 4;
            lblMinit.Text = "Middle Initial";
            // 
            // lblLname
            // 
            lblLname.Anchor = AnchorStyles.Right;
            lblLname.AutoSize = true;
            lblLname.Location = new Point(24, 153);
            lblLname.Margin = new Padding(2, 0, 2, 0);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(39, 30);
            lblLname.TabIndex = 6;
            lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            lblFname.Anchor = AnchorStyles.Right;
            lblFname.AutoSize = true;
            lblFname.Location = new Point(24, 57);
            lblFname.Margin = new Padding(2, 0, 2, 0);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(39, 30);
            lblFname.TabIndex = 2;
            lblFname.Text = "First Name";
            // 
            // lblJob_id
            // 
            lblJob_id.Anchor = AnchorStyles.Right;
            lblJob_id.AutoSize = true;
            lblJob_id.Location = new Point(24, 208);
            lblJob_id.Margin = new Padding(2, 0, 2, 0);
            lblJob_id.Name = "lblJob_id";
            lblJob_id.Size = new Size(39, 15);
            lblJob_id.TabIndex = 8;
            lblJob_id.Text = "Job ID";
            // 
            // lblJob_lvl
            // 
            lblJob_lvl.Anchor = AnchorStyles.Right;
            lblJob_lvl.AutoSize = true;
            lblJob_lvl.Location = new Point(8, 256);
            lblJob_lvl.Margin = new Padding(2, 0, 2, 0);
            lblJob_lvl.Name = "lblJob_lvl";
            lblJob_lvl.Size = new Size(55, 15);
            lblJob_lvl.TabIndex = 10;
            lblJob_lvl.Text = "Job Level";
            // 
            // lblPub_id
            // 
            lblPub_id.Anchor = AnchorStyles.Right;
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(18, 304);
            lblPub_id.Margin = new Padding(2, 0, 2, 0);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(45, 15);
            lblPub_id.TabIndex = 12;
            lblPub_id.Text = "Pub. ID";
            // 
            // lblHire_date
            // 
            lblHire_date.Anchor = AnchorStyles.Right;
            lblHire_date.AutoSize = true;
            lblHire_date.Location = new Point(7, 353);
            lblHire_date.Margin = new Padding(2, 0, 2, 0);
            lblHire_date.Name = "lblHire_date";
            lblHire_date.Size = new Size(56, 15);
            lblHire_date.TabIndex = 14;
            lblHire_date.Text = "Hire Date";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(67, 60);
            txtFname.Margin = new Padding(2);
            txtFname.MaxLength = 20;
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(259, 23);
            txtFname.TabIndex = 3;
            // 
            // txtminit
            // 
            txtminit.Anchor = AnchorStyles.Left;
            txtminit.CharacterCasing = CharacterCasing.Upper;
            txtminit.Location = new Point(67, 108);
            txtminit.Margin = new Padding(2);
            txtminit.MaxLength = 1;
            txtminit.Name = "txtminit";
            txtminit.Size = new Size(36, 23);
            txtminit.TabIndex = 5;
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
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLname.CharacterCasing = CharacterCasing.Upper;
            txtLname.Location = new Point(67, 156);
            txtLname.Margin = new Padding(2);
            txtLname.MaxLength = 30;
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(259, 23);
            txtLname.TabIndex = 7;
            // 
            // txtEmp_id
            // 
            txtEmp_id.Anchor = AnchorStyles.Left;
            txtEmp_id.CharacterCasing = CharacterCasing.Upper;
            txtEmp_id.Location = new Point(67, 12);
            txtEmp_id.Margin = new Padding(2);
            txtEmp_id.MaxLength = 9;
            txtEmp_id.Name = "txtEmp_id";
            txtEmp_id.Size = new Size(106, 23);
            txtEmp_id.TabIndex = 1;
            // 
            // nudJob_id
            // 
            nudJob_id.Anchor = AnchorStyles.Left;
            nudJob_id.Location = new Point(67, 204);
            nudJob_id.Margin = new Padding(2);
            nudJob_id.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJob_id.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJob_id.Name = "nudJob_id";
            nudJob_id.Size = new Size(88, 23);
            nudJob_id.TabIndex = 9;
            nudJob_id.Value = new decimal(new int[] { 1, 0, 0, 0 });
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