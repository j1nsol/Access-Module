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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Final_project.AdminTab
{
    public partial class Admin_ProfileList : Form
    {


        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Admin_ProfileList()
        {
            InitializeComponent();
        }

        private void Admin_ProfileList_Load(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            da = new OleDbDataAdapter("SELECT *FROM StudentDataList", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            StudDataList.DataSource = ds.Tables["Student"];
            myConn.Close();

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            da = new OleDbDataAdapter("SELECT *FROM StudentPermission", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            PermissionList.DataSource = ds.Tables["Student"];
            myConn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
            da = new OleDbDataAdapter("SELECT * FROM StudentDataList WHERE " +
                                     "ID LIKE '%" + Search.Text + "%' OR " +
                                     "F LIKE '%" + Search.Text + "%' OR " +
                                     "M LIKE '%" + Search.Text + "%' OR " +
                                     "L LIKE '%" + Search.Text + "%' OR " +
                                     "Suffix LIKE '%" + Search.Text + "%' OR " +
                                     "ProgramCode LIKE '%" + Search.Text + "%' OR " +
                                     "Program LIKE '%" + Search.Text + "%' OR " +
                                     "yearLevel LIKE '%" + Search.Text + "%' OR " +
                                     "units LIKE '%" + Search.Text + "%' OR " +
                                     "unitsTaken LIKE '%" + Search.Text + "%' OR " +
                                     "Phone LIKE '%" + Search.Text + "%' OR " +
                                     "Classification LIKE '%" + Search.Text + "%' OR " +
                                     "Department LIKE '%" + Search.Text + "%' OR " +
                                     "Gender LIKE '%" + Search.Text + "%' OR " +
                                     "[Address#1] LIKE '%" + Search.Text + "%' OR " +
                                     "[Address#2] LIKE '%" + Search.Text + "%' OR " +
                                     "E LIKE '%" + Search.Text + "%'", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            StudDataList.DataSource = ds.Tables["Student"];

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
            da = new OleDbDataAdapter("SELECT * FROM StudentPermission WHERE " +
                                     "ID LIKE '%" + Search.Text + "%'", myConn);
            ds = new DataSet();
            da.Fill(ds, "Student");
            PermissionList.DataSource = ds.Tables["Student"];
        }

        private void StudDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = StudDataList.Rows[e.RowIndex];
                string rowData = selectedRow.Cells["Edit"].Value.ToString();

                string id = selectedRow.Cells[2].Value.ToString();
                string fname = selectedRow.Cells[3].Value.ToString();
                string mname = selectedRow.Cells[4].Value.ToString();
                string lname = selectedRow.Cells[5].Value.ToString();
                string suffix = selectedRow.Cells[6].Value.ToString();
                string progcode = selectedRow.Cells[7].Value.ToString();
                string program = selectedRow.Cells[8].Value.ToString();
                int yearlevel = Convert.ToInt32(selectedRow.Cells[9].Value);
                string phone = selectedRow.Cells[12].Value.ToString();
                string classification = selectedRow.Cells[13].Value.ToString();
                string department = selectedRow.Cells[14].Value.ToString();
                string gender = selectedRow.Cells[15].Value.ToString();
                string Add1 = selectedRow.Cells[16].Value.ToString();
                string Add2 = selectedRow.Cells[17].Value.ToString();
                string email = selectedRow.Cells[18].Value.ToString();
                string password = selectedRow.Cells[19].Value.ToString();

                EditProfile editprofile = new EditProfile(id, fname, mname, lname, suffix, progcode,program,yearlevel,phone,classification,
                    department,gender,Add1,Add2,email,password);
                this.Enabled = false;
                editprofile.ShowDialog();
                Admin_ProfileList_Load(sender, e);
                this.Enabled = true;

            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show("This Student record will be deleted permanently, continue?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Code\\Final project\\Final project\\UserDatabase.accdb\"");
                    myConn.Open();
                    DataGridViewRow selectedRow = StudDataList.Rows[e.RowIndex];
                    string ID = selectedRow.Cells[2].Value.ToString();
                    string deleteQuery = "DELETE FROM Student WHERE ID = @id";
                    using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", ID);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully.");
                        Admin_ProfileList_Load(sender, e);
                        myConn.Close();
                    }
                }
            }
        }
    }
}
