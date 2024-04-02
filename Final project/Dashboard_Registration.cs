using Final_project.DataSet1TableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using ReaLTaiizor.Extension;

namespace Final_project
{
    public partial class Dashboard_Registration : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        string user;
        public Dashboard_Registration(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        public Tuple<string, string, string, string, string, string> GetDetailsByID1(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT F, L, M,E,Suffix,Program,Phone,CLassification,Department,Gender,[Address#1],[Address#2] FROM Student WHERE ID = @id";

            string fname = "";
            string lname = "";
            string mname = "";
            string email = "";
            string suffix = "";
            string Program = "";




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



                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return Tuple.Create(fname, lname, mname, email, suffix, Program);
        }
        public Tuple<string, string, string> GetDetailsByID2(string username)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT yearLevel,ProgramCode, units FROM Student WHERE ID = @id";

            string units = "";
            string progcode = "";
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
                                progcode = reader["ProgramCode"].ToString();
                                units = reader["units"].ToString();
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

            return Tuple.Create(progcode, units, yearlevel);
        }
        public string GetTerm()
        {
            string term = "";

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT Valuables FROM SchoolSettings WHERE Settings = 'Term'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        term = (string)command.ExecuteScalar();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return term;
        }
        public string GetSchoolYear()
        {
            string schoolyear = "";

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
            string query = "SELECT Valuables FROM SchoolSettings WHERE Settings = 'SchoolYear'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        schoolyear = (string)command.ExecuteScalar();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return schoolyear;
        }


        private void Dashboard_Registration_Load(object sender, EventArgs e)
        {
            SubjectList.DataSource = null;
            SubjectList.Columns.Clear();
            SubjectList.Rows.Clear();
            var names = GetDetailsByID1(user);
            StudName.Text = $"{names.Item1} {names.Item3[0].ToString().ToUpper()}. {names.Item2}";
            Prog.Text = names.Item6;
            Year.Text = GetSchoolYear();
            StudNo.Text = user;
            string term = GetTerm();
            string year = "";
            var item = GetDetailsByID2(user);
            year = item.Item3;

            switch (item.Item3)
            {
                case "1":
                    {
                        YearlevelName.Text = "First Year";
                        break;
                    }
                case "2":
                    {
                        YearlevelName.Text = "Second Year";
                        break;
                    }
                case "3":
                    {
                        YearlevelName.Text = "Third Year";
                        break;
                    }
                case "4":
                    {
                        YearlevelName.Text = "Fourth Year";
                        break;
                    }
                case "5":
                    {
                        YearlevelName.Text = "Fifth Year";
                        break;
                    }
            }

            switch (term)
            {
                case "1":
                    {
                        Term.Text = "First";
                        break;
                    }
                case "2":
                    {
                        Term.Text = "Second";
                        break;
                    }
                case "3":
                    {
                        Term.Text = "Third";
                        break;
                    }
            }
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            da = new OleDbDataAdapter(@"SELECT YearLevel, Term, SubjectCode, Description, [Lec Hours], [Lab Hours], [Credited Units] 
                            FROM BSCpE_Curriculum 
                            WHERE CourseID = @coursecode 
                            AND YearLevel = @yrlvl 
                            AND Term = (SELECT Valuables FROM schoolSettings WHERE Settings = 'Term')", myConn);

            MessageBox.Show(user);
            da.SelectCommand.Parameters.AddWithValue("@coursecode", item.Item1);
            da.SelectCommand.Parameters.AddWithValue("@yrlvl", item.Item3);
            da.SelectCommand.Parameters.AddWithValue("@term", term);
            da.SelectCommand.Parameters.AddWithValue("@id", user);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            SubjectList.DataSource = ds.Tables["Student"];
            myConn.Close();

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "";
            checkColumn.Name = "Check";
            SubjectList.Columns.Add(checkColumn);
            DataGridViewComboBoxColumn SelectSchedule = new DataGridViewComboBoxColumn();
            SelectSchedule.HeaderText = "Class Size | Section | Schedule | Room | Status";
            SelectSchedule.Name = "SelectedSched";
            SelectSchedule.Items.Add("Test");
            SelectSchedule.ReadOnly = true;
            SubjectList.Columns.Add(SelectSchedule);
            DataGridViewButtonColumn confirm = new DataGridViewButtonColumn();
            confirm.HeaderText = "";
            confirm.Name = "Confirm";
            confirm.Text = "Confirm";
            SubjectList.Columns.Add(confirm);
            SubjectList.Columns[0].Width = 50;
            SubjectList.Columns[0].HeaderText = "Year";
            SubjectList.Columns[1].Width = 50;
            SubjectList.Columns[2].Width = 80;
            SubjectList.Columns[3].Width = 200;
            SubjectList.Columns[4].Width = 70;
            SubjectList.Columns[5].Width = 70;
            SubjectList.Columns[6].Width = 90;
            SubjectList.Columns[7].Width = 30;
            SubjectList.Columns[8].Width = 200;
            SubjectList.Refresh();
            removerow();

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            da = new OleDbDataAdapter(@"SELECT SubjectCode, Description, Section, SectionDescription FROM 2324_EnrolleesDetails WHERE ID = @id", myConn);

            MessageBox.Show(user);
            da.SelectCommand.Parameters.AddWithValue("@id", user);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Stud");
            RegisteredList.DataSource = ds.Tables["stud"];
            myConn.Close();
        }

        private void removerow()
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            for (int i = SubjectList.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = SubjectList.Rows[i];
                string subjectCode = row.Cells[2].Value?.ToString();

                if (subjectCode != null)
                {
                    bool existsInDatabase = CheckIfRowExistsInDatabase(subjectCode, user);

                    if (existsInDatabase)
                    {
                        rowsToRemove.Add(row);
                    }
                }
            }
            foreach (DataGridViewRow rowToRemove in rowsToRemove)
            {
                SubjectList.Rows.Remove(rowToRemove);
            }
        }

        bool CheckIfRowExistsInDatabase(string subjectCode, string user)
        {
            bool exists = false;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Code\Final project\Final project\UserDatabase.accdb";

            string query = "SELECT COUNT(*) FROM 2324_Enrollees WHERE SubjectCode = @subjectCode AND ID = @id";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectCode", subjectCode);
                    command.Parameters.AddWithValue("@id", user);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    exists = count > 0;
                }
            }

