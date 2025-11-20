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
            btnCancel.Location = new Point(494, 788);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 99);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEmp_id
            // 
            lblEmp_id.AutoSize = true;
            lblEmp_id.Location = new Point(3, 0);
            lblEmp_id.Name = "lblEmp_id";
            lblEmp_id.Size = new Size(70, 25);
            lblEmp_id.TabIndex = 0;
            lblEmp_id.Text = "emp_id";
            // 
            // lblMinit
            // 
            lblMinit.AutoSize = true;
            lblMinit.Location = new Point(3, 160);
            lblMinit.Name = "lblMinit";
            lblMinit.Size = new Size(52, 25);
            lblMinit.TabIndex = 2;
            lblMinit.Text = "minit";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(3, 240);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(60, 25);
            lblLname.TabIndex = 3;
            lblLname.Text = "lname";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(3, 80);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(62, 25);
            lblFname.TabIndex = 1;
            lblFname.Text = "fname";
            // 
            // lblJob_id
            // 
            lblJob_id.AutoSize = true;
            lblJob_id.Location = new Point(3, 320);
            lblJob_id.Name = "lblJob_id";
            lblJob_id.Size = new Size(60, 25);
            lblJob_id.TabIndex = 4;
            lblJob_id.Text = "job_id";
            // 
            // lblJob_lvl
            // 
            lblJob_lvl.AutoSize = true;
            lblJob_lvl.Location = new Point(3, 400);
            lblJob_lvl.Name = "lblJob_lvl";
            lblJob_lvl.Size = new Size(62, 25);
            lblJob_lvl.TabIndex = 5;
            lblJob_lvl.Text = "job_lvl";
            // 
            // lblPub_id
            // 
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(3, 480);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(66, 25);
            lblPub_id.TabIndex = 6;
            lblPub_id.Text = "pub_id";
            // 
            // lblHire_date
            // 
            lblHire_date.AutoSize = true;
            lblHire_date.Location = new Point(3, 560);
            lblHire_date.Name = "lblHire_date";
            lblHire_date.Size = new Size(83, 25);
            lblHire_date.TabIndex = 7;
            lblHire_date.Text = "hire_date";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(163, 104);
            txtFname.MaxLength = 20;
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(634, 31);
            txtFname.TabIndex = 10;
            // 
            // txtminit
            // 
            txtminit.Anchor = AnchorStyles.Left;
            txtminit.CharacterCasing = CharacterCasing.Upper;
            txtminit.Location = new Point(163, 184);
            txtminit.MaxLength = 1;
            txtminit.Name = "txtminit";
            txtminit.Size = new Size(50, 31);
            txtminit.TabIndex = 11;
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
            tlpEmployee.Size = new Size(800, 641);
            tlpEmployee.TabIndex = 19;
            // 
            // nudJobLevel
            // 
            nudJobLevel.Anchor = AnchorStyles.Left;
            nudJobLevel.Location = new Point(163, 424);
            nudJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudJobLevel.Name = "nudJobLevel";
            nudJobLevel.Size = new Size(80, 31);
            nudJobLevel.TabIndex = 21;
            nudJobLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLname.CharacterCasing = CharacterCasing.Upper;
            txtLname.Location = new Point(163, 264);
            txtLname.MaxLength = 30;
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(634, 31);
            txtLname.TabIndex = 19;
            // 
            // txtEmp_id
            // 
            txtEmp_id.Anchor = AnchorStyles.Left;
            txtEmp_id.CharacterCasing = CharacterCasing.Upper;
            txtEmp_id.Location = new Point(163, 24);
            txtEmp_id.MaxLength = 9;
            txtEmp_id.Name = "txtEmp_id";
            txtEmp_id.Size = new Size(150, 31);
            txtEmp_id.TabIndex = 18;
            // 
            // nudJob_id
            // 
            nudJob_id.Anchor = AnchorStyles.Left;
            nudJob_id.Location = new Point(163, 344);
            nudJob_id.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudJob_id.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJob_id.Name = "nudJob_id";
            nudJob_id.Size = new Size(125, 31);
            nudJob_id.TabIndex = 20;
            nudJob_id.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // mtbPubId
            // 
            mtbPubId.Anchor = AnchorStyles.Left;
            mtbPubId.HidePromptOnLeave = true;
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
            // 
            // dtpHireDate
            // 
            dtpHireDate.Anchor = AnchorStyles.Left;
            dtpHireDate.CustomFormat = "yyyy/MM/dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
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