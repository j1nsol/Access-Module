using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Final_project
{
    public partial class Verification : Form
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
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
            );
        private string email;
        public Verification(string email)
        {
            InitializeComponent();
            this.email = email;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Verification_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                Form1 form1 = new Form1();
                form1.Enabled = true;
            }
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            IncorrectLabel.Visible = false;
            System.Threading.Thread.Sleep(2000);
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            bool CodeValid = CheckCodeValid(link, VerifyText.Text, email);
            if (CodeValid)
            {
                MessageBox.Show("Verified successfully." + MessageBoxButtons.OK);
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                this.Close();
            }
            else
            {
                IncorrectLabel.Visible = true;
                VerifyText.Clear();
            }
        }
        static bool CheckCodeValid(string connectionString, string code, string email)
        {
            bool CodeMatch = false;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT RegisteredCode FROM Student WHERE E = @email";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string registerCode = result.ToString();
                        if (registerCode == code)
                        {
                            CodeMatch = true;
                            string updateQuery = "UPDATE Student SET RegisteredEmail = True WHERE E = @Email";

                            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Email", email);

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                // Check if the update was successful
                                if (rowsAffected > 0)
                                {
                                    // Update successful
                                }
                                else
                                {
                                    // Update failed
                                }
                            }
                        }
                    }
                }

            }
            return CodeMatch;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int vCode = 1000;
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
                message.Body = $"Greetings, you are one step away from creating your account!" + "\n\n" + "This is your Verification Code:" + "\n\n" + vCode.ToString();
                message.Subject = "School Verification Code " + vCode.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                cmd.CommandText = "UPDATE Student SET RegisteredCode = @Reg WHERE E = @email";
                try
                {
                    cmd.Parameters.AddWithValue("@Reg", mail);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    smtp.Send(message);
                    MessageBox.Show("Verication code sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
         

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
