namespace BookStoreUI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblEmpID = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            cboEmployee = new ComboBox();
            SuspendLayout();
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.Location = new Point(63, 88);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(117, 25);
            lblEmpID.TabIndex = 0;
            lblEmpID.Text = "Employee ID:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(63, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(247, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 48);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cboEmployee
            // 
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(204, 85);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(182, 33);
            cboEmployee.TabIndex = 6;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(461, 242);
            Controls.Add(cboEmployee);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(lblEmpID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpID;
        private Button btnLogin;
        private Button btnExit;
        private ComboBox cboEmployee;
    }
}
