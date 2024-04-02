using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Final_project.AdminTab;

namespace Final_project
{
    public partial class AdminControls : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        Admin_ProfileApproval profileApprov;
        Admin_ProfileList profileList;
        public AdminControls()
        {
            InitializeComponent();
            mdiProp();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AdminControls_Load(object sender, EventArgs e)
        {

        }


        bool SprofileExpand = false;
        private void SProfileTransition_Tick(object sender, EventArgs e)
        {
            if (SprofileExpand == false)
            {
                SProfileContainer.Height += 10;
                if (SProfileContainer.Height >= 168)
                {
                    SProfileTransition.Stop();
                    SprofileExpand = true;
                }
            }
            else
            {
                SProfileContainer.Height -= 10;
                if (SProfileContainer.Height <= 56)
                {
                    SProfileTransition.Stop();
                    SprofileExpand = false;
                }
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            SProfileTransition.Start();
        }

        bool sidebarExpand = true;
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 5;
                if (SidebarPanel.Width <= 66)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                SidebarPanel.Width += 5;
                if (SidebarPanel.Width >= 230)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileApproval_Click(object sender, EventArgs e)
        {
            if (profileApprov == null)
            {
                profileApprov = new Admin_ProfileApproval();
                profileApprov.FormClosed += ProfileApprov_FormClosed;
                profileApprov.MdiParent = this;
                profileApprov.Dock = DockStyle.Fill;
                profileApprov.Show();
            }
            else
            {
                profileApprov.Activate();
            }
        }

        private void ProfileApprov_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profileApprov = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Unmaxim.Visible = true;
            Maxim.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Unmaxim.Visible = false;
            Maxim.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool mouseDown;
        private Point offset;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ProfileListbtn_Click(object sender, EventArgs e)
        {
                profileList = new Admin_ProfileList();
                profileList.FormClosed += ProfileList_FormClosed;
                profileList.MdiParent = this;
                profileList.Dock = DockStyle.Fill;
                profileList.Show();
        }

        private void ProfileList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profileList = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
