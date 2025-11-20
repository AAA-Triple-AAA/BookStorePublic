namespace BookStoreUI.AuthorMaintenanceForms
{
    partial class fromAuthorDeatail
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
            tlpAuthor = new TableLayoutPanel();
            lblAu_id = new Label();
            lblAu_lname = new Label();
            lblAu_fname = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            lblContract = new Label();
            mtbAuthorId = new MaskedTextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            mtbPhone = new MaskedTextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            mtbZip = new MaskedTextBox();
            chkContract = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtState = new TextBox();
            tlpAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAuthor
            // 
            tlpAuthor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpAuthor.ColumnCount = 2;
            tlpAuthor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAuthor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpAuthor.Controls.Add(txtCity, 1, 5);
            tlpAuthor.Controls.Add(lblAu_id, 0, 0);
            tlpAuthor.Controls.Add(lblAu_fname, 0, 2);
            tlpAuthor.Controls.Add(lblPhone, 0, 3);
            tlpAuthor.Controls.Add(lblAu_lname, 0, 1);
            tlpAuthor.Controls.Add(lblAddress, 0, 4);
            tlpAuthor.Controls.Add(lblCity, 0, 5);
            tlpAuthor.Controls.Add(lblState, 0, 6);
            tlpAuthor.Controls.Add(lblZip, 0, 7);
            tlpAuthor.Controls.Add(lblContract, 0, 8);
            tlpAuthor.Controls.Add(mtbAuthorId, 1, 0);
            tlpAuthor.Controls.Add(txtLastName, 1, 1);
            tlpAuthor.Controls.Add(txtFirstName, 1, 2);
            tlpAuthor.Controls.Add(mtbPhone, 1, 3);
            tlpAuthor.Controls.Add(txtAddress, 1, 4);
            tlpAuthor.Controls.Add(mtbZip, 1, 7);
            tlpAuthor.Controls.Add(chkContract, 1, 8);
            tlpAuthor.Controls.Add(txtState, 1, 6);
            tlpAuthor.Dock = DockStyle.Top;
            tlpAuthor.Location = new Point(0, 0);
            tlpAuthor.Name = "tlpAuthor";
            tlpAuthor.RowCount = 9;
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAuthor.Size = new Size(800, 641);
            tlpAuthor.TabIndex = 0;
            // 
            // lblAu_id
            // 
            lblAu_id.AutoSize = true;
            lblAu_id.Location = new Point(3, 0);
            lblAu_id.Name = "lblAu_id";
            lblAu_id.Size = new Size(53, 25);
            lblAu_id.TabIndex = 0;
            lblAu_id.Text = "au_id";
            // 
            // lblAu_lname
            // 
            lblAu_lname.AutoSize = true;
            lblAu_lname.Location = new Point(3, 71);
            lblAu_lname.Name = "lblAu_lname";
            lblAu_lname.Size = new Size(86, 25);
            lblAu_lname.TabIndex = 1;
            lblAu_lname.Text = "au_lname";
            // 
            // lblAu_fname
            // 
            lblAu_fname.AutoSize = true;
            lblAu_fname.Location = new Point(3, 142);
            lblAu_fname.Name = "lblAu_fname";
            lblAu_fname.Size = new Size(88, 25);
            lblAu_fname.TabIndex = 2;
            lblAu_fname.Text = "au_fname";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 213);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(3, 284);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "address";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(3, 355);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 25);
            lblCity.TabIndex = 5;
            lblCity.Text = "city";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(3, 426);
            lblState.Name = "lblState";
            lblState.Size = new Size(50, 25);
            lblState.TabIndex = 6;
            lblState.Text = "state";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(3, 497);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(35, 25);
            lblZip.TabIndex = 7;
            lblZip.Text = "zip";
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Location = new Point(3, 568);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(76, 25);
            lblContract.TabIndex = 8;
            lblContract.Text = "contract";
            // 
            // mtbAuthorId
            // 
            mtbAuthorId.Anchor = AnchorStyles.Left;
            mtbAuthorId.HidePromptOnLeave = true;
            mtbAuthorId.Location = new Point(163, 20);
            mtbAuthorId.Mask = "000-00-0000";
            mtbAuthorId.Name = "mtbAuthorId";
            mtbAuthorId.ResetOnSpace = false;
            mtbAuthorId.Size = new Size(150, 31);
            mtbAuthorId.TabIndex = 9;
            mtbAuthorId.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(163, 91);
            txtLastName.MaxLength = 40;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(634, 31);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(163, 162);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(634, 31);
            txtFirstName.TabIndex = 11;
            // 
            // mtbPhone
            // 
            mtbPhone.Anchor = AnchorStyles.Left;
            mtbPhone.HidePromptOnLeave = true;
            mtbPhone.Location = new Point(163, 233);
            mtbPhone.Mask = "000 000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.ResetOnSpace = false;
            mtbPhone.Size = new Size(150, 31);
            mtbPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(163, 304);
            txtAddress.MaxLength = 40;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(634, 31);
            txtAddress.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(163, 375);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(634, 31);
            txtCity.TabIndex = 1;
            // 
            // mtbZip
            // 
            mtbZip.HidePromptOnLeave = true;
            mtbZip.Location = new Point(163, 500);
            mtbZip.Mask = "00000";
            mtbZip.Name = "mtbZip";
            mtbZip.ResetOnSpace = false;
            mtbZip.Size = new Size(54, 31);
            mtbZip.TabIndex = 15;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(163, 571);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(22, 21);
            chkContract.TabIndex = 16;
            chkContract.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(80, 730);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 99);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(494, 730);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 99);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtState
            // 
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(163, 429);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 17;
            // 
            // fromAuthorDeatail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 944);
            Controls.Add(btnCancel);
            Controls.Add(tlpAuthor);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fromAuthorDeatail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Author";
            tlpAuthor.ResumeLayout(false);
            tlpAuthor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAuthor;
        private Label lblAu_id;
        private Label lblAu_fname;
        private Label lblPhone;
        private Label lblAu_lname;
        private Label lblAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblZip;
        private Label lblContract;
        private MaskedTextBox mtbAuthorId;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private MaskedTextBox mtbPhone;
        private TextBox txtCity;
        private TextBox txtAddress;
        private MaskedTextBox mtbZip;
        private CheckBox chkContract;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtState;
    }
}