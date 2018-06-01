using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionFactory
    {

        private static Dictionary<ConnectionType, IDbConnection>
            _connections = new Dictionary<ConnectionType, IDbConnection>
            {
                { ConnectionType.SqlServer, new SqlConnection() },
                { ConnectionType.Odbc, new OdbcConnection() },
                { ConnectionType.OleDb, new OleDbConnection() }
            };

        public static IDbConnection CreateConnectionV1(ConnectionType connectionType)
        {
            if (!_connections.ContainsKey(connectionType))
            {
                throw new NotImplementedException();
            }
            return _connections[connectionType];
        }
        public static IDbConnection CreateConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.SqlServer:
                    return new SqlConnection();
                case ConnectionType.Odbc:
                    return new OdbcConnection();
                case ConnectionType.OleDb:
                    return new OleDbConnection();
                default:
                    throw new NotImplementedException();
            } 
        }

    }
}
