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

namespace Final_project
{
    public partial class ProfileMenu : Form
    {
        string link = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        string user;
        public ProfileMenu(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        public Tuple<string, string, string, string, string, string, string> GetDetailsByID1(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT F, L, M,E,Suffix,Program,yearLevel,Phone,CLassification,Department,Gender,[Address#1],[Address#2] FROM Student WHERE ID = @id";

            string fname = "";
            string lname = "";
            string mname = "";
            string email = "";
            string suffix = "";
            string Program = "";
            string yearlevel = "";



            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", username);

                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fname = reader["F"].ToString();
                                lname = reader["L"].ToString();
                                mname = reader["M"].ToString();
                                email = reader["E"].ToString();
                                suffix = reader["Suffix"].ToString();
                                Program = reader["Program"].ToString();
                                yearlevel = reader["yearLevel"].ToString();

                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return Tuple.Create(fname, lname, mname, email, suffix, Program, yearlevel);
        }
        public Tuple<string, string, string, string, string, string> GetDetailsByID2(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT Phone,CLassification,Department,Gender,[Address#1],[Address#2] FROM Student WHERE ID = @id";
            string phone = "";
            string classification = "";
            string dept = "";
            string gender = "";
            string address1 = "";
            string address2 = "";


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", username);

                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                phone = reader["Phone"].ToString();
                                classification = reader["Classification"].ToString();
                                dept = reader["Department"].ToString();
                                gender = reader["Gender"].ToString();
                                address1 = reader["Address#1"].ToString();
                                address2 = reader["Address#2"].ToString();

                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return Tuple.Create(phone, classification, dept, gender, address1, address2);
        }

        private void ProfileMenu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            if (IsProfileVerified(user))
            {
                var names1 = GetDetailsByID1(user);
                string fname = names1.Item1;
                string lname = names1.Item2;
                string mname = names1.Item3;
                string email = names1.Item4;
                string suffix = names1.Item5;
                string Program = names1.Item6;
                string yearlevel = names1.Item7;
                var names2 = GetDetailsByID2(user);
                string phone = names2.Item1;
                string classification = names2.Item2;
                string dept = names2.Item3;
                string gender = names2.Item4;
                string address1 = names2.Item5;
                string address2 = names2.Item6;
                DepartmentBox.Enabled = false;
                ClassificationBox.Enabled = false;
                ProgramBox.Enabled = false;
                YearlevelBox.Enabled = false;
                FamilyNameBox.Enabled = false;
                FirstNameBox.Enabled = false;
                MiddleNameBox.Enabled = false;

                ClassificationBox.Enabled = false;
                ProgramBox.Enabled = false;
                YearlevelBox.Enabled = false;
                FamilyNameBox.Enabled = false;
                FirstNameBox.Enabled = false;
                MiddleNameBox.Enabled = false;

                DepartmentBox.Text = dept;
                ClassificationBox.Text = classification;
                ProgramBox.Text = Program;
                YearlevelBox.Text = yearlevel;
                FamilyNameBox.Text = fname;
                FirstNameBox.Text = lname;
                MiddleNameBox.Text = mname;
                SuffixBox.Text = suffix;
                Address1.Text = address1;
                Address2.Text = address2;
                GenderBox.Text = gender;
                PhoneBox.Text = phone;
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.Black, 20);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(pen, 50, 50, 100, 100);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Classification_Click(object sender, EventArgs e)
        {

        }

        private void smallTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SameAddressCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SameAddressCheck.Checked = true)
            {
                Address2.Text = Address1.Text;
            }
            else
            {
                Address2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string progCode = "";
            if (ProgramBox.Text == "BS in Computer Engineering")
            {
                progCode = "BSCPE";
            }
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into StudInfo_RE_Approval (ID,FirstName,MiddleName,LastName,Suffix,Address1,Address2,Department,Classification," +
                "Program,ProgramCode,YearLevel,Gender,Phone)values(@id,@FName,@MName,@LName,@Suffix,@Add1,@Add2,@Dept,@Class,@Program,@ProgCode,@Year,@gender,@phone)";
            cmd.Parameters.AddWithValue("@id", user);
            cmd.Parameters.AddWithValue("@FName", FirstNameBox.Text);
            cmd.Parameters.AddWithValue("@MName", MiddleNameBox.Text);
            cmd.Parameters.AddWithValue("@LName", FamilyNameBox.Text);
            cmd.Parameters.AddWithValue("@Suffix", SuffixBox.Text);
            cmd.Parameters.AddWithValue("@Add1", Address1.Text);
            cmd.Parameters.AddWithValue("@Add2", Address2.Text);
            cmd.Parameters.AddWithValue("@Dept", DepartmentBox.Text);
            cmd.Parameters.AddWithValue("@Class", ClassificationBox.Text);
            cmd.Parameters.AddWithValue("@Program", ProgramBox.Text);
            cmd.Parameters.AddWithValue("@ProgCode", progCode);
            cmd.Parameters.AddWithValue("@Year", YearlevelBox.Text);
            cmd.Parameters.AddWithValue("@gender", GenderBox.Text);
            cmd.Parameters.AddWithValue("@phone", PhoneBox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("OK");



        }
    }
}
