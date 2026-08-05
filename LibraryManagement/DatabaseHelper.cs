using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryManagement
{
    internal static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
