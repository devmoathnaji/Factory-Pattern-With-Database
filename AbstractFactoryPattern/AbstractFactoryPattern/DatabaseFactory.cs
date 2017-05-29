using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DBType type)
        {
            switch (type)
            {
                case DBType.SqlServer:
                    return new SqlServerDB();
                case DBType.MySql:
                    return new MySQLDB();
                
            }
            return null;
        }
    }
}