            return exists;
        }

        private void SubjectList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = SubjectList.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBoxCell.Value))
                {
                    SubjectList.Rows[e.RowIndex].Cells[1].ReadOnly = false;

                    string subjectCode = SubjectList.Rows[e.RowIndex].Cells[5].Value.ToString();

                    using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\""))
                    {
                        conn.Open();
                        using (OleDbCommand cmd = new OleDbCommand("SELECT SectionDescription, [Max Student], [Enrolled Student] FROM 2324_Year WHERE SubjectCode = @subjectcode", conn))
                        {
                            cmd.Parameters.AddWithValue("@subjectcode", subjectCode);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                DataGridViewComboBoxCell comboBoxCell = SubjectList.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
                                comboBoxCell.Items.Clear();

                                while (reader.Read())
                                {
                                    string sectionDescription = reader["SectionDescription"].ToString();
                                    int maxStudent = Convert.ToInt32(reader["Max Student"]);
                                    int enrolledStudent = Convert.ToInt32(reader["Enrolled Student"]);
                                    string displayValue = $"{sectionDescription}";
                                    comboBoxCell.Items.Add(displayValue);
                                }
                            }
                        }
                    }
                }
            }

        }
        public Tuple<string, string> GetDescription(string description)
        {
            string subjectcode = "";
            string section = "";


            string query = "SELECT SubjectCode, Section FROM BSCpE_Sections WHERE SectionDescription = @description";

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\""))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@description", description);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            subjectcode = reader["SubjectCode"].ToString();
                            section = reader["Section"].ToString();
                        }
                    }
                }
            }

            return Tuple.Create(subjectcode, section);
        }




        private bool IsConflict(string SectionDescription)
        {
            bool isConflict = false;


            return isConflict;
        }

        private void SubjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                MessageBox.Show("ok");
                string getScheduleAdd = SubjectList.Rows[e.RowIndex].Cells[1].Value.ToString();
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"";
                string insertStatement = "INSERT INTO 2324_Enrollees (ID, CourseID,SubjectCode,SectionEnrolled,YearLevel,Term) VALUES" +
                    " (@id,courseid,subjectcode,section,yearlvl,term)";
                var userdetails = GetDetailsByID2(user);
                MessageBox.Show(getScheduleAdd);
                var details = GetDescription(getScheduleAdd);
                string term = GetTerm();
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(insertStatement, connection))
                    {

                        command.Parameters.AddWithValue("@id", user);
                        command.Parameters.AddWithValue("@courseid", userdetails.Item1);
                        command.Parameters.AddWithValue("@subjectcode", details.Item1);
                        command.Parameters.AddWithValue("@section", details.Item2);
                        command.Parameters.AddWithValue("@yearlvl", userdetails.Item3); ;
                        command.Parameters.AddWithValue("@term", term);
                        command.ExecuteNonQuery();
                        removerow();
                        SubjectList.Rows.RemoveAt(SubjectList.CurrentRow.Index);
                    }
                }
                removerow();
            }
        }

        private void RegisteredList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("This Subject will be unregistered. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
                    myConn.Open();
                    DataGridViewRow selectedRow = RegisteredList.Rows[e.RowIndex];
                    string ID = selectedRow.Cells[1].Value.ToString();
                    string deleteQuery = "DELETE FROM 2324_Enrollees WHERE SubjectCode = @subcode";
                    using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn))
                    {
                        deleteCmd.Parameters.AddWithValue("@subcode", ID);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully.");
                        myConn.Close();
                        RegisteredList.Rows.RemoveAt(RegisteredList.CurrentRow.Index);
                    }
                }
            }
        }
    }
}
