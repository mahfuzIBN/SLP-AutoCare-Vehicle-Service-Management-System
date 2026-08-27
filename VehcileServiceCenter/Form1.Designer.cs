namespace VehicleServiceCenter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlBrand = new Panel();
            label2 = new Label();
            lblBrandTitle = new Label();
            picVehicle = new PictureBox();
            lblWelcome = new Label();
            lblLoginSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVehicle).BeginInit();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.DarkSlateGray;
            pnlBrand.Controls.Add(label2);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.ForeColor = Color.White;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(420, 553);
            pnlBrand.TabIndex = 1;
            pnlBrand.Paint += pnlBrand_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Console", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(40, 101);
            label2.Name = "label2";
            label2.Size = new Size(340, 40);
            label2.TabIndex = 3;
            label2.Text = "Vehicle Service Center Management System";
            label2.Click += label2_Click;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.BackColor = Color.Transparent;
            lblBrandTitle.Font = new Font("ROG Fonts STRIX SCAR", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBrandTitle.Location = new Point(30, 45);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(360, 50);
            lblBrandTitle.TabIndex = 2;
            lblBrandTitle.Text = "SLP AutoCare";
            lblBrandTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblBrandTitle.Click += label1_Click;
            // 
            // picVehicle
            // 
            picVehicle.BackColor = Color.DarkSlateGray;
            picVehicle.Image = (Image)resources.GetObject("picVehicle.Image");
            picVehicle.Location = new Point(30, 140);
            picVehicle.Name = "picVehicle";
            picVehicle.Size = new Size(360, 250);
            picVehicle.SizeMode = PictureBoxSizeMode.Zoom;
            picVehicle.TabIndex = 2;
            picVehicle.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DarkSlateGray;
            lblWelcome.Location = new Point(500, 105);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(340, 45);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome Back";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.BackColor = Color.Transparent;
            lblLoginSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginSubtitle.ForeColor = Color.DimGray;
            lblLoginSubtitle.Location = new Point(503, 155);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(340, 30);
            lblLoginSubtitle.TabIndex = 4;
            lblLoginSubtitle.Text = "Sign in to continue to your dashboard";
            lblLoginSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            lblLoginSubtitle.Click += label1_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkSlateGray;
            lblUsername.Location = new Point(500, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(330, 25);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(500, 240);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(330, 31);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(500, 320);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(330, 31);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DarkSlateGray;
            lblPassword.Location = new Point(500, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            lblPassword.Click += label1_Click_2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(500, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 42);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.FlatStyle = FlatStyle.Flat;
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(715, 355);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(130, 24);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 553);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(picVehicle);
            Controls.Add(pnlBrand);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLP AutoCare Service Center- Login";
            pnlBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBrand;
        private Label lblBrandTitle;
        private Label label2;
        private PictureBox picVehicle;
        private Label lblWelcome;
        private Label lblLoginSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private CheckBox chkShowPassword;
    }
}
