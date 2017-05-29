using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AbstractFactoryPattern
{
    public class SqlServerDB : IDatabase
    {
            private SqlConnection _Connection = null;
            private SqlCommand _Command = null;


        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = (SqlConnection)Connection;
                }
                return _Command;
            }
        }

        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["testSQL"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return _Connection;
            }
        }
    }
}