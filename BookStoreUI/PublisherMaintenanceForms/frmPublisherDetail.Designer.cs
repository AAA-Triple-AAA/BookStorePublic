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
            txtPub_name = new TextBox();
            lblPub_id = new Label();
            lblPub_name = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            btnSave = new Button();
            tlpPublisher = new TableLayoutPanel();
            lblState = new Label();
            mtbPub_id = new MaskedTextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            tlpPublisher.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            btnCancel.Location = new Point(460, 544);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(227, 128);
            btnCancel.TabIndex = 13;
=======
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
=======
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
>>>>>>> Stashed changes
            btnCancel.Size = new Size(140, 47);
            btnCancel.TabIndex = 15;
>>>>>>> Stashed changes
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCountry.CharacterCasing = CharacterCasing.Upper;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            txtCountry.Location = new Point(175, 160);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(624, 31);
=======
            txtCountry.Location = new Point(104, 354);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(362, 31);
>>>>>>> Stashed changes
=======
            txtCountry.Location = new Point(104, 354);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(362, 31);
>>>>>>> Stashed changes
            txtCountry.TabIndex = 13;
            txtCountry.Text = "USA";
            // 
            // txtPub_name
            // 
<<<<<<< Updated upstream
            txtPub_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPub_name.Location = new Point(175, 43);
            txtPub_name.MaxLength = 40;
            txtPub_name.Name = "txtPub_name";
            txtPub_name.Size = new Size(624, 31);
            txtPub_name.TabIndex = 11;
=======
            txtPubName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPubName.Location = new Point(104, 107);
            txtPubName.MaxLength = 40;
            txtPubName.Name = "txtPubName";
            txtPubName.Size = new Size(362, 31);
            txtPubName.TabIndex = 3;
>>>>>>> Stashed changes
            // 
            // lblPub_id
            // 
<<<<<<< Updated upstream
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(3, 0);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(66, 25);
            lblPub_id.TabIndex = 0;
            lblPub_id.Text = "pub_id";
=======
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(28, 28);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(70, 25);
            lblPubId.TabIndex = 0;
            lblPubId.Text = "Pub. ID";
>>>>>>> Stashed changes
            // 
            // lblPub_name
            // 
<<<<<<< Updated upstream
            lblPub_name.AutoSize = true;
            lblPub_name.Location = new Point(3, 39);
            lblPub_name.Name = "lblPub_name";
            lblPub_name.Size = new Size(95, 25);
            lblPub_name.TabIndex = 1;
            lblPub_name.Text = "pub_name";
=======
            lblPubName.Anchor = AnchorStyles.Right;
            lblPubName.AutoSize = true;
            lblPubName.Location = new Point(39, 98);
            lblPubName.Name = "lblPubName";
            lblPubName.Size = new Size(59, 50);
            lblPubName.TabIndex = 2;
            lblPubName.Text = "Pub. Name";
>>>>>>> Stashed changes
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            lblCity.Location = new Point(3, 78);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 25);
            lblCity.TabIndex = 2;
            lblCity.Text = "city";
=======
            lblCity.Location = new Point(56, 192);
            lblCity.Name = "lblCity";
=======
            lblCity.Location = new Point(56, 192);
            lblCity.Name = "lblCity";
>>>>>>> Stashed changes
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
>>>>>>> Stashed changes
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            lblCountry.Location = new Point(3, 156);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(72, 25);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "country";
=======
            lblCountry.Location = new Point(23, 357);
            lblCountry.Name = "lblCountry";
=======
            lblCountry.Location = new Point(23, 357);
            lblCountry.Name = "lblCountry";
>>>>>>> Stashed changes
            lblCountry.Size = new Size(75, 25);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country";
>>>>>>> Stashed changes
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            btnSave.Location = new Point(82, 544);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 128);
            btnSave.TabIndex = 12;
=======
            btnSave.Location = new Point(24, 655);
            btnSave.Name = "btnSave";
