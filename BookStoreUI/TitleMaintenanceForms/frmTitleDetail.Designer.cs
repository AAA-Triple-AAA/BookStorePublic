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
            lblTitleid = new Label();
            lbltitle = new Label();
            lbltype = new Label();
            lblPub_id = new Label();
            lblPrice = new Label();
            lblAdvance = new Label();
            lblRoyalty = new Label();
            lblYtd_sales = new Label();
            lblPubdate = new Label();
            txtTitle_id = new TextBox();
            comboBox1 = new ComboBox();
            lblNotes = new Label();
            dtp = new DateTimePicker();
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
            tlpTitle.Controls.Add(lblTitleid, 0, 0);
            tlpTitle.Controls.Add(lbltitle, 0, 1);
            tlpTitle.Controls.Add(lbltype, 0, 2);
            tlpTitle.Controls.Add(lblPub_id, 0, 3);
            tlpTitle.Controls.Add(lblPrice, 0, 4);
            tlpTitle.Controls.Add(lblAdvance, 0, 5);
            tlpTitle.Controls.Add(lblRoyalty, 0, 6);
            tlpTitle.Controls.Add(lblYtd_sales, 0, 7);
            tlpTitle.Controls.Add(lblPubdate, 0, 9);
            tlpTitle.Controls.Add(txtTitle_id, 1, 0);
            tlpTitle.Controls.Add(comboBox1, 1, 2);
            tlpTitle.Controls.Add(lblNotes, 0, 8);
            tlpTitle.Controls.Add(dtp, 1, 9);
            tlpTitle.Dock = DockStyle.Top;
            tlpTitle.Location = new Point(0, 0);
            tlpTitle.Margin = new Padding(2, 2, 2, 2);
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
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpTitle.Size = new Size(328, 389);
            tlpTitle.TabIndex = 8;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.CharacterCasing = CharacterCasing.Upper;
            txtNotes.Location = new Point(72, 298);
            txtNotes.Margin = new Padding(2, 2, 2, 2);
            txtNotes.MaxLength = 4;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(254, 44);
            txtNotes.TabIndex = 17;
            // 
            // nudYtdSales
            // 
            nudYtdSales.Anchor = AnchorStyles.Left;
            nudYtdSales.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudYtdSales.Location = new Point(72, 266);
            nudYtdSales.Margin = new Padding(2, 2, 2, 2);
            nudYtdSales.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudYtdSales.Name = "nudYtdSales";
            nudYtdSales.Size = new Size(126, 23);
            nudYtdSales.TabIndex = 15;
            nudYtdSales.ThousandsSeparator = true;
            // 
            // nudRoyalty
            // 
            nudRoyalty.Anchor = AnchorStyles.Left;
            nudRoyalty.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudRoyalty.Location = new Point(72, 229);
            nudRoyalty.Margin = new Padding(2, 2, 2, 2);
            nudRoyalty.Name = "nudRoyalty";
            nudRoyalty.Size = new Size(126, 23);
            nudRoyalty.TabIndex = 23;
            nudRoyalty.ThousandsSeparator = true;
            // 
            // nudAdvance
            // 
            nudAdvance.Anchor = AnchorStyles.Left;
            nudAdvance.DecimalPlaces = 2;
            nudAdvance.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudAdvance.Location = new Point(72, 192);
            nudAdvance.Margin = new Padding(2, 2, 2, 2);
            nudAdvance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAdvance.Name = "nudAdvance";
            nudAdvance.Size = new Size(126, 23);
            nudAdvance.TabIndex = 11;
            nudAdvance.ThousandsSeparator = true;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Left;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(72, 155);
            nudPrice.Margin = new Padding(2, 2, 2, 2);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(126, 23);
            nudPrice.TabIndex = 9;
            nudPrice.ThousandsSeparator = true;
            // 
            // txtPubId
            // 
            txtPubId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPubId.CharacterCasing = CharacterCasing.Upper;
            txtPubId.Location = new Point(72, 118);
            txtPubId.Margin = new Padding(2, 2, 2, 2);
            txtPubId.MaxLength = 4;
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(254, 23);
            txtPubId.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(72, 44);
            txtTitle.Margin = new Padding(2, 2, 2, 2);
            txtTitle.MaxLength = 80;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 23);
            txtTitle.TabIndex = 3;
            // 
            // lblTitleid
            // 
            lblTitleid.Anchor = AnchorStyles.Right;
            lblTitleid.AutoSize = true;
            lblTitleid.Location = new Point(24, 11);
            lblTitleid.Margin = new Padding(2, 0, 2, 0);
            lblTitleid.Name = "lblTitleid";
            lblTitleid.Size = new Size(44, 15);
            lblTitleid.TabIndex = 0;
            lblTitleid.Text = "Title ID";
            // 
            // lbltitle
            // 
            lbltitle.Anchor = AnchorStyles.Right;
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(38, 48);
            lbltitle.Margin = new Padding(2, 0, 2, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(30, 15);
            lbltitle.TabIndex = 2;
            lbltitle.Text = "Title";
            // 
            // lbltype
            // 
            lbltype.Anchor = AnchorStyles.Right;
            lbltype.AutoSize = true;
            lbltype.Location = new Point(36, 85);
            lbltype.Margin = new Padding(2, 0, 2, 0);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(32, 15);
            lbltype.TabIndex = 4;
            lbltype.Text = "Type";
            // 
            // lblPub_id
            // 
            lblPub_id.Anchor = AnchorStyles.Right;
            lblPub_id.AutoSize = true;
            lblPub_id.Location = new Point(23, 122);
            lblPub_id.Margin = new Padding(2, 0, 2, 0);
            lblPub_id.Name = "lblPub_id";
            lblPub_id.Size = new Size(45, 15);
            lblPub_id.TabIndex = 6;
            lblPub_id.Text = "Pub. ID";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(35, 159);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblAdvance
            // 
            lblAdvance.Anchor = AnchorStyles.Right;
            lblAdvance.AutoSize = true;
            lblAdvance.Location = new Point(15, 196);
            lblAdvance.Margin = new Padding(2, 0, 2, 0);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(53, 15);
            lblAdvance.TabIndex = 10;
            lblAdvance.Text = "Advance";
            // 
            // lblRoyalty
            // 
            lblRoyalty.Anchor = AnchorStyles.Right;
            lblRoyalty.AutoSize = true;
            lblRoyalty.Location = new Point(22, 233);
            lblRoyalty.Margin = new Padding(2, 0, 2, 0);
            lblRoyalty.Name = "lblRoyalty";
            lblRoyalty.Size = new Size(46, 15);
            lblRoyalty.TabIndex = 12;
            lblRoyalty.Text = "Royalty";
            // 
            // lblYtd_sales
            // 
            lblYtd_sales.Anchor = AnchorStyles.Right;
            lblYtd_sales.AutoSize = true;
            lblYtd_sales.Location = new Point(10, 270);
            lblYtd_sales.Margin = new Padding(2, 0, 2, 0);
            lblYtd_sales.Name = "lblYtd_sales";
            lblYtd_sales.Size = new Size(58, 15);
            lblYtd_sales.TabIndex = 14;
            lblYtd_sales.Text = "YTD Sales";
            // 
            // lblPubdate
            // 
            lblPubdate.Anchor = AnchorStyles.Right;
            lblPubdate.AutoSize = true;
            lblPubdate.Location = new Point(10, 359);
            lblPubdate.Margin = new Padding(2, 0, 2, 0);
            lblPubdate.Name = "lblPubdate";
            lblPubdate.Size = new Size(58, 15);
            lblPubdate.TabIndex = 9;
            lblPubdate.Text = "Pub. Date";
            // 
            // txtTitle_id
            // 
            txtTitle_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTitle_id.Location = new Point(72, 7);
            txtTitle_id.Margin = new Padding(2, 2, 2, 2);
            txtTitle_id.MaxLength = 6;
            txtTitle_id.Name = "txtTitle_id";
            txtTitle_id.Size = new Size(254, 23);
            txtTitle_id.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Technical", "Business", "Psychology", "Popular_Comp", "UNDECIDED" });
            comboBox1.Location = new Point(72, 81);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 23);
            comboBox1.TabIndex = 20;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(30, 312);
            lblNotes.Margin = new Padding(2, 0, 2, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 16;
            lblNotes.Text = "Notes";
            // 
            // dtp
            // 
            dtp.Anchor = AnchorStyles.Left;
            dtp.CustomFormat = "yyyy/MM/dd";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(72, 355);
            dtp.Margin = new Padding(2, 2, 2, 2);
            dtp.MaxDate = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(211, 23);
            dtp.TabIndex = 26;
            dtp.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(11, 393);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 28);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 393);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 28);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmTitleDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(328, 432);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tlpTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTitleDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Title";
            Load += frmTitleDetail_Load;
            tlpTitle.ResumeLayout(false);
            tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYtdSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoyalty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdvance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpTitle;
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