namespace BookStoreUI.StoreMaintenanceForms
{
    partial class frnStoreDetail
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
            btnCancel.Location = new Point(458, 594);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(227, 128);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStor_name
            // 
            txtStor_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStor_name.Location = new Point(176, 40);
            txtStor_name.MaxLength = 40;
            txtStor_name.Name = "txtStor_name";
            txtStor_name.Size = new Size(624, 31);
            txtStor_name.TabIndex = 11;
            // 
            // lblStore_id
            // 
            lblStore_id.AutoSize = true;
            lblStore_id.Location = new Point(3, 0);
            lblStore_id.Name = "lblStore_id";
            lblStore_id.Size = new Size(65, 25);
            lblStore_id.TabIndex = 0;
            lblStore_id.Text = "stor_id";
            // 
            // lblStor_name
            // 
            lblStor_name.AutoSize = true;
            lblStor_name.Location = new Point(3, 37);
            lblStor_name.Name = "lblStor_name";
            lblStor_name.Size = new Size(94, 25);
            lblStor_name.TabIndex = 1;
            lblStor_name.Text = "stor_name";
            // 
            // lblstore_address
            // 
            lblstore_address.AutoSize = true;
            lblstore_address.Location = new Point(3, 74);
            lblstore_address.Name = "lblstore_address";
            lblstore_address.Size = new Size(112, 25);
            lblstore_address.TabIndex = 2;
            lblstore_address.Text = "stor_address";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(3, 148);
            lblState.Name = "lblState";
            lblState.Size = new Size(50, 25);
            lblState.TabIndex = 3;
            lblState.Text = "state";
            // 
            // txtState
            // 
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(176, 151);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(60, 31);
            txtState.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(80, 594);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 128);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tlpAuthor
            // 
            tlpAuthor.Anchor = AnchorStyles.None;
            tlpAuthor.AutoSize = true;
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
            tlpAuthor.Location = new Point(-1, 223);
            tlpAuthor.Name = "tlpAuthor";
            tlpAuthor.RowCount = 6;
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAuthor.Size = new Size(803, 222);
            tlpAuthor.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.CharacterCasing = CharacterCasing.Upper;
            txtCity.Location = new Point(176, 114);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(624, 31);
            txtCity.TabIndex = 23;
            // 
            // txtStor_address
            // 
            txtStor_address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStor_address.Location = new Point(176, 77);
            txtStor_address.MaxLength = 40;
            txtStor_address.Name = "txtStor_address";
            txtStor_address.Size = new Size(624, 31);
            txtStor_address.TabIndex = 22;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(3, 111);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 25);
            lblCity.TabIndex = 14;
            lblCity.Text = "city";
            // 
            // mtbstor_id
            // 
            mtbstor_id.HidePromptOnLeave = true;
            mtbstor_id.Location = new Point(176, 3);
            mtbstor_id.Mask = "0000";
            mtbstor_id.Name = "mtbstor_id";
            mtbstor_id.ResetOnSpace = false;
            mtbstor_id.Size = new Size(60, 31);
            mtbstor_id.TabIndex = 21;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(3, 185);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(35, 25);
            lblZip.TabIndex = 24;
            lblZip.Text = "zip";
            // 
            // mtbZip
            // 
            mtbZip.HidePromptOnLeave = true;
            mtbZip.Location = new Point(176, 188);
            mtbZip.Mask = "00000";
            mtbZip.Name = "mtbZip";
            mtbZip.ResetOnSpace = false;
            mtbZip.Size = new Size(60, 31);
            mtbZip.TabIndex = 25;
            // 
            // frnStoreDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 944);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpAuthor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frnStoreDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Author Detail";
            tlpAuthor.ResumeLayout(false);
            tlpAuthor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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