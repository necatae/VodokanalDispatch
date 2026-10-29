using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VodokanalDispatch
{
    static class Db
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Vodokanal"].ConnectionString;

        public static DataTable GetTable(string sql, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddRange(parameters);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
