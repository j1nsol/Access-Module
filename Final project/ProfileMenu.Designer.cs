namespace Final_project
{
    partial class ProfileMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileMenu));
            WelcomeText = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            Address1 = new ReaLTaiizor.Controls.SmallTextBox();
            label3 = new Label();
            label1 = new Label();
            FamilyNameBox = new ReaLTaiizor.Controls.SmallTextBox();
            panel1 = new Panel();
            DepartmentBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            ClassificationBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            ProgramBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            YearlevelBox = new ReaLTaiizor.Controls.ComboBoxEdit();
            SubmitButton = new ReaLTaiizor.Controls.Button();
            label10 = new Label();
            PhoneBox = new ReaLTaiizor.Controls.SmallTextBox();
            label9 = new Label();
            GenderBox = new ReaLTaiizor.Controls.SmallTextBox();
            SameAddressCheck = new CheckBox();
            Address2 = new ReaLTaiizor.Controls.SmallTextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SuffixBox = new ReaLTaiizor.Controls.SmallTextBox();
            MiddleNameBox = new ReaLTaiizor.Controls.SmallTextBox();
            FirstNameBox = new ReaLTaiizor.Controls.SmallTextBox();
            Classification = new Label();
            label2 = new Label();
            Department = new Label();
            Program = new Label();
            YearLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeText.Location = new Point(15, 37);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(99, 25);
            WelcomeText.TabIndex = 0;
            WelcomeText.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(883, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 217);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 47;
            label7.Text = "Home Address:";
            // 
            // Address1
            // 
            Address1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Address1.BackColor = Color.Transparent;
            Address1.BorderColor = Color.Black;
            Address1.CustomBGColor = Color.White;
            Address1.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Address1.ForeColor = Color.Black;
            Address1.Location = new Point(33, 248);
            Address1.MaxLength = 32767;
            Address1.Multiline = false;
            Address1.Name = "Address1";
            Address1.ReadOnly = false;
            Address1.Size = new Size(654, 35);
            Address1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Address1.TabIndex = 9;
            Address1.TextAlignment = HorizontalAlignment.Left;
            Address1.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(41, 158);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 42;
            label3.Text = "(Family Name)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(353, 37);
            label1.TabIndex = 28;
            label1.Text = "PERSONAL INFORMATION";
            // 
            // FamilyNameBox
            // 
            FamilyNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FamilyNameBox.BackColor = Color.Transparent;
            FamilyNameBox.BorderColor = Color.Black;
            FamilyNameBox.CustomBGColor = Color.White;
            FamilyNameBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FamilyNameBox.ForeColor = Color.Black;
            FamilyNameBox.Location = new Point(8, 127);
            FamilyNameBox.MaxLength = 32767;
            FamilyNameBox.Multiline = false;
            FamilyNameBox.Name = "FamilyNameBox";
            FamilyNameBox.ReadOnly = false;
            FamilyNameBox.Size = new Size(142, 28);
            FamilyNameBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            FamilyNameBox.TabIndex = 5;
            FamilyNameBox.TextAlignment = HorizontalAlignment.Left;
            FamilyNameBox.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(DepartmentBox);
            panel1.Controls.Add(ClassificationBox);
            panel1.Controls.Add(ProgramBox);
            panel1.Controls.Add(YearlevelBox);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(PhoneBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(GenderBox);
            panel1.Controls.Add(SameAddressCheck);
            panel1.Controls.Add(Address2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SuffixBox);
            panel1.Controls.Add(MiddleNameBox);
            panel1.Controls.Add(FirstNameBox);
            panel1.Controls.Add(Classification);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Program);
            panel1.Controls.Add(Address1);
            panel1.Controls.Add(YearLevel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(FamilyNameBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(7, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 572);
            panel1.TabIndex = 50;
            panel1.Paint += panel1_Paint;
            // 
            // DepartmentBox
            // 
            DepartmentBox.BackColor = Color.FromArgb(246, 246, 246);
            DepartmentBox.DrawMode = DrawMode.OwnerDrawFixed;
            DepartmentBox.DropDownHeight = 100;
            DepartmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentBox.ForeColor = Color.FromArgb(142, 142, 142);
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            DepartmentBox.IntegralHeight = false;
            DepartmentBox.ItemHeight = 20;
            DepartmentBox.Items.AddRange(new object[] { "", "Freshman", "Sophomore", "Junior", "Senior", "Super Senior", "Legendary Senior", "Mythical Senior" });
            DepartmentBox.Location = new Point(8, 57);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(142, 26);
            DepartmentBox.StartIndex = 0;
            DepartmentBox.TabIndex = 73;
            // 
            // ClassificationBox
            // 
            ClassificationBox.BackColor = Color.FromArgb(246, 246, 246);
            ClassificationBox.DrawMode = DrawMode.OwnerDrawFixed;
            ClassificationBox.DropDownHeight = 100;
            ClassificationBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassificationBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ClassificationBox.ForeColor = Color.FromArgb(142, 142, 142);
            ClassificationBox.FormattingEnabled = true;
            ClassificationBox.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            ClassificationBox.IntegralHeight = false;
            ClassificationBox.ItemHeight = 20;
            ClassificationBox.Items.AddRange(new object[] { "", "Baccalaureate" });
            ClassificationBox.Location = new Point(153, 57);
            ClassificationBox.Name = "ClassificationBox";
            ClassificationBox.Size = new Size(145, 26);
            ClassificationBox.StartIndex = 0;
            ClassificationBox.TabIndex = 72;
            // 
            // ProgramBox
            // 
            ProgramBox.BackColor = Color.FromArgb(246, 246, 246);
            ProgramBox.DrawMode = DrawMode.OwnerDrawFixed;
            ProgramBox.DropDownHeight = 100;
            ProgramBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProgramBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramBox.ForeColor = Color.FromArgb(142, 142, 142);
            ProgramBox.FormattingEnabled = true;
            ProgramBox.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            ProgramBox.IntegralHeight = false;
            ProgramBox.ItemHeight = 20;
            ProgramBox.Items.AddRange(new object[] { "", "BS in Computer Engineering" });
            ProgramBox.Location = new Point(303, 57);
            ProgramBox.Name = "ProgramBox";
            ProgramBox.Size = new Size(208, 26);
            ProgramBox.StartIndex = 0;
            ProgramBox.TabIndex = 71;
            // 
            // YearlevelBox
            // 
            YearlevelBox.BackColor = Color.FromArgb(246, 246, 246);
            YearlevelBox.DrawMode = DrawMode.OwnerDrawFixed;
            YearlevelBox.DropDownHeight = 100;
            YearlevelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YearlevelBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            YearlevelBox.ForeColor = Color.FromArgb(142, 142, 142);
            YearlevelBox.FormattingEnabled = true;
            YearlevelBox.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            YearlevelBox.IntegralHeight = false;
            YearlevelBox.ItemHeight = 20;
            YearlevelBox.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            YearlevelBox.Location = new Point(517, 57);
            YearlevelBox.Name = "YearlevelBox";
            YearlevelBox.Size = new Size(135, 26);
            YearlevelBox.StartIndex = 0;
            YearlevelBox.TabIndex = 70;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Transparent;
            SubmitButton.BorderColor = Color.FromArgb(32, 34, 37);
            SubmitButton.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            SubmitButton.EnteredColor = Color.FromArgb(32, 34, 37);
            SubmitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.Image = null;
            SubmitButton.ImageAlign = ContentAlignment.MiddleLeft;
            SubmitButton.InactiveColor = Color.FromArgb(32, 34, 37);
            SubmitButton.Location = new Point(753, 502);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.PressedBorderColor = Color.FromArgb(165, 37, 37);
            SubmitButton.PressedColor = Color.FromArgb(165, 37, 37);
            SubmitButton.Size = new Size(120, 40);
            SubmitButton.TabIndex = 68;
            SubmitButton.Text = "Submit";
            SubmitButton.TextAlignment = StringAlignment.Center;
            SubmitButton.Click += button1_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(181, 410);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 67;
            label10.Text = "Phone";
            // 
            // PhoneBox
            // 
            PhoneBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneBox.BackColor = Color.Transparent;
            PhoneBox.BorderColor = Color.Black;
            PhoneBox.CustomBGColor = Color.White;
            PhoneBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneBox.ForeColor = Color.Black;
            PhoneBox.Location = new Point(156, 442);
            PhoneBox.MaxLength = 32767;
            PhoneBox.Multiline = false;
            PhoneBox.Name = "PhoneBox";
            PhoneBox.ReadOnly = false;
            PhoneBox.Size = new Size(142, 28);
            PhoneBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PhoneBox.TabIndex = 66;
            PhoneBox.TextAlignment = HorizontalAlignment.Left;
            PhoneBox.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 410);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 65;
            label9.Text = "Gender";
            // 
            // GenderBox
            // 
            GenderBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenderBox.BackColor = Color.Transparent;
            GenderBox.BorderColor = Color.Black;
            GenderBox.CustomBGColor = Color.White;
            GenderBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            GenderBox.ForeColor = Color.Black;
            GenderBox.Location = new Point(8, 442);
            GenderBox.MaxLength = 32767;
            GenderBox.Multiline = false;
            GenderBox.Name = "GenderBox";
            GenderBox.ReadOnly = false;
            GenderBox.Size = new Size(142, 28);
            GenderBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GenderBox.TabIndex = 64;
            GenderBox.TextAlignment = HorizontalAlignment.Left;
            GenderBox.UseSystemPasswordChar = false;
            // 
            // SameAddressCheck
            // 
            SameAddressCheck.AutoSize = true;
            SameAddressCheck.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SameAddressCheck.Location = new Point(33, 326);
            SameAddressCheck.Name = "SameAddressCheck";
            SameAddressCheck.Size = new Size(227, 29);
            SameAddressCheck.TabIndex = 63;
            SameAddressCheck.Text = "Same as Home Address";
            SameAddressCheck.UseVisualStyleBackColor = true;
            SameAddressCheck.CheckedChanged += SameAddressCheck_CheckedChanged;
            // 
            // Address2
            // 
            Address2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Address2.BackColor = Color.Transparent;
            Address2.BorderColor = Color.Black;
            Address2.CustomBGColor = Color.White;
            Address2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Address2.ForeColor = Color.Black;
            Address2.Location = new Point(33, 361);
            Address2.MaxLength = 32767;
            Address2.Multiline = false;
            Address2.Name = "Address2";
            Address2.ReadOnly = false;
            Address2.Size = new Size(654, 35);
            Address2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Address2.TabIndex = 61;
            Address2.TextAlignment = HorizontalAlignment.Left;
            Address2.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 291);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 62;
            label8.Text = "City Address:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(517, 158);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 60;
            label6.Text = "(Suffix)";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(334, 158);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 59;
            label5.Text = "(Middle Name)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(194, 158);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 58;
            label4.Text = "(First Name)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SuffixBox
            // 
            SuffixBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SuffixBox.BackColor = Color.Transparent;
            SuffixBox.BorderColor = Color.Black;
            SuffixBox.CustomBGColor = Color.White;
            SuffixBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SuffixBox.ForeColor = Color.Black;
            SuffixBox.Location = new Point(453, 127);
            SuffixBox.MaxLength = 32767;
            SuffixBox.Multiline = false;
            SuffixBox.Name = "SuffixBox";
            SuffixBox.ReadOnly = false;
            SuffixBox.Size = new Size(144, 28);
            SuffixBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SuffixBox.TabIndex = 8;
            SuffixBox.TextAlignment = HorizontalAlignment.Left;
            SuffixBox.UseSystemPasswordChar = false;
            // 
            // MiddleNameBox
            // 
            MiddleNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MiddleNameBox.BackColor = Color.Transparent;
            MiddleNameBox.BorderColor = Color.Black;
            MiddleNameBox.CustomBGColor = Color.White;
            MiddleNameBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameBox.ForeColor = Color.Black;
            MiddleNameBox.Location = new Point(303, 127);
            MiddleNameBox.MaxLength = 32767;
            MiddleNameBox.Multiline = false;
            MiddleNameBox.Name = "MiddleNameBox";
            MiddleNameBox.ReadOnly = false;
            MiddleNameBox.Size = new Size(144, 28);
            MiddleNameBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            MiddleNameBox.TabIndex = 7;
            MiddleNameBox.TextAlignment = HorizontalAlignment.Left;
            MiddleNameBox.UseSystemPasswordChar = false;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FirstNameBox.BackColor = Color.Transparent;
            FirstNameBox.BorderColor = Color.Black;
            FirstNameBox.CustomBGColor = Color.White;
            FirstNameBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameBox.ForeColor = Color.Black;
            FirstNameBox.Location = new Point(153, 127);
            FirstNameBox.MaxLength = 32767;
            FirstNameBox.Multiline = false;
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.ReadOnly = false;
            FirstNameBox.Size = new Size(144, 28);
            FirstNameBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            FirstNameBox.TabIndex = 6;
            FirstNameBox.TextAlignment = HorizontalAlignment.Left;
            FirstNameBox.UseSystemPasswordChar = false;
            FirstNameBox.TextChanged += smallTextBox1_TextChanged;
            // 
            // Classification
            // 
            Classification.Anchor = AnchorStyles.Top;
            Classification.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Classification.Location = new Point(166, 29);
            Classification.Name = "Classification";
            Classification.Size = new Size(114, 25);
            Classification.TabIndex = 29;
            Classification.Text = "Classification";
            Classification.Click += Classification_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 51;
            label2.Text = "Name:";
            // 
            // Department
            // 
            Department.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Department.AutoSize = true;
            Department.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Department.Location = new Point(8, 29);
            Department.Name = "Department";
            Department.Size = new Size(107, 25);
            Department.TabIndex = 30;
            Department.Text = "Department";
            // 
            // Program
            // 
            Program.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Program.AutoSize = true;
            Program.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Program.Location = new Point(303, 29);
            Program.Name = "Program";
            Program.Size = new Size(81, 25);
            Program.TabIndex = 31;
            Program.Text = "Program";
            // 
            // YearLevel
            // 
            YearLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            YearLevel.AutoSize = true;
            YearLevel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            YearLevel.Location = new Point(517, 29);
            YearLevel.Name = "YearLevel";
            YearLevel.Size = new Size(88, 25);
            YearLevel.TabIndex = 32;
            YearLevel.Text = "Year Level";
            // 
            // ProfileMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(907, 776);
            Controls.Add(pictureBox1);
            Controls.Add(WelcomeText);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileMenu";
            Text = "ProfileMenu";
            Load += ProfileMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeText;
        private PictureBox pictureBox1;
        private Label label7;
        private ReaLTaiizor.Controls.SmallTextBox Address1;
        private Label label3;
        private Label label1;
        private ReaLTaiizor.Controls.SmallTextBox FamilyNameBox;
        private Panel panel1;
        private Label label2;
        private ReaLTaiizor.Controls.AloneComboBox YearlevelBo;
        private Label Classification;
        private Label Department;
        private Label Program;
        private Label YearLevel;
        private ReaLTaiizor.Controls.SmallTextBox FirstNameBox;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox5;
        private ReaLTaiizor.Controls.SmallTextBox SuffixBox;
        private ReaLTaiizor.Controls.SmallTextBox MiddleNameBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private ReaLTaiizor.Controls.SmallTextBox Address2;
        private Label label8;
        private Label label9;
        private ReaLTaiizor.Controls.SmallTextBox GenderBox;
        private CheckBox SameAddressCheck;
        private Label label10;
        private ReaLTaiizor.Controls.SmallTextBox PhoneBox;
        private ReaLTaiizor.Controls.Button SubmitButton;
        private ComboBox comboBox1;
        private ReaLTaiizor.Controls.ComboBoxEdit YearlevelBox;
        private ReaLTaiizor.Controls.ComboBoxEdit DepartmentBox;
        private ReaLTaiizor.Controls.ComboBoxEdit ClassificationBox;
        private ReaLTaiizor.Controls.ComboBoxEdit ProgramBox;
    }
}