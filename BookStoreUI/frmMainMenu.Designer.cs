namespace BookStoreUI
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            btnCustomerOrder = new Button();
            btnTitleMaintenance = new Button();
            btnAuthorMaintenance = new Button();
            btnPublisherMaintenance = new Button();
            btnStoreMaintenance = new Button();
            btnEmployeeMaintenance = new Button();
            btnReports = new Button();
            btnExit = new Button();
            grpMainMenuOptions = new GroupBox();
            picBookStore = new PictureBox();
            grpMainMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookStore).BeginInit();
            SuspendLayout();
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.Location = new Point(5, 21);
            btnCustomerOrder.Margin = new Padding(2);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(228, 35);
            btnCustomerOrder.TabIndex = 1;
            btnCustomerOrder.Text = "Customer Order (Shopping Cart)";
            btnCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // btnTitleMaintenance
            // 
            btnTitleMaintenance.Location = new Point(5, 60);
            btnTitleMaintenance.Margin = new Padding(2);
            btnTitleMaintenance.Name = "btnTitleMaintenance";
            btnTitleMaintenance.Size = new Size(228, 35);
            btnTitleMaintenance.TabIndex = 2;
            btnTitleMaintenance.Text = "Title Maintenance \r\n";
            btnTitleMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnAuthorMaintenance
            // 
            btnAuthorMaintenance.Location = new Point(5, 99);
            btnAuthorMaintenance.Margin = new Padding(2);
            btnAuthorMaintenance.Name = "btnAuthorMaintenance";
            btnAuthorMaintenance.Size = new Size(228, 35);
            btnAuthorMaintenance.TabIndex = 3;
            btnAuthorMaintenance.Text = "Author Maintenance";
            btnAuthorMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnPublisherMaintenance
            // 
            btnPublisherMaintenance.Location = new Point(5, 138);
            btnPublisherMaintenance.Margin = new Padding(2);
            btnPublisherMaintenance.Name = "btnPublisherMaintenance";
            btnPublisherMaintenance.Size = new Size(228, 35);
            btnPublisherMaintenance.TabIndex = 4;
            btnPublisherMaintenance.Text = "Publisher Maintenance";
            btnPublisherMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnStoreMaintenance
            // 
            btnStoreMaintenance.Location = new Point(5, 177);
            btnStoreMaintenance.Margin = new Padding(2);
            btnStoreMaintenance.Name = "btnStoreMaintenance";
            btnStoreMaintenance.Size = new Size(228, 35);
            btnStoreMaintenance.TabIndex = 5;
            btnStoreMaintenance.Text = "Store Maintenance ";
            btnStoreMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeMaintenance
            // 
            btnEmployeeMaintenance.Location = new Point(5, 216);
            btnEmployeeMaintenance.Margin = new Padding(2);
            btnEmployeeMaintenance.Name = "btnEmployeeMaintenance";
            btnEmployeeMaintenance.Size = new Size(228, 35);
            btnEmployeeMaintenance.TabIndex = 6;
            btnEmployeeMaintenance.Text = "Employee Maintenance";
            btnEmployeeMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(5, 255);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(228, 35);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(460, 292);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 35);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpMainMenuOptions
            // 
            grpMainMenuOptions.Controls.Add(btnReports);
            grpMainMenuOptions.Controls.Add(btnEmployeeMaintenance);
            grpMainMenuOptions.Controls.Add(btnStoreMaintenance);
            grpMainMenuOptions.Controls.Add(btnPublisherMaintenance);
            grpMainMenuOptions.Controls.Add(btnAuthorMaintenance);
            grpMainMenuOptions.Controls.Add(btnTitleMaintenance);
            grpMainMenuOptions.Controls.Add(btnCustomerOrder);
            grpMainMenuOptions.ForeColor = SystemColors.ControlText;
            grpMainMenuOptions.Location = new Point(12, 12);
            grpMainMenuOptions.Name = "grpMainMenuOptions";
            grpMainMenuOptions.Size = new Size(238, 312);
            grpMainMenuOptions.TabIndex = 9;
            grpMainMenuOptions.TabStop = false;
            grpMainMenuOptions.Text = "Select an Option";
            // 
            // picBookStore
            // 
            picBookStore.Image = (Image)resources.GetObject("picBookStore.Image");
            picBookStore.Location = new Point(256, 12);
            picBookStore.Name = "picBookStore";
            picBookStore.Size = new Size(275, 275);
            picBookStore.SizeMode = PictureBoxSizeMode.StretchImage;
            picBookStore.TabIndex = 10;
            picBookStore.TabStop = false;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(543, 336);
            Controls.Add(picBookStore);
            Controls.Add(grpMainMenuOptions);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            grpMainMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBookStore).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCustomerOrder;
        private Button btnTitleMaintenance;
        private Button btnAuthorMaintenance;
        private Button btnPublisherMaintenance;
        private Button btnStoreMaintenance;
        private Button btnEmployeeMaintenance;
        private Button btnReports;
        private Button btnExit;
        private GroupBox grpMainMenuOptions;
        private PictureBox picBookStore;
    }
}