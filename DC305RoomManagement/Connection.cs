using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DC305RoomManagement
{
    class Connection
    {
        SqlConnection conn;
        string conStr = ConfigurationManager.ConnectionStrings["DC305RoomManagementDB"].ConnectionString;
        public Connection()
        {
            conn = new SqlConnection(conStr);
        }

        public SqlConnection OpenConn()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
