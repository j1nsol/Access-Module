namespace Final_project.AdminTab
{
    partial class Admin_ProfileList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ProfileList));
            label1 = new Label();
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            tabPage1 = new TabPage();
            StudDataList = new DataGridView();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            PermissionList = new DataGridView();
            panel1 = new Panel();
            Search = new TextBox();
            label2 = new Label();
            hopeTabPage1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudDataList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PermissionList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(168, 45);
            label1.TabIndex = 0;
            label1.Text = "Profile List";
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hopeTabPage1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTabPage1.Controls.Add(tabPage1);
            hopeTabPage1.Controls.Add(tabPage2);
            hopeTabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTabPage1.ForeColorA = Color.Silver;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(24, 122);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(724, 483);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 2;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(StudDataList);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(724, 443);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // StudDataList
            // 
            StudDataList.AllowUserToAddRows = false;
            StudDataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudDataList.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            StudDataList.Dock = DockStyle.Fill;
            StudDataList.Location = new Point(3, 3);
            StudDataList.Margin = new Padding(0);
            StudDataList.Name = "StudDataList";
            StudDataList.ReadOnly = true;
            StudDataList.RowTemplate.Height = 25;
            StudDataList.Size = new Size(718, 437);
            StudDataList.TabIndex = 0;
            StudDataList.CellContentClick += StudDataList_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(PermissionList);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(724, 443);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Permissions";
            // 
            // PermissionList
            // 
            PermissionList.AllowUserToAddRows = false;
            PermissionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PermissionList.Location = new Point(0, 0);
            PermissionList.Name = "PermissionList";
            PermissionList.ReadOnly = true;
            PermissionList.RowTemplate.Height = 25;
            PermissionList.Size = new Size(756, 443);
            PermissionList.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(Search);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(hopeTabPage1);
            panel1.Location = new Point(12, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 632);
            panel1.TabIndex = 3;
            // 
            // Search
            // 
            Search.Location = new Point(87, 81);
            Search.Name = "Search";
            Search.Size = new Size(142, 23);
            Search.TabIndex = 4;
            Search.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Search:";
            // 
            // Admin_ProfileList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 776);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_ProfileList";
            Text = "Admin_ProfileList";
            Load += Admin_ProfileList_Load;
            hopeTabPage1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudDataList).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PermissionList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox Search;
        private Label label2;
        private DataGridView StudDataList;
        private DataGridView PermissionList;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}