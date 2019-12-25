using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Scheduling
{
    public class AddStudentExcel
    {
        /*
        void createConnection()
        {
            SQLiteConnection myConnection = new SQLiteConnection("Data Source=schedulingDatabase.db;");
            myConnection.Open();


            using (SQLiteTransaction sqlTransaction = myConnection.BeginTransaction())
            {
                // Update the expiry date of the application
                string insertSightings = "INSERT INTO SIGHTINGS(name, person, location, sighted) VALUES(" + name + ", " + person + ", " + location + ", " + date + ");";
                SQLiteCommand insertCommand = new SQLiteCommand(insertSightings
                                                                    , myConnection);
                insertCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }
        */
}
}