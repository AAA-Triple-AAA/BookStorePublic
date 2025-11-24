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
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStoreName
            // 
            txtStoreName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStoreName.Location = new Point(104, 107);
            txtStoreName.MaxLength = 40;
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(362, 31);
            txtStoreName.TabIndex = 3;
            // 
            // lblStoreId
            // 
            lblStoreId.Anchor = AnchorStyles.Right;
            lblStoreId.AutoSize = true;
            lblStoreId.Location = new Point(22, 28);
            lblStoreId.Name = "lblStoreId";
            lblStoreId.Size = new Size(76, 25);
            lblStoreId.TabIndex = 0;
            lblStoreId.Text = "Store ID";
            // 
            // lblStoreName
            // 
            lblStoreName.Anchor = AnchorStyles.Right;
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(39, 98);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(59, 50);
            lblStoreName.TabIndex = 2;
            lblStoreName.Text = "Store Name";
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.Anchor = AnchorStyles.Right;
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Location = new Point(21, 180);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(77, 50);
            lblStoreAddress.TabIndex = 4;
            lblStoreAddress.Text = "Store Address";
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Location = new Point(47, 356);
            lblState.Name = "lblState";
            lblState.Size = new Size(51, 25);
            lblState.TabIndex = 8;
            lblState.Text = "State";
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(104, 353);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(60, 31);
            txtState.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(16, 655);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 47);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            tlpAuthor.Name = "tlpAuthor";
            tlpAuthor.RowCount = 6;
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.Size = new Size(469, 492);
            tlpAuthor.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.CharacterCasing = CharacterCasing.Upper;
            txtCity.Location = new Point(104, 271);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(362, 31);
            txtCity.TabIndex = 7;
            // 
            // txtStoreAddress
            // 
            txtStoreAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStoreAddress.Location = new Point(104, 189);
            txtStoreAddress.MaxLength = 40;
            txtStoreAddress.Name = "txtStoreAddress";
            txtStoreAddress.Size = new Size(362, 31);
            txtStoreAddress.TabIndex = 5;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(56, 274);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 6;
            lblCity.Text = "City";
            // 
            // mtbStoreId
            // 
            mtbStoreId.Anchor = AnchorStyles.Left;
            mtbStoreId.HidePromptOnLeave = true;
            mtbStoreId.Location = new Point(104, 25);
            mtbStoreId.Mask = "0000";
            mtbStoreId.Name = "mtbStoreId";
            mtbStoreId.ResetOnSpace = false;
            mtbStoreId.Size = new Size(60, 31);
            mtbStoreId.TabIndex = 1;
            // 
            // lblZip
            // 
            lblZip.Anchor = AnchorStyles.Right;
            lblZip.AutoSize = true;
            lblZip.Location = new Point(61, 438);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(37, 25);
            lblZip.TabIndex = 10;
            lblZip.Text = "Zip";
            // 
            // mtbZip
            // 
            mtbZip.Anchor = AnchorStyles.Left;
            mtbZip.HidePromptOnLeave = true;
            mtbZip.Location = new Point(104, 435);
            mtbZip.Mask = "00000";
            mtbZip.Name = "mtbZip";
            mtbZip.ResetOnSpace = false;
            mtbZip.Size = new Size(60, 31);
            mtbZip.TabIndex = 11;
            // 
            // frmStoreDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(469, 720);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpAuthor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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