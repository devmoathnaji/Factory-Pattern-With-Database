using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IDatabase
    {
         IDbConnection Connection { get; }
         IDbCommand Command { get; }
    }
}
