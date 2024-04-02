

using Microsoft.VisualBasic;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_project
{
    public partial class Form1 : Form
    {
        string link = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUsername.Clear();
            LoginPassword.Clear();
            LoginPanel.Visible = true;

        }

        private void BackSingup_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            SignupPanel.Visible = false;
        }

        private void BackLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            ErrorLogin.Visible = false;
            SignupSuccess.Visible = false;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            SignupPanel.Visible = true;
        }

        public Tuple<string, string, string, string> GetNamesByEmail(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT F, L, M,E FROM Student WHERE ID = @id";

            string fname = "";
            string lname = "";
            string mname = "";
            string email = "";

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
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return Tuple.Create(fname, lname, mname, email);
        }

        private void LoginAccess_Click(object sender, EventArgs e)
        {
            if (LoginUsername.Text == "admin" && LoginPassword.Text == "123")
            {
                AdminControls admin = new AdminControls();
                this.Hide();
                LoginUsername.Clear();
                LoginPassword.Clear();
                admin.ShowDialog();
                this.Show();

            }
            bool UserValid = CheckUserExists(link, LoginUsername.Text, LoginPassword.Text);
            if (UserValid)
            {
                bool isverified = IsEmailVerified(LoginUsername.Text);
                if (!isverified)
                {
                    var names = GetNamesByEmail(LoginUsername.Text);
                    if (names != null)
                    {
                        string fname = names.Item1;
                        string lname = names.Item2;
                        string mname = names.Item3;
                        string email = names.Item4;

                        con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        string to, from, pass, mail;
                        to = email;
                        from = "OnlineServiceJXIT@gmail.com";
                        Random rnd = new Random();
                        vCode = rnd.Next(10000, 100000);
                        mail = vCode.ToString();
                        pass = "auuq errs qyhe easi";
                        MailMessage message = new MailMessage();
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = $"Hi {fname} " + $"{mname} " + $"{lname}" + "\n\n" + "This is your Verification Code:" + "\n\n" + vCode.ToString();
                        message.Subject = "School Verification Code" + vCode.ToString();
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        MessageBox.Show($"{fname} {lname} {mname} {email}");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        cmd.CommandText = "UPDATE Student SET RegisteredCode = @Reg WHERE ID = @id";
                        try
                        {
                            cmd.Parameters.AddWithValue("@Reg", mail);
                            cmd.Parameters.AddWithValue("@id", LoginUsername.Text);
                            cmd.ExecuteNonQuery();
                            smtp.Send(message);
                            MessageBox.Show("Verication code sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Verification verify = new Verification(email);
                            this.Enabled = false;
                            verify.ShowDialog();
                            this.Enabled = true;
                            LoginUsername.Clear();
                            LoginPassword.Clear();
                            ErrorLogin.Visible = false;
                            LoginAccess_Click(sender, e);


                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }


                }
                else
                {
                    Dashboard dashboard = new Dashboard(LoginUsername.Text);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Show();
                    LoginPanel.Visible = false;
                    SignupPanel.Visible = false;
                }

            }
            else
            {
                ErrorLogin.Visible = true;
                LoginPassword.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int vCode = 1000;
        int startPart1 = 22;
        int startPart2 = 0;
        int startPart3 = 1;
        private void SignupAccess_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Student (E,P,ID,RegisteredCode)values(@email,@pass,@id,@Reg)";
            if (!IsValidEmail(EmailSignup.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool emailExists = CheckEmailExists("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"", EmailSignup.Text);
            if (emailExists)
            {
                ErrorText.Visible = true;
                ErrorText.Text = "Person already signed up";
            }
            else
            {
                cmd.Parameters.AddWithValue("@email", EmailSignup.Text);
                cmd.Parameters.AddWithValue("@pass", PasswordSignup.Text);
                bool idselection = false;
                while (!idselection)
                {

                    string formattedPart1 = startPart1.ToString("00");
                    string formattedPart2 = startPart2.ToString("0000");
                    string formattedPart3 = startPart3.ToString("000");

                    string generatedNumber = $"{formattedPart1}-{formattedPart2}-{formattedPart3}";
                    startPart3 += 1;
                    if (startPart3 > 999)
                    {
                        startPart3 = 1;
                        startPart2 += 1;
                    }
                    bool IDExists = CheckIDExists("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"", generatedNumber);

                    if (IDExists)
                    {
                        continue;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", generatedNumber);
                        idselection = true;
                    }
                }

                string to, from, pass, mail;
                to = EmailSignup.Text;
                from = "OnlineServiceJXIT@gmail.com";
                Random rnd = new Random();
                vCode = rnd.Next(10000, 100000);
                mail = vCode.ToString();
                pass = "auuq errs qyhe easi";
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = $"Greetings, you are one step away from creating your account!" + "\n\n" + "This is your Verification Code:" + "\n\n" + vCode.ToString();
                message.Subject = "School Verification Code " + vCode.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    cmd.Parameters.AddWithValue("@Reg", mail);
                    cmd.ExecuteNonQuery();
                    smtp.Send(message);
                    MessageBox.Show("Verication code sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Verification verify = new Verification(EmailSignup.Text);
                    this.Enabled = false;
                    verify.ShowDialog();
                    this.Enabled = true;
                    EmailSignup.Clear();
                    ConfirmEmail.Clear();
                    PasswordSignup.Clear();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                SignupPanel.Visible = false;
                SignupSuccess.Visible = true;


            }


        }
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        static bool CheckEmailExists(string connectionString, string email)
        {
            bool emailExists = false;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Student WHERE E = @email";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        emailExists = true;
                    }
                }
            }

            return emailExists;
        }

        static bool CheckIDExists(string connectionString, string number)
        {
            bool idExists = false;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID FROM Student WHERE ID = @id";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", number);
                    object count = command.ExecuteScalar();
                    if (count != null && count != DBNull.Value)
                    {
                        idExists = true;
                    }
                }
            }

            return idExists;
        }

        static bool CheckUserExists(string connectionString, string username, string password)
        {
            bool userExists = false;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID FROM Student WHERE ID = @id AND P = @password";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", username);
                    command.Parameters.AddWithValue("@password", password);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        userExists = true;
                    }
                }
            }

            return userExists;
        }

        public bool IsEmailVerified(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT RegisteredEmail FROM Student WHERE ID = @id";

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


        private void SignupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConnectionTest_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginAccess_Click(sender, e);
            }
        }

        private void PasswordSignup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SignupAccess_Click(sender, e);
            }
        }
    }
}