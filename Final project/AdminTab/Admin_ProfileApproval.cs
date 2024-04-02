using Final_project.AdminTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Admin_ProfileApproval : Form
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

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;


        public Admin_ProfileApproval()
        {
            InitializeComponent();

        }

        private void poisonDataGridView1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_ProfileApproval_Load(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            da = new OleDbDataAdapter("SELECT *FROM StudInfo_RE_Approval", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            ProfileSubmitApprov.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private string ID;
        private string Fname;
        private string Mname;
        private string Lname;
        private string Suffix;
        private string Add1;
        private string Add2;
        private string Dept;
        private string Class;
        private string Prog;
        private string ProgCode;
        private int YearLevel;
        private string Gender;
        private string Phone;


        private void ProfileSubmitApprov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ID = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[0].Value);
                Fname = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[1].Value);
                Mname = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[2].Value);
                Lname = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[3].Value);
                Suffix = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[4].Value);
                Add1 = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[5].Value);
                Add2 = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[6].Value);
                Dept = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[7].Value);
                Class = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[8].Value);
                Prog = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[9].Value);
                ProgCode = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[10].Value);
                YearLevel = Convert.ToInt32(ProfileSubmitApprov.Rows[e.RowIndex].Cells[11].Value);
                Gender = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[12].Value);
                Phone = Convert.ToString(ProfileSubmitApprov.Rows[e.RowIndex].Cells[13].Value);

                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
                da = new OleDbDataAdapter("SELECT *FROM Student where ID = @id", myConn);
                da.SelectCommand.Parameters.AddWithValue("@id", ID);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Student");
                ExistingDataGrid.DataSource = ds.Tables["Student"];
                myConn.Close();
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string updatequery = @"UPDATE Student SET F = @fname, 
                               M = @a,
                               L = @b,
                               Suffix = @c,
                               Gender = @d,
                               [Address#1] = @e,
                               [Address#2] = @f,
                               Phone = @g,
                               Classification = @h,
                               Department = @i,
                               Program = @j,
                               ProgramCode = @k,
                               yearLevel = @l
                  WHERE ID = @id";

            try
            {
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\""))
                {
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(updatequery, myConn))
                    {
                        cmd.Parameters.AddWithValue("@fname", Fname);
                        cmd.Parameters.AddWithValue("@a", Mname);
                        cmd.Parameters.AddWithValue("@b", Lname);
                        cmd.Parameters.AddWithValue("@c", Suffix);
                        cmd.Parameters.AddWithValue("@d", Gender);
                        cmd.Parameters.AddWithValue("@e", Add1);
                        cmd.Parameters.AddWithValue("@f", Add2);
                        cmd.Parameters.AddWithValue("@g", Phone);
                        cmd.Parameters.AddWithValue("@h", Class);
                        cmd.Parameters.AddWithValue("@i", Dept);
                        cmd.Parameters.AddWithValue("@j", Prog);
                        cmd.Parameters.AddWithValue("@k", ProgCode);
                        cmd.Parameters.AddWithValue("@l", YearLevel);
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM StudInfo_RE_Approval WHERE ID = @id";
                    using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", ID);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Student profile data updated successfully.");
                    }

                    string updateQuery = "UPDATE StudentPermission SET ProfileRegistration = True where ID = @id";

                    using (OleDbCommand deleteCmd = new OleDbCommand(updateQuery, myConn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", ID);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Student profile data updated successfully.");
                    }
                    Admin_ProfileApproval_Load(sender, e);


                    ExistingDataGrid.DataSource = null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
