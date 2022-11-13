namespace Login_Register_System
{
    partial class LoginRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.btnGoToRegister = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.lblNotMatch = new System.Windows.Forms.Label();
            this.tbConfPass = new System.Windows.Forms.TextBox();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PeakMuscles";
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnGoToLogin.DialogResult = System.Windows.Forms.DialogResult.TryAgain;
            this.btnGoToLogin.FlatAppearance.BorderSize = 0;
            this.btnGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnGoToLogin.Location = new System.Drawing.Point(61, 78);
            this.btnGoToLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(224, 64);
            this.btnGoToLogin.TabIndex = 1;
            this.btnGoToLogin.Text = "Login";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // btnGoToRegister
            // 
            this.btnGoToRegister.BackColor = System.Drawing.Color.IndianRed;
            this.btnGoToRegister.FlatAppearance.BorderSize = 0;
            this.btnGoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToRegister.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnGoToRegister.Location = new System.Drawing.Point(282, 78);
            this.btnGoToRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(224, 64);
            this.btnGoToRegister.TabIndex = 2;
            this.btnGoToRegister.Text = "Register";
            this.btnGoToRegister.UseVisualStyleBackColor = false;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.tbPasswordLogin);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Controls.Add(this.tbUsernameLogin);
            this.loginPanel.Controls.Add(this.lblUsername);
            this.loginPanel.Location = new System.Drawing.Point(60, 146);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(446, 354);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.Location = new System.Drawing.Point(138, 218);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(105, 146);
            this.tbPasswordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(239, 27);
            this.tbPasswordLogin.TabIndex = 4;
            this.tbPasswordLogin.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPassword.Location = new System.Drawing.Point(105, 126);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 21);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Location = new System.Drawing.Point(105, 90);
            this.tbUsernameLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(239, 27);
            this.tbUsernameLogin.TabIndex = 3;
            this.tbUsernameLogin.TextChanged += new System.EventHandler(this.txtUsernameLogin_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsername.Location = new System.Drawing.Point(105, 69);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registerPanel.Controls.Add(this.lblNotMatch);
            this.registerPanel.Controls.Add(this.tbConfPass);
            this.registerPanel.Controls.Add(this.lblConfPass);
            this.registerPanel.Controls.Add(this.tbFullName);
            this.registerPanel.Controls.Add(this.lblFullName);
            this.registerPanel.Controls.Add(this.tbAge);
            this.registerPanel.Controls.Add(this.lblAge);
            this.registerPanel.Controls.Add(this.btnRegister);
            this.registerPanel.Controls.Add(this.tbNewPass);
            this.registerPanel.Controls.Add(this.lblNewPass);
            this.registerPanel.Controls.Add(this.tbNewUsername);
            this.registerPanel.Controls.Add(this.lblNewUsername);
            this.registerPanel.Location = new System.Drawing.Point(61, 147);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(446, 354);
            this.registerPanel.TabIndex = 0;
            // 
            // lblNotMatch
            // 
            this.lblNotMatch.AutoSize = true;
            this.lblNotMatch.Location = new System.Drawing.Point(278, 236);
            this.lblNotMatch.Name = "lblNotMatch";
            this.lblNotMatch.Size = new System.Drawing.Size(104, 20);
            this.lblNotMatch.TabIndex = 9;
            this.lblNotMatch.Text = "❌ Not Match";
            this.lblNotMatch.Visible = false;
            // 
            // tbConfPass
            // 
            this.tbConfPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbConfPass.Location = new System.Drawing.Point(106, 258);
            this.tbConfPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfPass.Name = "tbConfPass";
            this.tbConfPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConfPass.Size = new System.Drawing.Size(239, 27);
            this.tbConfPass.TabIndex = 7;
            this.tbConfPass.UseSystemPasswordChar = true;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblConfPass.Location = new System.Drawing.Point(106, 234);
            this.lblConfPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(156, 21);
            this.lblConfPass.TabIndex = 0;
            this.lblConfPass.Text = "Confirm Password";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(106, 36);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(239, 27);
            this.tbFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFullName.Location = new System.Drawing.Point(106, 15);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 21);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(106, 90);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(239, 27);
            this.tbAge.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAge.Location = new System.Drawing.Point(106, 69);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 21);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnRegister.Location = new System.Drawing.Point(138, 304);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 40);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "JOIN";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(106, 198);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(239, 27);
            this.tbNewPass.TabIndex = 6;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNewPass.Location = new System.Drawing.Point(106, 178);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(88, 21);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Text = "Password";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(106, 142);
            this.tbNewUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(239, 27);
            this.tbNewUsername.TabIndex = 5;
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNewUsername.Location = new System.Drawing.Point(106, 122);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(93, 21);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "Username";
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(562, 539);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginRegister_FormClosed);
            this.Load += new System.EventHandler(this.LoginRegister_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnGoToLogin;
        private Button btnGoToRegister;
        private Panel loginPanel;
        private Button btnLogin;
        private TextBox tbPasswordLogin;
        private Label lblPassword;
        private TextBox tbUsernameLogin;
        private Label lblUsername;
        private Panel registerPanel;
        private TextBox tbFullName;
        private Label lblFullName;
        private Button btnRegister;
        private Label lblConfPass;
        private TextBox tbAge;
        private Label lblAge;
        private TextBox tbNewPass;
        private Label lblNewPass;
        private TextBox tbNewUsername;
        private Label lblNewUsername;
        private TextBox tbConfPass;
        private Label lblNotMatch;
    }
}