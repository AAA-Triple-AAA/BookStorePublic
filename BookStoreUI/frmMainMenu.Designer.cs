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
            lblSelect = new Label();
            btnCustomerOrder = new Button();
            btnMaintanceTitle = new Button();
            btnMaintanceAuthors = new Button();
            btnMaintancePublishers = new Button();
            btnStores = new Button();
            btnMaintenaceEmployees = new Button();
            btnReports = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(187, 9);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(413, 25);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "Select an Option to manage data ir create an order";
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.Location = new Point(225, 66);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(281, 58);
            btnCustomerOrder.TabIndex = 1;
            btnCustomerOrder.Text = "Customer Order (Shopping Cart)";
            btnCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // btnMaintanceTitle
            // 
            btnMaintanceTitle.Location = new Point(225, 172);
            btnMaintanceTitle.Name = "btnMaintanceTitle";
            btnMaintanceTitle.Size = new Size(281, 58);
            btnMaintanceTitle.TabIndex = 2;
            btnMaintanceTitle.Text = "Maintetance - Titles";
            btnMaintanceTitle.UseVisualStyleBackColor = true;
            // 
            // btnMaintanceAuthors
            // 
            btnMaintanceAuthors.Location = new Point(225, 273);
            btnMaintanceAuthors.Name = "btnMaintanceAuthors";
            btnMaintanceAuthors.Size = new Size(281, 58);
            btnMaintanceAuthors.TabIndex = 3;
            btnMaintanceAuthors.Text = "Maintenance - Authors";
            btnMaintanceAuthors.UseVisualStyleBackColor = true;
            // 
            // btnMaintancePublishers
            // 
            btnMaintancePublishers.Location = new Point(225, 381);
            btnMaintancePublishers.Name = "btnMaintancePublishers";
            btnMaintancePublishers.Size = new Size(281, 58);
            btnMaintancePublishers.TabIndex = 4;
            btnMaintancePublishers.Text = "Maintenance - Publishers";
            btnMaintancePublishers.UseVisualStyleBackColor = true;
            // 
            // btnStores
            // 
            btnStores.Location = new Point(225, 495);
            btnStores.Name = "btnStores";
            btnStores.Size = new Size(281, 58);
            btnStores.TabIndex = 5;
            btnStores.Text = "Maintenance - Stores";
            btnStores.UseVisualStyleBackColor = true;
            // 
            // btnMaintenaceEmployees
            // 
            btnMaintenaceEmployees.Location = new Point(225, 606);
            btnMaintenaceEmployees.Name = "btnMaintenaceEmployees";
            btnMaintenaceEmployees.Size = new Size(281, 58);
            btnMaintenaceEmployees.TabIndex = 6;
            btnMaintenaceEmployees.Text = "Mainenance - Employees";
            btnMaintenaceEmployees.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(225, 713);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(281, 58);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(225, 816);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(281, 58);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 944);
            Controls.Add(btnExit);
            Controls.Add(btnReports);
            Controls.Add(btnMaintenaceEmployees);
            Controls.Add(btnStores);
            Controls.Add(btnMaintancePublishers);
            Controls.Add(btnMaintanceAuthors);
            Controls.Add(btnMaintanceTitle);
            Controls.Add(btnCustomerOrder);
            Controls.Add(lblSelect);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelect;
        private Button btnCustomerOrder;
        private Button btnMaintanceTitle;
        private Button btnMaintanceAuthors;
        private Button btnMaintancePublishers;
        private Button btnStores;
        private Button btnMaintenaceEmployees;
        private Button btnReports;
        private Button btnExit;
    }
}