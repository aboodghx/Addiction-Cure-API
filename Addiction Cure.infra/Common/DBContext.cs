using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Text;

namespace Addiction_Cure.core.Common
{
    public class DBContext : IDBContext
    {
        private DbConnection connection; // 1- connection = null  --> new connection + open()
                                         // 2- return connection
                                         // 3- connection not open ---> open()
        private readonly IConfiguration configuration;
        public DBContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new OracleConnection(configuration["ConnectionStrings:DBConnectionString"]);
                    connection.Open();
                }
                else if (connection.State != ConnectionState.Open)
                {
                    // open
                    connection.Open();
                }
                return connection;
            }
        }
    }
}
