using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Policy;
using System.Runtime.InteropServices;

namespace Final_project.AdminTab
{
    public partial class EditProfile : Form
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


        string link = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        string id, progcode;
        string fname, mname, lname, suffix, phone, password, program, classification, department, gender, email, address1, address2;
        int yearlevel;
        public EditProfile(string id, string fname, string mname, string lname, string suffix, string progcode, string program,
                    int yearlevel, string phone, string classification,
                    string department, string gender, string Add1, string Add2, string email, string password)
        {
            InitializeComponent();
            this.id = id;
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
            this.suffix = suffix;
            this.progcode = progcode;
            this.program = program;
            this.department = department;
            this.yearlevel = yearlevel;
            this.classification = classification;
            this.phone = phone;
            this.password = password;
            this.address1 = Add1;
            this.address2 = Add2;
            this.gender = gender;
            this.email = email;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            string updatequery = @"UPDATE Student SET F = @a, 
                               M = @b,
                               L = @c,
                               Suffix = @d,
                               Gender = @e,
                               [Address#1] = @f,
                               [Address#2] = @g,
                               Phone = @h,
                               Classification = @i,
                               Department = @j,
                               Program = @k,
                               ProgramCode = @l,
                               yearLevel = @m
                  WHERE ID = @id";

            try
            {
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\""))
                {
                    string ProgCode = "";
                    if (Program.Text == "BS in Computer Engineering")
                    {
                        ProgCode = "BSCPE";
                    }
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(updatequery, myConn))
                    {
                        cmd.Parameters.AddWithValue("@a", Fname.Text);
                        cmd.Parameters.AddWithValue("@b", Mname.Text);
                        cmd.Parameters.AddWithValue("@c", Lname.Text);
                        cmd.Parameters.AddWithValue("@d", Suffix.Text);
                        cmd.Parameters.AddWithValue("@e", Gender.Text);
                        cmd.Parameters.AddWithValue("@f", Address1.Text);
                        cmd.Parameters.AddWithValue("@g", Address2.Text);
                        cmd.Parameters.AddWithValue("@h", Phone.Text);
                        cmd.Parameters.AddWithValue("@i", Classification.Text);
                        cmd.Parameters.AddWithValue("@j", Department.Text);
                        cmd.Parameters.AddWithValue("@k", Program.Text);
                        cmd.Parameters.AddWithValue("@l", ProgCode);
                        cmd.Parameters.AddWithValue("@m", YearLevel.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("OK");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Close();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            Fname.Text = fname;
            Mname.Text = mname;
            Lname.Text = lname;
            Suffix.Text = suffix;
            Phone.Text = phone;
            Password.Text = password;
            Program.Text = program;
            Classification.Text = classification;
            Department.Text = department;
            YearLevel.Text = $"{yearlevel}";
            Gender.Text = gender;
            Email.Text = email;
            Address1.Text = address1;
            Address2.Text = address2;
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
