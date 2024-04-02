namespace Final_project
{
    partial class Admin_ProfileApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ProfileApproval));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ExistingDataGrid = new DataGridView();
            ProfileSubmitApprov = new DataGridView();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            ConfirmBtn = new ReaLTaiizor.Controls.Button();
            label2 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExistingDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfileSubmitApprov).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(842, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(ExistingDataGrid);
            panel1.Controls.Add(ProfileSubmitApprov);
            panel1.Controls.Add(bigLabel3);
            panel1.Controls.Add(bigLabel2);
            panel1.Controls.Add(ConfirmBtn);
            panel1.Location = new Point(12, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 625);
            panel1.TabIndex = 30;
            // 
            // ExistingDataGrid
            // 
            ExistingDataGrid.AllowUserToAddRows = false;
            ExistingDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExistingDataGrid.Location = new Point(18, 344);
            ExistingDataGrid.Name = "ExistingDataGrid";
            ExistingDataGrid.RowTemplate.Height = 25;
            ExistingDataGrid.Size = new Size(795, 183);
            ExistingDataGrid.TabIndex = 36;
            // 
            // ProfileSubmitApprov
            // 
            ProfileSubmitApprov.AllowUserToAddRows = false;
            ProfileSubmitApprov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfileSubmitApprov.Location = new Point(16, 80);
            ProfileSubmitApprov.Name = "ProfileSubmitApprov";
            ProfileSubmitApprov.RowTemplate.Height = 25;
            ProfileSubmitApprov.Size = new Size(797, 190);
            ProfileSubmitApprov.TabIndex = 35;
            ProfileSubmitApprov.CellClick += ProfileSubmitApprov_CellClick;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(16, 305);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(242, 36);
            bigLabel3.TabIndex = 34;
            bigLabel3.Text = "Existing Profile Data";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(16, 41);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(295, 36);
            bigLabel2.TabIndex = 33;
            bigLabel2.Text = "Pending Profile Changes";
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ConfirmBtn.BackColor = Color.Transparent;
            ConfirmBtn.BorderColor = Color.FromArgb(32, 34, 37);
            ConfirmBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            ConfirmBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            ConfirmBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmBtn.Image = null;
            ConfirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConfirmBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            ConfirmBtn.Location = new Point(693, 572);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            ConfirmBtn.PressedColor = Color.FromArgb(165, 37, 37);
            ConfirmBtn.Size = new Size(120, 40);
            ConfirmBtn.TabIndex = 31;
            ConfirmBtn.Text = "Confirm Profile";
            ConfirmBtn.TextAlignment = StringAlignment.Center;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 304);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 31;
            label2.Text = "Existing Profile";
            label2.Click += label2_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 26);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(308, 46);
            bigLabel1.TabIndex = 32;
            bigLabel1.Text = "Profile Submissions";
            // 
            // Admin_ProfileApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(866, 745);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_ProfileApproval";
            Text = "Admin_ProfileApproval";
            Load += Admin_ProfileApproval_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExistingDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfileSubmitApprov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.Button ConfirmBtn;
        private Label label2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private DataGridView ProfileSubmitApprov;
        private DataGridView ExistingDataGrid;
    }
}