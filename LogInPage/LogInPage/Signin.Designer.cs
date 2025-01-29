namespace LogInPage
{
    partial class Signin
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
            panel3 = new Panel();
            logInCloseBtn = new Label();
            label4 = new Label();
            label3 = new Label();
            logInPassword = new TextBox();
            label7 = new Label();
            logInShowPass = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            logInUsername = new TextBox();
            logInEmail = new TextBox();
            logInBtn = new Button();
            label10 = new Label();
            panel1 = new Panel();
            signUpGoBack = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(logInCloseBtn);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(logInPassword);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(logInShowPass);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(logInUsername);
            panel3.Controls.Add(logInEmail);
            panel3.Controls.Add(logInBtn);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(252, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 411);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // logInCloseBtn
            // 
            logInCloseBtn.Anchor = AnchorStyles.None;
            logInCloseBtn.AutoSize = true;
            logInCloseBtn.Cursor = Cursors.Hand;
            logInCloseBtn.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInCloseBtn.Location = new Point(347, 4);
            logInCloseBtn.Name = "logInCloseBtn";
            logInCloseBtn.Size = new Size(17, 17);
            logInCloseBtn.TabIndex = 12;
            logInCloseBtn.Text = "X";
            logInCloseBtn.Click += logInCloseBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(429, 159);
            label4.Name = "label4";
            label4.Size = new Size(17, 17);
            label4.TabIndex = 11;
            label4.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 234);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // logInPassword
            // 
            logInPassword.Font = new Font("Sitka Banner", 12F);
            logInPassword.Location = new Point(58, 256);
            logInPassword.Multiline = true;
            logInPassword.Name = "logInPassword";
            logInPassword.PasswordChar = '*';
            logInPassword.Size = new Size(250, 31);
            logInPassword.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 23);
            label7.Name = "label7";
            label7.Size = new Size(231, 44);
            label7.TabIndex = 8;
            label7.Text = "Welcome Back!";
            // 
            // logInShowPass
            // 
            logInShowPass.AutoSize = true;
            logInShowPass.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInShowPass.ForeColor = SystemColors.AppWorkspace;
            logInShowPass.Location = new Point(201, 293);
            logInShowPass.Name = "logInShowPass";
            logInShowPass.Size = new Size(107, 23);
            logInShowPass.TabIndex = 7;
            logInShowPass.Text = "Show password";
            logInShowPass.UseVisualStyleBackColor = true;
            logInShowPass.CheckedChanged += logInShowPass_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 173);
            label8.Name = "label8";
            label8.Size = new Size(66, 19);
            label8.TabIndex = 6;
            label8.Text = "Username:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(58, 116);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 5;
            label9.Text = "Email Address:";
            // 
            // logInUsername
            // 
            logInUsername.Font = new Font("Sitka Banner", 12F);
            logInUsername.Location = new Point(58, 195);
            logInUsername.Multiline = true;
            logInUsername.Name = "logInUsername";
            logInUsername.Size = new Size(250, 31);
            logInUsername.TabIndex = 4;
            // 
            // logInEmail
            // 
            logInEmail.Font = new Font("Sitka Banner", 12F);
            logInEmail.Location = new Point(58, 139);
            logInEmail.Multiline = true;
            logInEmail.Name = "logInEmail";
            logInEmail.Size = new Size(250, 31);
            logInEmail.TabIndex = 2;
            // 
            // logInBtn
            // 
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBtn.Location = new Point(125, 337);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(115, 42);
            logInBtn.TabIndex = 1;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(103, 81);
            label10.Name = "label10";
            label10.Size = new Size(176, 22);
            label10.TabIndex = 0;
            label10.Text = "Sign in Your Account!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(signUpGoBack);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 411);
            panel1.TabIndex = 5;
            // 
            // signUpGoBack
            // 
            signUpGoBack.AutoSize = true;
            signUpGoBack.BackColor = Color.LightSeaGreen;
            signUpGoBack.Cursor = Cursors.Hand;
            signUpGoBack.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            signUpGoBack.ForeColor = SystemColors.ControlDarkDark;
            signUpGoBack.Location = new Point(77, 256);
            signUpGoBack.Name = "signUpGoBack";
            signUpGoBack.Size = new Size(121, 21);
            signUpGoBack.TabIndex = 2;
            signUpGoBack.Text = "Go back to sign up?";
            signUpGoBack.Click += signUpGoBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 150);
            label2.Name = "label2";
            label2.Size = new Size(263, 42);
            label2.TabIndex = 1;
            label2.Text = "   \"Log in to pick up where you left off and \r\n                  keep making memories!\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 107);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 0;
            label1.Text = "Hello, Again!";
            label1.Click += label1_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 411);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private Label label3;
        private TextBox logInPassword;
        private Label label7;
        private CheckBox logInShowPass;
        private Label label8;
        private Label label9;
        private TextBox logInUsername;
        private TextBox logInEmail;
        private Button logInBtn;
        private Label label10;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label signUpGoBack;
        private Label logInCloseBtn;
    }
}