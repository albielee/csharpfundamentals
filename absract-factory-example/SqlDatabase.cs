using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace absract_factory_example
{
    public class SqlDatabase : Database
    {
        private DbConnection _connection;
        private DbCommand _command;

        public SqlDatabase() { }
        public override DbConnection Connection
        {
            // lazy load
            get
            { 
                if( _connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ConnectionString;
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
        }

        public override DbCommand Command
        {
            get
            {
                if( _command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }
                return _command;
            }
            set
            {
                _command = value;
            }
        }
    }
}