=======
            btnSave.Location = new Point(24, 655);
            btnSave.Name = "btnSave";
>>>>>>> Stashed changes
            btnSave.Size = new Size(140, 47);
            btnSave.TabIndex = 14;
>>>>>>> Stashed changes
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tlpPublisher
            // 
            tlpPublisher.Anchor = AnchorStyles.None;
            tlpPublisher.AutoSize = true;
            tlpPublisher.ColumnCount = 2;
            tlpPublisher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.56863F));
            tlpPublisher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.43137F));
            tlpPublisher.Controls.Add(txtState, 1, 3);
            tlpPublisher.Controls.Add(txtCity, 1, 2);
            tlpPublisher.Controls.Add(lblState, 0, 3);
            tlpPublisher.Controls.Add(txtPub_name, 1, 1);
            tlpPublisher.Controls.Add(lblPub_id, 0, 0);
            tlpPublisher.Controls.Add(lblPub_name, 0, 1);
            tlpPublisher.Controls.Add(lblCity, 0, 2);
            tlpPublisher.Controls.Add(lblCountry, 0, 4);
            tlpPublisher.Controls.Add(txtCountry, 1, 4);
<<<<<<< Updated upstream
            tlpPublisher.Controls.Add(mtbPub_id, 1, 0);
            tlpPublisher.Location = new Point(1, 173);
=======
            tlpPublisher.Controls.Add(mtbPubId, 1, 0);
            tlpPublisher.Dock = DockStyle.Top;
            tlpPublisher.Location = new Point(0, 0);
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            tlpPublisher.Name = "tlpPublisher";
            tlpPublisher.RowCount = 5;
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            tlpPublisher.Size = new Size(802, 195);
=======
            tlpPublisher.Size = new Size(469, 412);
>>>>>>> Stashed changes
=======
            tlpPublisher.Size = new Size(469, 412);
>>>>>>> Stashed changes
            tlpPublisher.TabIndex = 11;
            // 
            // lblState
            // 
<<<<<<< Updated upstream
            lblState.AutoSize = true;
            lblState.Location = new Point(3, 117);
            lblState.Name = "lblState";
            lblState.Size = new Size(50, 25);
            lblState.TabIndex = 14;
            lblState.Text = "state";
            // 
            // mtbPub_id
            // 
            mtbPub_id.HidePromptOnLeave = true;
            mtbPub_id.Location = new Point(175, 3);
            mtbPub_id.Mask = "0000";
            mtbPub_id.Name = "mtbPub_id";
            mtbPub_id.ResetOnSpace = false;
            mtbPub_id.Size = new Size(60, 31);
            mtbPub_id.TabIndex = 21;
=======
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(104, 271);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 7;
>>>>>>> Stashed changes
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            txtCity.Location = new Point(175, 82);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(624, 31);
            txtCity.TabIndex = 22;
=======
            txtCity.Location = new Point(104, 189);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
=======
            txtCity.Location = new Point(104, 189);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
>>>>>>> Stashed changes
            txtCity.Size = new Size(362, 31);
            txtCity.TabIndex = 5;
>>>>>>> Stashed changes
            // 
            // txtState
            // 
<<<<<<< Updated upstream
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(175, 120);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 23;
=======
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
>>>>>>> Stashed changes
            // 
            // frmPublisherDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            ClientSize = new Size(800, 944);
=======
            ClientSize = new Size(469, 720);
>>>>>>> Stashed changes
=======
            ClientSize = new Size(469, 720);
>>>>>>> Stashed changes
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
        private TextBox txtPub_name;
        private Label lblPub_id;
        private Label lblPub_name;
        private Label lblCity;
        private Label lblCountry;
        private Button btnSave;
        private TableLayoutPanel tlpPublisher;
        private Label lblState;
        private MaskedTextBox mtbPub_id;
        private TextBox txtCity;
        private TextBox txtState;
    }
}