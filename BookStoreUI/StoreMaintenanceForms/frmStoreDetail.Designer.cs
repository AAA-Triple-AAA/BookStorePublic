namespace BookStoreUI.StoreMaintenanceForms
{
    partial class frmStoreDetail
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
            txtStoreName = new TextBox();
            lblStoreId = new Label();
            lblStoreName = new Label();
            lblStoreAddress = new Label();
            lblState = new Label();
            txtState = new TextBox();
            btnSave = new Button();
            tlpAuthor = new TableLayoutPanel();
            txtCity = new TextBox();
            txtStoreAddress = new TextBox();
            lblCity = new Label();
            mtbStoreId = new MaskedTextBox();
            lblZip = new Label();
            mtbZip = new MaskedTextBox();
            tlpAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 393);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 28);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStoreName
            // 
            txtStoreName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStoreName.Location = new Point(72, 62);
            txtStoreName.Margin = new Padding(2);
            txtStoreName.MaxLength = 40;
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(254, 23);
            txtStoreName.TabIndex = 3;
            // 
            // lblStoreId
            // 
            lblStoreId.Anchor = AnchorStyles.Right;
            lblStoreId.AutoSize = true;
            lblStoreId.Location = new Point(20, 17);
            lblStoreId.Margin = new Padding(2, 0, 2, 0);
            lblStoreId.Name = "lblStoreId";
            lblStoreId.Size = new Size(48, 15);
            lblStoreId.TabIndex = 0;
            lblStoreId.Text = "Store ID";
            // 
            // lblStoreName
            // 
            lblStoreName.Anchor = AnchorStyles.Right;
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(29, 58);
            lblStoreName.Margin = new Padding(2, 0, 2, 0);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(39, 30);
            lblStoreName.TabIndex = 2;
            lblStoreName.Text = "Store Name";
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.Anchor = AnchorStyles.Right;
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Location = new Point(19, 107);
            lblStoreAddress.Margin = new Padding(2, 0, 2, 0);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(49, 30);
            lblStoreAddress.TabIndex = 4;
            lblStoreAddress.Text = "Store Address";
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Location = new Point(35, 213);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(33, 15);
            lblState.TabIndex = 8;
            lblState.Text = "State";
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(72, 209);
            txtState.Margin = new Padding(2);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(43, 23);
            txtState.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(11, 393);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tlpAuthor
            // 
            tlpAuthor.ColumnCount = 2;
            tlpAuthor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.56863F));
            tlpAuthor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.43137F));
            tlpAuthor.Controls.Add(txtCity, 1, 3);
            tlpAuthor.Controls.Add(txtStoreAddress, 1, 2);
            tlpAuthor.Controls.Add(lblCity, 0, 3);
            tlpAuthor.Controls.Add(txtStoreName, 1, 1);
            tlpAuthor.Controls.Add(lblStoreId, 0, 0);
            tlpAuthor.Controls.Add(lblStoreName, 0, 1);
            tlpAuthor.Controls.Add(lblStoreAddress, 0, 2);
            tlpAuthor.Controls.Add(lblState, 0, 4);
            tlpAuthor.Controls.Add(txtState, 1, 4);
            tlpAuthor.Controls.Add(mtbStoreId, 1, 0);
            tlpAuthor.Controls.Add(lblZip, 0, 5);
            tlpAuthor.Controls.Add(mtbZip, 1, 5);
            tlpAuthor.Dock = DockStyle.Top;
            tlpAuthor.Location = new Point(0, 0);
            tlpAuthor.Margin = new Padding(2);
            tlpAuthor.Name = "tlpAuthor";
            tlpAuthor.RowCount = 6;
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.Size = new Size(328, 295);
            tlpAuthor.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.CharacterCasing = CharacterCasing.Upper;
            txtCity.Location = new Point(72, 160);
            txtCity.Margin = new Padding(2);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(254, 23);
            txtCity.TabIndex = 7;
            // 
            // txtStoreAddress
            // 
            txtStoreAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStoreAddress.Location = new Point(72, 111);
            txtStoreAddress.Margin = new Padding(2);
            txtStoreAddress.MaxLength = 40;
            txtStoreAddress.Name = "txtStoreAddress";
            txtStoreAddress.Size = new Size(254, 23);
            txtStoreAddress.TabIndex = 5;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(40, 164);
            lblCity.Margin = new Padding(2, 0, 2, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 6;
            lblCity.Text = "City";
            // 
            // mtbStoreId
            // 
            mtbStoreId.Anchor = AnchorStyles.Left;
            mtbStoreId.HidePromptOnLeave = true;
            mtbStoreId.Location = new Point(72, 13);
            mtbStoreId.Margin = new Padding(2);
            mtbStoreId.Mask = "0000";
            mtbStoreId.Name = "mtbStoreId";
            mtbStoreId.ResetOnSpace = false;
            mtbStoreId.Size = new Size(43, 23);
            mtbStoreId.TabIndex = 1;
            // 
            // lblZip
            // 
            lblZip.Anchor = AnchorStyles.Right;
            lblZip.AutoSize = true;
            lblZip.Location = new Point(44, 262);
            lblZip.Margin = new Padding(2, 0, 2, 0);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(24, 15);
            lblZip.TabIndex = 10;
            lblZip.Text = "Zip";
            // 
            // mtbZip
            // 
            mtbZip.Anchor = AnchorStyles.Left;
            mtbZip.HidePromptOnLeave = true;
            mtbZip.Location = new Point(72, 258);
            mtbZip.Margin = new Padding(2);
            mtbZip.Mask = "00000";
            mtbZip.Name = "mtbZip";
            mtbZip.ResetOnSpace = false;
            mtbZip.Size = new Size(43, 23);
            mtbZip.TabIndex = 11;
            // 
            // frmStoreDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(328, 432);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpAuthor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "frmStoreDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Store";
            Load += frnStoreDetail_Load;
            tlpAuthor.ResumeLayout(false);
            tlpAuthor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private TextBox txtStoreName;
        private Label lblStoreId;
        private Label lblStoreName;
        private Label lblStoreAddress;
        private Label lblState;
        private TextBox txtState;
        private Button btnSave;
        private TableLayoutPanel tlpAuthor;
        private TextBox txtCity;
        private TextBox txtStoreAddress;
        private Label lblCity;
        private MaskedTextBox mtbStoreId;
        private Label lblZip;
        private MaskedTextBox mtbZip;
    }
}