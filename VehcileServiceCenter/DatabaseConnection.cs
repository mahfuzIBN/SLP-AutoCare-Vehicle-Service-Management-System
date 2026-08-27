using Microsoft.Data.SqlClient;

namespace VehicleServiceCenter
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=VehicleServiceCenterDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}