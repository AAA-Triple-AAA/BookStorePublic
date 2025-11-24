namespace BookStoreUI.PublisherMaintenanceForms
{
    partial class frmPublisherDetail
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
            txtCountry = new TextBox();
            txtPubName = new TextBox();
            lblPubId = new Label();
            lblPubName = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            btnSave = new Button();
            tlpPublisher = new TableLayoutPanel();
            lblState = new Label();
            mtbPubId = new MaskedTextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            tlpPublisher.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCountry.CharacterCasing = CharacterCasing.Upper;
            txtCountry.Location = new Point(104, 354);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(362, 31);
            txtCountry.TabIndex = 9;
            txtCountry.Text = "USA";
            // 
            // txtPubName
            // 
            txtPubName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPubName.Location = new Point(104, 107);
            txtPubName.MaxLength = 40;
            txtPubName.Name = "txtPubName";
            txtPubName.Size = new Size(362, 31);
            txtPubName.TabIndex = 3;
            // 
            // lblPubId
            // 
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(28, 28);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(70, 25);
            lblPubId.TabIndex = 0;
            lblPubId.Text = "Pub. ID";
            // 
            // lblPubName
            // 
            lblPubName.Anchor = AnchorStyles.Right;
            lblPubName.AutoSize = true;
            lblPubName.Location = new Point(39, 98);
            lblPubName.Name = "lblPubName";
            lblPubName.Size = new Size(59, 50);
            lblPubName.TabIndex = 2;
            lblPubName.Text = "Pub. Name";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(56, 192);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Right;
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(23, 357);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 25);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(24, 655);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tlpPublisher
            // 
            tlpPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpPublisher.AutoSize = true;
            tlpPublisher.ColumnCount = 2;
            tlpPublisher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.56863F));
            tlpPublisher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.43137F));
            tlpPublisher.Controls.Add(mtbPubId, 1, 0);
            tlpPublisher.Controls.Add(txtState, 1, 3);
            tlpPublisher.Controls.Add(txtCity, 1, 2);
            tlpPublisher.Controls.Add(lblState, 0, 3);
            tlpPublisher.Controls.Add(txtPubName, 1, 1);
            tlpPublisher.Controls.Add(lblPubId, 0, 0);
            tlpPublisher.Controls.Add(lblPubName, 0, 1);
            tlpPublisher.Controls.Add(lblCity, 0, 2);
            tlpPublisher.Controls.Add(lblCountry, 0, 4);
            tlpPublisher.Controls.Add(txtCountry, 1, 4);
            tlpPublisher.Location = new Point(0, 0);
            tlpPublisher.Name = "tlpPublisher";
            tlpPublisher.RowCount = 5;
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.Size = new Size(469, 412);
            tlpPublisher.TabIndex = 0;
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Location = new Point(47, 274);
            lblState.Name = "lblState";
            lblState.Size = new Size(51, 25);
            lblState.TabIndex = 6;
            lblState.Text = "State";
            // 
            // mtbPubId
            // 
            mtbPubId.Anchor = AnchorStyles.Left;
            mtbPubId.HidePromptOnLeave = true;
            mtbPubId.Location = new Point(104, 25);
            mtbPubId.Mask = "0000";
            mtbPubId.Name = "mtbPubId";
            mtbPubId.ResetOnSpace = false;
            mtbPubId.Size = new Size(60, 31);
            mtbPubId.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(104, 189);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(362, 31);
            txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(104, 271);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 7;
            // 
            // frmPublisherDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(469, 720);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpPublisher);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPublisherDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Publisher";
            tlpPublisher.ResumeLayout(false);
            tlpPublisher.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private TextBox txtCountry;
        private TextBox txtPubName;
        private Label lblPubId;
        private Label lblPubName;
        private Label lblCity;
        private Label lblCountry;
        private Button btnSave;
        private TableLayoutPanel tlpPublisher;
        private Label lblState;
        private MaskedTextBox mtbPubId;
        private TextBox txtCity;
        private TextBox txtState;
    }
}
