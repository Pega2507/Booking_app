using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Booking_app
{
    public class DataBase
    {
        public SqlConnection conn = null;

        public DataBase() 
        {
            try { Connect(); }
            catch(Exception ex) { throw new Exception("DataBase " + ex.Message); }
        }
        private void Connect()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"localhost\SQLEXPRESS";
                builder.InitialCatalog = "Booking_App";
                builder.UserID = "sa";
                builder.Password = "minecraft2507";
                builder.Pooling = true;
                builder.ConnectTimeout = 15;
                builder.IntegratedSecurity = false;
                conn = new SqlConnection(builder.ConnectionString);
            }
            if (conn.State != ConnectionState.Open)
            {
                try { conn.Open(); } 
                catch(Exception ex) { throw new Exception("-> Connect: " + ex.Message); }

            }
        }

        public DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch(Exception ex) { throw new Exception("-> GetTable: " + ex.Message); }
            return dt;
        }

        public void ExecuteNonQuerySql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("-> ExecuteNonQuerySql: " + ex.Message); }
        }
    }
}
