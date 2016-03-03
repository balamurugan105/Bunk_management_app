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

        public bool isReportsViewAllowed(string iUsrName)
        {
            try
            {
                OleDbConnection lConn = new OleDbConnection();
                lConn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
                lConn.Open();
                OleDbCommand lcmd = new OleDbCommand("SELECT * FROM UserCredentials WHERE (userid = @uname AND ( NOT ( Role = @worker OR Role = @Cashier )))", lConn);
                lcmd.Parameters.AddWithValue("@uname", iUsrName);
                lcmd.Parameters.AddWithValue("@worker", "Worker");
                lcmd.Parameters.AddWithValue("@Cashier", "Cashier");
                OleDbDataReader ldata = lcmd.ExecuteReader();
                return ldata.Read();
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Exception received", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            return false;        
        }
        public List<string> getList(string iQueryCommand)
        {
            List<string> lProdList= new List<string>();
            try
            {
                OleDbConnection lConn = new OleDbConnection();
                lConn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
                lConn.Open();
                //"SELECT Items_table.[ItemName] FROM Items_table"
                OleDbCommand lcmd = new OleDbCommand(iQueryCommand, lConn);
                OleDbDataReader lDataReader = lcmd.ExecuteReader();
                while (lDataReader.Read())
                {
                    lProdList.Add( lDataReader.GetString(0));
                }
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Exception received", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            return lProdList;
        }
    }
}
