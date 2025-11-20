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
            tlpFields = new TableLayoutPanel();
            txtPubId = new TextBox();
            txtTitle = new TextBox();
            lblTitleid = new Label();
            lbltitle = new Label();
            lbltype = new Label();
            lblPub_id = new Label();
            lblPrice = new Label();
            lblAdvance = new Label();
            lblRoyalty = new Label();
            lblYtd_sales = new Label();
            lblNotes = new Label();
            lblPubdate = new Label();
            txtTitle_id = new TextBox();
            comboBox1 = new ComboBox();
            nudPrice = new NumericUpDown();
            nudAdvance = new NumericUpDown();
            nudRoyalty = new NumericUpDown();
            nudYtdSales = new NumericUpDown();
            txtNotes = new TextBox();
            dtp = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            tlpFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdvance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoyalty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYtdSales).BeginInit();
            SuspendLayout();
            // 
            // tlpFields
            // 
            tlpFields.AutoSize = true;
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.56863F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.43137F));
            tlpFields.Controls.Add(txtNotes, 1, 8);
            tlpFields.Controls.Add(nudYtdSales, 1, 7);
            tlpFields.Controls.Add(nudRoyalty, 1, 6);
            tlpFields.Controls.Add(nudAdvance, 1, 5);
            tlpFields.Controls.Add(nudPrice, 1, 4);
            tlpFields.Controls.Add(txtPubId, 1, 3);
            tlpFields.Controls.Add(txtTitle, 1, 1);
            tlpFields.Controls.Add(lblTitleid, 0, 0);
            tlpFields.Controls.Add(lbltitle, 0, 1);
            tlpFields.Controls.Add(lbltype, 0, 2);
            tlpFields.Controls.Add(lblPub_id, 0, 3);
            tlpFields.Controls.Add(lblPrice, 0, 4);
            tlpFields.Controls.Add(lblAdvance, 0, 5);
            tlpFields.Controls.Add(lblRoyalty, 0, 6);
            tlpFields.Controls.Add(lblYtd_sales, 0, 7);
            tlpFields.Controls.Add(lblPubdate, 0, 9);
            tlpFields.Controls.Add(txtTitle_id, 1, 0);
            tlpFields.Controls.Add(comboBox1, 1, 2);
            tlpFields.Controls.Add(lblNotes, 0, 8);
            tlpFields.Controls.Add(dtp, 1, 9);
            tlpFields.Dock = DockStyle.Top;
            tlpFields.Location = new Point(0, 0);
            tlpFields.Name = "tlpFields";
            tlpFields.RowCount = 10;
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFields.Size = new Size(800, 584);
            tlpFields.TabIndex = 8;
            // 
            // txtPubId
            // 
            txtPubId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPubId.CharacterCasing = CharacterCasing.Upper;
            txtPubId.Location = new Point(175, 180);
            txtPubId.MaxLength = 4;
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(622, 31);
            txtPubId.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(175, 68);
            txtTitle.MaxLength = 80;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(622, 31);
            txtTitle.TabIndex = 11;
            // 
            // lblTitleid
            // 
            lblTitleid.AutoSize = true;
            lblTitleid.Location = new Point(3, 0);
            lblTitleid.Name = "lblTitleid";
            lblTitleid.Size = new Size(63, 25);
            lblTitleid.TabIndex = 0;
            lblTitleid.Text = "title_id";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(3, 56);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(41, 25);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "title";
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Location = new Point(3, 112);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(47, 25);
            lbltype.TabIndex = 2;
            lbltype.Text = "type";
            // 
            // lblPub_id
            // 
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(3, 168);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(66, 25);
            lblPub_id.TabIndex = 3;
            lblPub_id.Text = "pub_id";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 224);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "price";
            // 
            // lblAdvance
            // 
            lblAdvance.AutoSize = true;
            lblAdvance.Location = new Point(3, 280);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(77, 25);
            lblAdvance.TabIndex = 5;
            lblAdvance.Text = "advance";
            // 
            // lblRoyalty
            // 
            lblRoyalty.AutoSize = true;
            lblRoyalty.Location = new Point(3, 336);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(66, 25);
            lblRoyalty.TabIndex = 6;
            lblRoyalty.Text = "royalty";
            // 
            // lblYtd_sales
            // 
            lblYtd_sales.AutoSize = true;
            lblYtd_sales.Location = new Point(3, 392);
            lblYtd_sales.Name = "lblYtd_sales";
            lblYtd_sales.Size = new Size(83, 25);
            lblYtd_sales.TabIndex = 7;
            lblYtd_sales.Text = "ytd_sales";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(3, 448);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(56, 25);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "notes";
            // 
            // lblPubdate
            // 
            lblPubdate.AutoSize = true;
            lblPubdate.Location = new Point(3, 528);
            lblPubdate.Name = "lblPubdate";
            lblPubdate.Size = new Size(79, 25);
            lblPubdate.TabIndex = 9;
            lblPubdate.Text = "pubdate";
            // 
            // txtTitle_id
            // 
            txtTitle_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle_id.Location = new Point(175, 12);
            txtTitle_id.MaxLength = 6;
            txtTitle_id.Name = "txtTitle_id";
            txtTitle_id.Size = new Size(622, 31);
            txtTitle_id.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Technical", "Business", "Psychology", "Popular_Comp", "UNDECIDED" });
            comboBox1.Location = new Point(175, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(622, 33);
            comboBox1.TabIndex = 20;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Left;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(175, 229);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(180, 31);
            nudPrice.TabIndex = 21;
            nudPrice.ThousandsSeparator = true;
            // 
            // nudAdvance
            // 
            nudAdvance.Anchor = AnchorStyles.Left;
            nudAdvance.DecimalPlaces = 2;
            nudAdvance.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudAdvance.Location = new Point(175, 292);
            nudAdvance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAdvance.Name = "nudAdvance";
            nudAdvance.Size = new Size(180, 31);
            nudAdvance.TabIndex = 22;
            nudAdvance.ThousandsSeparator = true;
            // 
            // nudRoyalty
            // 
            nudRoyalty.Anchor = AnchorStyles.Left;
            nudRoyalty.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudRoyalty.Location = new Point(175, 348);
            nudRoyalty.Name = "nudRoyalty";
            nudRoyalty.Size = new Size(180, 31);
            nudRoyalty.TabIndex = 23;
            nudRoyalty.ThousandsSeparator = true;
            // 
            // nudYtdSales
            // 
            nudYtdSales.Anchor = AnchorStyles.Left;
            nudYtdSales.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudYtdSales.Location = new Point(175, 404);
            nudYtdSales.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudYtdSales.Name = "nudYtdSales";
            nudYtdSales.Size = new Size(180, 31);
            nudYtdSales.TabIndex = 24;
            nudYtdSales.ThousandsSeparator = true;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.CharacterCasing = CharacterCasing.Upper;
            txtNotes.Location = new Point(175, 451);
            txtNotes.MaxLength = 4;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(622, 74);
            txtNotes.TabIndex = 25;
            // 
            // dtp
            // 
            dtp.Anchor = AnchorStyles.Left;
            dtp.CustomFormat = "yyyy/MM/dd";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(175, 533);
            dtp.MaxDate = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(300, 31);
            dtp.TabIndex = 26;
            dtp.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(65, 689);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 128);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(443, 689);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(227, 128);
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
            ClientSize = new Size(800, 944);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpFields);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTitleDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Title";
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdvance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoyalty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYtdSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpFields;
        private Label lblTitleid;
        private Label lbltitle;
        private Label lbltype;
        private Label lblPub_id;
        private Label lblPrice;
        private Label lblAdvance;
        private Label lblRoyalty;
        private Label lblYtd_sales;
        private Label lblNotes;
        private Label lblPubdate;
        private TextBox txtPubId;
        private TextBox txtTitle;
        private TextBox txtTitle_id;
        private ComboBox comboBox1;
        private NumericUpDown nudPrice;
        private NumericUpDown nudRoyalty;
        private NumericUpDown nudAdvance;
        private NumericUpDown nudYtdSales;
        private TextBox txtNotes;
        private DateTimePicker dtp;
        private Button btnSave;
        private Button btnCancel;
    }
}