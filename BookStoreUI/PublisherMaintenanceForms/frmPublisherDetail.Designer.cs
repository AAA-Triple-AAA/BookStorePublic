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
            btnCancel.Location = new Point(460, 544);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(227, 128);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            txtCountry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCountry.CharacterCasing = CharacterCasing.Upper;
            txtCountry.Location = new Point(175, 160);
            txtCountry.MaxLength = 30;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(624, 31);
            txtCountry.TabIndex = 13;
            txtCountry.Text = "USA";
            // 
            // txtPub_name
            // 
            txtPub_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPub_name.Location = new Point(175, 43);
            txtPub_name.MaxLength = 40;
            txtPub_name.Name = "txtPub_name";
            txtPub_name.Size = new Size(624, 31);
            txtPub_name.TabIndex = 11;
            // 
            // lblPub_id
            // 
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(3, 0);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(66, 25);
            lblPub_id.TabIndex = 0;
            lblPub_id.Text = "pub_id";
            // 
            // lblPub_name
            // 
            lblPub_name.AutoSize = true;
            lblPub_name.Location = new Point(3, 39);
            lblPub_name.Name = "lblPub_name";
            lblPub_name.Size = new Size(95, 25);
            lblPub_name.TabIndex = 1;
            lblPub_name.Text = "pub_name";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(3, 78);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 25);
            lblCity.TabIndex = 2;
            lblCity.Text = "city";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(3, 156);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(72, 25);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "country";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(82, 544);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 128);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
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
            tlpPublisher.Controls.Add(mtbPub_id, 1, 0);
            tlpPublisher.Location = new Point(1, 173);
            tlpPublisher.Name = "tlpPublisher";
            tlpPublisher.RowCount = 5;
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPublisher.Size = new Size(802, 195);
            tlpPublisher.TabIndex = 11;
            // 
            // lblState
            // 
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
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(175, 82);
            txtCity.MaxLength = 20;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(624, 31);
            txtCity.TabIndex = 22;
            // 
            // txtState
            // 
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(175, 120);
            txtState.MaxLength = 2;
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 23;
            // 
            // frmPublisherDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 944);
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