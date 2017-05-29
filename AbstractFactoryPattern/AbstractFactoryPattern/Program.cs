using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database;
            Console.WriteLine("please select 1 for sql and 2 for mysql");
            var databaseSelected = Console.ReadLine();
            DBType databaseType = DBType.SqlServer;

            switch (databaseSelected)
            {
                case "1":
                    databaseType = DBType.SqlServer;
                    break;
                case "2":
                    databaseType = DBType.MySql;
                    break;
                default:
                    break;
            }
            Console.WriteLine(databaseSelected.ToString());

            database = DatabaseFactory.CreateDatabase(databaseType);
            IDbConnection connection = database.Connection;
            IDbCommand command = database.Command;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Users";
            command.Connection.Open();
            var reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Console.WriteLine(reader["ID"]);
                Console.WriteLine(reader["UserName"]);
                Console.WriteLine(reader["Password"]);
                i++;
            }

            command.Connection.Close();
        }
    }
}
