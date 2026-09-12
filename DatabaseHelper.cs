using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    internal static class DatabaseHelper
    {
        
        public static readonly string ConnectionString =
            @"Server=localhost;Database=TollPlazaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}