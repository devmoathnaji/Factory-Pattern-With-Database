using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AbstractFactoryPattern
{
    internal class MySQLDB : IDatabase
    {
        private MySqlConnection _Connection = null;
        private MySqlCommand _Command = null;
        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new MySqlCommand();
                    _Command.Connection = (MySqlConnection)Connection;
                    
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
                    string connectionString = ConfigurationManager.ConnectionStrings["testMySql"].ConnectionString;
                    _Connection = new MySqlConnection(connectionString);
                }
                return _Connection;
            }
        }
    }
}