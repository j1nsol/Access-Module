namespace Final_project.AdminTab
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            label1 = new Label();
            label2 = new Label();
            Fname = new ReaLTaiizor.Controls.SmallTextBox();
            Mname = new ReaLTaiizor.Controls.SmallTextBox();
            label3 = new Label();
            Lname = new ReaLTaiizor.Controls.SmallTextBox();
            label4 = new Label();
            Suffix = new ReaLTaiizor.Controls.SmallTextBox();
            label5 = new Label();
            label6 = new Label();
            Program = new ReaLTaiizor.Controls.AloneComboBox();
            Classification = new ReaLTaiizor.Controls.AloneComboBox();
            label7 = new Label();
            Department = new ReaLTaiizor.Controls.AloneComboBox();
            label8 = new Label();
            YearLevel = new ReaLTaiizor.Controls.AloneComboBox();
            label9 = new Label();
            Phone = new ReaLTaiizor.Controls.SmallTextBox();
            label10 = new Label();
            Address1 = new ReaLTaiizor.Controls.SmallTextBox();
            label11 = new Label();
            Address2 = new ReaLTaiizor.Controls.SmallTextBox();
            label12 = new Label();
            Gender = new ReaLTaiizor.Controls.SmallTextBox();
            label13 = new Label();
            Email = new ReaLTaiizor.Controls.SmallTextBox();
            label14 = new Label();
            Password = new ReaLTaiizor.Controls.SmallTextBox();
            label15 = new Label();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            UnMinimize = new PictureBox();
            Maximize = new PictureBox();
            LogoutDashboard = new Button();
            Minimize = new PictureBox();
            Close = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(92, 59);
            label1.TabIndex = 0;
            label1.Text = "[ID]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // Fname
            // 
            Fname.BackColor = Color.Transparent;
            Fname.BorderColor = Color.Black;
            Fname.CustomBGColor = Color.White;
            Fname.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Fname.ForeColor = Color.Black;
            Fname.Location = new Point(150, 87);
            Fname.Margin = new Padding(3, 8, 8, 8);
            Fname.MaxLength = 32767;
            Fname.Multiline = false;
            Fname.Name = "Fname";
            Fname.ReadOnly = false;
            Fname.Size = new Size(128, 28);
            Fname.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Fname.TabIndex = 1;
            Fname.Text = "[First Name]";
            Fname.TextAlignment = HorizontalAlignment.Left;
            Fname.UseSystemPasswordChar = false;
            // 
            // Mname
            // 
            Mname.BackColor = Color.Transparent;
            Mname.BorderColor = Color.Black;
            Mname.CustomBGColor = Color.White;
            Mname.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Mname.ForeColor = Color.Black;
            Mname.Location = new Point(150, 131);
            Mname.Margin = new Padding(3, 8, 8, 8);
            Mname.MaxLength = 32767;
            Mname.Multiline = false;
            Mname.Name = "Mname";
            Mname.ReadOnly = false;
            Mname.Size = new Size(128, 28);
            Mname.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Mname.TabIndex = 2;
            Mname.Text = "[Middle Name]";
            Mname.TextAlignment = HorizontalAlignment.Left;
            Mname.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 131);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 2;
            label3.Text = "Middle Name:";
            // 
            // Lname
            // 
            Lname.BackColor = Color.Transparent;
            Lname.BorderColor = Color.Black;
            Lname.CustomBGColor = Color.White;
            Lname.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Lname.ForeColor = Color.Black;
            Lname.Location = new Point(150, 175);
            Lname.Margin = new Padding(3, 8, 8, 8);
            Lname.MaxLength = 32767;
            Lname.Multiline = false;
            Lname.Name = "Lname";
            Lname.ReadOnly = false;
            Lname.Size = new Size(128, 28);
            Lname.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Lname.TabIndex = 3;
            Lname.Text = "[Family Name]";
            Lname.TextAlignment = HorizontalAlignment.Left;
            Lname.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 175);
            label4.Name = "label4";
            label4.Size = new Size(126, 24);
            label4.TabIndex = 5;
            label4.Text = "Family Name:";
            // 
            // Suffix
            // 
            Suffix.BackColor = Color.Transparent;
            Suffix.BorderColor = Color.Black;
            Suffix.CustomBGColor = Color.White;
            Suffix.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Suffix.ForeColor = Color.Black;
            Suffix.Location = new Point(150, 219);
            Suffix.Margin = new Padding(3, 8, 8, 8);
            Suffix.MaxLength = 32767;
            Suffix.Multiline = false;
            Suffix.Name = "Suffix";
            Suffix.ReadOnly = false;
            Suffix.Size = new Size(128, 28);
            Suffix.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Suffix.TabIndex = 4;
            Suffix.Text = "[Suffix]";
            Suffix.TextAlignment = HorizontalAlignment.Left;
            Suffix.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(84, 219);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 7;
            label5.Text = "Suffix:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(320, 87);
            label6.Name = "label6";
            label6.Size = new Size(87, 24);
            label6.TabIndex = 9;
            label6.Text = "Program:";
            // 
            // Program
            // 
            Program.DrawMode = DrawMode.OwnerDrawFixed;
            Program.DropDownStyle = ComboBoxStyle.DropDownList;
            Program.EnabledCalc = true;
            Program.ForeColor = Color.Black;
            Program.FormattingEnabled = true;
            Program.ItemHeight = 20;
            Program.Items.AddRange(new object[] { "", "BS in Computer Engineering" });
            Program.Location = new Point(413, 87);
            Program.Margin = new Padding(3, 8, 8, 8);
            Program.Name = "Program";
            Program.Size = new Size(140, 26);
            Program.TabIndex = 7;
            // 
            // Classification
            // 
            Classification.DrawMode = DrawMode.OwnerDrawFixed;
            Classification.DropDownStyle = ComboBoxStyle.DropDownList;
            Classification.EnabledCalc = true;
            Classification.FormattingEnabled = true;
            Classification.ItemHeight = 20;
            Classification.Items.AddRange(new object[] { "", "Baccalaureate" });
            Classification.Location = new Point(413, 131);
            Classification.Margin = new Padding(3, 8, 8, 8);
            Classification.Name = "Classification";
            Classification.Size = new Size(140, 26);
            Classification.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(285, 131);
            label7.Name = "label7";
            label7.Size = new Size(122, 24);
            label7.TabIndex = 12;
            label7.Text = "Classification:";
            // 
            // Department
            // 
            Department.DrawMode = DrawMode.OwnerDrawFixed;
            Department.DropDownStyle = ComboBoxStyle.DropDownList;
            Department.EnabledCalc = true;
            Department.FormattingEnabled = true;
            Department.ItemHeight = 20;
            Department.Items.AddRange(new object[] { "", "Freshman", "Sophomore", "Junior", "Senior", "Super Senior", "Legendary Senior", "Mythical Senior" });
            Department.Location = new Point(413, 175);
            Department.Margin = new Padding(3, 8, 8, 8);
            Department.Name = "Department";
            Department.Size = new Size(140, 26);
            Department.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(295, 175);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 14;
            label8.Text = "Department:";
            // 
            // YearLevel
            // 
            YearLevel.DrawMode = DrawMode.OwnerDrawFixed;
            YearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            YearLevel.EnabledCalc = true;
            YearLevel.FormattingEnabled = true;
            YearLevel.ItemHeight = 20;
            YearLevel.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            YearLevel.Location = new Point(413, 219);
            YearLevel.Margin = new Padding(3, 8, 8, 8);
            YearLevel.Name = "YearLevel";
            YearLevel.Size = new Size(140, 26);
            YearLevel.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(303, 219);
            label9.Name = "label9";
            label9.Size = new Size(104, 24);
            label9.TabIndex = 16;
            label9.Text = "Year Level:";
            label9.Click += label9_Click;
            // 
            // Phone
            // 
            Phone.BackColor = Color.Transparent;
            Phone.BorderColor = Color.Black;
            Phone.CustomBGColor = Color.White;
            Phone.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Phone.ForeColor = Color.Black;
            Phone.Location = new Point(150, 263);
            Phone.Margin = new Padding(3, 8, 8, 8);
            Phone.MaxLength = 32767;
            Phone.Multiline = false;
            Phone.Name = "Phone";
            Phone.ReadOnly = false;
            Phone.Size = new Size(128, 28);
            Phone.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Phone.TabIndex = 5;
            Phone.Text = "[Phone]";
            Phone.TextAlignment = HorizontalAlignment.Left;
            Phone.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(73, 263);
            label10.Name = "label10";
            label10.Size = new Size(71, 24);
            label10.TabIndex = 18;
            label10.Text = "Phone:";
            // 
            // Address1
            // 
            Address1.BackColor = Color.Transparent;
            Address1.BorderColor = Color.FromArgb(180, 180, 180);
            Address1.CustomBGColor = Color.White;
            Address1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Address1.ForeColor = Color.Black;
            Address1.Location = new Point(18, 390);
            Address1.Margin = new Padding(3, 8, 8, 8);
            Address1.MaxLength = 32767;
            Address1.Multiline = false;
            Address1.Name = "Address1";
            Address1.ReadOnly = false;
            Address1.Size = new Size(606, 28);
            Address1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Address1.TabIndex = 13;
            Address1.Text = "[Address 1]";
            Address1.TextAlignment = HorizontalAlignment.Left;
            Address1.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 350);
            label11.Margin = new Padding(3, 0, 8, 8);
            label11.Name = "label11";
            label11.Size = new Size(110, 24);
            label11.TabIndex = 20;
            label11.Text = "Address #1:";
            // 
            // Address2
            // 
            Address2.BackColor = Color.Transparent;
            Address2.BorderColor = Color.FromArgb(180, 180, 180);
            Address2.CustomBGColor = Color.White;
            Address2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Address2.ForeColor = Color.Black;
            Address2.Location = new Point(18, 460);
            Address2.Margin = new Padding(3, 8, 8, 8);
            Address2.MaxLength = 32767;
            Address2.Multiline = false;
            Address2.Name = "Address2";
            Address2.ReadOnly = false;
            Address2.Size = new Size(606, 28);
            Address2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Address2.TabIndex = 14;
            Address2.Text = "[Address 2]";
            Address2.TextAlignment = HorizontalAlignment.Left;
            Address2.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 426);
            label12.Margin = new Padding(3, 0, 8, 8);
            label12.Name = "label12";
            label12.Size = new Size(110, 24);
            label12.TabIndex = 22;
            label12.Text = "Address #2:";
            // 
            // Gender
            // 
            Gender.BackColor = Color.Transparent;
            Gender.BorderColor = Color.Black;
            Gender.CustomBGColor = Color.White;
            Gender.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Gender.ForeColor = Color.Black;
            Gender.Location = new Point(413, 263);
            Gender.Margin = new Padding(3, 8, 8, 8);
            Gender.MaxLength = 32767;
            Gender.Multiline = false;
            Gender.Name = "Gender";
            Gender.ReadOnly = false;
            Gender.Size = new Size(140, 28);
            Gender.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Gender.TabIndex = 11;
            Gender.Text = "[Gender]";
            Gender.TextAlignment = HorizontalAlignment.Left;
            Gender.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(328, 263);
            label13.Name = "label13";
            label13.Size = new Size(79, 24);
            label13.TabIndex = 24;
            label13.Text = "Gender:";
            // 
            // Email
            // 
            Email.BackColor = Color.Transparent;
            Email.BorderColor = Color.Black;
            Email.CustomBGColor = Color.White;
            Email.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(413, 307);
            Email.Margin = new Padding(3, 8, 8, 8);
            Email.MaxLength = 32767;
            Email.Multiline = false;
            Email.Name = "Email";
            Email.ReadOnly = false;
            Email.Size = new Size(140, 28);
            Email.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Email.TabIndex = 12;
            Email.Text = "[Email]";
            Email.TextAlignment = HorizontalAlignment.Left;
            Email.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(336, 307);
            label14.Name = "label14";
            label14.Size = new Size(62, 24);
            label14.TabIndex = 26;
            label14.Text = "Email:";
            // 
            // Password
            // 
            Password.BackColor = Color.Transparent;
            Password.BorderColor = Color.Black;
            Password.CustomBGColor = Color.White;
            Password.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(151, 307);
            Password.Margin = new Padding(3, 8, 8, 8);
            Password.MaxLength = 32767;
            Password.Multiline = false;
            Password.Name = "Password";
            Password.ReadOnly = false;
            Password.Size = new Size(127, 28);
            Password.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Password.TabIndex = 6;
            Password.Text = "[Password]";
            Password.TextAlignment = HorizontalAlignment.Left;
            Password.UseSystemPasswordChar = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(47, 307);
            label15.Name = "label15";
            label15.Size = new Size(97, 24);
            label15.TabIndex = 28;
            label15.Text = "Password:";
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.Red;
            cyberButton1.ColorBackground_1 = Color.Red;
            cyberButton1.ColorBackground_2 = Color.Red;
            cyberButton1.ColorBackground_Pen = Color.Red;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.Black;
            cyberButton1.ColorPen_2 = Color.Black;
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = true;
            cyberButton1.Location = new Point(18, 525);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(130, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 29;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Discard Edit";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.Lime;
            cyberButton2.ColorBackground_1 = Color.Lime;
            cyberButton2.ColorBackground_2 = Color.Lime;
            cyberButton2.ColorBackground_Pen = Color.Red;
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.Black;
            cyberButton2.ColorPen_2 = Color.Black;
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton2.ForeColor = Color.Black;
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = true;
            cyberButton2.LinearGradientPen = true;
            cyberButton2.Location = new Point(494, 525);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(130, 50);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 30;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Save Edit";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(UnMinimize);
            panel1.Controls.Add(Maximize);
            panel1.Controls.Add(LogoutDashboard);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 69);
            panel1.TabIndex = 31;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(603, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UnMinimize
            // 
            UnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UnMinimize.BackColor = Color.Transparent;
            UnMinimize.Image = (Image)resources.GetObject("UnMinimize.Image");
            UnMinimize.Location = new Point(1458, 7);
            UnMinimize.Name = "UnMinimize";
            UnMinimize.Size = new Size(26, 30);
            UnMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            UnMinimize.TabIndex = 8;
            UnMinimize.TabStop = false;
            // 
            // Maximize
            // 
            Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximize.BackColor = Color.Transparent;
            Maximize.Image = (Image)resources.GetObject("Maximize.Image");
            Maximize.Location = new Point(1503, 7);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(26, 30);
            Maximize.SizeMode = PictureBoxSizeMode.CenterImage;
            Maximize.TabIndex = 7;
            Maximize.TabStop = false;
            // 
            // LogoutDashboard
            // 
            LogoutDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutDashboard.Location = new Point(1333, 3);
            LogoutDashboard.Name = "LogoutDashboard";
            LogoutDashboard.Size = new Size(94, 35);
            LogoutDashboard.TabIndex = 2;
            LogoutDashboard.Text = "Logout";
            LogoutDashboard.UseVisualStyleBackColor = true;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.BackColor = Color.Transparent;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1503, 7);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(26, 30);
            Minimize.SizeMode = PictureBoxSizeMode.CenterImage;
            Minimize.TabIndex = 6;
            Minimize.TabStop = false;
            Minimize.Visible = false;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.BackColor = Color.Transparent;
            Close.Image = (Image)resources.GetObject("Close.Image");
            Close.Location = new Point(1546, 7);
            Close.Name = "Close";
            Close.Size = new Size(26, 30);
            Close.SizeMode = PictureBoxSizeMode.CenterImage;
            Close.TabIndex = 5;
            Close.TabStop = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(641, 587);
            Controls.Add(panel1);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            Controls.Add(Password);
            Controls.Add(label15);
            Controls.Add(Email);
            Controls.Add(label14);
            Controls.Add(Gender);
            Controls.Add(label13);
            Controls.Add(Address2);
            Controls.Add(label12);
            Controls.Add(Address1);
            Controls.Add(label11);
            Controls.Add(Phone);
            Controls.Add(label10);
            Controls.Add(YearLevel);
            Controls.Add(label9);
            Controls.Add(Department);
            Controls.Add(label8);
            Controls.Add(Classification);
            Controls.Add(label7);
            Controls.Add(Program);
            Controls.Add(label6);
            Controls.Add(Suffix);
            Controls.Add(label5);
            Controls.Add(Lname);
            Controls.Add(label4);
            Controls.Add(Mname);
            Controls.Add(label3);
            Controls.Add(Fname);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditProfile";
            Load += EditProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.SmallTextBox Fname;
        private ReaLTaiizor.Controls.SmallTextBox Mname;
        private Label label3;
        private ReaLTaiizor.Controls.SmallTextBox Lname;
        private Label label4;
        private ReaLTaiizor.Controls.SmallTextBox Suffix;
        private Label label5;
        private Label label6;
        private ReaLTaiizor.Controls.AloneComboBox Program;
        private ReaLTaiizor.Controls.AloneComboBox Classification;
        private Label label7;
        private ReaLTaiizor.Controls.AloneComboBox Department;
        private Label label8;
        private ReaLTaiizor.Controls.AloneComboBox YearLevel;
        private Label label9;
        private ReaLTaiizor.Controls.SmallTextBox Phone;
        private Label label10;
        private ReaLTaiizor.Controls.SmallTextBox Address1;
        private Label label11;
        private ReaLTaiizor.Controls.SmallTextBox Address2;
        private Label label12;
        private ReaLTaiizor.Controls.SmallTextBox Gender;
        private Label label13;
        private ReaLTaiizor.Controls.SmallTextBox Email;
        private Label label14;
        private ReaLTaiizor.Controls.SmallTextBox Password;
        private Label label15;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private Panel panel1;
        private PictureBox UnMinimize;
        private PictureBox Maximize;
        private Button LogoutDashboard;
        private PictureBox Minimize;
        private PictureBox Close;
        private PictureBox pictureBox1;
    }
}