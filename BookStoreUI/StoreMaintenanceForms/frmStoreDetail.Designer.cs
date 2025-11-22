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
            txtStor_name = new TextBox();
            lblStore_id = new Label();
            lblStor_name = new Label();
            lblstore_address = new Label();
            lblState = new Label();
            txtState = new TextBox();
            btnSave = new Button();
            tlpAuthor = new TableLayoutPanel();
            txtCity = new TextBox();
            txtStor_address = new TextBox();
            lblCity = new Label();
            mtbstor_id = new MaskedTextBox();
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
            // txtStor_name
            // 
            txtStor_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStor_name.Location = new Point(72, 62);
            txtStor_name.Margin = new Padding(2);
            txtStor_name.MaxLength = 40;
            txtStor_name.Name = "txtStor_name";
            txtStor_name.Size = new Size(254, 23);
            txtStor_name.TabIndex = 3;
            // 
            // lblStore_id
            // 
            lblStore_id.Anchor = AnchorStyles.Right;
            lblStore_id.AutoSize = true;
            lblStore_id.Location = new Point(20, 17);
            lblStore_id.Margin = new Padding(2, 0, 2, 0);
            lblStore_id.Name = "lblStore_id";
            lblStore_id.Size = new Size(48, 15);
            lblStore_id.TabIndex = 0;
            lblStore_id.Text = "Store ID";
            // 
            // lblStor_name
            // 
            lblStor_name.Anchor = AnchorStyles.Right;
            lblStor_name.AutoSize = true;
            lblStor_name.Location = new Point(29, 58);
            lblStor_name.Margin = new Padding(2, 0, 2, 0);
            lblStor_name.Name = "lblStor_name";
            lblStor_name.Size = new Size(39, 30);
            lblStor_name.TabIndex = 2;
            lblStor_name.Text = "Store Name";
            // 
            // lblstore_address
            // 
            lblstore_address.Anchor = AnchorStyles.Right;
            lblstore_address.AutoSize = true;
            lblstore_address.Location = new Point(19, 107);
            lblstore_address.Margin = new Padding(2, 0, 2, 0);
            lblstore_address.Name = "lblstore_address";
            lblstore_address.Size = new Size(49, 30);
            lblstore_address.TabIndex = 4;
            lblstore_address.Text = "Store Address";
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
            tlpAuthor.Controls.Add(txtStor_address, 1, 2);
            tlpAuthor.Controls.Add(lblCity, 0, 3);
            tlpAuthor.Controls.Add(txtStor_name, 1, 1);
            tlpAuthor.Controls.Add(lblStore_id, 0, 0);
            tlpAuthor.Controls.Add(lblStor_name, 0, 1);
            tlpAuthor.Controls.Add(lblstore_address, 0, 2);
            tlpAuthor.Controls.Add(lblState, 0, 4);
            tlpAuthor.Controls.Add(txtState, 1, 4);
            tlpAuthor.Controls.Add(mtbstor_id, 1, 0);
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
            // txtStor_address
            // 
            txtStor_address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStor_address.Location = new Point(72, 111);
            txtStor_address.Margin = new Padding(2);
            txtStor_address.MaxLength = 40;
            txtStor_address.Name = "txtStor_address";
            txtStor_address.Size = new Size(254, 23);
            txtStor_address.TabIndex = 5;
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
            // mtbstor_id
            // 
            mtbstor_id.Anchor = AnchorStyles.Left;
            mtbstor_id.HidePromptOnLeave = true;
            mtbstor_id.Location = new Point(72, 13);
            mtbstor_id.Margin = new Padding(2);
            mtbstor_id.Mask = "0000";
            mtbstor_id.Name = "mtbstor_id";
            mtbstor_id.ResetOnSpace = false;
            mtbstor_id.Size = new Size(43, 23);
            mtbstor_id.TabIndex = 1;
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
            // frnStoreDetail
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
            Name = "frnStoreDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Author Detail";
            Load += frnStoreDetail_Load;
            tlpAuthor.ResumeLayout(false);
            tlpAuthor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private TextBox txtStor_name;
        private Label lblStore_id;
        private Label lblStor_name;
        private Label lblstore_address;
        private Label lblState;
        private TextBox txtState;
        private Button btnSave;
        private TableLayoutPanel tlpAuthor;
        private TextBox txtCity;
        private TextBox txtStor_address;
        private Label lblCity;
        private MaskedTextBox mtbstor_id;
        private Label lblZip;
        private MaskedTextBox mtbZip;
    }
}