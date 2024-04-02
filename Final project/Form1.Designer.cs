namespace Final_project
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
            label1 = new Label();
            LoginUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginPassword = new TextBox();
            LoginPanel = new Panel();
            SignupPanel = new Panel();
            panel4 = new Panel();
            BackSingup = new Button();
            label12 = new Label();
            ConfirmEmail = new TextBox();
            label11 = new Label();
            EmailSignup = new TextBox();
            SignupSuccess = new Label();
            ErrorText = new Label();
            label8 = new Label();
            PasswordSignup = new TextBox();
            label9 = new Label();
            SignupAccess = new Button();
            ErrorLogin = new Label();
            LoginAccess = new Button();
            panel2 = new Panel();
            BackLogin = new Button();
            label4 = new Label();
            label5 = new Label();
            label13 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            SignupButton = new ReaLTaiizor.Controls.Button();
            LoginButton = new ReaLTaiizor.Controls.Button();
            LoginPanel.SuspendLayout();
            SignupPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 158);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 0;
            label1.Text = "Access Module";
            // 
            // LoginUsername
            // 
            LoginUsername.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUsername.Location = new Point(85, 260);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(263, 31);
            LoginUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 233);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 306);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // LoginPassword
            // 
            LoginPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LoginPassword.Location = new Point(85, 324);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.PasswordChar = '*';
            LoginPassword.Size = new Size(263, 31);
            LoginPassword.TabIndex = 3;
            LoginPassword.KeyPress += LoginPassword_KeyPress;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.WhiteSmoke;
            LoginPanel.Controls.Add(SignupPanel);
            LoginPanel.Controls.Add(ErrorLogin);
            LoginPanel.Controls.Add(LoginAccess);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(LoginUsername);
            LoginPanel.Controls.Add(LoginPassword);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(panel2);
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(529, 821);
            LoginPanel.TabIndex = 5;
            LoginPanel.Visible = false;
            // 
            // SignupPanel
            // 
            SignupPanel.BackColor = Color.WhiteSmoke;
            SignupPanel.Controls.Add(panel4);
            SignupPanel.Controls.Add(label12);
            SignupPanel.Controls.Add(ConfirmEmail);
            SignupPanel.Controls.Add(label11);
            SignupPanel.Controls.Add(EmailSignup);
            SignupPanel.Controls.Add(SignupSuccess);
            SignupPanel.Controls.Add(ErrorText);
            SignupPanel.Controls.Add(label8);
            SignupPanel.Controls.Add(PasswordSignup);
            SignupPanel.Controls.Add(label9);
            SignupPanel.Controls.Add(SignupAccess);
            SignupPanel.Location = new Point(0, 0);
            SignupPanel.Name = "SignupPanel";
            SignupPanel.Size = new Size(444, 821);
            SignupPanel.TabIndex = 6;
            SignupPanel.Visible = false;
            SignupPanel.Paint += SignupPanel_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(BackSingup);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 48);
            panel4.TabIndex = 18;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            panel4.MouseUp += panel4_MouseUp;
            // 
            // BackSingup
            // 
            BackSingup.FlatAppearance.BorderSize = 0;
            BackSingup.FlatStyle = FlatStyle.Flat;
            BackSingup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackSingup.Image = (Image)resources.GetObject("BackSingup.Image");
            BackSingup.ImageAlign = ContentAlignment.MiddleLeft;
            BackSingup.Location = new Point(8, 10);
            BackSingup.Name = "BackSingup";
            BackSingup.Size = new Size(77, 26);
            BackSingup.TabIndex = 8;
            BackSingup.Text = "       Back";
            BackSingup.TextAlign = ContentAlignment.MiddleLeft;
            BackSingup.UseVisualStyleBackColor = true;
            BackSingup.Click += BackSingup_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 304);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 17;
            label12.Text = "Confirm Email:";
            // 
            // ConfirmEmail
            // 
            ConfirmEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmEmail.Location = new Point(25, 322);
            ConfirmEmail.Name = "ConfirmEmail";
            ConfirmEmail.Size = new Size(375, 31);
            ConfirmEmail.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 249);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 15;
            label11.Text = "Email:";
            // 
            // EmailSignup
            // 
            EmailSignup.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailSignup.Location = new Point(25, 267);
            EmailSignup.Name = "EmailSignup";
            EmailSignup.Size = new Size(375, 31);
            EmailSignup.TabIndex = 14;
            // 
            // SignupSuccess
            // 
            SignupSuccess.AutoSize = true;
            SignupSuccess.BackColor = Color.Transparent;
            SignupSuccess.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignupSuccess.ForeColor = Color.Green;
            SignupSuccess.Location = new Point(107, 154);
            SignupSuccess.Name = "SignupSuccess";
            SignupSuccess.Size = new Size(198, 15);
            SignupSuccess.TabIndex = 11;
            SignupSuccess.Text = "Signup successfully, you may log in.";
            SignupSuccess.Visible = false;
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.BackColor = Color.Transparent;
            ErrorText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(132, 511);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(28, 15);
            ErrorText.TabIndex = 13;
            ErrorText.Text = "Text";
            ErrorText.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 359);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 4;
            label8.Text = "Password:";
            // 
            // PasswordSignup
            // 
            PasswordSignup.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordSignup.Location = new Point(25, 377);
            PasswordSignup.Name = "PasswordSignup";
            PasswordSignup.Size = new Size(375, 31);
            PasswordSignup.TabIndex = 3;
            PasswordSignup.KeyPress += PasswordSignup_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SansSerif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(110, 178);
            label9.Name = "label9";
            label9.Size = new Size(195, 31);
            label9.TabIndex = 0;
            label9.Text = "Access Module";
            // 
            // SignupAccess
            // 
            SignupAccess.Location = new Point(317, 430);
            SignupAccess.Name = "SignupAccess";
            SignupAccess.Size = new Size(83, 27);
            SignupAccess.TabIndex = 7;
            SignupAccess.Text = "Signup";
            SignupAccess.UseVisualStyleBackColor = true;
            SignupAccess.Click += SignupAccess_Click;
            // 
            // ErrorLogin
            // 
            ErrorLogin.AutoSize = true;
            ErrorLogin.BackColor = Color.Transparent;
            ErrorLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLogin.ForeColor = Color.Red;
            ErrorLogin.Location = new Point(132, 391);
            ErrorLogin.Name = "ErrorLogin";
            ErrorLogin.Size = new Size(167, 15);
            ErrorLogin.TabIndex = 10;
            ErrorLogin.Text = "Invalid username or password.";
            ErrorLogin.Visible = false;
            ErrorLogin.Click += label6_Click;
            // 
            // LoginAccess
            // 
            LoginAccess.Location = new Point(265, 361);
            LoginAccess.Name = "LoginAccess";
            LoginAccess.Size = new Size(83, 27);
            LoginAccess.TabIndex = 8;
            LoginAccess.Text = "Login";
            LoginAccess.UseVisualStyleBackColor = true;
            LoginAccess.Click += LoginAccess_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(BackLogin);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 48);
            panel2.TabIndex = 12;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // BackLogin
            // 
            BackLogin.FlatAppearance.BorderSize = 0;
            BackLogin.FlatStyle = FlatStyle.Flat;
            BackLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackLogin.Image = (Image)resources.GetObject("BackLogin.Image");
            BackLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BackLogin.Location = new Point(8, 10);
            BackLogin.Name = "BackLogin";
            BackLogin.Size = new Size(75, 26);
            BackLogin.TabIndex = 9;
            BackLogin.Text = "       Back";
            BackLogin.TextAlign = ContentAlignment.MiddleLeft;
            BackLogin.UseVisualStyleBackColor = true;
            BackLogin.Click += BackLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("GENISO", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(426, 55);
            label4.TabIndex = 1;
            label4.Text = "INSTITUTE OF TECHNOLOGY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("GENISO", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(94, 154);
            label5.Name = "label5";
            label5.Size = new Size(247, 65);
            label5.TabIndex = 0;
            label5.Text = "WELCOME TO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("GENISO", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(127, 239);
            label13.Name = "label13";
            label13.Size = new Size(200, 55);
            label13.TabIndex = 6;
            label13.Text = "UNIVERSITY";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(370, 10);
            button1.Name = "button1";
            button1.Size = new Size(64, 27);
            button1.TabIndex = 10;
            button1.Text = "Exit     ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 48);
            panel1.TabIndex = 11;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(LoginPanel);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(SignupButton);
            panel3.Controls.Add(LoginButton);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 825);
            panel3.TabIndex = 12;
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.Transparent;
            SignupButton.BorderColor = Color.FromArgb(32, 34, 37);
            SignupButton.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            SignupButton.EnteredColor = Color.FromArgb(32, 34, 37);
            SignupButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignupButton.Image = null;
            SignupButton.ImageAlign = ContentAlignment.MiddleLeft;
            SignupButton.InactiveColor = Color.FromArgb(32, 34, 37);
            SignupButton.Location = new Point(164, 430);
            SignupButton.Name = "SignupButton";
            SignupButton.PressedBorderColor = Color.FromArgb(165, 37, 37);
            SignupButton.PressedColor = Color.FromArgb(165, 37, 37);
            SignupButton.Size = new Size(117, 58);
            SignupButton.TabIndex = 13;
            SignupButton.Text = "Signup";
            SignupButton.TextAlignment = StringAlignment.Center;
            SignupButton.Click += SignupButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BorderColor = Color.FromArgb(32, 34, 37);
            LoginButton.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            LoginButton.EnteredColor = Color.FromArgb(32, 34, 37);
            LoginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Image = null;
            LoginButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginButton.InactiveColor = Color.FromArgb(32, 34, 37);
            LoginButton.Location = new Point(164, 366);
            LoginButton.Name = "LoginButton";
            LoginButton.PressedBorderColor = Color.FromArgb(165, 37, 37);
            LoginButton.PressedColor = Color.FromArgb(165, 37, 37);
            LoginButton.Size = new Size(117, 58);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Login";
            LoginButton.TextAlignment = StringAlignment.Center;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 816);
            Controls.Add(panel3);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(442, 816);
            MinimumSize = new Size(442, 816);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JXIT-U Access Module";
            Load += Form1_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            SignupPanel.ResumeLayout(false);
            SignupPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox LoginUsername;
        private Label label2;
        private Label label3;
        private TextBox LoginPassword;
        private Panel LoginPanel;
        private Button LoginAccess;
        private Label label4;
        private Label label5;
        private Panel SignupPanel;
        private Label label8;
        private TextBox PasswordSignup;
        private Label label9;
        private Button SignupAccess;
        private Button BackSingup;
        private Label ErrorLogin;
        private Label ErrorText;
        private Label SignupSuccess;
        private Label label12;
        private TextBox ConfirmEmail;
        private Label label11;
        private TextBox EmailSignup;
        private Label label13;
        private Button button1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button BackLogin;
        private ReaLTaiizor.Controls.Button LoginButton;
        private ReaLTaiizor.Controls.Button SignupButton;
    }
}