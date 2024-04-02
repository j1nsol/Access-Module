namespace Final_project
{
    partial class Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            VerifyText = new TextBox();
            linkLabel1 = new LinkLabel();
            VerifyButton = new Button();
            bsCpE_1Year_1TermTableAdapter1 = new DataSet1TableAdapters.BSCpE_1Year_1TermTableAdapter();
            IncorrectLabel = new Label();
            Close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter the code that was sent to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "One more Step!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "your email.";
            // 
            // VerifyText
            // 
            VerifyText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            VerifyText.Location = new Point(12, 152);
            VerifyText.Name = "VerifyText";
            VerifyText.Size = new Size(303, 31);
            VerifyText.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 186);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Didn't Receive a code? Click to resend";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(240, 235);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(75, 23);
            VerifyButton.TabIndex = 5;
            VerifyButton.Text = "Verify";
            VerifyButton.UseVisualStyleBackColor = true;
            VerifyButton.Click += VerifyButton_Click;
            // 
            // bsCpE_1Year_1TermTableAdapter1
            // 
            bsCpE_1Year_1TermTableAdapter1.ClearBeforeFill = true;
            // 
            // IncorrectLabel
            // 
            IncorrectLabel.AutoSize = true;
            IncorrectLabel.ForeColor = Color.Red;
            IncorrectLabel.Location = new Point(12, 217);
            IncorrectLabel.Name = "IncorrectLabel";
            IncorrectLabel.Size = new Size(174, 15);
            IncorrectLabel.TabIndex = 6;
            IncorrectLabel.Text = "Incorrect code, please try again.";
            IncorrectLabel.Visible = false;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.BackColor = Color.Transparent;
            Close.Image = (Image)resources.GetObject("Close.Image");
            Close.Location = new Point(295, 12);
            Close.Name = "Close";
            Close.Size = new Size(26, 30);
            Close.SizeMode = PictureBoxSizeMode.CenterImage;
            Close.TabIndex = 7;
            Close.TabStop = false;
            Close.Click += Close_Click;
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 281);
            Controls.Add(Close);
            Controls.Add(IncorrectLabel);
            Controls.Add(VerifyButton);
            Controls.Add(linkLabel1);
            Controls.Add(VerifyText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Verification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verification";
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox VerifyText;
        private LinkLabel linkLabel1;
        private Button VerifyButton;
        private DataSet1TableAdapters.BSCpE_1Year_1TermTableAdapter bsCpE_1Year_1TermTableAdapter1;
        private Label IncorrectLabel;
        private PictureBox Close;
    }
}