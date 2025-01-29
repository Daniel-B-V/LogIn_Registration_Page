namespace LogInPage
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
        private void signUpEmail_TextChanged(object sender, EventArgs e)
        {
            // Your code to handle the email text changed event
            Console.WriteLine("Email text changed: " + signUpEmail.Text);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            signInBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            signInCloseBtn = new Label();
            label3 = new Label();
            signUpPassword = new TextBox();
            SignInPassword = new TextBox();
            label7 = new Label();
            SignInShowPass = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            signUpUsername = new TextBox();
            signInUsername = new TextBox();
            signUpEmail = new TextBox();
            signInEmail = new TextBox();
            signUpBtn = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(signInBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 411);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // signInBtn
            // 
            signInBtn.Cursor = Cursors.Hand;
            signInBtn.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInBtn.Location = new Point(77, 217);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(112, 39);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "Sign-In";
            signInBtn.UseVisualStyleBackColor = true;
            signInBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 150);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 1;
            label2.Text = "         \"Stay connected! Log in with your \r\npersonal information to access your account.\"";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 99);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(signInCloseBtn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(signUpPassword);
            panel3.Controls.Add(SignInPassword);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(SignInShowPass);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(signUpUsername);
            panel3.Controls.Add(signInUsername);
            panel3.Controls.Add(signUpEmail);
            panel3.Controls.Add(signInEmail);
            panel3.Controls.Add(signUpBtn);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(271, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 411);
            panel3.TabIndex = 3;
            // 
            // signInCloseBtn
            // 
            signInCloseBtn.Anchor = AnchorStyles.None;
            signInCloseBtn.AutoSize = true;
            signInCloseBtn.Cursor = Cursors.Hand;
            signInCloseBtn.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInCloseBtn.Location = new Point(342, 4);
            signInCloseBtn.Name = "signInCloseBtn";
            signInCloseBtn.Size = new Size(17, 17);
            signInCloseBtn.TabIndex = 11;
            signInCloseBtn.Text = "X";
            signInCloseBtn.Click += signInCloseBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 234);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // signUpPassword
            // 
            signUpPassword.Font = new Font("Sitka Banner", 12F);
            signUpPassword.Location = new Point(51, 256);
            signUpPassword.Multiline = true;
            signUpPassword.Name = "signUpPassword";
            signUpPassword.PasswordChar = '*';
            signUpPassword.Size = new Size(257, 31);
            signUpPassword.TabIndex = 9;
            // 
            // SignInPassword
            // 
            SignInPassword.Font = new Font("Tahoma", 11.25F);
            SignInPassword.Location = new Point(58, 256);
            SignInPassword.Multiline = true;
            SignInPassword.Name = "SignInPassword";
            SignInPassword.PasswordChar = '*';
            SignInPassword.Size = new Size(250, 31);
            SignInPassword.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 24);
            label7.Name = "label7";
            label7.Size = new Size(253, 44);
            label7.TabIndex = 8;
            label7.Text = "Let's Get Started";
            // 
            // SignInShowPass
            // 
            SignInShowPass.AutoSize = true;
            SignInShowPass.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInShowPass.ForeColor = SystemColors.AppWorkspace;
            SignInShowPass.Location = new Point(201, 293);
            SignInShowPass.Name = "SignInShowPass";
            SignInShowPass.Size = new Size(107, 23);
            SignInShowPass.TabIndex = 7;
            SignInShowPass.Text = "Show password";
            SignInShowPass.UseVisualStyleBackColor = true;
            SignInShowPass.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(51, 173);
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
            label9.Location = new Point(51, 117);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 5;
            label9.Text = "Email Address:";
            // 
            // signUpUsername
            // 
            signUpUsername.Font = new Font("Sitka Banner", 12F);
            signUpUsername.Location = new Point(51, 195);
            signUpUsername.Multiline = true;
            signUpUsername.Name = "signUpUsername";
            signUpUsername.Size = new Size(257, 31);
            signUpUsername.TabIndex = 4;
            // 
            // signInUsername
            // 
            signInUsername.Font = new Font("Tahoma", 11.25F);
            signInUsername.Location = new Point(58, 195);
            signInUsername.Multiline = true;
            signInUsername.Name = "signInUsername";
            signInUsername.Size = new Size(250, 31);
            signInUsername.TabIndex = 4;
            // 
            // signUpEmail
            // 
            signUpEmail.Font = new Font("Sitka Banner", 12F);
            signUpEmail.Location = new Point(51, 139);
            signUpEmail.Multiline = true;
            signUpEmail.Name = "signUpEmail";
            signUpEmail.Size = new Size(257, 31);
            signUpEmail.TabIndex = 2;
            signUpEmail.TextChanged += signUpEmail_TextChanged;
            // 
            // signInEmail
            // 
            signInEmail.Font = new Font("Tahoma", 11.25F);
            signInEmail.Location = new Point(58, 139);
            signInEmail.Multiline = true;
            signInEmail.Name = "signInEmail";
            signInEmail.Size = new Size(250, 31);
            signInEmail.TabIndex = 2;
            // 
            // signUpBtn
            // 
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpBtn.Location = new Point(125, 337);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(115, 42);
            signUpBtn.TabIndex = 1;
            signUpBtn.Text = "Sign-Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(111, 77);
            label10.Name = "label10";
            label10.Size = new Size(129, 22);
            label10.TabIndex = 0;
            label10.Text = "Create Account!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 411);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button signInBtn;
        private Panel panel3;
        private Label label7;
        private CheckBox SignInShowPass;
        private Label label8;
        private Label label9;
        private TextBox signInUsername;
        private TextBox signInEmail;
        private Button signUpBtn;
        private Label label10;
        private Label label3;
        private TextBox SignInPassword;
        private Label signInCloseBtn;
        private TextBox signUpPassword;
        private TextBox signUpUsername;
        private TextBox signUpEmail;
    }
}
