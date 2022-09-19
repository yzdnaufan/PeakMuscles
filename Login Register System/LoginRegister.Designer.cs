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
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 56);
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
            this.btnGoToLogin.Location = new System.Drawing.Point(76, 98);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(280, 80);
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
            this.btnGoToRegister.Location = new System.Drawing.Point(353, 98);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(280, 80);
            this.btnGoToRegister.TabIndex = 2;
            this.btnGoToRegister.Text = "Register";
            this.btnGoToRegister.UseVisualStyleBackColor = false;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.txtPasswordLogin);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.txtUsernameLogin);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Location = new System.Drawing.Point(76, 184);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(557, 443);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.Location = new System.Drawing.Point(172, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(131, 183);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(298, 31);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(131, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(131, 112);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(298, 31);
            this.txtUsernameLogin.TabIndex = 3;
            this.txtUsernameLogin.TextChanged += new System.EventHandler(this.txtUsernameLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registerPanel.Controls.Add(this.txtConfPass);
            this.registerPanel.Controls.Add(this.label8);
            this.registerPanel.Controls.Add(this.txtFullName);
            this.registerPanel.Controls.Add(this.label7);
            this.registerPanel.Controls.Add(this.txtAge);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.btnRegister);
            this.registerPanel.Controls.Add(this.txtNewPass);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.txtNewUsername);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Location = new System.Drawing.Point(76, 184);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(557, 443);
            this.registerPanel.TabIndex = 0;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(132, 318);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(298, 31);
            this.txtConfPass.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(132, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Confirm Password";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(132, 45);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(298, 31);
            this.txtFullName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(132, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Full Name";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 112);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(298, 31);
            this.txtAge.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(132, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Age";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnRegister.Location = new System.Drawing.Point(173, 380);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 50);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "JOIN";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(132, 248);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(298, 31);
            this.txtNewPass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(132, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(132, 177);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(298, 31);
            this.txtNewUsername.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(132, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(721, 651);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private TextBox txtPasswordLogin;
        private Label label3;
        private TextBox txtUsernameLogin;
        private Label label2;
        private Panel registerPanel;
        private TextBox txtFullName;
        private Label label7;
        private Button btnRegister;
        private Label label8;
        private TextBox txtAge;
        private Label label6;
        private TextBox txtNewPass;
        private Label label4;
        private TextBox txtNewUsername;
        private Label label5;
        private TextBox txtConfPass;
    }
}