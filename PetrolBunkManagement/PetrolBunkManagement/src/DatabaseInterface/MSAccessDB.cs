using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetrolBunkManagement.src.DatabaseInterface;
using System.Data.OleDb; 
using System.Windows.Forms;

namespace PetrolBunkManagement.src.DatabaseInterface
{
    class MSAccessDB : DBInterface
    {
        public bool Login(string iUsername, string iPassword)
        {
             try
         {
         OleDbConnection lConn = new OleDbConnection();
         lConn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
         lConn.Open();
         OleDbCommand lcmd = new OleDbCommand("SELECT * FROM UserCredentials WHERE userid = @uname AND pwd=@passwd", lConn);
         lcmd.Parameters.AddWithValue("@uname", iUsername);
         lcmd.Parameters.AddWithValue("@passwd", iPassword);
         OleDbDataReader ldata= lcmd.ExecuteReader();
         return ldata.Read();  
         }
         catch(OleDbException exp)
         {
             MessageBox.Show(exp.Message.ToString(),"Exception received",MessageBoxButtons.OK,MessageBoxIcon.Error);
         };
         return false;        
        }
    }
}
