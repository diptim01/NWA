using NPoco.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Country.Services
{
    class Databasem: SqlServerDatabase
    {
        public Databasem(string connString) : base(connString)
        {

        }
    }
}
