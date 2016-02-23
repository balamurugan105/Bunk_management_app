using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetrolBunkManagement.src;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace PetrolBunkManagement.src
{
    class MSAccessImplementer : DatabaseInterface
    {
        public bool Login(string iUsrName, string iPwd)
        {
            try
            {
                OleDbConnection lConn = new OleDbConnection();
                lConn.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
                lConn.Open();
                OleDbCommand lcmd = new OleDbCommand("SELECT * FROM UserCredentials WHERE userid = @uname AND pwd=@passwd", lConn);
                lcmd.Parameters.AddWithValue("@uname", iUsrName);
                lcmd.Parameters.AddWithValue("@passwd", iPwd);
                OleDbDataReader ldata = lcmd.ExecuteReader();
                return ldata.Read();
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.Message.ToString(), "Exception received", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            return false;
        }
    }
}
