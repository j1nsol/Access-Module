namespace Final_project
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LogoutDashboard = new Button();
            panel1 = new Panel();
            UnMinimize = new PictureBox();
            Maximize = new PictureBox();
            Minimize = new PictureBox();
            Close = new PictureBox();
            btnHam = new PictureBox();
            SidebarPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            panel8 = new Panel();
            ProfileButton = new Button();
            panel6 = new Panel();
            Schedulebtn = new Button();
            panel3 = new Panel();
            Gradesbtn = new Button();
            panel5 = new Panel();
            AccountBtn = new Button();
            panel4 = new Panel();
            Registrationpanelbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            Securitybtn = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            SidebarPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // LogoutDashboard
            // 
            LogoutDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutDashboard.Location = new Point(893, 3);
            LogoutDashboard.Name = "LogoutDashboard";
            LogoutDashboard.Size = new Size(94, 35);
            LogoutDashboard.TabIndex = 2;
            LogoutDashboard.Text = "Logout";
            LogoutDashboard.UseVisualStyleBackColor = true;
            LogoutDashboard.Click += LogoutDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(UnMinimize);
            panel1.Controls.Add(Maximize);
            panel1.Controls.Add(LogoutDashboard);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Close);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 44);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // UnMinimize
            // 
            UnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UnMinimize.BackColor = Color.Transparent;
            UnMinimize.Image = (Image)resources.GetObject("UnMinimize.Image");
            UnMinimize.Location = new Point(1018, 7);
            UnMinimize.Name = "UnMinimize";
            UnMinimize.Size = new Size(26, 30);
            UnMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            UnMinimize.TabIndex = 8;
            UnMinimize.TabStop = false;
            UnMinimize.Click += UnMinimize_Click;
            // 
            // Maximize
            // 
            Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximize.BackColor = Color.Transparent;
            Maximize.Image = (Image)resources.GetObject("Maximize.Image");
            Maximize.Location = new Point(1063, 7);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(26, 30);
            Maximize.SizeMode = PictureBoxSizeMode.CenterImage;
            Maximize.TabIndex = 7;
            Maximize.TabStop = false;
            Maximize.Click += pictureBox4_Click;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.BackColor = Color.Transparent;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1063, 7);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(26, 30);
            Minimize.SizeMode = PictureBoxSizeMode.CenterImage;
            Minimize.TabIndex = 6;
            Minimize.TabStop = false;
            Minimize.Visible = false;
            Minimize.Click += pictureBox3_Click;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.BackColor = Color.Transparent;
            Close.Image = (Image)resources.GetObject("Close.Image");
            Close.Location = new Point(1106, 7);
            Close.Name = "Close";
            Close.Size = new Size(26, 30);
            Close.SizeMode = PictureBoxSizeMode.CenterImage;
            Close.TabIndex = 5;
            Close.TabStop = false;
            Close.Click += pictureBox2_Click;
            // 
            // btnHam
            // 
            btnHam.BackColor = Color.Transparent;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(7, 7);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(26, 30);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 4;
            btnHam.TabStop = false;
            btnHam.Click += pictureBox1_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.Black;
            SidebarPanel.Controls.Add(panel2);
            SidebarPanel.Controls.Add(panel8);
            SidebarPanel.Controls.Add(panel6);
            SidebarPanel.Controls.Add(panel3);
            SidebarPanel.Controls.Add(panel5);
            SidebarPanel.Controls.Add(panel4);
            SidebarPanel.Controls.Add(pictureBox1);
            SidebarPanel.Controls.Add(pictureBox2);
            SidebarPanel.Controls.Add(panel7);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 44);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(230, 647);
            SidebarPanel.TabIndex = 4;
            SidebarPanel.Paint += SidebarPanel_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 56);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-7, -47);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(290, 153);
            button1.TabIndex = 5;
            button1.Text = "          Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(ProfileButton);
            panel8.Location = new Point(3, 65);
            panel8.Name = "panel8";
            panel8.Size = new Size(236, 56);
            panel8.TabIndex = 7;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.Black;
            ProfileButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileButton.ForeColor = Color.White;
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileButton.Location = new Point(-8, -50);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Padding = new Padding(25, 0, 0, 0);
            ProfileButton.Size = new Size(284, 153);
            ProfileButton.TabIndex = 5;
            ProfileButton.Text = "          Profile";
            ProfileButton.TextAlign = ContentAlignment.MiddleLeft;
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(Schedulebtn);
            panel6.Location = new Point(3, 127);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 56);
            panel6.TabIndex = 7;
            // 
            // Schedulebtn
            // 
            Schedulebtn.BackColor = Color.Black;
            Schedulebtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Schedulebtn.ForeColor = Color.White;
            Schedulebtn.Image = (Image)resources.GetObject("Schedulebtn.Image");
            Schedulebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Schedulebtn.Location = new Point(-7, -50);
            Schedulebtn.Name = "Schedulebtn";
            Schedulebtn.Padding = new Padding(25, 0, 0, 0);
            Schedulebtn.Size = new Size(290, 153);
            Schedulebtn.TabIndex = 5;
            Schedulebtn.Text = "          Schedule";
            Schedulebtn.TextAlign = ContentAlignment.MiddleLeft;
            Schedulebtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(Gradesbtn);
            panel3.Location = new Point(3, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 56);
            panel3.TabIndex = 7;
            // 
            // Gradesbtn
            // 
            Gradesbtn.BackColor = Color.Black;
            Gradesbtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Gradesbtn.ForeColor = Color.White;
            Gradesbtn.Image = (Image)resources.GetObject("Gradesbtn.Image");
            Gradesbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Gradesbtn.Location = new Point(-7, -50);
            Gradesbtn.Name = "Gradesbtn";
            Gradesbtn.Padding = new Padding(25, 0, 0, 0);
            Gradesbtn.Size = new Size(290, 153);
            Gradesbtn.TabIndex = 5;
            Gradesbtn.Text = "          Grades";
            Gradesbtn.TextAlign = ContentAlignment.MiddleLeft;
            Gradesbtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(AccountBtn);
            panel5.Location = new Point(3, 251);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 56);
            panel5.TabIndex = 7;
            // 
            // AccountBtn
            // 
            AccountBtn.BackColor = Color.Black;
            AccountBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AccountBtn.ForeColor = Color.White;
            AccountBtn.Image = (Image)resources.GetObject("AccountBtn.Image");
            AccountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AccountBtn.Location = new Point(-7, -50);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Padding = new Padding(25, 0, 0, 0);
            AccountBtn.Size = new Size(290, 153);
            AccountBtn.TabIndex = 5;
            AccountBtn.Text = "          Account";
            AccountBtn.TextAlign = ContentAlignment.MiddleLeft;
            AccountBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Registrationpanelbtn);
            panel4.Location = new Point(3, 313);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 56);
            panel4.TabIndex = 7;
            // 
            // Registrationpanelbtn
            // 
            Registrationpanelbtn.BackColor = Color.Black;
            Registrationpanelbtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Registrationpanelbtn.ForeColor = Color.White;
            Registrationpanelbtn.Image = (Image)resources.GetObject("Registrationpanelbtn.Image");
            Registrationpanelbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Registrationpanelbtn.Location = new Point(-7, -50);
            Registrationpanelbtn.Name = "Registrationpanelbtn";
            Registrationpanelbtn.Padding = new Padding(25, 0, 0, 0);
            Registrationpanelbtn.Size = new Size(290, 153);
            Registrationpanelbtn.TabIndex = 5;
            Registrationpanelbtn.Text = "          Registration";
            Registrationpanelbtn.TextAlign = ContentAlignment.MiddleLeft;
            Registrationpanelbtn.UseVisualStyleBackColor = false;
            Registrationpanelbtn.Click += Registrationpanelbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(3, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 437);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 10);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(Securitybtn);
            panel7.Location = new Point(0, 450);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 56);
            panel7.TabIndex = 7;
            // 
            // Securitybtn
            // 
            Securitybtn.BackColor = Color.Black;
            Securitybtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Securitybtn.ForeColor = Color.White;
            Securitybtn.Image = (Image)resources.GetObject("Securitybtn.Image");
            Securitybtn.ImageAlign = ContentAlignment.MiddleLeft;
            Securitybtn.Location = new Point(-9, -13);
            Securitybtn.Margin = new Padding(0);
            Securitybtn.Name = "Securitybtn";
            Securitybtn.Padding = new Padding(25, 0, 0, 0);
            Securitybtn.Size = new Size(266, 80);
            Securitybtn.TabIndex = 5;
            Securitybtn.Text = "          Security";
            Securitybtn.TextAlign = ContentAlignment.MiddleLeft;
            Securitybtn.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += timer1_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 691);
            Controls.Add(SidebarPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1137, 691);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            SidebarPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button LogoutDashboard;
        private Button Registrationpanelbtn;
        private Panel panel1;
        private PictureBox btnHam;
        private PictureBox Maximize;
        private PictureBox Minimize;
        private PictureBox Close;
        private FlowLayoutPanel SidebarPanel;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button Gradesbtn;
        private Panel panel4;
        private Panel panel5;
        private Button AccountBtn;
        private Panel panel6;
        private Button Schedulebtn;
        private Panel panel7;
        private Button Securitybtn;
        private Panel panel8;
        private Button ProfileButton;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox UnMinimize;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}