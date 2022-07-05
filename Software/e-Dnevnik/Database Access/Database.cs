using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Access
{
    public class Database
    {
        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }

                return instance;
            }
        }

        private string connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI2205_DB; User = PI2205_User; Password = =ikN&lf=;";
        private SqlConnection connection;

        private Database()
        {

        }

        public void Connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Disconnect()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public IDataReader GetDataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            return cmd.ExecuteReader();
        }

        public object GetValue(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            return cmd.ExecuteScalar();
        }

        public int ExecuteCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            return cmd.ExecuteNonQuery();
        }
    }
}