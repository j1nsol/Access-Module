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
using System.Data.OleDb;

namespace Final_project
{
    public partial class Dashboard : Form
    {

        ProfileMenu profilemenu;
        Dashboard_Registration Registration;


        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        string user;
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
        public Dashboard(string user)
        {
            InitializeComponent();
            this.user = user;
            mdiProp();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (IsProfileVerified(user))
            {
                ProfileButton.Visible = true;
                Gradesbtn.Visible = true;
                Schedulebtn.Visible = true;
                AccountBtn.Visible = true;
                Registrationpanelbtn.Visible = true;
                Securitybtn.Visible = true;
            }
            else
            {
                ProfileButton.Visible = true;
                Gradesbtn.Visible = false;
                Schedulebtn.Visible = false;
                AccountBtn.Visible = false;
                Registrationpanelbtn.Visible = false;
                Securitybtn.Visible = true;
            }

        }
        public bool IsProfileVerified(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT ProfileRegistration FROM Student WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", username);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            bool isVerified = (bool)result;
                            return isVerified;
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return false;
        }

        private void LogoutDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        bool sidebarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 5;
                if (SidebarPanel.Width <= 72)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                SidebarPanel.Width += 5;
                if (SidebarPanel.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Minimize.Visible = true;
            Maximize.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Minimize.Visible = false;
            Maximize.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void UnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            if (profilemenu == null)
            {
                profilemenu = new ProfileMenu(user);
                profilemenu.FormClosed += Profilemenu_FormClosed;
                profilemenu.MdiParent = this;
                profilemenu.Dock = DockStyle.Fill;
                profilemenu.Show();
            }
            else
            {
                profilemenu.Activate();
            }

        }

        private void Profilemenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profilemenu = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registrationpanelbtn_Click(object sender, EventArgs e)
        {
            if (Registration == null)
            {
                Registration = new Dashboard_Registration(user);
                Registration.FormClosed += Registration_FormClosed;
                Registration.MdiParent = this;
                Registration.Dock = DockStyle.Fill;
                Registration.Show();
            }
            else
            {
                Registration.Activate();
            }
        }

        private void Registration_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
