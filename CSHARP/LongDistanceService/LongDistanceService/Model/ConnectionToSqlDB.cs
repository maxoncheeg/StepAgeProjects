using System.Data.SqlClient;
using System;

namespace LongDistanceService.Model
{
    abstract class ConnectionToSqlDB: IDisposable
    {
        protected SqlConnection _connection;

        protected ConnectionToSqlDB(string nameOfDataBase) =>
            _connection = new SqlConnection($"Data Source = DESKTOP-L8SQ807\\SQLEXPRESS;" +
                                            $" Initial Catalog = {nameOfDataBase};" +
                                            $" Integrated Security = SSPI;");

        public void Dispose() => _connection.Dispose();      
    }
}
