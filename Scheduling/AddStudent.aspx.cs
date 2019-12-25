using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace Scheduling
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void enter_Click(object sender, EventArgs e)
        {
            /* string relativePath = @"schedulingDatabase.db";
             string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
             string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
             absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
             string connectionString = string.Format("Data Source={0}", absolutePath);
             SQLiteConnection myConnection = new SQLiteConnection(connectionString);*/
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:\\Users\\Peyton\\source\\repos\\Scheduling\\Scheduling\\schedulingDatabase.db;");
            // I dont know why this isnt working the comment above is the relative path but i dont know why it is saying the students table isnt found
            
            myConnection.Open();

            string fName = firstNameTB.Text;
            string lName = lastNameTB.Text;
            string studentNumber = studentNumberTB.Text;
            string dob = dobTB.Text;
            if (fName == "")
                fName = "null";
            else fName = "\"" + fName + "\"";
            if (lName == "")
                lName = "null";
            else lName = "\"" + lName + "\"";
            if (studentNumber == "")
                studentNumber = "null";
            if (dob == "")
                dob = "null";


            using (SQLiteTransaction sqlTransaction = myConnection.BeginTransaction())
            {
                // Update the expiry date of the application
                string insertStudents = "INSERT INTO STUDENTS(FirstName, LastName, StudentNumber, DateOfBirth) VALUES(" + fName + ", " + lName + ", " + studentNumber + ", " + dob + ");";
                SQLiteCommand insertCommand = new SQLiteCommand(insertStudents, myConnection);
                insertCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }
    }
}