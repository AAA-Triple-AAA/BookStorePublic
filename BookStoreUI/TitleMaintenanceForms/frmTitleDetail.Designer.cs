namespace BookStoreUI
{
    partial class frmTitleDetail
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
            tlpTitle = new TableLayoutPanel();
            txtNotes = new TextBox();
            nudYtdSales = new NumericUpDown();
            nudRoyalty = new NumericUpDown();
            nudAdvance = new NumericUpDown();
            nudPrice = new NumericUpDown();
            txtPubId = new TextBox();
            txtTitle = new TextBox();
            lblTitleId = new Label();
            lblTitle = new Label();
            lblType = new Label();
            lblPubId = new Label();
            lblPrice = new Label();
            lblAdvance = new Label();
            lblRoyalty = new Label();
            lblYtdSales = new Label();
            lblPubDate = new Label();
            txtTitleId = new TextBox();
            cboType = new ComboBox();
            lblNotes = new Label();
            dtpPubDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            tlpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYtdSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoyalty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdvance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // tlpTitle
            // 
            tlpTitle.AutoSize = true;
            tlpTitle.ColumnCount = 2;
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.56863F));
            tlpTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.43137F));
            tlpTitle.Controls.Add(txtNotes, 1, 8);
            tlpTitle.Controls.Add(nudYtdSales, 1, 7);
            tlpTitle.Controls.Add(nudRoyalty, 1, 6);
            tlpTitle.Controls.Add(nudAdvance, 1, 5);
            tlpTitle.Controls.Add(nudPrice, 1, 4);
            tlpTitle.Controls.Add(txtPubId, 1, 3);
            tlpTitle.Controls.Add(txtTitle, 1, 1);
            tlpTitle.Controls.Add(lblTitleId, 0, 0);
            tlpTitle.Controls.Add(lblTitle, 0, 1);
            tlpTitle.Controls.Add(lblType, 0, 2);
            tlpTitle.Controls.Add(lblPubId, 0, 3);
            tlpTitle.Controls.Add(lblPrice, 0, 4);
            tlpTitle.Controls.Add(lblAdvance, 0, 5);
            tlpTitle.Controls.Add(lblRoyalty, 0, 6);
            tlpTitle.Controls.Add(lblYtdSales, 0, 7);
            tlpTitle.Controls.Add(lblPubDate, 0, 9);
            tlpTitle.Controls.Add(txtTitleId, 1, 0);
            tlpTitle.Controls.Add(cboType, 1, 2);
            tlpTitle.Controls.Add(lblNotes, 0, 8);
            tlpTitle.Controls.Add(dtpPubDate, 1, 9);
            tlpTitle.Dock = DockStyle.Top;
            tlpTitle.Location = new Point(0, 0);
            tlpTitle.Name = "tlpTitle";
            tlpTitle.RowCount = 10;
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTitle.Size = new Size(469, 431);
            tlpTitle.TabIndex = 0;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.CharacterCasing = CharacterCasing.Upper;
            txtNotes.Location = new Point(104, 308);
            txtNotes.MaxLength = 4;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(362, 71);
            txtNotes.TabIndex = 17;
            // 
            // nudYtdSales
            // 
            nudYtdSales.Anchor = AnchorStyles.Left;
            nudYtdSales.Location = new Point(104, 269);
            nudYtdSales.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudYtdSales.Name = "nudYtdSales";
            nudYtdSales.Size = new Size(180, 31);
            nudYtdSales.TabIndex = 15;
            nudYtdSales.ThousandsSeparator = true;
            // 
            // nudRoyalty
            // 
            nudRoyalty.Anchor = AnchorStyles.Left;
            nudRoyalty.Location = new Point(104, 231);
            nudRoyalty.Name = "nudRoyalty";
            nudRoyalty.Size = new Size(180, 31);
            nudRoyalty.TabIndex = 13;
            nudRoyalty.ThousandsSeparator = true;
            // 
            // nudAdvance
            // 
            nudAdvance.Anchor = AnchorStyles.Left;
            nudAdvance.DecimalPlaces = 2;
            nudAdvance.Location = new Point(104, 193);
            nudAdvance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAdvance.Name = "nudAdvance";
            nudAdvance.Size = new Size(180, 31);
            nudAdvance.TabIndex = 11;
            nudAdvance.ThousandsSeparator = true;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Left;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(104, 155);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(180, 31);
            nudPrice.TabIndex = 9;
            nudPrice.ThousandsSeparator = true;
            // 
            // txtPubId
            // 
            txtPubId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPubId.CharacterCasing = CharacterCasing.Upper;
            txtPubId.Location = new Point(104, 117);
            txtPubId.MaxLength = 4;
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(362, 31);
            txtPubId.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(104, 41);
            txtTitle.MaxLength = 80;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(362, 31);
            txtTitle.TabIndex = 3;
            // 
            // lblTitleId
            // 
            lblTitleId.Anchor = AnchorStyles.Right;
            lblTitleId.AutoSize = true;
            lblTitleId.Location = new Point(31, 6);
            lblTitleId.Name = "lblTitleId";
            lblTitleId.Size = new Size(67, 25);
            lblTitleId.TabIndex = 0;
            lblTitleId.Text = "Title ID";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(54, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Right;
            lblType.AutoSize = true;
            lblType.Location = new Point(49, 82);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // lblPubId
            // 
            lblPubId.Anchor = AnchorStyles.Right;
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(28, 120);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(70, 25);
            lblPubId.TabIndex = 6;
            lblPubId.Text = "Pub. ID";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(49, 158);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblAdvance
            // 
            lblAdvance.Anchor = AnchorStyles.Right;
            lblAdvance.AutoSize = true;
            lblAdvance.Location = new Point(18, 196);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(80, 25);
            lblAdvance.TabIndex = 10;
            lblAdvance.Text = "Advance";
            // 
            // lblRoyalty
            // 
            lblRoyalty.Anchor = AnchorStyles.Right;
            lblRoyalty.AutoSize = true;
            lblRoyalty.Location = new Point(28, 234);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(70, 25);
            lblRoyalty.TabIndex = 12;
            lblRoyalty.Text = "Royalty";
            // 
            // lblYtdSales
            // 
            lblYtdSales.Anchor = AnchorStyles.Right;
            lblYtdSales.AutoSize = true;
            lblYtdSales.Location = new Point(9, 272);
            lblYtdSales.Name = "lblYtdSales";
            lblYtdSales.Size = new Size(89, 25);
            lblYtdSales.TabIndex = 14;
            lblYtdSales.Text = "YTD Sales";
            // 
            // lblPubDate
            // 
            lblPubDate.Anchor = AnchorStyles.Right;
            lblPubDate.AutoSize = true;
            lblPubDate.Location = new Point(9, 395);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(89, 25);
            lblPubDate.TabIndex = 18;
            lblPubDate.Text = "Pub. Date";
            // 
            // txtTitleId
            // 
            txtTitleId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitleId.Location = new Point(104, 3);
            txtTitleId.MaxLength = 6;
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(362, 31);
            txtTitleId.TabIndex = 1;
            // 
            // cboType
            // 
            cboType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Technical", "Business", "Psychology", "Popular_Comp", "UNDECIDED" });
            cboType.Location = new Point(104, 79);
            cboType.Name = "cboType";
            cboType.Size = new Size(362, 33);
            cboType.TabIndex = 5;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(39, 331);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(59, 25);
            lblNotes.TabIndex = 16;
            lblNotes.Text = "Notes";
            // 
            // dtpPubDate
            // 
            dtpPubDate.Anchor = AnchorStyles.Left;
            dtpPubDate.CustomFormat = "yyyy/MM/dd";
            dtpPubDate.Format = DateTimePickerFormat.Custom;
            dtpPubDate.Location = new Point(104, 392);
            dtpPubDate.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(178, 31);
            dtpPubDate.TabIndex = 19;
            dtpPubDate.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(16, 655);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 47);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(313, 655);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 47);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmTitleDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(469, 720);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTitleDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Title";
            tlpTitle.ResumeLayout(false);
            tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYtdSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoyalty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdvance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpTitle;
        private Label lblTitleId;
        private Label lblTitle;
        private Label lblType;
        private Label lblPubId;
        private Label lblPrice;
        private Label lblAdvance;
        private Label lblRoyalty;
        private Label lblYtdSales;
        private Label lblNotes;
        private Label lblPubDate;
        private TextBox txtPubId;
        private TextBox txtTitle;
        private TextBox txtTitleId;
        private ComboBox cboType;
        private NumericUpDown nudPrice;
        private NumericUpDown nudRoyalty;
        private NumericUpDown nudAdvance;
        private NumericUpDown nudYtdSales;
        private TextBox txtNotes;
        private DateTimePicker dtpPubDate;
        private Button btnSave;
        private Button btnCancel;
    }
}
