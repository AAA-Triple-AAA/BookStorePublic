namespace BookStoreUI.AuthorMaintenanceForms
{
    partial class frmAuthorDetail
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
            txtCity = new TextBox();
            lblAu_fname = new Label();
            lblPhone = new Label();
            lblAu_lname = new Label();
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
            mtbZip = new MaskedTextBox();
            chkContract = new CheckBox();
            txtState = new TextBox();
            lblAu_id = new Label();
            btnSave = new Button();
            btnCancel = new Button();
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
            tlpAuthor.Controls.Add(lblAu_id, 0, 0);
            tlpAuthor.Dock = DockStyle.Top;
            tlpAuthor.Location = new Point(0, 0);
            tlpAuthor.Margin = new Padding(2);
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
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpAuthor.Size = new Size(328, 385);
            tlpAuthor.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(67, 219);
            txtCity.Margin = new Padding(2);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(259, 23);
            txtCity.TabIndex = 10;
            // 
            // lblAu_fname
            // 
            lblAu_fname.Anchor = AnchorStyles.Right;
            lblAu_fname.AutoSize = true;
            lblAu_fname.Location = new Point(24, 90);
            lblAu_fname.Margin = new Padding(2, 0, 2, 0);
            lblAu_fname.Name = "lblAu_fname";
            lblAu_fname.Size = new Size(39, 30);
            lblAu_fname.TabIndex = 4;
            lblAu_fname.Text = "First Name";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(22, 139);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblAu_lname
            // 
            lblAu_lname.Anchor = AnchorStyles.Right;
            lblAu_lname.AutoSize = true;
            lblAu_lname.Location = new Point(24, 48);
            lblAu_lname.Margin = new Padding(2, 0, 2, 0);
            lblAu_lname.Name = "lblAu_lname";
            lblAu_lname.Size = new Size(39, 30);
            lblAu_lname.TabIndex = 2;
            lblAu_lname.Text = "Last Name";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Right;
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 181);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(35, 223);
            lblCity.Margin = new Padding(2, 0, 2, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 9;
            lblCity.Text = "City";
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Location = new Point(30, 265);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(33, 15);
            lblState.TabIndex = 11;
            lblState.Text = "State";
            // 
            // lblZip
            // 
            lblZip.Anchor = AnchorStyles.Right;
            lblZip.AutoSize = true;
            lblZip.Cursor = Cursors.No;
            lblZip.Location = new Point(39, 307);
            lblZip.Margin = new Padding(2, 0, 2, 0);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(24, 15);
            lblZip.TabIndex = 13;
            lblZip.Text = "Zip";
            // 
            // lblContract
            // 
            lblContract.Anchor = AnchorStyles.Right;
            lblContract.AutoSize = true;
            lblContract.Location = new Point(10, 353);
            lblContract.Margin = new Padding(2, 0, 2, 0);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(53, 15);
            lblContract.TabIndex = 15;
            lblContract.Text = "Contract";
            // 
            // mtbAuthorId
            // 
            mtbAuthorId.Anchor = AnchorStyles.Left;
            mtbAuthorId.HidePromptOnLeave = true;
            mtbAuthorId.Location = new Point(67, 9);
            mtbAuthorId.Margin = new Padding(2);
            mtbAuthorId.Mask = "000-00-0000";
            mtbAuthorId.Name = "mtbAuthorId";
            mtbAuthorId.ResetOnSpace = false;
            mtbAuthorId.Size = new Size(106, 23);
            mtbAuthorId.TabIndex = 1;
            mtbAuthorId.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(67, 51);
            txtLastName.Margin = new Padding(2);
            txtLastName.MaxLength = 40;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(67, 93);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(259, 23);
            txtFirstName.TabIndex = 4;
            // 
            // mtbPhone
            // 
            mtbPhone.Anchor = AnchorStyles.Left;
            mtbPhone.HidePromptOnLeave = true;
            mtbPhone.Location = new Point(67, 135);
            mtbPhone.Margin = new Padding(2);
            mtbPhone.Mask = "000 000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.ResetOnSpace = false;
            mtbPhone.Size = new Size(106, 23);
            mtbPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(67, 177);
            txtAddress.Margin = new Padding(2);
            txtAddress.MaxLength = 40;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(259, 23);
            txtAddress.TabIndex = 8;
            // 
            // mtbZip
            // 
            mtbZip.Anchor = AnchorStyles.Left;
            mtbZip.HidePromptOnLeave = true;
            mtbZip.Location = new Point(67, 303);
            mtbZip.Margin = new Padding(2);
            mtbZip.Mask = "00000";
            mtbZip.Name = "mtbZip";
            mtbZip.ResetOnSpace = false;
            mtbZip.Size = new Size(39, 23);
            mtbZip.TabIndex = 14;
            // 
            // chkContract
            // 
            chkContract.Anchor = AnchorStyles.Left;
            chkContract.AutoSize = true;
            chkContract.Location = new Point(67, 353);
            chkContract.Margin = new Padding(2);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(15, 14);
            chkContract.TabIndex = 16;
            chkContract.UseVisualStyleBackColor = true;
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(67, 261);
            txtState.Margin = new Padding(2);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(106, 23);
            txtState.TabIndex = 12;
            // 
            // lblAu_id
            // 
            lblAu_id.Anchor = AnchorStyles.Right;
            lblAu_id.AutoSize = true;
            lblAu_id.Location = new Point(5, 13);
            lblAu_id.Margin = new Padding(2, 0, 2, 0);
            lblAu_id.Name = "lblAu_id";
            lblAu_id.Size = new Size(58, 15);
            lblAu_id.TabIndex = 0;
            lblAu_id.Text = "Author ID";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(9, 395);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 395);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 28);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAuthorDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(328, 432);
            Controls.Add(btnCancel);
            Controls.Add(tlpAuthor);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAuthorDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Author";
            Load += frmAuthorDetail_Load;
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