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
            txtState = new TextBox();
            txtCity = new TextBox();
            lblState = new Label();
            mtbPub_id = new MaskedTextBox();
            tlpPublisher.SuspendLayout();
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
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCountry.CharacterCasing = CharacterCasing.Upper;
            txtCountry.Location = new Point(72, 210);
            txtCountry.Margin = new Padding(2);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(254, 23);
            txtCountry.TabIndex = 13;
            txtCountry.Text = "USA";
            // 
            // txtPub_name
            // 
            txtPub_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPub_name.Location = new Point(72, 62);
            txtPub_name.Margin = new Padding(2);
            txtPub_name.MaxLength = 40;
            txtPub_name.Name = "txtPub_name";
            txtPub_name.Size = new Size(254, 23);
            txtPub_name.TabIndex = 3;
            // 
            // lblPub_id
            // 
            lblPub_id.Anchor = AnchorStyles.Right;
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(23, 17);
            lblPub_id.Margin = new Padding(2, 0, 2, 0);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(45, 15);
            lblPub_id.TabIndex = 0;
            lblPub_id.Text = "Pub. ID";
            // 
            // lblPub_name
            // 
            lblPub_name.Anchor = AnchorStyles.Right;
            lblPub_name.AutoSize = true;
            lblPub_name.Location = new Point(2, 66);
            lblPub_name.Margin = new Padding(2, 0, 2, 0);
            lblPub_name.Name = "lblPub_name";
            lblPub_name.Size = new Size(66, 15);
            lblPub_name.TabIndex = 2;
            lblPub_name.Text = "Pub. Name";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Location = new Point(40, 115);
            lblCity.Margin = new Padding(2, 0, 2, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Right;
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(18, 214);
            lblCountry.Margin = new Padding(2, 0, 2, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(17, 393);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tlpPublisher
            // 
            tlpPublisher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            tlpPublisher.Controls.Add(mtbPub_id, 1, 0);
            tlpPublisher.Dock = DockStyle.Top;
            tlpPublisher.Location = new Point(0, 0);
            tlpPublisher.Margin = new Padding(2);
            tlpPublisher.Name = "tlpPublisher";
            tlpPublisher.RowCount = 5;
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.Size = new Size(328, 247);
            tlpPublisher.TabIndex = 11;
            // 
            // txtState
            // 
            txtState.Anchor = AnchorStyles.Left;
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(72, 160);
            txtState.Margin = new Padding(2);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(106, 23);
            txtState.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(72, 111);
            txtCity.Margin = new Padding(2);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(254, 23);
            txtCity.TabIndex = 5;
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Location = new Point(35, 164);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(33, 15);
            lblState.TabIndex = 6;
            lblState.Text = "State";
            // 
            // mtbPub_id
            // 
            mtbPub_id.Anchor = AnchorStyles.Left;
            mtbPub_id.HidePromptOnLeave = true;
            mtbPub_id.Location = new Point(72, 13);
            mtbPub_id.Margin = new Padding(2);
            mtbPub_id.Mask = "0000";
            mtbPub_id.Name = "mtbPub_id";
            mtbPub_id.ResetOnSpace = false;
            mtbPub_id.Size = new Size(43, 23);
            mtbPub_id.TabIndex = 1;
            // 
            // frmPublisherDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(328, 432);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpPublisher);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPublisherDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Publisher";
            Load += frmPublisherDetail_Load;
            tlpPublisher.ResumeLayout(false);
            tlpPublisher.PerformLayout();
            ResumeLayout(false);
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